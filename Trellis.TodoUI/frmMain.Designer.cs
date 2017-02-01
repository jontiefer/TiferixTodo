namespace Trellis.TodoUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBackground = new DotCoolControls.WinForms.DotCoolPanel();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.lblUserHdr = new DotCoolControls.WinForms.DotCoolLabel();
            this.btnSave = new DotCoolControls.WinForms.DotCoolButton();
            this.gridTodoList = new System.Windows.Forms.DataGridView();
            this.TodoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteTodoItem = new DotCoolControls.WinForms.DotCoolButton();
            this.btnEditTodoItem = new DotCoolControls.WinForms.DotCoolButton();
            this.btnNewTodoItem = new DotCoolControls.WinForms.DotCoolButton();
            this.btnExit = new DotCoolControls.WinForms.DotCoolButton();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTodoList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackGradientSettings.GradientColor1 = System.Drawing.Color.Gainsboro;
            this.pnlBackground.BackGradientSettings.GradientColor2 = System.Drawing.Color.SlateGray;
            this.pnlBackground.BackGradientSettings.GradientOffset = new System.Drawing.Point(0, 0);
            this.pnlBackground.BackGradientSettings.GradientType = DotCoolControls.Tools.CoolGradientType.BackwardDiagonal;
            this.pnlBackground.BackGradientSettingsDisabled.GradientColor1 = System.Drawing.Color.Transparent;
            this.pnlBackground.BackGradientSettingsDisabled.GradientColor2 = System.Drawing.Color.Transparent;
            this.pnlBackground.BackGradientSettingsDisabled.GradientOffset = new System.Drawing.Point(0, 0);
            this.pnlBackground.BackGradientSettingsMouseDown.GradientColor1 = System.Drawing.Color.Transparent;
            this.pnlBackground.BackGradientSettingsMouseDown.GradientColor2 = System.Drawing.Color.Transparent;
            this.pnlBackground.BackGradientSettingsMouseDown.GradientOffset = new System.Drawing.Point(0, 0);
            this.pnlBackground.BackGradientSettingsMouseOver.GradientColor1 = System.Drawing.Color.Transparent;
            this.pnlBackground.BackGradientSettingsMouseOver.GradientColor2 = System.Drawing.Color.Transparent;
            this.pnlBackground.BackGradientSettingsMouseOver.GradientOffset = new System.Drawing.Point(0, 0);
            this.pnlBackground.Controls.Add(this.cbUsers);
            this.pnlBackground.Controls.Add(this.lblUserHdr);
            this.pnlBackground.Controls.Add(this.btnSave);
            this.pnlBackground.Controls.Add(this.gridTodoList);
            this.pnlBackground.Controls.Add(this.btnDeleteTodoItem);
            this.pnlBackground.Controls.Add(this.btnEditTodoItem);
            this.pnlBackground.Controls.Add(this.btnNewTodoItem);
            this.pnlBackground.Controls.Add(this.btnExit);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1075, 617);
            this.pnlBackground.TabIndex = 2;
            // 
            // cbUsers
            // 
            this.cbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsers.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Location = new System.Drawing.Point(6, 18);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(357, 25);
            this.cbUsers.TabIndex = 36;
            this.cbUsers.SelectedIndexChanged += new System.EventHandler(this.cbUsers_SelectedIndexChanged);
            // 
            // lblUserHdr
            // 
            this.lblUserHdr.BackColor = System.Drawing.Color.Transparent;
            this.lblUserHdr.BackGradientSettings.GradientColor1 = System.Drawing.Color.Transparent;
            this.lblUserHdr.BackGradientSettings.GradientColor2 = System.Drawing.Color.Transparent;
            this.lblUserHdr.BackGradientSettings.GradientOffset = new System.Drawing.Point(0, 0);
            this.lblUserHdr.BackGradientSettingsDisabled.GradientColor1 = System.Drawing.Color.Transparent;
            this.lblUserHdr.BackGradientSettingsDisabled.GradientColor2 = System.Drawing.Color.Transparent;
            this.lblUserHdr.BackGradientSettingsDisabled.GradientOffset = new System.Drawing.Point(0, 0);
            this.lblUserHdr.BackGradientSettingsMouseDown.GradientColor1 = System.Drawing.Color.Transparent;
            this.lblUserHdr.BackGradientSettingsMouseDown.GradientColor2 = System.Drawing.Color.Transparent;
            this.lblUserHdr.BackGradientSettingsMouseDown.GradientOffset = new System.Drawing.Point(0, 0);
            this.lblUserHdr.BackGradientSettingsMouseOver.GradientColor1 = System.Drawing.Color.Transparent;
            this.lblUserHdr.BackGradientSettingsMouseOver.GradientColor2 = System.Drawing.Color.Transparent;
            this.lblUserHdr.BackGradientSettingsMouseOver.GradientOffset = new System.Drawing.Point(0, 0);
            this.lblUserHdr.BorderColorSettings.BorderColor = System.Drawing.Color.Black;
            this.lblUserHdr.BorderColorSettings.BorderColorDisabled = System.Drawing.Color.Transparent;
            this.lblUserHdr.BorderColorSettings.BorderColorMouseDown = System.Drawing.Color.Transparent;
            this.lblUserHdr.BorderColorSettings.BorderColorMouseOver = System.Drawing.Color.Transparent;
            this.lblUserHdr.BorderRadius = new System.Drawing.Point(20, 20);
            this.lblUserHdr.BorderWidthSettings.BorderWidth = 0;
            this.lblUserHdr.BorderWidthSettings.BorderWidthMouseDown = 0;
            this.lblUserHdr.ImageSettings.EnableImage = true;
            this.lblUserHdr.ImageSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserHdr.ImageSettings.ImageOffset = new System.Drawing.Point(0, 0);
            this.lblUserHdr.ImageSettings.ImageTransColor = System.Drawing.Color.Transparent;
            this.lblUserHdr.ImageSettingsDisabled.EnableImage = false;
            this.lblUserHdr.ImageSettingsDisabled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserHdr.ImageSettingsDisabled.ImageOffset = new System.Drawing.Point(0, 0);
            this.lblUserHdr.ImageSettingsDisabled.ImageTransColor = System.Drawing.Color.Transparent;
            this.lblUserHdr.ImageSettingsMouseDown.EnableImage = false;
            this.lblUserHdr.ImageSettingsMouseDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserHdr.ImageSettingsMouseDown.ImageOffset = new System.Drawing.Point(0, 0);
            this.lblUserHdr.ImageSettingsMouseDown.ImageTransColor = System.Drawing.Color.Transparent;
            this.lblUserHdr.ImageSettingsMouseOver.EnableImage = false;
            this.lblUserHdr.ImageSettingsMouseOver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserHdr.ImageSettingsMouseOver.ImageOffset = new System.Drawing.Point(0, 0);
            this.lblUserHdr.ImageSettingsMouseOver.ImageTransColor = System.Drawing.Color.Transparent;
            this.lblUserHdr.Location = new System.Drawing.Point(6, 3);
            this.lblUserHdr.Name = "lblUserHdr";
            this.lblUserHdr.Size = new System.Drawing.Size(204, 18);
            this.lblUserHdr.TabIndex = 35;
            this.lblUserHdr.Text = "Select User To Display";
            this.lblUserHdr.TextSettings.EnableText = true;
            this.lblUserHdr.TextSettings.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserHdr.TextSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUserHdr.TextSettings.TextOffset = new System.Drawing.Point(0, 0);
            this.lblUserHdr.TextSettingsDisabled.EnableText = false;
            this.lblUserHdr.TextSettingsDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserHdr.TextSettingsDisabled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUserHdr.TextSettingsDisabled.TextOffset = new System.Drawing.Point(0, 0);
            this.lblUserHdr.TextSettingsMouseDown.EnableText = false;
            this.lblUserHdr.TextSettingsMouseDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserHdr.TextSettingsMouseDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUserHdr.TextSettingsMouseDown.TextOffset = new System.Drawing.Point(0, 0);
            this.lblUserHdr.TextSettingsMouseOver.EnableText = false;
            this.lblUserHdr.TextSettingsMouseOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserHdr.TextSettingsMouseOver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUserHdr.TextSettingsMouseOver.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackGradientSettings.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.BackGradientSettings.GradientColor2 = System.Drawing.Color.Indigo;
            this.btnSave.BackGradientSettings.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnSave.BackGradientSettings.GradientType = DotCoolControls.Tools.CoolGradientType.Circular;
            this.btnSave.BackGradientSettingsDisabled.GradientColor1 = System.Drawing.Color.Transparent;
            this.btnSave.BackGradientSettingsDisabled.GradientColor2 = System.Drawing.Color.Transparent;
            this.btnSave.BackGradientSettingsDisabled.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnSave.BackGradientSettingsMouseDown.GradientColor1 = System.Drawing.Color.Maroon;
            this.btnSave.BackGradientSettingsMouseDown.GradientColor2 = System.Drawing.Color.LavenderBlush;
            this.btnSave.BackGradientSettingsMouseDown.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnSave.BackGradientSettingsMouseDown.GradientType = DotCoolControls.Tools.CoolGradientType.Circular;
            this.btnSave.BackGradientSettingsMouseOver.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnSave.BackGradientSettingsMouseOver.GradientColor2 = System.Drawing.Color.MediumPurple;
            this.btnSave.BackGradientSettingsMouseOver.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnSave.BackGradientSettingsMouseOver.GradientType = DotCoolControls.Tools.CoolGradientType.Circular;
            this.btnSave.BorderColorSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSave.BorderColorSettings.BorderColorDisabled = System.Drawing.Color.Transparent;
            this.btnSave.BorderColorSettings.BorderColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.BorderColorSettings.BorderColorMouseOver = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = new System.Drawing.Point(20, 20);
            this.btnSave.BorderShape = Tiferix.Global.CoolShape.Square;
            this.btnSave.BorderWidthSettings.BorderWidth = 3;
            this.btnSave.BorderWidthSettings.BorderWidthMouseDown = 4;
            this.btnSave.ImageSettings.EnableImage = true;
            this.btnSave.ImageSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageSettings.Image")));
            this.btnSave.ImageSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.ImageSettings.ImageOffset = new System.Drawing.Point(-3, -7);
            this.btnSave.ImageSettings.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnSave.ImageSettingsDisabled.EnableImage = false;
            this.btnSave.ImageSettingsDisabled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageSettingsDisabled.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSave.ImageSettingsDisabled.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnSave.ImageSettingsMouseDown.EnableImage = false;
            this.btnSave.ImageSettingsMouseDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageSettingsMouseDown.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSave.ImageSettingsMouseDown.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnSave.ImageSettingsMouseOver.EnableImage = false;
            this.btnSave.ImageSettingsMouseOver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageSettingsMouseOver.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSave.ImageSettingsMouseOver.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(915, 539);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 72);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "&Save";
            this.btnSave.TextSettings.EnableText = true;
            this.btnSave.TextSettings.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.TextSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.TextSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.TextSettings.TextOffset = new System.Drawing.Point(0, -5);
            this.btnSave.TextSettingsDisabled.EnableText = false;
            this.btnSave.TextSettingsDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.TextSettingsDisabled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.TextSettingsDisabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextSettingsDisabled.TextOffset = new System.Drawing.Point(0, 0);
            this.btnSave.TextSettingsMouseDown.EnableText = true;
            this.btnSave.TextSettingsMouseDown.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.TextSettingsMouseDown.ForeColor = System.Drawing.Color.Yellow;
            this.btnSave.TextSettingsMouseDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.TextSettingsMouseDown.TextOffset = new System.Drawing.Point(0, -5);
            this.btnSave.TextSettingsMouseOver.EnableText = false;
            this.btnSave.TextSettingsMouseOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.TextSettingsMouseOver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.TextSettingsMouseOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextSettingsMouseOver.TextOffset = new System.Drawing.Point(0, 0);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridTodoList
            // 
            this.gridTodoList.AllowUserToAddRows = false;
            this.gridTodoList.AllowUserToDeleteRows = false;
            this.gridTodoList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTodoList.BackgroundColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTodoList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridTodoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTodoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TodoID,
            this.Completed,
            this.Deadline,
            this.Task});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTodoList.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridTodoList.EnableHeadersVisualStyles = false;
            this.gridTodoList.Location = new System.Drawing.Point(6, 48);
            this.gridTodoList.MultiSelect = false;
            this.gridTodoList.Name = "gridTodoList";
            this.gridTodoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTodoList.Size = new System.Drawing.Size(1062, 480);
            this.gridTodoList.TabIndex = 33;
            this.gridTodoList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTodoList_CellDoubleClick);
            this.gridTodoList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTodoList_CellValueChanged);
            // 
            // TodoID
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.TodoID.DefaultCellStyle = dataGridViewCellStyle2;
            this.TodoID.HeaderText = "TodoID";
            this.TodoID.Name = "TodoID";
            this.TodoID.ReadOnly = true;
            this.TodoID.Visible = false;
            // 
            // Completed
            // 
            this.Completed.HeaderText = "Completed";
            this.Completed.Name = "Completed";
            // 
            // Deadline
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.Deadline.DefaultCellStyle = dataGridViewCellStyle3;
            this.Deadline.HeaderText = "Deadline";
            this.Deadline.Name = "Deadline";
            this.Deadline.ReadOnly = true;
            this.Deadline.Width = 105;
            // 
            // Task
            // 
            this.Task.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Task.HeaderText = "Task Description";
            this.Task.Name = "Task";
            this.Task.ReadOnly = true;
            // 
            // btnDeleteTodoItem
            // 
            this.btnDeleteTodoItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteTodoItem.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteTodoItem.BackGradientSettings.GradientColor1 = System.Drawing.Color.LightSteelBlue;
            this.btnDeleteTodoItem.BackGradientSettings.GradientColor2 = System.Drawing.Color.DarkSlateBlue;
            this.btnDeleteTodoItem.BackGradientSettings.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnDeleteTodoItem.BackGradientSettings.GradientSpan = 1.4F;
            this.btnDeleteTodoItem.BackGradientSettings.GradientType = DotCoolControls.Tools.CoolGradientType.Ellipsis;
            this.btnDeleteTodoItem.BackGradientSettings.UseDefaultGradientSpan = false;
            this.btnDeleteTodoItem.BackGradientSettingsDisabled.GradientColor1 = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteTodoItem.BackGradientSettingsDisabled.GradientColor2 = System.Drawing.Color.DarkGray;
            this.btnDeleteTodoItem.BackGradientSettingsDisabled.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnDeleteTodoItem.BackGradientSettingsDisabled.GradientSpan = 1.4F;
            this.btnDeleteTodoItem.BackGradientSettingsDisabled.GradientType = DotCoolControls.Tools.CoolGradientType.Ellipsis;
            this.btnDeleteTodoItem.BackGradientSettingsMouseDown.GradientColor1 = System.Drawing.Color.Firebrick;
            this.btnDeleteTodoItem.BackGradientSettingsMouseDown.GradientColor2 = System.Drawing.Color.MistyRose;
            this.btnDeleteTodoItem.BackGradientSettingsMouseDown.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnDeleteTodoItem.BackGradientSettingsMouseDown.GradientType = DotCoolControls.Tools.CoolGradientType.Triangular;
            this.btnDeleteTodoItem.BackGradientSettingsMouseOver.GradientColor1 = System.Drawing.Color.AliceBlue;
            this.btnDeleteTodoItem.BackGradientSettingsMouseOver.GradientColor2 = System.Drawing.Color.MediumPurple;
            this.btnDeleteTodoItem.BackGradientSettingsMouseOver.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnDeleteTodoItem.BackGradientSettingsMouseOver.GradientSpan = 1.4F;
            this.btnDeleteTodoItem.BackGradientSettingsMouseOver.GradientType = DotCoolControls.Tools.CoolGradientType.Ellipsis;
            this.btnDeleteTodoItem.BorderColorSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDeleteTodoItem.BorderColorSettings.BorderColorDisabled = System.Drawing.Color.Transparent;
            this.btnDeleteTodoItem.BorderColorSettings.BorderColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteTodoItem.BorderColorSettings.BorderColorMouseOver = System.Drawing.Color.Transparent;
            this.btnDeleteTodoItem.BorderRadius = new System.Drawing.Point(20, 20);
            this.btnDeleteTodoItem.BorderShape = Tiferix.Global.CoolShape.RoundedRect;
            this.btnDeleteTodoItem.BorderWidthSettings.BorderWidth = 2;
            this.btnDeleteTodoItem.BorderWidthSettings.BorderWidthMouseDown = 3;
            this.btnDeleteTodoItem.ImageSettings.EnableImage = true;
            this.btnDeleteTodoItem.ImageSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteTodoItem.ImageSettings.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDeleteTodoItem.ImageSettings.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnDeleteTodoItem.ImageSettingsDisabled.EnableImage = false;
            this.btnDeleteTodoItem.ImageSettingsDisabled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteTodoItem.ImageSettingsDisabled.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDeleteTodoItem.ImageSettingsDisabled.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnDeleteTodoItem.ImageSettingsMouseDown.EnableImage = false;
            this.btnDeleteTodoItem.ImageSettingsMouseDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteTodoItem.ImageSettingsMouseDown.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDeleteTodoItem.ImageSettingsMouseDown.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnDeleteTodoItem.ImageSettingsMouseOver.EnableImage = false;
            this.btnDeleteTodoItem.ImageSettingsMouseOver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteTodoItem.ImageSettingsMouseOver.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDeleteTodoItem.ImageSettingsMouseOver.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnDeleteTodoItem.Location = new System.Drawing.Point(522, 546);
            this.btnDeleteTodoItem.Name = "btnDeleteTodoItem";
            this.btnDeleteTodoItem.Size = new System.Drawing.Size(177, 60);
            this.btnDeleteTodoItem.TabIndex = 32;
            this.btnDeleteTodoItem.Text = "&Delete";
            this.btnDeleteTodoItem.TextSettings.EnableText = true;
            this.btnDeleteTodoItem.TextSettings.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTodoItem.TextSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteTodoItem.TextSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteTodoItem.TextSettings.TextOffset = new System.Drawing.Point(0, 0);
            this.btnDeleteTodoItem.TextSettingsDisabled.EnableText = false;
            this.btnDeleteTodoItem.TextSettingsDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTodoItem.TextSettingsDisabled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteTodoItem.TextSettingsDisabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteTodoItem.TextSettingsDisabled.TextOffset = new System.Drawing.Point(0, 0);
            this.btnDeleteTodoItem.TextSettingsMouseDown.EnableText = true;
            this.btnDeleteTodoItem.TextSettingsMouseDown.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTodoItem.TextSettingsMouseDown.ForeColor = System.Drawing.Color.Yellow;
            this.btnDeleteTodoItem.TextSettingsMouseDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteTodoItem.TextSettingsMouseDown.TextOffset = new System.Drawing.Point(0, 0);
            this.btnDeleteTodoItem.TextSettingsMouseOver.EnableText = false;
            this.btnDeleteTodoItem.TextSettingsMouseOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTodoItem.TextSettingsMouseOver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteTodoItem.TextSettingsMouseOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteTodoItem.TextSettingsMouseOver.TextOffset = new System.Drawing.Point(0, 0);
            this.btnDeleteTodoItem.Click += new System.EventHandler(this.btnDeleteTodoItem_Click);
            // 
            // btnEditTodoItem
            // 
            this.btnEditTodoItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditTodoItem.BackColor = System.Drawing.Color.Transparent;
            this.btnEditTodoItem.BackGradientSettings.GradientColor1 = System.Drawing.Color.LightSteelBlue;
            this.btnEditTodoItem.BackGradientSettings.GradientColor2 = System.Drawing.Color.DarkSlateBlue;
            this.btnEditTodoItem.BackGradientSettings.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnEditTodoItem.BackGradientSettings.GradientSpan = 1.4F;
            this.btnEditTodoItem.BackGradientSettings.GradientType = DotCoolControls.Tools.CoolGradientType.Ellipsis;
            this.btnEditTodoItem.BackGradientSettings.UseDefaultGradientSpan = false;
            this.btnEditTodoItem.BackGradientSettingsDisabled.GradientColor1 = System.Drawing.Color.WhiteSmoke;
            this.btnEditTodoItem.BackGradientSettingsDisabled.GradientColor2 = System.Drawing.Color.DarkGray;
            this.btnEditTodoItem.BackGradientSettingsDisabled.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnEditTodoItem.BackGradientSettingsDisabled.GradientSpan = 1.4F;
            this.btnEditTodoItem.BackGradientSettingsDisabled.GradientType = DotCoolControls.Tools.CoolGradientType.Ellipsis;
            this.btnEditTodoItem.BackGradientSettingsMouseDown.GradientColor1 = System.Drawing.Color.Firebrick;
            this.btnEditTodoItem.BackGradientSettingsMouseDown.GradientColor2 = System.Drawing.Color.MistyRose;
            this.btnEditTodoItem.BackGradientSettingsMouseDown.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnEditTodoItem.BackGradientSettingsMouseDown.GradientType = DotCoolControls.Tools.CoolGradientType.Triangular;
            this.btnEditTodoItem.BackGradientSettingsMouseOver.GradientColor1 = System.Drawing.Color.AliceBlue;
            this.btnEditTodoItem.BackGradientSettingsMouseOver.GradientColor2 = System.Drawing.Color.MediumPurple;
            this.btnEditTodoItem.BackGradientSettingsMouseOver.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnEditTodoItem.BackGradientSettingsMouseOver.GradientSpan = 1.4F;
            this.btnEditTodoItem.BackGradientSettingsMouseOver.GradientType = DotCoolControls.Tools.CoolGradientType.Ellipsis;
            this.btnEditTodoItem.BorderColorSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEditTodoItem.BorderColorSettings.BorderColorDisabled = System.Drawing.Color.Transparent;
            this.btnEditTodoItem.BorderColorSettings.BorderColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditTodoItem.BorderColorSettings.BorderColorMouseOver = System.Drawing.Color.Transparent;
            this.btnEditTodoItem.BorderRadius = new System.Drawing.Point(20, 20);
            this.btnEditTodoItem.BorderShape = Tiferix.Global.CoolShape.RoundedRect;
            this.btnEditTodoItem.BorderWidthSettings.BorderWidth = 2;
            this.btnEditTodoItem.BorderWidthSettings.BorderWidthMouseDown = 3;
            this.btnEditTodoItem.ImageSettings.EnableImage = true;
            this.btnEditTodoItem.ImageSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditTodoItem.ImageSettings.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnEditTodoItem.ImageSettings.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnEditTodoItem.ImageSettingsDisabled.EnableImage = false;
            this.btnEditTodoItem.ImageSettingsDisabled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditTodoItem.ImageSettingsDisabled.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnEditTodoItem.ImageSettingsDisabled.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnEditTodoItem.ImageSettingsMouseDown.EnableImage = false;
            this.btnEditTodoItem.ImageSettingsMouseDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditTodoItem.ImageSettingsMouseDown.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnEditTodoItem.ImageSettingsMouseDown.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnEditTodoItem.ImageSettingsMouseOver.EnableImage = false;
            this.btnEditTodoItem.ImageSettingsMouseOver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditTodoItem.ImageSettingsMouseOver.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnEditTodoItem.ImageSettingsMouseOver.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnEditTodoItem.Location = new System.Drawing.Point(315, 546);
            this.btnEditTodoItem.Name = "btnEditTodoItem";
            this.btnEditTodoItem.Size = new System.Drawing.Size(177, 60);
            this.btnEditTodoItem.TabIndex = 31;
            this.btnEditTodoItem.Text = "&Edit";
            this.btnEditTodoItem.TextSettings.EnableText = true;
            this.btnEditTodoItem.TextSettings.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTodoItem.TextSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditTodoItem.TextSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditTodoItem.TextSettings.TextOffset = new System.Drawing.Point(0, 0);
            this.btnEditTodoItem.TextSettingsDisabled.EnableText = false;
            this.btnEditTodoItem.TextSettingsDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTodoItem.TextSettingsDisabled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditTodoItem.TextSettingsDisabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditTodoItem.TextSettingsDisabled.TextOffset = new System.Drawing.Point(0, 0);
            this.btnEditTodoItem.TextSettingsMouseDown.EnableText = true;
            this.btnEditTodoItem.TextSettingsMouseDown.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTodoItem.TextSettingsMouseDown.ForeColor = System.Drawing.Color.Yellow;
            this.btnEditTodoItem.TextSettingsMouseDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditTodoItem.TextSettingsMouseDown.TextOffset = new System.Drawing.Point(0, 0);
            this.btnEditTodoItem.TextSettingsMouseOver.EnableText = false;
            this.btnEditTodoItem.TextSettingsMouseOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTodoItem.TextSettingsMouseOver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditTodoItem.TextSettingsMouseOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditTodoItem.TextSettingsMouseOver.TextOffset = new System.Drawing.Point(0, 0);
            this.btnEditTodoItem.Click += new System.EventHandler(this.btnEditTodoItem_Click);
            // 
            // btnNewTodoItem
            // 
            this.btnNewTodoItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewTodoItem.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTodoItem.BackGradientSettings.GradientColor1 = System.Drawing.Color.LightSteelBlue;
            this.btnNewTodoItem.BackGradientSettings.GradientColor2 = System.Drawing.Color.DarkSlateBlue;
            this.btnNewTodoItem.BackGradientSettings.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnNewTodoItem.BackGradientSettings.GradientSpan = 1.4F;
            this.btnNewTodoItem.BackGradientSettings.GradientType = DotCoolControls.Tools.CoolGradientType.Ellipsis;
            this.btnNewTodoItem.BackGradientSettings.UseDefaultGradientSpan = false;
            this.btnNewTodoItem.BackGradientSettingsDisabled.GradientColor1 = System.Drawing.Color.WhiteSmoke;
            this.btnNewTodoItem.BackGradientSettingsDisabled.GradientColor2 = System.Drawing.Color.DarkGray;
            this.btnNewTodoItem.BackGradientSettingsDisabled.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnNewTodoItem.BackGradientSettingsDisabled.GradientSpan = 1.4F;
            this.btnNewTodoItem.BackGradientSettingsDisabled.GradientType = DotCoolControls.Tools.CoolGradientType.Ellipsis;
            this.btnNewTodoItem.BackGradientSettingsMouseDown.GradientColor1 = System.Drawing.Color.Firebrick;
            this.btnNewTodoItem.BackGradientSettingsMouseDown.GradientColor2 = System.Drawing.Color.MistyRose;
            this.btnNewTodoItem.BackGradientSettingsMouseDown.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnNewTodoItem.BackGradientSettingsMouseDown.GradientType = DotCoolControls.Tools.CoolGradientType.Triangular;
            this.btnNewTodoItem.BackGradientSettingsMouseOver.GradientColor1 = System.Drawing.Color.AliceBlue;
            this.btnNewTodoItem.BackGradientSettingsMouseOver.GradientColor2 = System.Drawing.Color.MediumPurple;
            this.btnNewTodoItem.BackGradientSettingsMouseOver.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnNewTodoItem.BackGradientSettingsMouseOver.GradientSpan = 1.4F;
            this.btnNewTodoItem.BackGradientSettingsMouseOver.GradientType = DotCoolControls.Tools.CoolGradientType.Ellipsis;
            this.btnNewTodoItem.BorderColorSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNewTodoItem.BorderColorSettings.BorderColorDisabled = System.Drawing.Color.Transparent;
            this.btnNewTodoItem.BorderColorSettings.BorderColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNewTodoItem.BorderColorSettings.BorderColorMouseOver = System.Drawing.Color.Transparent;
            this.btnNewTodoItem.BorderRadius = new System.Drawing.Point(20, 20);
            this.btnNewTodoItem.BorderShape = Tiferix.Global.CoolShape.RoundedRect;
            this.btnNewTodoItem.BorderWidthSettings.BorderWidth = 2;
            this.btnNewTodoItem.BorderWidthSettings.BorderWidthMouseDown = 3;
            this.btnNewTodoItem.ImageSettings.EnableImage = true;
            this.btnNewTodoItem.ImageSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewTodoItem.ImageSettings.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnNewTodoItem.ImageSettings.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnNewTodoItem.ImageSettingsDisabled.EnableImage = false;
            this.btnNewTodoItem.ImageSettingsDisabled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewTodoItem.ImageSettingsDisabled.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnNewTodoItem.ImageSettingsDisabled.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnNewTodoItem.ImageSettingsMouseDown.EnableImage = false;
            this.btnNewTodoItem.ImageSettingsMouseDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewTodoItem.ImageSettingsMouseDown.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnNewTodoItem.ImageSettingsMouseDown.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnNewTodoItem.ImageSettingsMouseOver.EnableImage = false;
            this.btnNewTodoItem.ImageSettingsMouseOver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewTodoItem.ImageSettingsMouseOver.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnNewTodoItem.ImageSettingsMouseOver.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnNewTodoItem.Location = new System.Drawing.Point(111, 546);
            this.btnNewTodoItem.Name = "btnNewTodoItem";
            this.btnNewTodoItem.Size = new System.Drawing.Size(177, 60);
            this.btnNewTodoItem.TabIndex = 30;
            this.btnNewTodoItem.Text = "&New";
            this.btnNewTodoItem.TextSettings.EnableText = true;
            this.btnNewTodoItem.TextSettings.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTodoItem.TextSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNewTodoItem.TextSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewTodoItem.TextSettings.TextOffset = new System.Drawing.Point(0, 0);
            this.btnNewTodoItem.TextSettingsDisabled.EnableText = false;
            this.btnNewTodoItem.TextSettingsDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTodoItem.TextSettingsDisabled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNewTodoItem.TextSettingsDisabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewTodoItem.TextSettingsDisabled.TextOffset = new System.Drawing.Point(0, 0);
            this.btnNewTodoItem.TextSettingsMouseDown.EnableText = true;
            this.btnNewTodoItem.TextSettingsMouseDown.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTodoItem.TextSettingsMouseDown.ForeColor = System.Drawing.Color.Yellow;
            this.btnNewTodoItem.TextSettingsMouseDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewTodoItem.TextSettingsMouseDown.TextOffset = new System.Drawing.Point(0, 0);
            this.btnNewTodoItem.TextSettingsMouseOver.EnableText = false;
            this.btnNewTodoItem.TextSettingsMouseOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTodoItem.TextSettingsMouseOver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNewTodoItem.TextSettingsMouseOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewTodoItem.TextSettingsMouseOver.TextOffset = new System.Drawing.Point(0, 0);
            this.btnNewTodoItem.Click += new System.EventHandler(this.btnNewTodoItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackGradientSettings.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExit.BackGradientSettings.GradientColor2 = System.Drawing.Color.Indigo;
            this.btnExit.BackGradientSettings.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnExit.BackGradientSettings.GradientType = DotCoolControls.Tools.CoolGradientType.Circular;
            this.btnExit.BackGradientSettingsDisabled.GradientColor1 = System.Drawing.Color.Transparent;
            this.btnExit.BackGradientSettingsDisabled.GradientColor2 = System.Drawing.Color.Transparent;
            this.btnExit.BackGradientSettingsDisabled.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnExit.BackGradientSettingsMouseDown.GradientColor1 = System.Drawing.Color.Maroon;
            this.btnExit.BackGradientSettingsMouseDown.GradientColor2 = System.Drawing.Color.LavenderBlush;
            this.btnExit.BackGradientSettingsMouseDown.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnExit.BackGradientSettingsMouseDown.GradientType = DotCoolControls.Tools.CoolGradientType.Circular;
            this.btnExit.BackGradientSettingsMouseOver.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnExit.BackGradientSettingsMouseOver.GradientColor2 = System.Drawing.Color.MediumPurple;
            this.btnExit.BackGradientSettingsMouseOver.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnExit.BackGradientSettingsMouseOver.GradientType = DotCoolControls.Tools.CoolGradientType.Circular;
            this.btnExit.BorderColorSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnExit.BorderColorSettings.BorderColorDisabled = System.Drawing.Color.Transparent;
            this.btnExit.BorderColorSettings.BorderColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.BorderColorSettings.BorderColorMouseOver = System.Drawing.Color.Transparent;
            this.btnExit.BorderRadius = new System.Drawing.Point(20, 20);
            this.btnExit.BorderShape = Tiferix.Global.CoolShape.Square;
            this.btnExit.BorderWidthSettings.BorderWidth = 3;
            this.btnExit.BorderWidthSettings.BorderWidthMouseDown = 4;
            this.btnExit.ImageSettings.EnableImage = true;
            this.btnExit.ImageSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageSettings.Image")));
            this.btnExit.ImageSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.ImageSettings.ImageOffset = new System.Drawing.Point(-3, -7);
            this.btnExit.ImageSettings.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnExit.ImageSettingsDisabled.EnableImage = false;
            this.btnExit.ImageSettingsDisabled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.ImageSettingsDisabled.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnExit.ImageSettingsDisabled.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnExit.ImageSettingsMouseDown.EnableImage = false;
            this.btnExit.ImageSettingsMouseDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.ImageSettingsMouseDown.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnExit.ImageSettingsMouseDown.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnExit.ImageSettingsMouseOver.EnableImage = false;
            this.btnExit.ImageSettingsMouseOver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.ImageSettingsMouseOver.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnExit.ImageSettingsMouseOver.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(997, 539);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 72);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "E&xit";
            this.btnExit.TextSettings.EnableText = true;
            this.btnExit.TextSettings.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.TextSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.TextSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.TextSettings.TextOffset = new System.Drawing.Point(0, -5);
            this.btnExit.TextSettingsDisabled.EnableText = false;
            this.btnExit.TextSettingsDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.TextSettingsDisabled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.TextSettingsDisabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.TextSettingsDisabled.TextOffset = new System.Drawing.Point(0, 0);
            this.btnExit.TextSettingsMouseDown.EnableText = true;
            this.btnExit.TextSettingsMouseDown.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.TextSettingsMouseDown.ForeColor = System.Drawing.Color.Yellow;
            this.btnExit.TextSettingsMouseDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.TextSettingsMouseDown.TextOffset = new System.Drawing.Point(0, -5);
            this.btnExit.TextSettingsMouseOver.EnableText = false;
            this.btnExit.TextSettingsMouseOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.TextSettingsMouseOver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.TextSettingsMouseOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.TextSettingsMouseOver.TextOffset = new System.Drawing.Point(0, 0);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 617);
            this.Controls.Add(this.pnlBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Trellis Todo List Test Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTodoList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DotCoolControls.WinForms.DotCoolPanel pnlBackground;
        private DotCoolControls.WinForms.DotCoolButton btnExit;
        private DotCoolControls.WinForms.DotCoolButton btnDeleteTodoItem;
        private DotCoolControls.WinForms.DotCoolButton btnEditTodoItem;
        private DotCoolControls.WinForms.DotCoolButton btnNewTodoItem;
        private System.Windows.Forms.DataGridView gridTodoList;
        private DotCoolControls.WinForms.DotCoolButton btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn TodoID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Completed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.ComboBox cbUsers;
        private DotCoolControls.WinForms.DotCoolLabel lblUserHdr;
    }
}

