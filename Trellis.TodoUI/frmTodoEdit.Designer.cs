namespace Trellis.TodoUI
{
    partial class frmTodoEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTodoEdit));
            this.btnCancel = new DotCoolControls.WinForms.DotCoolButton();
            this.btnOK = new DotCoolControls.WinForms.DotCoolButton();
            this.lblTaskHdr = new DotCoolControls.WinForms.DotCoolLabel();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.lblDeadlineHdr = new DotCoolControls.WinForms.DotCoolLabel();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblDetailsHdr = new DotCoolControls.WinForms.DotCoolLabel();
            this.chbCompleted = new DotCoolControls.WinForms.DotCoolCheckBox();
            this.lblDeadlineWarning = new DotCoolControls.WinForms.DotCoolLabel();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackGradientSettings.GradientColor1 = System.Drawing.Color.Wheat;
            this.btnCancel.BackGradientSettings.GradientColor2 = System.Drawing.Color.DarkRed;
            this.btnCancel.BackGradientSettings.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnCancel.BackGradientSettings.GradientSpan = 1.4F;
            this.btnCancel.BackGradientSettings.GradientType = DotCoolControls.Tools.CoolGradientType.Ellipsis;
            this.btnCancel.BackGradientSettings.UseDefaultGradientSpan = false;
            this.btnCancel.BackGradientSettingsDisabled.GradientColor1 = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.BackGradientSettingsDisabled.GradientColor2 = System.Drawing.Color.DarkGray;
            this.btnCancel.BackGradientSettingsDisabled.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnCancel.BackGradientSettingsDisabled.GradientSpan = 1.4F;
            this.btnCancel.BackGradientSettingsDisabled.GradientType = DotCoolControls.Tools.CoolGradientType.Ellipsis;
            this.btnCancel.BackGradientSettingsMouseDown.GradientColor1 = System.Drawing.Color.Firebrick;
            this.btnCancel.BackGradientSettingsMouseDown.GradientColor2 = System.Drawing.Color.MistyRose;
            this.btnCancel.BackGradientSettingsMouseDown.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnCancel.BackGradientSettingsMouseDown.GradientType = DotCoolControls.Tools.CoolGradientType.Triangular;
            this.btnCancel.BackGradientSettingsMouseOver.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.BackGradientSettingsMouseOver.GradientColor2 = System.Drawing.Color.OrangeRed;
            this.btnCancel.BackGradientSettingsMouseOver.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnCancel.BackGradientSettingsMouseOver.GradientSpan = 1.4F;
            this.btnCancel.BackGradientSettingsMouseOver.GradientType = DotCoolControls.Tools.CoolGradientType.Ellipsis;
            this.btnCancel.BorderColorSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancel.BorderColorSettings.BorderColorDisabled = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColorSettings.BorderColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.BorderColorSettings.BorderColorMouseOver = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = new System.Drawing.Point(20, 20);
            this.btnCancel.BorderShape = Tiferix.Global.CoolShape.RoundedRect;
            this.btnCancel.BorderWidthSettings.BorderWidth = 2;
            this.btnCancel.BorderWidthSettings.BorderWidthMouseDown = 3;
            this.btnCancel.ImageSettings.EnableImage = true;
            this.btnCancel.ImageSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImageSettings.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCancel.ImageSettings.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnCancel.ImageSettingsDisabled.EnableImage = false;
            this.btnCancel.ImageSettingsDisabled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImageSettingsDisabled.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCancel.ImageSettingsDisabled.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnCancel.ImageSettingsMouseDown.EnableImage = false;
            this.btnCancel.ImageSettingsMouseDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImageSettingsMouseDown.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCancel.ImageSettingsMouseDown.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnCancel.ImageSettingsMouseOver.EnableImage = false;
            this.btnCancel.ImageSettingsMouseOver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImageSettingsMouseOver.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCancel.ImageSettingsMouseOver.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(628, 381);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 63);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextSettings.EnableText = true;
            this.btnCancel.TextSettings.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.TextSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.TextSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextSettings.TextOffset = new System.Drawing.Point(0, 0);
            this.btnCancel.TextSettingsDisabled.EnableText = false;
            this.btnCancel.TextSettingsDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.TextSettingsDisabled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.TextSettingsDisabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextSettingsDisabled.TextOffset = new System.Drawing.Point(0, 0);
            this.btnCancel.TextSettingsMouseDown.EnableText = true;
            this.btnCancel.TextSettingsMouseDown.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.TextSettingsMouseDown.ForeColor = System.Drawing.Color.Yellow;
            this.btnCancel.TextSettingsMouseDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextSettingsMouseDown.TextOffset = new System.Drawing.Point(0, 0);
            this.btnCancel.TextSettingsMouseOver.EnableText = false;
            this.btnCancel.TextSettingsMouseOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.TextSettingsMouseOver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.TextSettingsMouseOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextSettingsMouseOver.TextOffset = new System.Drawing.Point(0, 0);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BackGradientSettings.GradientColor1 = System.Drawing.Color.Wheat;
            this.btnOK.BackGradientSettings.GradientColor2 = System.Drawing.Color.DarkRed;
            this.btnOK.BackGradientSettings.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnOK.BackGradientSettings.GradientSpan = 1.4F;
            this.btnOK.BackGradientSettings.GradientType = DotCoolControls.Tools.CoolGradientType.Ellipsis;
            this.btnOK.BackGradientSettings.UseDefaultGradientSpan = false;
            this.btnOK.BackGradientSettingsDisabled.GradientColor1 = System.Drawing.Color.WhiteSmoke;
            this.btnOK.BackGradientSettingsDisabled.GradientColor2 = System.Drawing.Color.DarkGray;
            this.btnOK.BackGradientSettingsDisabled.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnOK.BackGradientSettingsDisabled.GradientSpan = 1.4F;
            this.btnOK.BackGradientSettingsDisabled.GradientType = DotCoolControls.Tools.CoolGradientType.Ellipsis;
            this.btnOK.BackGradientSettingsMouseDown.GradientColor1 = System.Drawing.Color.Firebrick;
            this.btnOK.BackGradientSettingsMouseDown.GradientColor2 = System.Drawing.Color.MistyRose;
            this.btnOK.BackGradientSettingsMouseDown.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnOK.BackGradientSettingsMouseDown.GradientType = DotCoolControls.Tools.CoolGradientType.Triangular;
            this.btnOK.BackGradientSettingsMouseOver.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOK.BackGradientSettingsMouseOver.GradientColor2 = System.Drawing.Color.OrangeRed;
            this.btnOK.BackGradientSettingsMouseOver.GradientOffset = new System.Drawing.Point(0, 0);
            this.btnOK.BackGradientSettingsMouseOver.GradientSpan = 1.4F;
            this.btnOK.BackGradientSettingsMouseOver.GradientType = DotCoolControls.Tools.CoolGradientType.Ellipsis;
            this.btnOK.BorderColorSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnOK.BorderColorSettings.BorderColorDisabled = System.Drawing.Color.Transparent;
            this.btnOK.BorderColorSettings.BorderColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOK.BorderColorSettings.BorderColorMouseOver = System.Drawing.Color.Transparent;
            this.btnOK.BorderRadius = new System.Drawing.Point(20, 20);
            this.btnOK.BorderShape = Tiferix.Global.CoolShape.RoundedRect;
            this.btnOK.BorderWidthSettings.BorderWidth = 2;
            this.btnOK.BorderWidthSettings.BorderWidthMouseDown = 3;
            this.btnOK.ImageSettings.EnableImage = true;
            this.btnOK.ImageSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.ImageSettings.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnOK.ImageSettings.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnOK.ImageSettingsDisabled.EnableImage = false;
            this.btnOK.ImageSettingsDisabled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.ImageSettingsDisabled.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnOK.ImageSettingsDisabled.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnOK.ImageSettingsMouseDown.EnableImage = false;
            this.btnOK.ImageSettingsMouseDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.ImageSettingsMouseDown.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnOK.ImageSettingsMouseDown.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnOK.ImageSettingsMouseOver.EnableImage = false;
            this.btnOK.ImageSettingsMouseOver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.ImageSettingsMouseOver.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnOK.ImageSettingsMouseOver.ImageTransColor = System.Drawing.Color.Transparent;
            this.btnOK.Location = new System.Drawing.Point(505, 381);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(114, 63);
            this.btnOK.TabIndex = 32;
            this.btnOK.Text = "&OK";
            this.btnOK.TextSettings.EnableText = true;
            this.btnOK.TextSettings.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.TextSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOK.TextSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.TextSettings.TextOffset = new System.Drawing.Point(0, 0);
            this.btnOK.TextSettingsDisabled.EnableText = false;
            this.btnOK.TextSettingsDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.TextSettingsDisabled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOK.TextSettingsDisabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.TextSettingsDisabled.TextOffset = new System.Drawing.Point(0, 0);
            this.btnOK.TextSettingsMouseDown.EnableText = true;
            this.btnOK.TextSettingsMouseDown.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.TextSettingsMouseDown.ForeColor = System.Drawing.Color.Yellow;
            this.btnOK.TextSettingsMouseDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.TextSettingsMouseDown.TextOffset = new System.Drawing.Point(0, 0);
            this.btnOK.TextSettingsMouseOver.EnableText = false;
            this.btnOK.TextSettingsMouseOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.TextSettingsMouseOver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOK.TextSettingsMouseOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.TextSettingsMouseOver.TextOffset = new System.Drawing.Point(0, 0);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblTaskHdr
            // 
            this.lblTaskHdr.BackGradientSettings.GradientColor1 = System.Drawing.Color.Transparent;
            this.lblTaskHdr.BackGradientSettings.GradientColor2 = System.Drawing.Color.Transparent;
            this.lblTaskHdr.BackGradientSettings.GradientOffset = new System.Drawing.Point(0, 0);
            this.lblTaskHdr.BackGradientSettingsDisabled.GradientColor1 = System.Drawing.Color.Transparent;
            this.lblTaskHdr.BackGradientSettingsDisabled.GradientColor2 = System.Drawing.Color.Transparent;
            this.lblTaskHdr.BackGradientSettingsDisabled.GradientOffset = new System.Drawing.Point(0, 0);
            this.lblTaskHdr.BackGradientSettingsMouseDown.GradientColor1 = System.Drawing.Color.Transparent;
            this.lblTaskHdr.BackGradientSettingsMouseDown.GradientColor2 = System.Drawing.Color.Transparent;
            this.lblTaskHdr.BackGradientSettingsMouseDown.GradientOffset = new System.Drawing.Point(0, 0);
            this.lblTaskHdr.BackGradientSettingsMouseOver.GradientColor1 = System.Drawing.Color.Transparent;
            this.lblTaskHdr.BackGradientSettingsMouseOver.GradientColor2 = System.Drawing.Color.Transparent;
            this.lblTaskHdr.BackGradientSettingsMouseOver.GradientOffset = new System.Drawing.Point(0, 0);
            this.lblTaskHdr.BorderColorSettings.BorderColor = System.Drawing.Color.Black;
            this.lblTaskHdr.BorderColorSettings.BorderColorDisabled = System.Drawing.Color.Transparent;
            this.lblTaskHdr.BorderColorSettings.BorderColorMouseDown = System.Drawing.Color.Transparent;
            this.lblTaskHdr.BorderColorSettings.BorderColorMouseOver = System.Drawing.Color.Transparent;
            this.lblTaskHdr.BorderRadius = new System.Drawing.Point(20, 20);
            this.lblTaskHdr.BorderWidthSettings.BorderWidth = 0;
            this.lblTaskHdr.BorderWidthSettings.BorderWidthMouseDown = 0;
            this.lblTaskHdr.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskHdr.ImageSettings.EnableImage = true;
            this.lblTaskHdr.ImageSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTaskHdr.ImageSettings.ImageOffset = new System.Drawing.Point(0, 0);
            this.lblTaskHdr.ImageSettings.ImageTransColor = System.Drawing.Color.Transparent;
            this.lblTaskHdr.ImageSettingsDisabled.EnableImage = false;
            this.lblTaskHdr.ImageSettingsDisabled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTaskHdr.ImageSettingsDisabled.ImageOffset = new System.Drawing.Point(0, 0);
            this.lblTaskHdr.ImageSettingsDisabled.ImageTransColor = System.Drawing.Color.Transparent;
            this.lblTaskHdr.ImageSettingsMouseDown.EnableImage = false;
            this.lblTaskHdr.ImageSettingsMouseDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTaskHdr.ImageSettingsMouseDown.ImageOffset = new System.Drawing.Point(0, 0);
            this.lblTaskHdr.ImageSettingsMouseDown.ImageTransColor = System.Drawing.Color.Transparent;
            this.lblTaskHdr.ImageSettingsMouseOver.EnableImage = false;
            this.lblTaskHdr.ImageSettingsMouseOver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTaskHdr.ImageSettingsMouseOver.ImageOffset = new System.Drawing.Point(0, 0);
            this.lblTaskHdr.ImageSettingsMouseOver.ImageTransColor = System.Drawing.Color.Transparent;
            this.lblTaskHdr.Location = new System.Drawing.Point(3, 51);
            this.lblTaskHdr.Name = "lblTaskHdr";
            this.lblTaskHdr.Size = new System.Drawing.Size(117, 18);
            this.lblTaskHdr.TabIndex = 33;
            this.lblTaskHdr.Text = "Task Description";
            this.lblTaskHdr.TextSettings.EnableText = true;
            this.lblTaskHdr.TextSettings.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskHdr.TextSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTaskHdr.TextSettings.TextOffset = new System.Drawing.Point(0, 0);
            this.lblTaskHdr.TextSettingsDisabled.EnableText = false;
            this.lblTaskHdr.TextSettingsDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskHdr.TextSettingsDisabled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTaskHdr.TextSettingsDisabled.TextOffset = new System.Drawing.Point(0, 0);
            this.lblTaskHdr.TextSettingsMouseDown.EnableText = false;
            this.lblTaskHdr.TextSettingsMouseDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskHdr.TextSettingsMouseDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTaskHdr.TextSettingsMouseDown.TextOffset = new System.Drawing.Point(0, 0);
            this.lblTaskHdr.TextSettingsMouseOver.EnableText = false;
            this.lblTaskHdr.TextSettingsMouseOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskHdr.TextSettingsMouseOver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTaskHdr.TextSettingsMouseOver.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // txtTask
            // 
            this.txtTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTask.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTask.Location = new System.Drawing.Point(3, 69);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(714, 25);
            this.txtTask.TabIndex = 34;
            // 
            // lblDeadlineHdr
            // 
            this.lblDeadlineHdr.BackGradientSettings.GradientColor1 = System.Drawing.Color.Transparent;
            this.lblDeadlineHdr.BackGradientSettings.GradientColor2 = System.Drawing.Color.Transparent;
            this.lblDeadlineHdr.BackGradientSettings.GradientOffset = new System.Drawing.Point(0, 0);
            this.lblDeadlineHdr.BackGradientSettingsDisabled.GradientColor1 = System.Drawing.Color.Transparent;
            this.lblDeadlineHdr.BackGradientSettingsDisabled.GradientColor2 = System.Drawing.Color.Transparent;
            this.lblDeadlineHdr.BackGradientSettingsDisabled.GradientOffset = new System.Drawing.Point(0, 0);
            this.lblDeadlineHdr.BackGradientSettingsMouseDown.GradientColor1 = System.Drawing.Color.Transparent;
            this.lblDeadlineHdr.BackGradientSettingsMouseDown.GradientColor2 = System.Drawing.Color.Transparent;
            this.lblDeadlineHdr.BackGradientSettingsMouseDown.GradientOffset = new System.Drawing.Point(0, 0);
            this.lblDeadlineHdr.BackGradientSettingsMouseOver.GradientColor1 = System.Drawing.Color.Transparent;
            this.lblDeadlineHdr.BackGradientSettingsMouseOver.GradientColor2 = System.Drawing.Color.Transparent;
            this.lblDeadlineHdr.BackGradientSettingsMouseOver.GradientOffset = new System.Drawing.Point(0, 0);
            this.lblDeadlineHdr.BorderColorSettings.BorderColor = System.Drawing.Color.Black;
            this.lblDeadlineHdr.BorderColorSettings.BorderColorDisabled = System.Drawing.Color.Transparent;
            this.lblDeadlineHdr.BorderColorSettings.BorderColorMouseDown = System.Drawing.Color.Transparent;
            this.lblDeadlineHdr.BorderColorSettings.BorderColorMouseOver = System.Drawing.Color.Transparent;
            this.lblDeadlineHdr.BorderRadius = new System.Drawing.Point(20, 20);
            this.lblDeadlineHdr.BorderWidthSettings.BorderWidth = 0;
            this.lblDeadlineHdr.BorderWidthSettings.BorderWidthMouseDown = 0;
            this.lblDeadlineHdr.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadlineHdr.ImageSettings.EnableImage = true;
            this.lblDeadlineHdr.ImageSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDeadlineHdr.ImageSettings.ImageOffset = new System.Drawing.Point(0, 0);
            this.lblDeadlineHdr.ImageSettings.ImageTransColor = System.Drawing.Color.Transparent;
            this.lblDeadlineHdr.ImageSettingsDisabled.EnableImage = false;
            this.lblDeadlineHdr.ImageSettingsDisabled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDeadlineHdr.ImageSettingsDisabled.ImageOffset = new System.Drawing.Point(0, 0);
            this.lblDeadlineHdr.ImageSettingsDisabled.ImageTransColor = System.Drawing.Color.Transparent;
            this.lblDeadlineHdr.ImageSettingsMouseDown.EnableImage = false;
            this.lblDeadlineHdr.ImageSettingsMouseDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDeadlineHdr.ImageSettingsMouseDown.ImageOffset = new System.Drawing.Point(0, 0);
            this.lblDeadlineHdr.ImageSettingsMouseDown.ImageTransColor = System.Drawing.Color.Transparent;
            this.lblDeadlineHdr.ImageSettingsMouseOver.EnableImage = false;
            this.lblDeadlineHdr.ImageSettingsMouseOver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDeadlineHdr.ImageSettingsMouseOver.ImageOffset = new System.Drawing.Point(0, 0);
            this.lblDeadlineHdr.ImageSettingsMouseOver.ImageTransColor = System.Drawing.Color.Transparent;
            this.lblDeadlineHdr.Location = new System.Drawing.Point(3, 6);
            this.lblDeadlineHdr.Name = "lblDeadlineHdr";
            this.lblDeadlineHdr.Size = new System.Drawing.Size(108, 18);
            this.lblDeadlineHdr.TabIndex = 35;
            this.lblDeadlineHdr.Text = "Deadline";
            this.lblDeadlineHdr.TextSettings.EnableText = true;
            this.lblDeadlineHdr.TextSettings.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadlineHdr.TextSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDeadlineHdr.TextSettings.TextOffset = new System.Drawing.Point(0, 0);
            this.lblDeadlineHdr.TextSettingsDisabled.EnableText = false;
            this.lblDeadlineHdr.TextSettingsDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadlineHdr.TextSettingsDisabled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDeadlineHdr.TextSettingsDisabled.TextOffset = new System.Drawing.Point(0, 0);
            this.lblDeadlineHdr.TextSettingsMouseDown.EnableText = false;
            this.lblDeadlineHdr.TextSettingsMouseDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadlineHdr.TextSettingsMouseDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDeadlineHdr.TextSettingsMouseDown.TextOffset = new System.Drawing.Point(0, 0);
            this.lblDeadlineHdr.TextSettingsMouseOver.EnableText = false;
            this.lblDeadlineHdr.TextSettingsMouseOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadlineHdr.TextSettingsMouseOver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDeadlineHdr.TextSettingsMouseOver.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpDeadline.CustomFormat = "MM/dd/yyyy";
            this.dtpDeadline.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeadline.Location = new System.Drawing.Point(3, 21);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(126, 22);
            this.dtpDeadline.TabIndex = 36;
            this.dtpDeadline.ValueChanged += new System.EventHandler(this.dtpDeadline_ValueChanged);
            // 
            // txtDetails
            // 
            this.txtDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetails.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(3, 123);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(714, 249);
            this.txtDetails.TabIndex = 38;
            // 
            // lblDetailsHdr
            // 
            this.lblDetailsHdr.BackGradientSettings.GradientColor1 = System.Drawing.Color.Transparent;
            this.lblDetailsHdr.BackGradientSettings.GradientColor2 = System.Drawing.Color.Transparent;
            this.lblDetailsHdr.BackGradientSettings.GradientOffset = new System.Drawing.Point(0, 0);
            this.lblDetailsHdr.BackGradientSettingsDisabled.GradientColor1 = System.Drawing.Color.Transparent;
            this.lblDetailsHdr.BackGradientSettingsDisabled.GradientColor2 = System.Drawing.Color.Transparent;
            this.lblDetailsHdr.BackGradientSettingsDisabled.GradientOffset = new System.Drawing.Point(0, 0);
            this.lblDetailsHdr.BackGradientSettingsMouseDown.GradientColor1 = System.Drawing.Color.Transparent;
            this.lblDetailsHdr.BackGradientSettingsMouseDown.GradientColor2 = System.Drawing.Color.Transparent;
            this.lblDetailsHdr.BackGradientSettingsMouseDown.GradientOffset = new System.Drawing.Point(0, 0);
            this.lblDetailsHdr.BackGradientSettingsMouseOver.GradientColor1 = System.Drawing.Color.Transparent;
            this.lblDetailsHdr.BackGradientSettingsMouseOver.GradientColor2 = System.Drawing.Color.Transparent;
            this.lblDetailsHdr.BackGradientSettingsMouseOver.GradientOffset = new System.Drawing.Point(0, 0);
            this.lblDetailsHdr.BorderColorSettings.BorderColor = System.Drawing.Color.Black;
            this.lblDetailsHdr.BorderColorSettings.BorderColorDisabled = System.Drawing.Color.Transparent;
            this.lblDetailsHdr.BorderColorSettings.BorderColorMouseDown = System.Drawing.Color.Transparent;
            this.lblDetailsHdr.BorderColorSettings.BorderColorMouseOver = System.Drawing.Color.Transparent;
            this.lblDetailsHdr.BorderRadius = new System.Drawing.Point(20, 20);
            this.lblDetailsHdr.BorderWidthSettings.BorderWidth = 0;
            this.lblDetailsHdr.BorderWidthSettings.BorderWidthMouseDown = 0;
            this.lblDetailsHdr.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsHdr.ImageSettings.EnableImage = true;
            this.lblDetailsHdr.ImageSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDetailsHdr.ImageSettings.ImageOffset = new System.Drawing.Point(0, 0);
            this.lblDetailsHdr.ImageSettings.ImageTransColor = System.Drawing.Color.Transparent;
            this.lblDetailsHdr.ImageSettingsDisabled.EnableImage = false;
            this.lblDetailsHdr.ImageSettingsDisabled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDetailsHdr.ImageSettingsDisabled.ImageOffset = new System.Drawing.Point(0, 0);
            this.lblDetailsHdr.ImageSettingsDisabled.ImageTransColor = System.Drawing.Color.Transparent;
            this.lblDetailsHdr.ImageSettingsMouseDown.EnableImage = false;
            this.lblDetailsHdr.ImageSettingsMouseDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDetailsHdr.ImageSettingsMouseDown.ImageOffset = new System.Drawing.Point(0, 0);
            this.lblDetailsHdr.ImageSettingsMouseDown.ImageTransColor = System.Drawing.Color.Transparent;
            this.lblDetailsHdr.ImageSettingsMouseOver.EnableImage = false;
            this.lblDetailsHdr.ImageSettingsMouseOver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDetailsHdr.ImageSettingsMouseOver.ImageOffset = new System.Drawing.Point(0, 0);
            this.lblDetailsHdr.ImageSettingsMouseOver.ImageTransColor = System.Drawing.Color.Transparent;
            this.lblDetailsHdr.Location = new System.Drawing.Point(3, 105);
            this.lblDetailsHdr.Name = "lblDetailsHdr";
            this.lblDetailsHdr.Size = new System.Drawing.Size(117, 18);
            this.lblDetailsHdr.TabIndex = 37;
            this.lblDetailsHdr.Text = "Details";
            this.lblDetailsHdr.TextSettings.EnableText = true;
            this.lblDetailsHdr.TextSettings.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsHdr.TextSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDetailsHdr.TextSettings.TextOffset = new System.Drawing.Point(0, 0);
            this.lblDetailsHdr.TextSettingsDisabled.EnableText = false;
            this.lblDetailsHdr.TextSettingsDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsHdr.TextSettingsDisabled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDetailsHdr.TextSettingsDisabled.TextOffset = new System.Drawing.Point(0, 0);
            this.lblDetailsHdr.TextSettingsMouseDown.EnableText = false;
            this.lblDetailsHdr.TextSettingsMouseDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsHdr.TextSettingsMouseDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDetailsHdr.TextSettingsMouseDown.TextOffset = new System.Drawing.Point(0, 0);
            this.lblDetailsHdr.TextSettingsMouseOver.EnableText = false;
            this.lblDetailsHdr.TextSettingsMouseOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsHdr.TextSettingsMouseOver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDetailsHdr.TextSettingsMouseOver.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // chbCompleted
            // 
            this.chbCompleted.BackColor = System.Drawing.Color.Transparent;
            this.chbCompleted.BackGradientSettings.GradientColor1 = System.Drawing.Color.LightSteelBlue;
            this.chbCompleted.BackGradientSettings.GradientColor2 = System.Drawing.Color.AliceBlue;
            this.chbCompleted.BackGradientSettings.GradientOffset = new System.Drawing.Point(0, 0);
            this.chbCompleted.BackGradientSettings.GradientType = DotCoolControls.Tools.CoolGradientType.ForwardDiagonal;
            this.chbCompleted.BackGradientSettingsDisabled.GradientColor1 = System.Drawing.Color.Transparent;
            this.chbCompleted.BackGradientSettingsDisabled.GradientColor2 = System.Drawing.Color.Transparent;
            this.chbCompleted.BackGradientSettingsDisabled.GradientOffset = new System.Drawing.Point(0, 0);
            this.chbCompleted.BackGradientSettingsMouseOver.GradientColor1 = System.Drawing.Color.RoyalBlue;
            this.chbCompleted.BackGradientSettingsMouseOver.GradientColor2 = System.Drawing.Color.AliceBlue;
            this.chbCompleted.BackGradientSettingsMouseOver.GradientOffset = new System.Drawing.Point(0, 0);
            this.chbCompleted.BackGradientSettingsMouseOver.GradientType = DotCoolControls.Tools.CoolGradientType.ForwardDiagonal;
            this.chbCompleted.BorderColorSettings.BorderColor = System.Drawing.Color.Black;
            this.chbCompleted.BorderColorSettings.BorderColorDisabled = System.Drawing.Color.Transparent;
            this.chbCompleted.BorderColorSettings.BorderColorIndeterminate = System.Drawing.Color.Transparent;
            this.chbCompleted.BorderColorSettings.BorderColorMouseDown = System.Drawing.Color.Transparent;
            this.chbCompleted.BorderColorSettings.BorderColorMouseOver = System.Drawing.Color.Transparent;
            this.chbCompleted.BorderOffset = new System.Drawing.Point(1, 1);
            this.chbCompleted.BorderRadius = new System.Drawing.Point(20, 20);
            this.chbCompleted.BorderShape = Tiferix.Global.CoolShape.Square;
            this.chbCompleted.BorderSize = new System.Drawing.Size(20, 20);
            this.chbCompleted.BorderWidthSettings.BorderWidthMouseDown = 1;
            this.chbCompleted.CheckBorderColorSettings.BorderColor = System.Drawing.Color.Black;
            this.chbCompleted.CheckBorderColorSettings.BorderColorDisabled = System.Drawing.Color.Transparent;
            this.chbCompleted.CheckBorderColorSettings.BorderColorIndeterminate = System.Drawing.Color.Transparent;
            this.chbCompleted.CheckBorderColorSettings.BorderColorMouseDown = System.Drawing.Color.Transparent;
            this.chbCompleted.CheckBorderColorSettings.BorderColorMouseOver = System.Drawing.Color.Transparent;
            this.chbCompleted.CheckBorderWidth = 1;
            this.chbCompleted.Checked = false;
            this.chbCompleted.CheckGradientSettings.GradientColor1 = System.Drawing.Color.Black;
            this.chbCompleted.CheckGradientSettings.GradientColor2 = System.Drawing.Color.Transparent;
            this.chbCompleted.CheckGradientSettings.GradientOffset = new System.Drawing.Point(0, 0);
            this.chbCompleted.CheckGradientSettingsDisabled.GradientColor1 = System.Drawing.Color.Transparent;
            this.chbCompleted.CheckGradientSettingsDisabled.GradientColor2 = System.Drawing.Color.Transparent;
            this.chbCompleted.CheckGradientSettingsDisabled.GradientOffset = new System.Drawing.Point(0, 0);
            this.chbCompleted.CheckGradientSettingsIndeterminate.GradientColor1 = System.Drawing.Color.Transparent;
            this.chbCompleted.CheckGradientSettingsIndeterminate.GradientColor2 = System.Drawing.Color.Transparent;
            this.chbCompleted.CheckGradientSettingsIndeterminate.GradientOffset = new System.Drawing.Point(0, 0);
            this.chbCompleted.CheckGradientSettingsMouseOver.GradientColor1 = System.Drawing.Color.Transparent;
            this.chbCompleted.CheckGradientSettingsMouseOver.GradientColor2 = System.Drawing.Color.Transparent;
            this.chbCompleted.CheckGradientSettingsMouseOver.GradientOffset = new System.Drawing.Point(0, 0);
            this.chbCompleted.CheckOffset = new System.Drawing.Point(2, 2);
            this.chbCompleted.CheckRadius = new System.Drawing.Point(10, 10);
            this.chbCompleted.CheckShape = Tiferix.Global.CoolShape.Diamond;
            this.chbCompleted.CheckSize = new System.Drawing.Size(10, 10);
            this.chbCompleted.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chbCompleted.ImageSettings.EnableImage = true;
            this.chbCompleted.ImageSettings.Image = global::Trellis.TodoUI.Properties.Resources.CheckImage_16x12;
            this.chbCompleted.ImageSettings.ImageOffset = new System.Drawing.Point(2, 4);
            this.chbCompleted.ImageSettings.ImageTransColor = System.Drawing.Color.Transparent;
            this.chbCompleted.ImageSettingsDisabled.EnableImage = false;
            this.chbCompleted.ImageSettingsDisabled.ImageOffset = new System.Drawing.Point(0, 0);
            this.chbCompleted.ImageSettingsDisabled.ImageTransColor = System.Drawing.Color.Transparent;
            this.chbCompleted.ImageSettingsIndeterminate.EnableImage = false;
            this.chbCompleted.ImageSettingsIndeterminate.ImageOffset = new System.Drawing.Point(0, 0);
            this.chbCompleted.ImageSettingsIndeterminate.ImageTransColor = System.Drawing.Color.Transparent;
            this.chbCompleted.ImageSettingsMouseOver.EnableImage = false;
            this.chbCompleted.ImageSettingsMouseOver.ImageOffset = new System.Drawing.Point(0, 0);
            this.chbCompleted.ImageSettingsMouseOver.ImageTransColor = System.Drawing.Color.Transparent;
            this.chbCompleted.Location = new System.Drawing.Point(159, 21);
            this.chbCompleted.Name = "chbCompleted";
            this.chbCompleted.Size = new System.Drawing.Size(126, 21);
            this.chbCompleted.TabIndex = 39;
            this.chbCompleted.Text = "Completed";
            this.chbCompleted.TextSettings.EnableText = true;
            this.chbCompleted.TextSettings.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCompleted.TextSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chbCompleted.TextSettings.TextOffset = new System.Drawing.Point(21, 3);
            this.chbCompleted.TextSettingsDisabled.EnableText = false;
            this.chbCompleted.TextSettingsDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCompleted.TextSettingsDisabled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chbCompleted.TextSettingsDisabled.TextOffset = new System.Drawing.Point(16, 1);
            this.chbCompleted.TextSettingsMouseOver.EnableText = false;
            this.chbCompleted.TextSettingsMouseOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCompleted.TextSettingsMouseOver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chbCompleted.TextSettingsMouseOver.TextOffset = new System.Drawing.Point(16, 1);
            this.chbCompleted.ThreeState = false;
            this.chbCompleted.CheckChanged += new System.EventHandler(this.chbCompleted_CheckChanged);
            // 
            // lblDeadlineWarning
            // 
            this.lblDeadlineWarning.BackGradientSettings.GradientColor1 = System.Drawing.Color.Transparent;
            this.lblDeadlineWarning.BackGradientSettings.GradientColor2 = System.Drawing.Color.Transparent;
            this.lblDeadlineWarning.BackGradientSettings.GradientOffset = new System.Drawing.Point(0, 0);
            this.lblDeadlineWarning.BackGradientSettingsDisabled.GradientColor1 = System.Drawing.Color.Transparent;
            this.lblDeadlineWarning.BackGradientSettingsDisabled.GradientColor2 = System.Drawing.Color.Transparent;
            this.lblDeadlineWarning.BackGradientSettingsDisabled.GradientOffset = new System.Drawing.Point(0, 0);
            this.lblDeadlineWarning.BackGradientSettingsMouseDown.GradientColor1 = System.Drawing.Color.Transparent;
            this.lblDeadlineWarning.BackGradientSettingsMouseDown.GradientColor2 = System.Drawing.Color.Transparent;
            this.lblDeadlineWarning.BackGradientSettingsMouseDown.GradientOffset = new System.Drawing.Point(0, 0);
            this.lblDeadlineWarning.BackGradientSettingsMouseOver.GradientColor1 = System.Drawing.Color.Transparent;
            this.lblDeadlineWarning.BackGradientSettingsMouseOver.GradientColor2 = System.Drawing.Color.Transparent;
            this.lblDeadlineWarning.BackGradientSettingsMouseOver.GradientOffset = new System.Drawing.Point(0, 0);
            this.lblDeadlineWarning.BorderColorSettings.BorderColor = System.Drawing.Color.Black;
            this.lblDeadlineWarning.BorderColorSettings.BorderColorDisabled = System.Drawing.Color.Transparent;
            this.lblDeadlineWarning.BorderColorSettings.BorderColorMouseDown = System.Drawing.Color.Transparent;
            this.lblDeadlineWarning.BorderColorSettings.BorderColorMouseOver = System.Drawing.Color.Transparent;
            this.lblDeadlineWarning.BorderRadius = new System.Drawing.Point(20, 20);
            this.lblDeadlineWarning.BorderWidthSettings.BorderWidth = 0;
            this.lblDeadlineWarning.BorderWidthSettings.BorderWidthMouseDown = 0;
            this.lblDeadlineWarning.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadlineWarning.ImageSettings.EnableImage = true;
            this.lblDeadlineWarning.ImageSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDeadlineWarning.ImageSettings.ImageOffset = new System.Drawing.Point(0, 0);
            this.lblDeadlineWarning.ImageSettings.ImageTransColor = System.Drawing.Color.Transparent;
            this.lblDeadlineWarning.ImageSettingsDisabled.EnableImage = false;
            this.lblDeadlineWarning.ImageSettingsDisabled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDeadlineWarning.ImageSettingsDisabled.ImageOffset = new System.Drawing.Point(0, 0);
            this.lblDeadlineWarning.ImageSettingsDisabled.ImageTransColor = System.Drawing.Color.Transparent;
            this.lblDeadlineWarning.ImageSettingsMouseDown.EnableImage = false;
            this.lblDeadlineWarning.ImageSettingsMouseDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDeadlineWarning.ImageSettingsMouseDown.ImageOffset = new System.Drawing.Point(0, 0);
            this.lblDeadlineWarning.ImageSettingsMouseDown.ImageTransColor = System.Drawing.Color.Transparent;
            this.lblDeadlineWarning.ImageSettingsMouseOver.EnableImage = false;
            this.lblDeadlineWarning.ImageSettingsMouseOver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDeadlineWarning.ImageSettingsMouseOver.ImageOffset = new System.Drawing.Point(0, 0);
            this.lblDeadlineWarning.ImageSettingsMouseOver.ImageTransColor = System.Drawing.Color.Transparent;
            this.lblDeadlineWarning.Location = new System.Drawing.Point(327, 24);
            this.lblDeadlineWarning.Name = "lblDeadlineWarning";
            this.lblDeadlineWarning.Size = new System.Drawing.Size(240, 27);
            this.lblDeadlineWarning.TabIndex = 40;
            this.lblDeadlineWarning.Text = "*** PAST DEADLINE ***";
            this.lblDeadlineWarning.TextSettings.EnableText = true;
            this.lblDeadlineWarning.TextSettings.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadlineWarning.TextSettings.ForeColor = System.Drawing.Color.Red;
            this.lblDeadlineWarning.TextSettings.TextOffset = new System.Drawing.Point(0, 0);
            this.lblDeadlineWarning.TextSettingsDisabled.EnableText = false;
            this.lblDeadlineWarning.TextSettingsDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadlineWarning.TextSettingsDisabled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDeadlineWarning.TextSettingsDisabled.TextOffset = new System.Drawing.Point(0, 0);
            this.lblDeadlineWarning.TextSettingsMouseDown.EnableText = false;
            this.lblDeadlineWarning.TextSettingsMouseDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadlineWarning.TextSettingsMouseDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDeadlineWarning.TextSettingsMouseDown.TextOffset = new System.Drawing.Point(0, 0);
            this.lblDeadlineWarning.TextSettingsMouseOver.EnableText = false;
            this.lblDeadlineWarning.TextSettingsMouseOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadlineWarning.TextSettingsMouseOver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDeadlineWarning.TextSettingsMouseOver.TextOffset = new System.Drawing.Point(0, 0);
            this.lblDeadlineWarning.Visible = false;
            // 
            // frmTodoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(724, 448);
            this.Controls.Add(this.lblDeadlineWarning);
            this.Controls.Add(this.chbCompleted);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.lblDetailsHdr);
            this.Controls.Add(this.dtpDeadline);
            this.Controls.Add(this.lblDeadlineHdr);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.lblTaskHdr);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "frmTodoEdit";
            this.Text = "View/Edit Todo Item";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTodoEdit_FormClosing);
            this.Load += new System.EventHandler(this.frmTodoEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DotCoolControls.WinForms.DotCoolButton btnCancel;
        private DotCoolControls.WinForms.DotCoolButton btnOK;
        private DotCoolControls.WinForms.DotCoolLabel lblTaskHdr;
        private System.Windows.Forms.TextBox txtTask;
        private DotCoolControls.WinForms.DotCoolLabel lblDeadlineHdr;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.TextBox txtDetails;
        private DotCoolControls.WinForms.DotCoolLabel lblDetailsHdr;
        private DotCoolControls.WinForms.DotCoolCheckBox chbCompleted;
        private DotCoolControls.WinForms.DotCoolLabel lblDeadlineWarning;
    }
}