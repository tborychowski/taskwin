using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace TaskWin {
	public partial class TaskWinForm : Form {

		private int DragDropSourceIndex;

		private Boolean isEditMode = false;
		private Tasks tsk = new Tasks();
		private Settings AppSettings = new Settings();

		public TaskWinForm() { InitializeComponent(); }

		private void Form1_Load(object sender, EventArgs e) {
			tsk.editor = this.taskEditor;
			tsk.list = this.taskList;
			tsk.calendar = this.calendar;
			tsk.emptyListLabel = this.noTasksLabel;
			tsk.today = DateTime.Now.Date.ToString("yyyyMMdd");

			this.helpPanelMask.Dock = DockStyle.Fill;
			this.taskEditorPanel.Dock = DockStyle.Fill;
			this.taskListPanel.Dock = DockStyle.Fill;
			this.settingsPanelMask.Dock = DockStyle.Fill;
			this.settingsPanelMask.BringToFront();

			this.initSettings();
			this.readSettings();
		}



		#region SETTINGS

		/// <summary>
		/// Set settings' defaults
		/// </summary>
		private void initSettings() {
			AppSettings.add("taskFolder");
			AppSettings.add("lastVisit", Settings.DataType.DATE, DateTime.Now.Date);
			AppSettings.add("autoUpdate", Settings.DataType.BOOL);
			AppSettings.add("showCalendar", Settings.DataType.BOOL);
			AppSettings.add("autoDelete", Settings.DataType.BOOL);
			AppSettings.add("autoDeleteDays", Settings.DataType.INT);
			AppSettings.add("winX", Settings.DataType.INT, 150);
			AppSettings.add("winY", Settings.DataType.INT, 150);
			AppSettings.add("winW", Settings.DataType.INT, 500);
			AppSettings.add("winH", Settings.DataType.INT, 500);
		}

		/// <summary>
		/// Read and apply settings
		/// </summary>
		private void readSettings() {
			tsk.today = DateTime.Now.Date.ToString("yyyyMMdd");		// goto today
			this.calendar.SetDate(DateTime.Now.Date);
			this.updateDateLabel(DateTime.Now.Date);

			this.Text = "TaskWin v." + AppSettings.version;
			this.Location = new Point(AppSettings.get("winX")<0?0:AppSettings.get("winX"), AppSettings.get("winY")<0?0:AppSettings.get("winY"));
			this.Size = new Size(AppSettings.get("winW")<0?0:AppSettings.get("winW"), AppSettings.get("winH")<0?0:AppSettings.get("winH"));

			// fix calendar position
			this.calendar.Location = new Point(-2, this.statusBar.Top - this.calendar.Height + 2);

			if (AppSettings.get("taskFolder").Length != 0) tsk.taskFolder = AppSettings.get("taskFolder");
			else tsk.taskFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

			// fill settings form
			this.taskFolderPathTextBox.Text = AppSettings.get("taskFolder");
			this.autoUpdateCheckbox.Checked = AppSettings.get("autoUpdate");
			this.autoDeleteCheckbox.Checked = AppSettings.get("autoDelete");
			this.autoDeleteNumber.Value = AppSettings.get("autoDeleteDays");
			this.autoDeleteNumber.Enabled = this.autoDeleteCheckbox.Checked;
			if (this.autoDeleteCheckbox.Checked) tsk.autoDeleteOldTaskFiles((int)this.autoDeleteNumber.Value);

			// do actions
			tsk.textToList(tsk.readTasksFromFile());
			if (this.autoUpdateCheckbox.Checked) {			// if autoupdate - move tasks & hide actionlink
				tsk.moveOldUnresolvedTasks();
				this.btnUpdateOld.Visible = false;
			}
			else this.checkForUnresolved();					// else - just check

			this.toggleCalendar(AppSettings.get("showCalendar"));
			this.calendar.BoldedDates = tsk.boldDates();
			this.updateDateLabel(this.calendar.SelectionStart);

		}

		private void saveSettings() {
			if (!Directory.Exists(this.taskFolderPathTextBox.Text)) this.taskFolderPathTextBox.Text = "";
			AppSettings.set("taskFolder", this.taskFolderPathTextBox.Text);
			AppSettings.set("autoUpdate", this.autoUpdateCheckbox.Checked);
			AppSettings.set("autoDelete", this.autoDeleteCheckbox.Checked);
			AppSettings.set("autoDeleteDays", this.autoDeleteNumber.Value);
			AppSettings.set("showCalendar", this.calendar.Visible);
			AppSettings.set("lastVisit", DateTime.Now.Date);

			AppSettings.Save();
			readSettings();		// re-apply settings
		}

		private void savePosition() {
			AppSettings.set("winY", this.Location.Y);
			AppSettings.set("winX", this.Location.X);
			AppSettings.set("winW", this.Width);
			AppSettings.set("winH", this.Height);
			AppSettings.Save();
		}

		#endregion SETTINGS


		#region GENERAL Functions
		private void checkForUnresolved(String day = "") {
			int old = tsk.countOldUnresolvedTasks(day);
			if (old > 0) {
				this.btnUpdateOld.Visible = true;
				if (day == "") this.btnUpdateOld.Text = "Update " + old + " unresolved tasks";		// viewing current day
				else this.btnUpdateOld.Text = "Update " + old + " unresolved tasks";				// viewing "that" day
			}
			else {
				this.btnUpdateOld.Visible = false;
				this.btnUpdateOld.Text = "Update old tasks";
			}
		}

		private void showHelp() {
			if (this.helpPanelMask.Visible) this.helpPanelMask.Hide();		// hide
			else {															// show
				this.helpPanelMask.BringToFront();
				this.settingsPanelMask.Hide();
				this.helpPanelMask.Show();
			}
			this.taskList.Focus();
		}

		private void showSettings() {
			if (this.settingsPanelMask.Visible) this.settingsPanelMask.Hide();
			else {
				this.settingsPanelMask.BringToFront();
				this.helpPanelMask.Hide();
				this.settingsPanelMask.Show();
			}
			this.taskList.Focus();
		}

		private void updateDateLabel(DateTime date) {
			DateTime now = DateTime.Now;
			String format = "dddd, d MMM yyyy", dateStr = date.ToString(format);
			this.statusDateLabel.Text = dateStr;
		}

		private void toggleCalendar(Boolean show) { this.calendar.Visible = show; }
		private void toggleCalendar() {
			this.calendar.Visible = !this.calendar.Visible;
			AppSettings.set("showCalendar", this.calendar.Visible);
			AppSettings.Save();
		}

		#endregion GENERAL Functions


		#region View/Edit Mode

		/// <summary>
		/// Show editor, hide list
		/// </summary>
		private void editMode() {
			this.taskEditorPanel.Visible = true;
			this.taskListPanel.Visible = false;
			this.noTasksLabel.Visible = false;
			this.tsk.tasksToEditor();
			this.isEditMode = true;
		}

		/// <summary>
		/// Show list, hide editor
		/// </summary>
		/// <param name="save">if true - saves the list to a file and rewrites tasks from editor to the list</param>
		private void viewMode(bool save = false) {
			this.taskEditorPanel.Visible = false;
			this.taskListPanel.Visible = true;
			this.noTasksLabel.Visible = (this.taskList.Rows.Count==0);
			if (save) this.tsk.editorToTasks();
			else this.taskList.Focus();
			this.isEditMode = false;
		}

		#endregion View/Edit Mode


		#region APPLICATION EVENTS

		private void TaskWinForm_ResizeEnd(object sender, EventArgs e) { this.savePosition(); }

		private void TaskWinForm_FormClosing(object sender, FormClosingEventArgs e) { this.savePosition(); }

		private void Form1_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Escape){
				if (this.isEditMode) this.viewMode();
				else if (this.settingsPanelMask.Visible) this.settingsPanelMask.Hide();
				else if (this.helpPanelMask.Visible) this.helpPanelMask.Hide();
				else Application.Exit();
			}
		}

		private void taskEditor_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.Control && this.isEditMode) this.viewMode(true);
		}

		private void taskList_KeyDown(object sender, KeyEventArgs e) {
			switch (e.KeyCode) {
				case Keys.Delete: this.tsk.delTask(); break;
				case Keys.Up: if (e.Modifiers == Keys.Alt) { e.Handled = true; this.tsk.moveCurrentRowUp(); } break;
				case Keys.Down: if (e.Modifiers == Keys.Alt) { e.Handled = true; this.tsk.moveCurrentRowDown(); } break;
				case Keys.Left: tsk.prevDay(); break;
				case Keys.Right: tsk.nextDay(); break;
				case Keys.Home: tsk.gotoToday(); break;
				case Keys.Space: e.SuppressKeyPress = true; e.Handled = true; this.tsk.toggleResolve(); break;
				case Keys.Enter: this.editMode(); break;
				case Keys.F1: this.showHelp(); break;
				case Keys.F9: this.toggleCalendar(); break;
				case Keys.F12: this.showSettings(); break;
			}
		}

		// EDITOR - Save | Cancel
		private void btnEditorCancel_Click(object sender, EventArgs e){ this.viewMode(); }
		private void btnEditorSave_Click(object sender, EventArgs e){ this.viewMode(true); }


		private void calendar_DateChanged(object sender, DateRangeEventArgs e) {
			String calDate = e.Start.Date.ToString("yyyyMMdd");
			tsk.today = calDate;
			tsk.textToList(tsk.readTasksFromFile());
			if (tsk.realToday != tsk.today) this.checkForUnresolved(tsk.today);
			else this.checkForUnresolved(); 
			this.updateDateLabel(e.Start.Date);
		}

		// Toggle calendar
		private void btnCalendar_Click(object sender, EventArgs e) { this.toggleCalendar(); this.taskList.Focus(); }

		// Open/Close help
		private void btnInfo_Click(object sender, EventArgs e) { this.showHelp(); }
		private void btnHelpClose_Click(object sender, EventArgs e) { this.helpPanelMask.Hide(); this.taskList.Focus(); }

		// Open/Close settings
		private void btnSettings_Click(object sender, EventArgs e) { this.showSettings(); }
		private void btnSettingsClose_Click(object sender, EventArgs e){ this.settingsPanelMask.Visible = false; this.taskList.Focus(); }


		// Settings changed - enable Apply button
		private void settingsChangedEvent(object sender, EventArgs e) { this.saveSettings(); }

		private void autoDeleteCheckbox_Click(object sender, EventArgs e) {
			this.autoDeleteNumber.Enabled = this.autoDeleteCheckbox.Checked;
			this.saveSettings();
		}


		// Browse for a task folder
		private void btnTaskFolderBrowse_Click(object sender, EventArgs e) {
			//this.taskFolderBrowserDialog.SelectedPath = this.AppSettings.taskFolder;
			DialogResult result = this.taskFolderBrowserDialog.ShowDialog();
			this.taskFolderPathTextBox.Text = this.taskFolderBrowserDialog.SelectedPath;
		}
		private void btnTaskFolderClear_Click(object sender, EventArgs e) { this.taskFolderPathTextBox.Text = ""; }

		// task folder label click
		private void taskFolderLabel_Click(object sender, EventArgs e) { Process.Start(@tsk.taskFolder); }



		private void btnUpdateOld_Click(object sender, EventArgs e) { 
			if (tsk.realToday == tsk.today) tsk.moveOldUnresolvedTasks();	// if viewing today
			else tsk.moveOldUnresolvedTasks(tsk.today);						// if viewing earlier day
			this.btnUpdateOld.Visible = false;
		}


		// list D&D functions:
		private void taskList_MouseDown(object sender, MouseEventArgs e) {
			if (e.Clicks == 2) {	// mouse double-click
				this.editMode();
				DragDropSourceIndex = -1;
				ReleaseCapture();
			}
			else {					// single click
				if ((e.Button & MouseButtons.Right) == MouseButtons.Right) {
					int newIdx = this.taskList.HitTest(e.X, e.Y).RowIndex;
					if (newIdx > -1) {
						this.taskList.CurrentCell = this.taskList.Rows[newIdx].Cells[1];
						tsk.toggleResolve();
					}
				}
				else {
					if (this.taskList.AllowDrop && this.taskList.HitTest(e.X, e.Y).RowIndex > -1)
						DragDropSourceIndex = this.taskList.HitTest(e.X, e.Y).RowIndex;
					else {
						ReleaseCapture();
						SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
					}
				}
			}
		}
		private void taskList_MouseUp(object sender, MouseEventArgs e) {  DragDropSourceIndex = -1; tsk.renumber(); }
		private void taskList_MouseMove(object sender, MouseEventArgs e) {
			if (this.taskList.AllowDrop && (e.Button & MouseButtons.Left) == MouseButtons.Left) {
				int newIdx = this.taskList.HitTest(e.X, e.Y).RowIndex;
				if (newIdx > -1 && newIdx != DragDropSourceIndex) {
					DataGridViewRow SourceRow = this.taskList.Rows[DragDropSourceIndex];
					this.taskList.Rows.RemoveAt(DragDropSourceIndex);
					this.taskList.Rows.Insert(newIdx, SourceRow);
					this.taskList.CurrentCell = this.taskList.Rows[newIdx].Cells[1];
					DragDropSourceIndex = newIdx;
				}
			}

		}

		#endregion APPLICATION EVENTS


		#region mouse handling
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		#endregion

	}
}

