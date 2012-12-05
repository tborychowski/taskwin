namespace TaskWin {
	partial class TaskWinForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskWinForm));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnEditorSave = new System.Windows.Forms.Button();
            this.btnEditorCancel = new System.Windows.Forms.Button();
            this.taskList = new System.Windows.Forms.DataGridView();
            this.tlcol_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlcol_task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlcol_status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnTaskFolderClear = new System.Windows.Forms.Button();
            this.btnTaskFolderBrowse = new System.Windows.Forms.Button();
            this.taskFolderLabel = new System.Windows.Forms.LinkLabel();
            this.settingsPanelMask = new System.Windows.Forms.Panel();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.autoDeleteNumber = new System.Windows.Forms.NumericUpDown();
            this.btnSettingsClose = new System.Windows.Forms.PictureBox();
            this.autoUpdateCheckbox = new System.Windows.Forms.CheckBox();
            this.autoDeleteCheckbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.taskFolderPathTextBox = new System.Windows.Forms.TextBox();
            this.taskFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.helpPanelMask = new System.Windows.Forms.Panel();
            this.helpPanel = new System.Windows.Forms.Panel();
            this.btnHelpClose = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusDateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnInfo = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnUpdateOld = new System.Windows.Forms.ToolStripStatusLabel();
            this.taskEditorPanel = new System.Windows.Forms.Panel();
            this.taskEditor = new System.Windows.Forms.RichTextBox();
            this.taskListPanel = new System.Windows.Forms.Panel();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.noTasksLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taskList)).BeginInit();
            this.settingsPanelMask.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoDeleteNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettingsClose)).BeginInit();
            this.helpPanelMask.SuspendLayout();
            this.helpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelpClose)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.taskEditorPanel.SuspendLayout();
            this.taskListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditorSave
            // 
            this.btnEditorSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditorSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditorSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditorSave.Location = new System.Drawing.Point(5, 32);
            this.btnEditorSave.Name = "btnEditorSave";
            this.btnEditorSave.Size = new System.Drawing.Size(135, 28);
            this.btnEditorSave.TabIndex = 11;
            this.btnEditorSave.Text = "Save";
            this.toolTip.SetToolTip(this.btnEditorSave, "Save (Ctrl+Enter)");
            this.btnEditorSave.UseVisualStyleBackColor = true;
            this.btnEditorSave.Click += new System.EventHandler(this.btnEditorSave_Click);
            // 
            // btnEditorCancel
            // 
            this.btnEditorCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditorCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditorCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditorCancel.Location = new System.Drawing.Point(148, 32);
            this.btnEditorCancel.Name = "btnEditorCancel";
            this.btnEditorCancel.Size = new System.Drawing.Size(135, 28);
            this.btnEditorCancel.TabIndex = 12;
            this.btnEditorCancel.Text = "Cancel";
            this.toolTip.SetToolTip(this.btnEditorCancel, "Cancel edit (Esc)");
            this.btnEditorCancel.UseVisualStyleBackColor = true;
            this.btnEditorCancel.Click += new System.EventHandler(this.btnEditorCancel_Click);
            // 
            // taskList
            // 
            this.taskList.AllowDrop = true;
            this.taskList.AllowUserToAddRows = false;
            this.taskList.AllowUserToDeleteRows = false;
            this.taskList.AllowUserToResizeColumns = false;
            this.taskList.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.taskList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.taskList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.taskList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.taskList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.taskList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskList.CausesValidation = false;
            this.taskList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.taskList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.taskList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.taskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskList.ColumnHeadersVisible = false;
            this.taskList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tlcol_No,
            this.tlcol_task,
            this.tlcol_status});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.taskList.DefaultCellStyle = dataGridViewCellStyle26;
            this.taskList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.taskList.Location = new System.Drawing.Point(3, 3);
            this.taskList.MinimumSize = new System.Drawing.Size(100, 30);
            this.taskList.MultiSelect = false;
            this.taskList.Name = "taskList";
            this.taskList.ReadOnly = true;
            this.taskList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.taskList.RowHeadersVisible = false;
            this.taskList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.taskList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.taskList.Size = new System.Drawing.Size(163, 43);
            this.taskList.TabIndex = 0;
            this.toolTip.SetToolTip(this.taskList, "Double click to edit");
            this.taskList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.taskList_KeyDown);
            this.taskList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.taskList_MouseDown);
            this.taskList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.taskList_MouseMove);
            this.taskList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.taskList_MouseUp);
            // 
            // tlcol_No
            // 
            this.tlcol_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tlcol_No.FillWeight = 16.24365F;
            this.tlcol_No.HeaderText = "No";
            this.tlcol_No.Name = "tlcol_No";
            this.tlcol_No.ReadOnly = true;
            this.tlcol_No.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tlcol_No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tlcol_No.Width = 20;
            // 
            // tlcol_task
            // 
            this.tlcol_task.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tlcol_task.FillWeight = 183.7563F;
            this.tlcol_task.HeaderText = "Task";
            this.tlcol_task.Name = "tlcol_task";
            this.tlcol_task.ReadOnly = true;
            // 
            // tlcol_status
            // 
            this.tlcol_status.HeaderText = "status";
            this.tlcol_status.Name = "tlcol_status";
            this.tlcol_status.ReadOnly = true;
            this.tlcol_status.Visible = false;
            // 
            // btnTaskFolderClear
            // 
            this.btnTaskFolderClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaskFolderClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTaskFolderClear.Image = global::TaskWin.Properties.Resources.delete_16;
            this.btnTaskFolderClear.Location = new System.Drawing.Point(385, 63);
            this.btnTaskFolderClear.Name = "btnTaskFolderClear";
            this.btnTaskFolderClear.Size = new System.Drawing.Size(32, 26);
            this.btnTaskFolderClear.TabIndex = 7;
            this.toolTip.SetToolTip(this.btnTaskFolderClear, "Clear folder");
            this.btnTaskFolderClear.UseVisualStyleBackColor = true;
            this.btnTaskFolderClear.Click += new System.EventHandler(this.btnTaskFolderClear_Click);
            // 
            // btnTaskFolderBrowse
            // 
            this.btnTaskFolderBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaskFolderBrowse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTaskFolderBrowse.Image = global::TaskWin.Properties.Resources.folder_16;
            this.btnTaskFolderBrowse.Location = new System.Drawing.Point(350, 63);
            this.btnTaskFolderBrowse.Name = "btnTaskFolderBrowse";
            this.btnTaskFolderBrowse.Size = new System.Drawing.Size(32, 26);
            this.btnTaskFolderBrowse.TabIndex = 7;
            this.toolTip.SetToolTip(this.btnTaskFolderBrowse, "Browse for a folder");
            this.btnTaskFolderBrowse.UseVisualStyleBackColor = true;
            this.btnTaskFolderBrowse.Click += new System.EventHandler(this.btnTaskFolderBrowse_Click);
            // 
            // taskFolderLabel
            // 
            this.taskFolderLabel.ActiveLinkColor = System.Drawing.Color.Black;
            this.taskFolderLabel.AutoSize = true;
            this.taskFolderLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.taskFolderLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taskFolderLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.taskFolderLabel.LinkColor = System.Drawing.Color.Black;
            this.taskFolderLabel.Location = new System.Drawing.Point(20, 67);
            this.taskFolderLabel.Name = "taskFolderLabel";
            this.taskFolderLabel.Size = new System.Drawing.Size(83, 18);
            this.taskFolderLabel.TabIndex = 4;
            this.taskFolderLabel.TabStop = true;
            this.taskFolderLabel.Text = "Tasks Folder";
            this.toolTip.SetToolTip(this.taskFolderLabel, "Open current task folder");
            this.taskFolderLabel.VisitedLinkColor = System.Drawing.Color.Black;
            this.taskFolderLabel.Click += new System.EventHandler(this.taskFolderLabel_Click);
            // 
            // settingsPanelMask
            // 
            this.settingsPanelMask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.settingsPanelMask.Controls.Add(this.settingsPanel);
            this.settingsPanelMask.Location = new System.Drawing.Point(0, 0);
            this.settingsPanelMask.Name = "settingsPanelMask";
            this.settingsPanelMask.Padding = new System.Windows.Forms.Padding(10);
            this.settingsPanelMask.Size = new System.Drawing.Size(462, 299);
            this.settingsPanelMask.TabIndex = 1013;
            this.settingsPanelMask.Visible = false;
            // 
            // settingsPanel
            // 
            this.settingsPanel.AutoScroll = true;
            this.settingsPanel.AutoScrollMinSize = new System.Drawing.Size(100, 0);
            this.settingsPanel.BackColor = System.Drawing.Color.White;
            this.settingsPanel.Controls.Add(this.label1);
            this.settingsPanel.Controls.Add(this.autoDeleteNumber);
            this.settingsPanel.Controls.Add(this.btnSettingsClose);
            this.settingsPanel.Controls.Add(this.autoUpdateCheckbox);
            this.settingsPanel.Controls.Add(this.autoDeleteCheckbox);
            this.settingsPanel.Controls.Add(this.label4);
            this.settingsPanel.Controls.Add(this.btnTaskFolderClear);
            this.settingsPanel.Controls.Add(this.btnTaskFolderBrowse);
            this.settingsPanel.Controls.Add(this.label3);
            this.settingsPanel.Controls.Add(this.taskFolderLabel);
            this.settingsPanel.Controls.Add(this.taskFolderPathTextBox);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(10, 10);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Padding = new System.Windows.Forms.Padding(15);
            this.settingsPanel.Size = new System.Drawing.Size(442, 279);
            this.settingsPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label1.Location = new System.Drawing.Point(353, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 1020;
            this.label1.Text = "days";
            // 
            // autoDeleteNumber
            // 
            this.autoDeleteNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.autoDeleteNumber.Enabled = false;
            this.autoDeleteNumber.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.autoDeleteNumber.Location = new System.Drawing.Point(300, 152);
            this.autoDeleteNumber.Maximum = new decimal(new int[] {
            366,
            0,
            0,
            0});
            this.autoDeleteNumber.Name = "autoDeleteNumber";
            this.autoDeleteNumber.Size = new System.Drawing.Size(47, 26);
            this.autoDeleteNumber.TabIndex = 1019;
            this.autoDeleteNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.autoDeleteNumber.Validated += new System.EventHandler(this.settingsChangedEvent);
            // 
            // btnSettingsClose
            // 
            this.btnSettingsClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettingsClose.Image = ((System.Drawing.Image)(resources.GetObject("btnSettingsClose.Image")));
            this.btnSettingsClose.Location = new System.Drawing.Point(418, 1);
            this.btnSettingsClose.Name = "btnSettingsClose";
            this.btnSettingsClose.Size = new System.Drawing.Size(24, 24);
            this.btnSettingsClose.TabIndex = 1018;
            this.btnSettingsClose.TabStop = false;
            this.btnSettingsClose.Click += new System.EventHandler(this.btnSettingsClose_Click);
            // 
            // autoUpdateCheckbox
            // 
            this.autoUpdateCheckbox.AutoSize = true;
            this.autoUpdateCheckbox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.autoUpdateCheckbox.Location = new System.Drawing.Point(20, 191);
            this.autoUpdateCheckbox.Name = "autoUpdateCheckbox";
            this.autoUpdateCheckbox.Size = new System.Drawing.Size(289, 22);
            this.autoUpdateCheckbox.TabIndex = 9;
            this.autoUpdateCheckbox.Text = "Automatically update old unresolved tasks";
            this.autoUpdateCheckbox.UseVisualStyleBackColor = true;
            this.autoUpdateCheckbox.Click += new System.EventHandler(this.settingsChangedEvent);
            // 
            // autoDeleteCheckbox
            // 
            this.autoDeleteCheckbox.AutoSize = true;
            this.autoDeleteCheckbox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.autoDeleteCheckbox.Location = new System.Drawing.Point(20, 154);
            this.autoDeleteCheckbox.Name = "autoDeleteCheckbox";
            this.autoDeleteCheckbox.Size = new System.Drawing.Size(280, 22);
            this.autoDeleteCheckbox.TabIndex = 9;
            this.autoDeleteCheckbox.Text = "Automatically delete task files older than";
            this.autoDeleteCheckbox.UseVisualStyleBackColor = true;
            this.autoDeleteCheckbox.Click += new System.EventHandler(this.autoDeleteCheckbox_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(102, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select a folder where TaskWin will store your task files.\r\nLeave blank to store t" +
    "ask files in the same folder \r\nas the program exe file.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(18, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Settings";
            // 
            // taskFolderPathTextBox
            // 
            this.taskFolderPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskFolderPathTextBox.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.taskFolderPathTextBox.Location = new System.Drawing.Point(105, 63);
            this.taskFolderPathTextBox.Name = "taskFolderPathTextBox";
            this.taskFolderPathTextBox.Size = new System.Drawing.Size(239, 26);
            this.taskFolderPathTextBox.TabIndex = 3;
            this.taskFolderPathTextBox.Validated += new System.EventHandler(this.settingsChangedEvent);
            // 
            // taskFolderBrowserDialog
            // 
            this.taskFolderBrowserDialog.Description = "Select a folder where the task files will be stored";
            // 
            // helpPanelMask
            // 
            this.helpPanelMask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.helpPanelMask.Controls.Add(this.helpPanel);
            this.helpPanelMask.Location = new System.Drawing.Point(466, 0);
            this.helpPanelMask.Name = "helpPanelMask";
            this.helpPanelMask.Padding = new System.Windows.Forms.Padding(10);
            this.helpPanelMask.Size = new System.Drawing.Size(357, 446);
            this.helpPanelMask.TabIndex = 1014;
            this.helpPanelMask.Visible = false;
            // 
            // helpPanel
            // 
            this.helpPanel.BackColor = System.Drawing.Color.White;
            this.helpPanel.Controls.Add(this.btnHelpClose);
            this.helpPanel.Controls.Add(this.flowLayoutPanel2);
            this.helpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpPanel.Location = new System.Drawing.Point(10, 10);
            this.helpPanel.Name = "helpPanel";
            this.helpPanel.Padding = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.helpPanel.Size = new System.Drawing.Size(337, 426);
            this.helpPanel.TabIndex = 0;
            // 
            // btnHelpClose
            // 
            this.btnHelpClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelpClose.Image = ((System.Drawing.Image)(resources.GetObject("btnHelpClose.Image")));
            this.btnHelpClose.Location = new System.Drawing.Point(313, 1);
            this.btnHelpClose.Name = "btnHelpClose";
            this.btnHelpClose.Size = new System.Drawing.Size(24, 24);
            this.btnHelpClose.TabIndex = 1018;
            this.btnHelpClose.TabStop = false;
            this.btnHelpClose.Click += new System.EventHandler(this.btnHelpClose_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.richTextBox1);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.richTextBox3);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.richTextBox2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(15, 10);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(322, 416);
            this.flowLayoutPanel2.TabIndex = 13;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // label8
            // 
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(289, 32);
            this.label8.TabIndex = 10;
            this.label8.Text = "Keyboard";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "List view";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(289, 136);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "Alt+Up/Down - move task up/down\nLeft/Right - go to previous/next day\nHome - go to" +
    " today\nSpace - resolve/unresolve\nDel - remove task\nEnter - switch to Editor\nEsc " +
    "- exit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(3, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Editor view";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox3.Location = new System.Drawing.Point(3, 234);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(289, 52);
            this.richTextBox3.TabIndex = 12;
            this.richTextBox3.Text = "Ctrl+Enter - save tasks & switch to list view\nEsc - switch to list view";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mouse";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox2.Location = new System.Drawing.Point(3, 324);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(289, 64);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "Drag task up/down to reorder\nRight-Click a task to resolve/unresolve\nDouble-click" +
    " the task list to enter edit mode";
            // 
            // statusBar
            // 
            this.statusBar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusDateLabel,
            this.btnSettings,
            this.btnInfo,
            this.btnUpdateOld});
            this.statusBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusBar.Location = new System.Drawing.Point(0, 583);
            this.statusBar.Name = "statusBar";
            this.statusBar.ShowItemToolTips = true;
            this.statusBar.Size = new System.Drawing.Size(855, 23);
            this.statusBar.TabIndex = 1015;
            // 
            // statusDateLabel
            // 
            this.statusDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusDateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statusDateLabel.Image = global::TaskWin.Properties.Resources.event16;
            this.statusDateLabel.IsLink = true;
            this.statusDateLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.statusDateLabel.LinkColor = System.Drawing.Color.Black;
            this.statusDateLabel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 2);
            this.statusDateLabel.Name = "statusDateLabel";
            this.statusDateLabel.Size = new System.Drawing.Size(57, 18);
            this.statusDateLabel.Text = "today";
            this.statusDateLabel.ToolTipText = "Toggle calendar (F9)";
            this.statusDateLabel.VisitedLinkColor = System.Drawing.Color.Black;
            this.statusDateLabel.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSettings.Image = global::TaskWin.Properties.Resources.gear_16;
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Margin = new System.Windows.Forms.Padding(5, 2, 0, 1);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ShowDropDownArrow = false;
            this.btnSettings.Size = new System.Drawing.Size(20, 20);
            this.btnSettings.Text = "Settings (F12)";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInfo.Image = global::TaskWin.Properties.Resources.info_16;
            this.btnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInfo.Margin = new System.Windows.Forms.Padding(5, 2, 0, 1);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.ShowDropDownArrow = false;
            this.btnInfo.Size = new System.Drawing.Size(20, 20);
            this.btnInfo.Text = "Help (F1)";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnUpdateOld
            // 
            this.btnUpdateOld.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateOld.Image = global::TaskWin.Properties.Resources.down_16;
            this.btnUpdateOld.IsLink = true;
            this.btnUpdateOld.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnUpdateOld.LinkColor = System.Drawing.Color.Black;
            this.btnUpdateOld.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.btnUpdateOld.Name = "btnUpdateOld";
            this.btnUpdateOld.Size = new System.Drawing.Size(123, 18);
            this.btnUpdateOld.Text = "Update old tasks";
            this.btnUpdateOld.Click += new System.EventHandler(this.btnUpdateOld_Click);
            // 
            // taskEditorPanel
            // 
            this.taskEditorPanel.BackColor = System.Drawing.Color.White;
            this.taskEditorPanel.Controls.Add(this.btnEditorSave);
            this.taskEditorPanel.Controls.Add(this.btnEditorCancel);
            this.taskEditorPanel.Controls.Add(this.taskEditor);
            this.taskEditorPanel.Location = new System.Drawing.Point(173, 304);
            this.taskEditorPanel.Margin = new System.Windows.Forms.Padding(0);
            this.taskEditorPanel.MinimumSize = new System.Drawing.Size(160, 2);
            this.taskEditorPanel.Name = "taskEditorPanel";
            this.taskEditorPanel.Padding = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.taskEditorPanel.Size = new System.Drawing.Size(289, 68);
            this.taskEditorPanel.TabIndex = 1016;
            this.taskEditorPanel.Visible = false;
            // 
            // taskEditor
            // 
            this.taskEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskEditor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taskEditor.Location = new System.Drawing.Point(3, 3);
            this.taskEditor.Margin = new System.Windows.Forms.Padding(0);
            this.taskEditor.Name = "taskEditor";
            this.taskEditor.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.taskEditor.Size = new System.Drawing.Size(283, 60);
            this.taskEditor.TabIndex = 10;
            this.taskEditor.Text = "";
            this.taskEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.taskEditor_KeyDown);
            // 
            // taskListPanel
            // 
            this.taskListPanel.BackColor = System.Drawing.Color.White;
            this.taskListPanel.Controls.Add(this.taskList);
            this.taskListPanel.Location = new System.Drawing.Point(0, 302);
            this.taskListPanel.Margin = new System.Windows.Forms.Padding(0);
            this.taskListPanel.MinimumSize = new System.Drawing.Size(160, 2);
            this.taskListPanel.Name = "taskListPanel";
            this.taskListPanel.Padding = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.taskListPanel.Size = new System.Drawing.Size(169, 70);
            this.taskListPanel.TabIndex = 1017;
            // 
            // calendar
            // 
            this.calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.calendar.BackColor = System.Drawing.SystemColors.Window;
            this.calendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.calendar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calendar.Location = new System.Drawing.Point(-2, 424);
            this.calendar.MaxSelectionCount = 1;
            this.calendar.Name = "calendar";
            this.calendar.ShowTodayCircle = false;
            this.calendar.TabIndex = 999;
            this.calendar.TabStop = false;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            // 
            // noTasksLabel
            // 
            this.noTasksLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.noTasksLabel.AutoSize = true;
            this.noTasksLabel.BackColor = System.Drawing.SystemColors.Window;
            this.noTasksLabel.CausesValidation = false;
            this.noTasksLabel.Enabled = false;
            this.noTasksLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noTasksLabel.ForeColor = System.Drawing.Color.DimGray;
            this.noTasksLabel.Location = new System.Drawing.Point(367, 61);
            this.noTasksLabel.Name = "noTasksLabel";
            this.noTasksLabel.Size = new System.Drawing.Size(120, 38);
            this.noTasksLabel.TabIndex = 1018;
            this.noTasksLabel.Text = "No tasks\r\n(hit Enter to edit)";
            this.noTasksLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.noTasksLabel.Visible = false;
            // 
            // TaskWinForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(855, 606);
            this.Controls.Add(this.taskEditorPanel);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.noTasksLabel);
            this.Controls.Add(this.taskListPanel);
            this.Controls.Add(this.settingsPanelMask);
            this.Controls.Add(this.helpPanelMask);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "TaskWinForm";
            this.Text = "TaskWin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskWinForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.TaskWinForm_ResizeEnd);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.taskList)).EndInit();
            this.settingsPanelMask.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoDeleteNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettingsClose)).EndInit();
            this.helpPanelMask.ResumeLayout(false);
            this.helpPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHelpClose)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.taskEditorPanel.ResumeLayout(false);
            this.taskListPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Panel settingsPanelMask;
		private System.Windows.Forms.Panel settingsPanel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.LinkLabel taskFolderLabel;
		private System.Windows.Forms.TextBox taskFolderPathTextBox;
		private System.Windows.Forms.Button btnTaskFolderBrowse;
		private System.Windows.Forms.FolderBrowserDialog taskFolderBrowserDialog;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox autoDeleteCheckbox;
		private System.Windows.Forms.Panel helpPanelMask;
		private System.Windows.Forms.Panel helpPanel;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RichTextBox richTextBox3;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.ToolStripStatusLabel statusDateLabel;
		private System.Windows.Forms.Panel taskEditorPanel;
		private System.Windows.Forms.Button btnEditorSave;
		private System.Windows.Forms.Button btnEditorCancel;
		private System.Windows.Forms.RichTextBox taskEditor;
		private System.Windows.Forms.Panel taskListPanel;
		private System.Windows.Forms.DataGridView taskList;
		private System.Windows.Forms.MonthCalendar calendar;
		private System.Windows.Forms.ToolStripStatusLabel btnUpdateOld;
		private System.Windows.Forms.ToolStripDropDownButton btnSettings;
		private System.Windows.Forms.ToolStripDropDownButton btnInfo;
		private System.Windows.Forms.DataGridViewTextBoxColumn tlcol_No;
		private System.Windows.Forms.DataGridViewTextBoxColumn tlcol_task;
		private System.Windows.Forms.DataGridViewCheckBoxColumn tlcol_status;
		private System.Windows.Forms.PictureBox btnHelpClose;
		private System.Windows.Forms.PictureBox btnSettingsClose;
		private System.Windows.Forms.Button btnTaskFolderClear;
		private System.Windows.Forms.CheckBox autoUpdateCheckbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown autoDeleteNumber;
		private System.Windows.Forms.Label noTasksLabel;
	}
}

