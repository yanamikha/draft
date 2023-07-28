namespace Fire_Control_Service
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tableRequests = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortInProgressReq = new System.Windows.Forms.Label();
            this.sortDoneReq = new System.Windows.Forms.Label();
            this.sortBusyCar = new System.Windows.Forms.Label();
            this.sortFreeCar = new System.Windows.Forms.Label();
            this.sortAllCar = new System.Windows.Forms.Label();
            this.sortNewReq = new System.Windows.Forms.Label();
            this.sortAllReq = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.appointCarBatton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonCreateMessage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCurrentReq = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.змінитиКористувачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFromProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.налаштуванняToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.параметриToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.службаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.підключитисьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.налаштуванняПідключенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базаДанихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервісиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автомобіліToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CarSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.історіяВиїздівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.історіяСтанівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повідомленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCatalogWindow = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tableRequests)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.labelCurrentReq.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableRequests
            // 
            this.tableRequests.AllowUserToAddRows = false;
            this.tableRequests.AllowUserToDeleteRows = false;
            this.tableRequests.AllowUserToOrderColumns = true;
            this.tableRequests.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.tableRequests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bookman Old Style", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableRequests.ColumnHeadersHeight = 28;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bookman Old Style", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableRequests.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableRequests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tableRequests.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.tableRequests.Location = new System.Drawing.Point(8, 49);
            this.tableRequests.Name = "tableRequests";
            this.tableRequests.ReadOnly = true;
            this.tableRequests.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.tableRequests.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tableRequests.Size = new System.Drawing.Size(1079, 279);
            this.tableRequests.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.sortInProgressReq);
            this.groupBox1.Controls.Add(this.sortDoneReq);
            this.groupBox1.Controls.Add(this.sortBusyCar);
            this.groupBox1.Controls.Add(this.sortFreeCar);
            this.groupBox1.Controls.Add(this.sortAllCar);
            this.groupBox1.Controls.Add(this.sortNewReq);
            this.groupBox1.Controls.Add(this.sortAllReq);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(1122, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 294);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальна інформація";
            // 
            // sortInProgressReq
            // 
            this.sortInProgressReq.AutoSize = true;
            this.sortInProgressReq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortInProgressReq.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortInProgressReq.ForeColor = System.Drawing.Color.Black;
            this.sortInProgressReq.Location = new System.Drawing.Point(8, 101);
            this.sortInProgressReq.Name = "sortInProgressReq";
            this.sortInProgressReq.Size = new System.Drawing.Size(74, 21);
            this.sortInProgressReq.TabIndex = 11;
            this.sortInProgressReq.Text = "В роботі";
            this.sortInProgressReq.Click += new System.EventHandler(this.sortInProgressReq_Click);
            // 
            // sortDoneReq
            // 
            this.sortDoneReq.AutoSize = true;
            this.sortDoneReq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortDoneReq.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortDoneReq.ForeColor = System.Drawing.Color.Black;
            this.sortDoneReq.Location = new System.Drawing.Point(8, 122);
            this.sortDoneReq.Name = "sortDoneReq";
            this.sortDoneReq.Size = new System.Drawing.Size(113, 21);
            this.sortDoneReq.TabIndex = 10;
            this.sortDoneReq.Text = "Опрацьовано";
            this.sortDoneReq.Click += new System.EventHandler(this.sortDoneReq_Click);
            // 
            // sortBusyCar
            // 
            this.sortBusyCar.AutoSize = true;
            this.sortBusyCar.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortBusyCar.Location = new System.Drawing.Point(8, 237);
            this.sortBusyCar.Name = "sortBusyCar";
            this.sortBusyCar.Size = new System.Drawing.Size(106, 21);
            this.sortBusyCar.TabIndex = 4;
            this.sortBusyCar.Text = "На викликах";
            // 
            // sortFreeCar
            // 
            this.sortFreeCar.AutoSize = true;
            this.sortFreeCar.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortFreeCar.Location = new System.Drawing.Point(7, 211);
            this.sortFreeCar.Name = "sortFreeCar";
            this.sortFreeCar.Size = new System.Drawing.Size(74, 21);
            this.sortFreeCar.TabIndex = 3;
            this.sortFreeCar.Text = "Вільних ";
            // 
            // sortAllCar
            // 
            this.sortAllCar.AutoSize = true;
            this.sortAllCar.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortAllCar.Location = new System.Drawing.Point(8, 184);
            this.sortAllCar.Name = "sortAllCar";
            this.sortAllCar.Size = new System.Drawing.Size(153, 21);
            this.sortAllCar.TabIndex = 2;
            this.sortAllCar.Text = "Всього автомобілів";
            // 
            // sortNewReq
            // 
            this.sortNewReq.AutoSize = true;
            this.sortNewReq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortNewReq.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortNewReq.ForeColor = System.Drawing.Color.Black;
            this.sortNewReq.Location = new System.Drawing.Point(8, 73);
            this.sortNewReq.Name = "sortNewReq";
            this.sortNewReq.Size = new System.Drawing.Size(130, 21);
            this.sortNewReq.TabIndex = 1;
            this.sortNewReq.Text = "Неопрацьовано";
            this.sortNewReq.Click += new System.EventHandler(this.sortNewReq_Click);
            // 
            // sortAllReq
            // 
            this.sortAllReq.AutoEllipsis = true;
            this.sortAllReq.AutoSize = true;
            this.sortAllReq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortAllReq.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortAllReq.Location = new System.Drawing.Point(8, 46);
            this.sortAllReq.Name = "sortAllReq";
            this.sortAllReq.Size = new System.Drawing.Size(160, 21);
            this.sortAllReq.TabIndex = 0;
            this.sortAllReq.Text = "Всього повідомлень";
            this.sortAllReq.Click += new System.EventHandler(this.sortAllReq_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(703, 412);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 22);
            this.label13.TabIndex = 15;
            // 
            // ok
            // 
            this.ok.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ok.BackColor = System.Drawing.Color.DarkCyan;
            this.ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ok.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ok.ForeColor = System.Drawing.Color.White;
            this.ok.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ok.Location = new System.Drawing.Point(549, 275);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(116, 33);
            this.ok.TabIndex = 16;
            this.ok.Text = "Редагувати";
            this.ok.UseVisualStyleBackColor = false;
            // 
            // appointCarBatton
            // 
            this.appointCarBatton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.appointCarBatton.BackColor = System.Drawing.Color.DarkCyan;
            this.appointCarBatton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.appointCarBatton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.appointCarBatton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.appointCarBatton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appointCarBatton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appointCarBatton.ForeColor = System.Drawing.Color.White;
            this.appointCarBatton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.appointCarBatton.Location = new System.Drawing.Point(1108, 275);
            this.appointCarBatton.Name = "appointCarBatton";
            this.appointCarBatton.Size = new System.Drawing.Size(213, 33);
            this.appointCarBatton.TabIndex = 17;
            this.appointCarBatton.Text = "Назначити  автомобіль";
            this.appointCarBatton.UseVisualStyleBackColor = false;
            this.appointCarBatton.Click += new System.EventHandler(this.appointCarBatton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(5, 21);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(660, 248);
            this.textBox2.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.appointCarBatton);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.ok);
            this.groupBox2.Font = new System.Drawing.Font("Bookman Old Style", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox2.Location = new System.Drawing.Point(13, 419);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1331, 314);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Повідомлення №";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView2.ColumnHeadersHeight = 28;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView2.Location = new System.Drawing.Point(687, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(634, 248);
            this.dataGridView2.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Window;
            this.label11.Font = new System.Drawing.Font("Bookman Old Style", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(690, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(229, 21);
            this.label11.TabIndex = 13;
            this.label11.Text = "Автомобілі на виклику №";
            // 
            // buttonCreateMessage
            // 
            this.buttonCreateMessage.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonCreateMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCreateMessage.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonCreateMessage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCreateMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateMessage.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateMessage.ForeColor = System.Drawing.Color.White;
            this.buttonCreateMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCreateMessage.Location = new System.Drawing.Point(765, 11);
            this.buttonCreateMessage.Name = "buttonCreateMessage";
            this.buttonCreateMessage.Size = new System.Drawing.Size(321, 35);
            this.buttonCreateMessage.TabIndex = 20;
            this.buttonCreateMessage.Text = "Зареєструвати повідомлення";
            this.buttonCreateMessage.UseVisualStyleBackColor = false;
            this.buttonCreateMessage.Click += new System.EventHandler(this.buttonCreateMessage_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1265, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "14:04";
            // 
            // labelCurrentReq
            // 
            this.labelCurrentReq.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.labelCurrentReq.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentReq.Controls.Add(this.tableRequests);
            this.labelCurrentReq.Controls.Add(this.buttonCreateMessage);
            this.labelCurrentReq.Font = new System.Drawing.Font("Bookman Old Style", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentReq.ForeColor = System.Drawing.Color.DimGray;
            this.labelCurrentReq.Location = new System.Drawing.Point(12, 30);
            this.labelCurrentReq.Name = "labelCurrentReq";
            this.labelCurrentReq.Padding = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.labelCurrentReq.Size = new System.Drawing.Size(1095, 338);
            this.labelCurrentReq.TabIndex = 22;
            this.labelCurrentReq.TabStop = false;
            this.labelCurrentReq.Text = "Поточні повідомлення";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem1,
            this.налаштуванняToolStripMenuItem1,
            this.сервісиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1366, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem1
            // 
            this.менюToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.змінитиКористувачаToolStripMenuItem,
            this.exitFromProgram});
            this.менюToolStripMenuItem1.Name = "менюToolStripMenuItem1";
            this.менюToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem1.Text = "Меню";
            // 
            // змінитиКористувачаToolStripMenuItem
            // 
            this.змінитиКористувачаToolStripMenuItem.Name = "змінитиКористувачаToolStripMenuItem";
            this.змінитиКористувачаToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.змінитиКористувачаToolStripMenuItem.Text = "Змінити користувача";
            // 
            // exitFromProgram
            // 
            this.exitFromProgram.Name = "exitFromProgram";
            this.exitFromProgram.Size = new System.Drawing.Size(191, 22);
            this.exitFromProgram.Text = "Вихід";
            this.exitFromProgram.Click += new System.EventHandler(this.exitFromProgram_Click);
            // 
            // налаштуванняToolStripMenuItem1
            // 
            this.налаштуванняToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметриToolStripMenuItem,
            this.службаToolStripMenuItem,
            this.базаДанихToolStripMenuItem});
            this.налаштуванняToolStripMenuItem1.Name = "налаштуванняToolStripMenuItem1";
            this.налаштуванняToolStripMenuItem1.Size = new System.Drawing.Size(101, 20);
            this.налаштуванняToolStripMenuItem1.Text = "Налаштування";
            // 
            // параметриToolStripMenuItem
            // 
            this.параметриToolStripMenuItem.Name = "параметриToolStripMenuItem";
            this.параметриToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.параметриToolStripMenuItem.Text = "Параметри програми";
            // 
            // службаToolStripMenuItem
            // 
            this.службаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.підключитисьToolStripMenuItem,
            this.налаштуванняПідключенняToolStripMenuItem});
            this.службаToolStripMenuItem.Name = "службаToolStripMenuItem";
            this.службаToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.службаToolStripMenuItem.Text = "Служба";
            // 
            // підключитисьToolStripMenuItem
            // 
            this.підключитисьToolStripMenuItem.Name = "підключитисьToolStripMenuItem";
            this.підключитисьToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.підключитисьToolStripMenuItem.Text = "Підключитись";
            // 
            // налаштуванняПідключенняToolStripMenuItem
            // 
            this.налаштуванняПідключенняToolStripMenuItem.Name = "налаштуванняПідключенняToolStripMenuItem";
            this.налаштуванняПідключенняToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.налаштуванняПідключенняToolStripMenuItem.Text = "Налаштування підключення";
            // 
            // базаДанихToolStripMenuItem
            // 
            this.базаДанихToolStripMenuItem.Name = "базаДанихToolStripMenuItem";
            this.базаДанихToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.базаДанихToolStripMenuItem.Text = "База даних";
            // 
            // сервісиToolStripMenuItem
            // 
            this.сервісиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.автомобіліToolStripMenuItem,
            this.повідомленняToolStripMenuItem,
            this.openCatalogWindow});
            this.сервісиToolStripMenuItem.Name = "сервісиToolStripMenuItem";
            this.сервісиToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.сервісиToolStripMenuItem.Text = "Сервіси";
            // 
            // автомобіліToolStripMenuItem
            // 
            this.автомобіліToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CarSchedule,
            this.історіяВиїздівToolStripMenuItem,
            this.історіяСтанівToolStripMenuItem});
            this.автомобіліToolStripMenuItem.Name = "автомобіліToolStripMenuItem";
            this.автомобіліToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.автомобіліToolStripMenuItem.Text = "Автомобілі";
            // 
            // CarSchedule
            // 
            this.CarSchedule.Name = "CarSchedule";
            this.CarSchedule.Size = new System.Drawing.Size(170, 22);
            this.CarSchedule.Text = "Графік чергувань";
            this.CarSchedule.Click += new System.EventHandler(this.CarSchedule_Click);
            // 
            // історіяВиїздівToolStripMenuItem
            // 
            this.історіяВиїздівToolStripMenuItem.Name = "історіяВиїздівToolStripMenuItem";
            this.історіяВиїздівToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.історіяВиїздівToolStripMenuItem.Text = "Історія виїздів";
            // 
            // історіяСтанівToolStripMenuItem
            // 
            this.історіяСтанівToolStripMenuItem.Name = "історіяСтанівToolStripMenuItem";
            this.історіяСтанівToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.історіяСтанівToolStripMenuItem.Text = "Історія станів";
            // 
            // повідомленняToolStripMenuItem
            // 
            this.повідомленняToolStripMenuItem.Name = "повідомленняToolStripMenuItem";
            this.повідомленняToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.повідомленняToolStripMenuItem.Text = "Повідомлення";
            // 
            // openCatalogWindow
            // 
            this.openCatalogWindow.Name = "openCatalogWindow";
            this.openCatalogWindow.Size = new System.Drawing.Size(154, 22);
            this.openCatalogWindow.Text = "Довідники";
            this.openCatalogWindow.Click += new System.EventHandler(this.openCatalogWindow_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 745);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelCurrentReq);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Врятуй";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableRequests)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.labelCurrentReq.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
   
        private System.Windows.Forms.DataGridView tableRequests;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label sortNewReq;
        private System.Windows.Forms.Label sortAllReq;
        private System.Windows.Forms.Label sortBusyCar;
        private System.Windows.Forms.Label sortFreeCar;
        private System.Windows.Forms.Label sortAllCar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button appointCarBatton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label sortDoneReq;
        private System.Windows.Forms.Label sortInProgressReq;
        private System.Windows.Forms.Button buttonCreateMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox labelCurrentReq;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem параметриToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem службаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem підключитисьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem змінитиКористувачаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitFromProgram;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняПідключенняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem базаДанихToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервісиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автомобіліToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CarSchedule;
        private System.Windows.Forms.ToolStripMenuItem історіяВиїздівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem історіяСтанівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повідомленняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCatalogWindow;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn housingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn informantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
    }
}

