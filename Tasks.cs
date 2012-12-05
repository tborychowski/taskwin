using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;

namespace TaskWin {
	class Tasks {

		public MonthCalendar calendar;
		public RichTextBox editor;
		public DataGridView list;
		public Label emptyListLabel;
		public String taskFolder;
		public String today;
		public String realToday = DateTime.Now.Date.ToString("yyyyMMdd");


		#region Rewriting Functions (tasks<->editor, text<->list)
		
		/// <summary>
		/// Convert tasks from list to the formatted text
		/// </summary>
		/// <returns>formatted text</returns>
		public String listToText() {
			String txt="", resolved;
			int i = 0, il = this.list.Rows.Count;
			if (il > 0) {
				for (; i < il; i++) {
					resolved = (bool)this.list.Rows[i].Cells[2].Value?"-":"";
					txt += resolved + this.list.Rows[i].Cells[1].Value + "\n";
				}
			}
			return txt;
		}


		/// <summary>
		/// Convert tasks from the formatted text to the list 
		/// </summary>
		/// <param name="txt">text from the file or editor</param>
		/// <param name="append">if false - clear the list before adding tasks</param>
		public void textToList(String txt, bool append = false) {
			String[] lines = txt.Split('\n');
			String line;
			int i = 0, n = 1, il = lines.Count();
			if (append == false) this.list.Rows.Clear();
			if (il > 0 && txt.Length > 0) {
				for (; i < il; i++) {
					line = lines[i].Trim('\n', '\r');
					if (line.Length > 0) {
						if (line.Substring(0, 1) == "-") {
							line = line.Substring(1);
							this.list.Rows.Add(n++, line, true);
							this.resolveTask(n - 2, true);
						}
						else this.list.Rows.Add(n++, line, false);
					}
				}
				this.list.Sort(this.list.Columns[2], ListSortDirection.Ascending);	// resolved to bottom
				//this.renumber(true);
			}
			this.emptyListLabel.Visible = (this.list.Rows.Count == 0);
			this.list.Focus();
		}


		/// <summary>
		/// Rewrite tasks from editor to list 
		/// </summary>
		public void editorToTasks() {
			this.textToList(this.editor.Text);
			this.saveTasksToFile();
			this.list.Focus();
		}


		/// <summary>
		/// Rewrite tasks from list to editor
		/// </summary>
		public void tasksToEditor() {
			String txt = this.listToText();
			this.editor.Clear();
			if (txt.Length > 0) this.editor.AppendText(txt);
			this.editor.Focus();
		}
		#endregion Rewriting Functions (tasks<->editor, text<->list)



		#region Resolve/Unresolve
		/// <summary>
		/// Toggle resolve/unresolve
		/// </summary>
		public void toggleResolve() {
			if (this.list.CurrentRow == null) return ;
			int rowIndex = this.list.CurrentRow.Index;
			Boolean oldVal = false, newVal = !oldVal;
			oldVal = (bool)this.list.Rows[rowIndex].Cells[2].Value;
			newVal = !oldVal;
			this.list.Rows[rowIndex].Cells[2].Value = (object)newVal;
			if (newVal) this.resolveTask(rowIndex);
			else this.unresolveTask(rowIndex);
		}


		/// <summary>
		/// Mark task as resolved
		/// </summary>
		/// <param name="row">Row index to resolve</param>
		public void resolveTask(int row){ this.resolveTask(row, false); }

		/// <summary>
		/// Mark task as resolved
		/// </summary>
		/// <param name="row">Row index to resolve</param>
		/// <param name="raw">Raw resolve - do not sort/renumber after that (when reading a list)</param>
		public void resolveTask(int row, bool raw) {
			Font curFont = this.list.DefaultCellStyle.Font;
			this.list.Rows[row].Cells[0].Value = "";
			this.list.Rows[row].DefaultCellStyle.Font = new Font(curFont, FontStyle.Strikeout);
			this.list.Rows[row].DefaultCellStyle.ForeColor = Color.Gray;
			this.list.Rows[row].DefaultCellStyle.SelectionForeColor = Color.Gray;

			if (raw == false) {
				// remove checked row
				DataGridViewRow SourceRow = this.list.Rows[row];
				this.list.Rows.RemoveAt(row);
				// find last unchecked row
				int i = 0, ile = 0, max = this.list.Rows.Count;
				for (; i < max; i++) if ((bool)this.list.Rows[i].Cells[2].Value == false) ile++; else break;
				// insert removed row to the end of the unchecked list
				this.list.Rows.Insert(ile, SourceRow);
				this.list.CurrentCell = this.list.Rows[ile].Cells[1];				
				this.renumber(true);
			}
		}


		/// <summary>
		/// Mark task as unresolved
		/// </summary>
		public void unresolveTask(int row) {
			Font curFont = this.list.DefaultCellStyle.Font;
			this.list.Rows[row].DefaultCellStyle.Font = curFont;
			this.list.Rows[row].DefaultCellStyle.ForeColor = Color.Black;
			this.list.Rows[row].DefaultCellStyle.SelectionForeColor = Color.Black;
			//this.list.Sort(this.list.Columns[2], ListSortDirection.Ascending);
			this.renumber(true);
		}
		#endregion Resolve/Unresolve



		#region Move, Delete, Renumber

		/// <summary>
		/// Renumber all tasks, save list to file
		/// </summary>
		public void renumber(bool save = false) {
			int i = 0, il = this.list.Rows.Count;
			if (il > 0) {											// if more than 1 task - renumber
				for (; i < il; i++) 
					if ((bool)this.list.Rows[i].Cells[2].Value == false) 
						this.list.Rows[i].Cells[0].Value = i + 1;
			}
			if (save) this.saveTasksToFile();
		}

		
		/// <summary>
		/// Remove a task
		/// </summary>
		public void delTask() {
			foreach (DataGridViewRow drv in this.list.SelectedRows) this.list.Rows.Remove(drv);
			this.emptyListLabel.Visible = (this.list.Rows.Count == 0);
			this.renumber(true);
		}
		

		/// <summary>
		/// Move currently selected row UP
		/// </summary>
		public void moveCurrentRowUp() {
			if (list.CurrentRow == null) return;
			int idx = list.CurrentRow.Index;
			if (idx > 0) {
				DataGridViewRow row = list.SelectedRows[0];
				list.Rows.RemoveAt(idx);
				list.Rows.Insert(idx - 1, row);
				list.CurrentCell = list.Rows[idx - 1].Cells[1];
			}
			this.renumber(true);
		}
		

		/// <summary>
		/// Move currently selected row DOWN
		/// </summary>
		public void moveCurrentRowDown() {
			if (list.CurrentRow == null) return;
			int idx = list.CurrentRow.Index;
			if (idx < list.Rows.Count - 1) {
				DataGridViewRow row = list.SelectedRows[0];
				list.Rows.RemoveAt(idx);
				list.Rows.Insert(idx + 1, row);
				list.CurrentCell = list.Rows[idx + 1].Cells[1];
			}
			this.renumber(true);
		}
		#endregion Move, Delete, Renumber



		#region Read/Write File

		/// <summary>
		/// Saves current list to "today's" file
		/// </summary>
		private void saveTasksToFile() { this.saveTasksToFile(this.today, this.listToText()); }

		/// <summary>
		/// Saves text to file
		/// </summary>
		/// <param name="today">Date-string for file name to save</param>
		/// <param name="txt">Text to save</param>
		private void saveTasksToFile(String today, String txt, bool append = false) {
			String filename = this.taskFolder + "\\" + today + ".txt";
			if (txt.Length > 0) {
				if (append) txt = this.readTasksFromFile(today) + txt;
				TextWriter file = new StreamWriter(filename);
				file.Write(txt);
				file.Close();
			}
			else {
				if (File.Exists(filename)) File.Delete(filename);		// if no tasks - remove file
			}
			this.calendar.BoldedDates = this.boldDates();
		}



		/// <summary>
		/// Reads the tasks from today's file into the list
		/// </summary>
		public String readTasksFromFile() { return this.readTasksFromFile(this.today); }

		/// <summary>
		/// Reads the tasks from date-string-named file into the list
		/// </summary>
		/// <param name="today">Date-string file name to read</param>
		public String readTasksFromFile(String today) {
			String filename = this.taskFolder + "\\" + today + ".txt";
			if (File.Exists(filename)) {
				TextReader file = new StreamReader(filename);
				String fileText = file.ReadToEnd();
				file.Close();
				return fileText;
			}
			return "";
		}


		public void autoDeleteOldTaskFiles(int days) {
			String[] filenames = this.getFileNames();
			List<String> toDelete = new List<String>();
			String y, m, d;
			DateTime dat, today = DateTime.Now;
			TimeSpan diff;
			foreach (String name in filenames) {		// gather files older than "days"
				y = name.Substring(0, 4);
				m = name.Substring(4, 2);
				d = name.Substring(6, 2);
				dat = new System.DateTime(int.Parse(y), int.Parse(m), int.Parse(d));
				diff = today - dat;
				if (diff.Days > days) toDelete.Add(name + ".txt");
			}
			// delete files
			foreach (String name in toDelete) File.Delete(this.taskFolder + "\\" + name);
		}

		#endregion Read/Write File



		#region Bold Dates, Move Old, Count Old

		/// <summary>
		/// Scan all files in the task folder and bold dates with tasks
		/// </summary>
		public DateTime[] boldDates() {
			List<DateTime> dates = new List<DateTime>();
			String[] filenames = this.getFileNames();
			String y, m, d;
			foreach (String name in filenames) {
				y = name.Substring(0, 4);
				m = name.Substring(4, 2);
				d = name.Substring(6, 2);
				try {
					dates.Add( new System.DateTime(int.Parse(y), int.Parse(m), int.Parse(d)) );
				}
				catch(SystemException e){}
			}
			return dates.ToArray();
		}


		/// <summary>
		/// Read all files in the task folder and filter out only the valid ones
		/// </summary>
		public String[] getFileNames() {
			List<String> filenames = new List<String>();
			DirectoryInfo di = new DirectoryInfo(this.taskFolder);
			if (di.Exists) {
				FileInfo[] rgFiles = di.GetFiles("*.txt");					// get all text files
				Regex fnRX = new Regex("\\d{8}");
				String tmpName = "";
				foreach (FileInfo fi in rgFiles) {
					tmpName = Path.GetFileNameWithoutExtension(fi.Name);
					Match m = fnRX.Match(tmpName);
					if (m.Success) filenames.Add(tmpName);
				}
				filenames.Sort();
			}
			return filenames.ToArray();
		}


		/// <summary>
		/// If there are unresolved tasks before today - move them to today's list
		/// </summary>
		/// <param name="today">Move tasks for a particular day</param>
		public void moveOldUnresolvedTasks(String day = "") {
			String newTasks = "", oldTasks = "", fileText, line, fname;
			if (day == "") {
				String[] filenames = this.getFileNames();
				if (filenames.Length > 1) {
					if (filenames[filenames.Length-1] == this.realToday)// if last one is today
						fname = filenames[filenames.Length - 2];		// get the most recent day file (except today)
					else 
						fname = filenames[filenames.Length - 1];		// get the most recent day file (except today)
				}
				else if (filenames.Length > 0) {
					if (filenames[filenames.Length - 1] == this.realToday) return;
					else fname = filenames[filenames.Length - 1];		// get the most recent day file (except today)
				}
				else return;
			}
			else fname = day;

			fileText = this.readTasksFromFile(fname);						// read file content
			String[] lines = fileText.Split('\n');						// split file to lines
			for (int j = 0, jl = lines.Count(); j < jl; j++) {			// loop through lines
				line = lines[j].Trim('\n', '\r');
				if (line.Length == 0) continue;							// if line empty - go on
				if (line.Substring(0, 1) == "-") oldTasks += line+"\n"; // if task resolved - leave it in the file
				else newTasks += line + "\n";							// if unresolved - add it to today's list
			}
			this.saveTasksToFile(fname, oldTasks);						// save resolved tasks where they were
			if (day == "") {											// append unresolved tasks to today
				if (newTasks.Length > 0) this.textToList(newTasks, true);
				this.saveTasksToFile();
				this.renumber();
			}
			else {
				this.saveTasksToFile(this.realToday, newTasks, true);	// append unresolved tasks to today if viewing old day
				this.textToList(this.readTasksFromFile());
			}
		}

		/// <summary>
		/// Count old unresolved tasks
		/// </summary>
		/// <param name="today">Count tasks for a particular day</param>
		public int countOldUnresolvedTasks(String day = "") {
			int ile=0;
			String fileText, line, fname;
			if (day == "") {
				String[] filenames = this.getFileNames();
				if (filenames.Length > 1) {
					if (filenames[filenames.Length - 1] == this.realToday)// if last one is today
						fname = filenames[filenames.Length - 2];		// get the most recent day file (except today)
					else
						fname = filenames[filenames.Length - 1];		// get the most recent day file (except today)
				}
				else if (filenames.Length > 0) {
					if (filenames[filenames.Length - 1] == this.realToday) return 0;
					else fname = filenames[filenames.Length - 1];		// get the most recent day file (except today)
				}
				else return 0;
			}
			else fname = day;

			fileText = this.readTasksFromFile(fname);						// read file content
			String[] lines = fileText.Split('\n');						// split file to lines
			for (int j = 0, jl = lines.Count(); j < jl; j++) {			// loop through lines
				line = lines[j].Trim('\n', '\r');
				if (line.Length == 0) continue;							// if line empty - go on
				if (line.Substring(0, 1) != "-") ile++;					// if not resolved - increase the counter
			}
			return ile;
		}

		#endregion Bold Dates, Move Old, Count Old



		#region Navigation
		public void prevDay() {
			DateTime newDay = this.calendar.SelectionStart.Date.AddDays(-1);
			this.calendar.SelectionStart = newDay;
			this.calendar.SelectionEnd = newDay;
		}

		public void nextDay() {
			DateTime newDay = this.calendar.SelectionStart.Date.AddDays(1);
			this.calendar.SelectionStart = newDay;
			this.calendar.SelectionEnd = newDay;
		}
		public void gotoToday() {
			DateTime newDay = DateTime.Now.Date;
			this.calendar.SelectionStart = newDay;
			this.calendar.SelectionEnd = newDay;
		}
		#endregion Navigation



	}
}
