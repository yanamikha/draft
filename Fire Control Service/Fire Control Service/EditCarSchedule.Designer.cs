namespace Fire_Control_Service
{
    partial class EditCarSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCarSchedule));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.carComboBox = new System.Windows.Forms.ComboBox();
            this.driverComboBox = new System.Windows.Forms.ComboBox();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.defaultSchedule = new System.Windows.Forms.CheckBox();
            this.fireManComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tableRequests = new System.Windows.Forms.DataGridView();
            this.closeTheWindow = new System.Windows.Forms.Button();
            this.saveChanges = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCurrentReq = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.labelCurrentReq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // carComboBox
            // 
            this.carComboBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.carComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.carComboBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carComboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.carComboBox.FormattingEnabled = true;
            this.carComboBox.Items.AddRange(new object[] {
            "1 - пожежна цистерна",
            "2 - пожежна цистерна",
            "3 - пожежна драбина",
            "4 - лімузін:)",
            "5 - пожежна драбина"});
            this.carComboBox.Location = new System.Drawing.Point(239, 23);
            this.carComboBox.Name = "carComboBox";
            this.carComboBox.Size = new System.Drawing.Size(305, 34);
            this.carComboBox.TabIndex = 34;
            this.carComboBox.Text = "Пожежний автомобіль";
            this.carComboBox.SelectedIndexChanged += new System.EventHandler(this.carComboBox_SelectedIndexChanged);
            // 
            // driverComboBox
            // 
            this.driverComboBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.driverComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.driverComboBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driverComboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.driverComboBox.FormattingEnabled = true;
            this.driverComboBox.Items.AddRange(new object[] {
            "Групи користувачів",
            "Дозволи",
            "Користувачі"});
            this.driverComboBox.Location = new System.Drawing.Point(633, 23);
            this.driverComboBox.Name = "driverComboBox";
            this.driverComboBox.Size = new System.Drawing.Size(249, 34);
            this.driverComboBox.TabIndex = 35;
            this.driverComboBox.Text = "Старший машини";
            this.driverComboBox.SelectedIndexChanged += new System.EventHandler(this.driverComboBox_SelectedIndexChanged);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = "ddMMMMyyyy - hh:mm";
            this.startDateTimePicker.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(240, 124);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(297, 33);
            this.startDateTimePicker.TabIndex = 36;
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.startDateTimePicker_ValueChanged);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = "ddMMMMyyyy - hh:mm";
            this.endDateTimePicker.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(587, 125);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(281, 33);
            this.endDateTimePicker.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(245, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Початок чергування";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(591, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Кінець чергування";
            // 
            // defaultSchedule
            // 
            this.defaultSchedule.AutoSize = true;
            this.defaultSchedule.Checked = true;
            this.defaultSchedule.CheckState = System.Windows.Forms.CheckState.Checked;
            this.defaultSchedule.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.defaultSchedule.ForeColor = System.Drawing.SystemColors.MenuText;
            this.defaultSchedule.Location = new System.Drawing.Point(239, 63);
            this.defaultSchedule.Name = "defaultSchedule";
            this.defaultSchedule.Size = new System.Drawing.Size(219, 26);
            this.defaultSchedule.TabIndex = 40;
            this.defaultSchedule.Text = "Тип чергування \"доба/три\"";
            this.defaultSchedule.UseVisualStyleBackColor = true;
            // 
            // fireManComboBox
            // 
            this.fireManComboBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fireManComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fireManComboBox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fireManComboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.fireManComboBox.FormattingEnabled = true;
            this.fireManComboBox.Items.AddRange(new object[] {
            "Групи користувачів",
            "Дозволи",
            "Користувачі"});
            this.fireManComboBox.Location = new System.Drawing.Point(239, 175);
            this.fireManComboBox.Name = "fireManComboBox";
            this.fireManComboBox.Size = new System.Drawing.Size(305, 34);
            this.fireManComboBox.TabIndex = 42;
            this.fireManComboBox.Text = "Рятувальник";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(191, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(587, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // tableRequests
            // 
            this.tableRequests.AllowUserToAddRows = false;
            this.tableRequests.AllowUserToDeleteRows = false;
            this.tableRequests.AllowUserToOrderColumns = true;
            this.tableRequests.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.tableRequests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bookman Old Style", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tableRequests.ColumnHeadersHeight = 28;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bookman Old Style", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableRequests.DefaultCellStyle = dataGridViewCellStyle5;
            this.tableRequests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tableRequests.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.tableRequests.Location = new System.Drawing.Point(25, 277);
            this.tableRequests.Name = "tableRequests";
            this.tableRequests.ReadOnly = true;
            this.tableRequests.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.tableRequests.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tableRequests.Size = new System.Drawing.Size(901, 296);
            this.tableRequests.TabIndex = 45;
            // 
            // closeTheWindow
            // 
            this.closeTheWindow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.closeTheWindow.BackColor = System.Drawing.SystemColors.Control;
            this.closeTheWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeTheWindow.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.closeTheWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeTheWindow.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeTheWindow.ForeColor = System.Drawing.Color.OrangeRed;
            this.closeTheWindow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeTheWindow.Location = new System.Drawing.Point(417, 600);
            this.closeTheWindow.Name = "closeTheWindow";
            this.closeTheWindow.Size = new System.Drawing.Size(230, 35);
            this.closeTheWindow.TabIndex = 47;
            this.closeTheWindow.Text = "Скасувати";
            this.closeTheWindow.UseVisualStyleBackColor = false;
            this.closeTheWindow.Click += new System.EventHandler(this.closeTheWindow_Click);
            // 
            // saveChanges
            // 
            this.saveChanges.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveChanges.BackColor = System.Drawing.Color.DarkCyan;
            this.saveChanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveChanges.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.saveChanges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChanges.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveChanges.ForeColor = System.Drawing.Color.White;
            this.saveChanges.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saveChanges.Location = new System.Drawing.Point(680, 600);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(227, 35);
            this.saveChanges.TabIndex = 46;
            this.saveChanges.Text = "Зберегти";
            this.saveChanges.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(193, 175);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 48;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(41, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 23);
            this.label3.TabIndex = 51;
            this.label3.Text = "Рятувальники у складі даної групи:";
            // 
            // labelCurrentReq
            // 
            this.labelCurrentReq.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.labelCurrentReq.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentReq.Controls.Add(this.pictureBox6);
            this.labelCurrentReq.Controls.Add(this.label1);
            this.labelCurrentReq.Controls.Add(this.label7);
            this.labelCurrentReq.Controls.Add(this.carComboBox);
            this.labelCurrentReq.Controls.Add(this.driverComboBox);
            this.labelCurrentReq.Controls.Add(this.startDateTimePicker);
            this.labelCurrentReq.Controls.Add(this.endDateTimePicker);
            this.labelCurrentReq.Controls.Add(this.defaultSchedule);
            this.labelCurrentReq.Controls.Add(this.fireManComboBox);
            this.labelCurrentReq.Controls.Add(this.pictureBox3);
            this.labelCurrentReq.Controls.Add(this.pictureBox2);
            this.labelCurrentReq.Controls.Add(this.pictureBox4);
            this.labelCurrentReq.Font = new System.Drawing.Font("Bookman Old Style", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentReq.ForeColor = System.Drawing.Color.DimGray;
            this.labelCurrentReq.Location = new System.Drawing.Point(25, 18);
            this.labelCurrentReq.Name = "labelCurrentReq";
            this.labelCurrentReq.Padding = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.labelCurrentReq.Size = new System.Drawing.Size(901, 226);
            this.labelCurrentReq.TabIndex = 53;
            this.labelCurrentReq.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(-13, 14);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(200, 195);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 55;
            this.pictureBox6.TabStop = false;
            // 
            // EditCarSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(951, 647);
            this.Controls.Add(this.labelCurrentReq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.closeTheWindow);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.tableRequests);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditCarSchedule";
            this.Text = "Графік чергувань";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.labelCurrentReq.ResumeLayout(false);
            this.labelCurrentReq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox carComboBox;
        private System.Windows.Forms.ComboBox driverComboBox;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox defaultSchedule;
        private System.Windows.Forms.ComboBox fireManComboBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView tableRequests;
        private System.Windows.Forms.Button closeTheWindow;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox labelCurrentReq;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}