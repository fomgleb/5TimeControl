namespace TimeControl
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ButtonClearAll = new System.Windows.Forms.Button();
            this.ButtonClearThisWeek = new System.Windows.Forms.Button();
            this.ButtonAddTime = new System.Windows.Forms.Button();
            this.TextBoxThisWeekMinute = new System.Windows.Forms.TextBox();
            this.TextBoxThisWeekSecond = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.TextBoxThisWeekHour = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.TextBoxAllMinute = new System.Windows.Forms.TextBox();
            this.TextBoxAllSecond = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxAllHour = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonSetNowSecond = new System.Windows.Forms.Button();
            this.ButtonSetNowFirst = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxSecondMonth = new System.Windows.Forms.TextBox();
            this.TextBoxSecondDay = new System.Windows.Forms.TextBox();
            this.TextBoxSecondSecond = new System.Windows.Forms.TextBox();
            this.TextBoxSecondMinute = new System.Windows.Forms.TextBox();
            this.TextBoxSecondHour = new System.Windows.Forms.TextBox();
            this.TextBoxSecondYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxFirstMonth = new System.Windows.Forms.TextBox();
            this.TextBoxFirstDay = new System.Windows.Forms.TextBox();
            this.TextBoxFirstSecond = new System.Windows.Forms.TextBox();
            this.TextBoxFirstMinute = new System.Windows.Forms.TextBox();
            this.TextBoxFirstHour = new System.Windows.Forms.TextBox();
            this.TextBoxFirstYear = new System.Windows.Forms.TextBox();
            this.ButtonClearToday = new System.Windows.Forms.Button();
            this.TextBoxTodayMinute = new System.Windows.Forms.TextBox();
            this.TextBoxTodaySecond = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TextBoxTodayHour = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.TextBoxNewName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ButtonChange = new System.Windows.Forms.Button();
            this.TextBoxOldName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.TextBoxDelete = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ButtonAddName = new System.Windows.Forms.Button();
            this.TextBoxAddName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GroupBoxAdd = new System.Windows.Forms.GroupBox();
            this.LabelAdd = new System.Windows.Forms.Label();
            this.GroupBoxTime = new System.Windows.Forms.GroupBox();
            this.LabelSelect = new System.Windows.Forms.Label();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.GroupBoxAdd.SuspendLayout();
            this.GroupBoxTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Items.AddRange(new object[] {
            "Загрузка..."});
            this.listBox1.Location = new System.Drawing.Point(16, 428);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(277, 381);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ButtonClearAll
            // 
            this.ButtonClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClearAll.Location = new System.Drawing.Point(278, 302);
            this.ButtonClearAll.Name = "ButtonClearAll";
            this.ButtonClearAll.Size = new System.Drawing.Size(141, 48);
            this.ButtonClearAll.TabIndex = 20;
            this.ButtonClearAll.Text = "Очистить";
            this.ButtonClearAll.UseVisualStyleBackColor = true;
            this.ButtonClearAll.Click += new System.EventHandler(this.ButtonClearAll_Click);
            // 
            // ButtonClearThisWeek
            // 
            this.ButtonClearThisWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClearThisWeek.Location = new System.Drawing.Point(404, 130);
            this.ButtonClearThisWeek.Name = "ButtonClearThisWeek";
            this.ButtonClearThisWeek.Size = new System.Drawing.Size(138, 48);
            this.ButtonClearThisWeek.TabIndex = 21;
            this.ButtonClearThisWeek.Text = "Очистить";
            this.ButtonClearThisWeek.UseVisualStyleBackColor = true;
            this.ButtonClearThisWeek.Click += new System.EventHandler(this.ButtonClearThisWeek_Click);
            // 
            // ButtonAddTime
            // 
            this.ButtonAddTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddTime.Location = new System.Drawing.Point(155, 320);
            this.ButtonAddTime.Name = "ButtonAddTime";
            this.ButtonAddTime.Size = new System.Drawing.Size(410, 75);
            this.ButtonAddTime.TabIndex = 12;
            this.ButtonAddTime.Text = "Добавить";
            this.ButtonAddTime.UseVisualStyleBackColor = true;
            this.ButtonAddTime.Click += new System.EventHandler(this.ButtonAddTime_Click);
            // 
            // TextBoxThisWeekMinute
            // 
            this.TextBoxThisWeekMinute.BackColor = System.Drawing.Color.White;
            this.TextBoxThisWeekMinute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxThisWeekMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxThisWeekMinute.Location = new System.Drawing.Point(445, 75);
            this.TextBoxThisWeekMinute.MaxLength = 2;
            this.TextBoxThisWeekMinute.Name = "TextBoxThisWeekMinute";
            this.TextBoxThisWeekMinute.ReadOnly = true;
            this.TextBoxThisWeekMinute.Size = new System.Drawing.Size(54, 55);
            this.TextBoxThisWeekMinute.TabIndex = 158;
            this.TextBoxThisWeekMinute.TabStop = false;
            this.TextBoxThisWeekMinute.Text = "00";
            // 
            // TextBoxThisWeekSecond
            // 
            this.TextBoxThisWeekSecond.BackColor = System.Drawing.Color.White;
            this.TextBoxThisWeekSecond.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxThisWeekSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxThisWeekSecond.Location = new System.Drawing.Point(505, 75);
            this.TextBoxThisWeekSecond.MaxLength = 2;
            this.TextBoxThisWeekSecond.Name = "TextBoxThisWeekSecond";
            this.TextBoxThisWeekSecond.ReadOnly = true;
            this.TextBoxThisWeekSecond.Size = new System.Drawing.Size(54, 55);
            this.TextBoxThisWeekSecond.TabIndex = 160;
            this.TextBoxThisWeekSecond.TabStop = false;
            this.TextBoxThisWeekSecond.Text = "00";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(485, 75);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 55);
            this.label21.TabIndex = 159;
            this.label21.Text = ":";
            // 
            // TextBoxThisWeekHour
            // 
            this.TextBoxThisWeekHour.BackColor = System.Drawing.Color.White;
            this.TextBoxThisWeekHour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxThisWeekHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxThisWeekHour.Location = new System.Drawing.Point(278, 75);
            this.TextBoxThisWeekHour.MaxLength = 999999;
            this.TextBoxThisWeekHour.Name = "TextBoxThisWeekHour";
            this.TextBoxThisWeekHour.ReadOnly = true;
            this.TextBoxThisWeekHour.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxThisWeekHour.Size = new System.Drawing.Size(158, 55);
            this.TextBoxThisWeekHour.TabIndex = 156;
            this.TextBoxThisWeekHour.TabStop = false;
            this.TextBoxThisWeekHour.Text = "00";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(424, 75);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 55);
            this.label22.TabIndex = 157;
            this.label22.Text = ":";
            // 
            // TextBoxAllMinute
            // 
            this.TextBoxAllMinute.BackColor = System.Drawing.Color.White;
            this.TextBoxAllMinute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxAllMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAllMinute.Location = new System.Drawing.Point(320, 250);
            this.TextBoxAllMinute.MaxLength = 2;
            this.TextBoxAllMinute.Name = "TextBoxAllMinute";
            this.TextBoxAllMinute.ReadOnly = true;
            this.TextBoxAllMinute.Size = new System.Drawing.Size(54, 55);
            this.TextBoxAllMinute.TabIndex = 153;
            this.TextBoxAllMinute.TabStop = false;
            this.TextBoxAllMinute.Text = "00";
            // 
            // TextBoxAllSecond
            // 
            this.TextBoxAllSecond.BackColor = System.Drawing.Color.White;
            this.TextBoxAllSecond.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxAllSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAllSecond.Location = new System.Drawing.Point(380, 250);
            this.TextBoxAllSecond.MaxLength = 2;
            this.TextBoxAllSecond.Name = "TextBoxAllSecond";
            this.TextBoxAllSecond.ReadOnly = true;
            this.TextBoxAllSecond.Size = new System.Drawing.Size(54, 55);
            this.TextBoxAllSecond.TabIndex = 155;
            this.TextBoxAllSecond.TabStop = false;
            this.TextBoxAllSecond.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(360, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 55);
            this.label9.TabIndex = 154;
            this.label9.Text = ":";
            // 
            // TextBoxAllHour
            // 
            this.TextBoxAllHour.BackColor = System.Drawing.Color.White;
            this.TextBoxAllHour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxAllHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAllHour.Location = new System.Drawing.Point(153, 250);
            this.TextBoxAllHour.MaxLength = 999999;
            this.TextBoxAllHour.Name = "TextBoxAllHour";
            this.TextBoxAllHour.ReadOnly = true;
            this.TextBoxAllHour.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxAllHour.Size = new System.Drawing.Size(158, 55);
            this.TextBoxAllHour.TabIndex = 151;
            this.TextBoxAllHour.TabStop = false;
            this.TextBoxAllHour.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(299, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 55);
            this.label10.TabIndex = 152;
            this.label10.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(289, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 39);
            this.label8.TabIndex = 150;
            this.label8.Text = "Всего";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(341, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 39);
            this.label6.TabIndex = 149;
            this.label6.Text = "На этой неделе";
            // 
            // ButtonSetNowSecond
            // 
            this.ButtonSetNowSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSetNowSecond.Location = new System.Drawing.Point(437, 231);
            this.ButtonSetNowSecond.Name = "ButtonSetNowSecond";
            this.ButtonSetNowSecond.Size = new System.Drawing.Size(161, 75);
            this.ButtonSetNowSecond.TabIndex = 19;
            this.ButtonSetNowSecond.Text = "Установить сейчас";
            this.ButtonSetNowSecond.UseVisualStyleBackColor = true;
            this.ButtonSetNowSecond.Click += new System.EventHandler(this.ButtonSetNowSecond_Click);
            // 
            // ButtonSetNowFirst
            // 
            this.ButtonSetNowFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSetNowFirst.Location = new System.Drawing.Point(118, 231);
            this.ButtonSetNowFirst.Name = "ButtonSetNowFirst";
            this.ButtonSetNowFirst.Size = new System.Drawing.Size(161, 75);
            this.ButtonSetNowFirst.TabIndex = 11;
            this.ButtonSetNowFirst.Text = "Установить сейчас";
            this.ButtonSetNowFirst.UseVisualStyleBackColor = true;
            this.ButtonSetNowFirst.Click += new System.EventHandler(this.ButtonSetNowFirst_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(477, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 55);
            this.label3.TabIndex = 146;
            this.label3.Text = "До";
            // 
            // TextBoxSecondMonth
            // 
            this.TextBoxSecondMonth.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxSecondMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSecondMonth.Location = new System.Drawing.Point(460, 95);
            this.TextBoxSecondMonth.MaxLength = 2;
            this.TextBoxSecondMonth.Name = "TextBoxSecondMonth";
            this.TextBoxSecondMonth.Size = new System.Drawing.Size(61, 62);
            this.TextBoxSecondMonth.TabIndex = 14;
            this.TextBoxSecondMonth.Text = "00";
            // 
            // TextBoxSecondDay
            // 
            this.TextBoxSecondDay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxSecondDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSecondDay.Location = new System.Drawing.Point(393, 95);
            this.TextBoxSecondDay.MaxLength = 2;
            this.TextBoxSecondDay.Name = "TextBoxSecondDay";
            this.TextBoxSecondDay.Size = new System.Drawing.Size(61, 62);
            this.TextBoxSecondDay.TabIndex = 13;
            this.TextBoxSecondDay.Text = "00";
            // 
            // TextBoxSecondSecond
            // 
            this.TextBoxSecondSecond.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxSecondSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSecondSecond.Location = new System.Drawing.Point(554, 163);
            this.TextBoxSecondSecond.MaxLength = 2;
            this.TextBoxSecondSecond.Name = "TextBoxSecondSecond";
            this.TextBoxSecondSecond.Size = new System.Drawing.Size(61, 62);
            this.TextBoxSecondSecond.TabIndex = 18;
            this.TextBoxSecondSecond.Text = "00";
            // 
            // TextBoxSecondMinute
            // 
            this.TextBoxSecondMinute.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxSecondMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSecondMinute.Location = new System.Drawing.Point(487, 163);
            this.TextBoxSecondMinute.MaxLength = 2;
            this.TextBoxSecondMinute.Name = "TextBoxSecondMinute";
            this.TextBoxSecondMinute.Size = new System.Drawing.Size(61, 62);
            this.TextBoxSecondMinute.TabIndex = 17;
            this.TextBoxSecondMinute.Text = "00";
            // 
            // TextBoxSecondHour
            // 
            this.TextBoxSecondHour.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxSecondHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSecondHour.Location = new System.Drawing.Point(420, 163);
            this.TextBoxSecondHour.MaxLength = 2;
            this.TextBoxSecondHour.Name = "TextBoxSecondHour";
            this.TextBoxSecondHour.Size = new System.Drawing.Size(61, 62);
            this.TextBoxSecondHour.TabIndex = 16;
            this.TextBoxSecondHour.Text = "00";
            // 
            // TextBoxSecondYear
            // 
            this.TextBoxSecondYear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxSecondYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSecondYear.Location = new System.Drawing.Point(527, 95);
            this.TextBoxSecondYear.MaxLength = 4;
            this.TextBoxSecondYear.Name = "TextBoxSecondYear";
            this.TextBoxSecondYear.Size = new System.Drawing.Size(115, 62);
            this.TextBoxSecondYear.TabIndex = 15;
            this.TextBoxSecondYear.Text = "0000";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(159, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 55);
            this.label2.TabIndex = 139;
            this.label2.Text = "От";
            // 
            // TextBoxFirstMonth
            // 
            this.TextBoxFirstMonth.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxFirstMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxFirstMonth.Location = new System.Drawing.Point(142, 95);
            this.TextBoxFirstMonth.MaxLength = 2;
            this.TextBoxFirstMonth.Name = "TextBoxFirstMonth";
            this.TextBoxFirstMonth.Size = new System.Drawing.Size(61, 62);
            this.TextBoxFirstMonth.TabIndex = 6;
            this.TextBoxFirstMonth.Text = "00";
            // 
            // TextBoxFirstDay
            // 
            this.TextBoxFirstDay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxFirstDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxFirstDay.Location = new System.Drawing.Point(75, 95);
            this.TextBoxFirstDay.MaxLength = 2;
            this.TextBoxFirstDay.Name = "TextBoxFirstDay";
            this.TextBoxFirstDay.Size = new System.Drawing.Size(61, 62);
            this.TextBoxFirstDay.TabIndex = 5;
            this.TextBoxFirstDay.Text = "00";
            // 
            // TextBoxFirstSecond
            // 
            this.TextBoxFirstSecond.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxFirstSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxFirstSecond.Location = new System.Drawing.Point(236, 163);
            this.TextBoxFirstSecond.MaxLength = 2;
            this.TextBoxFirstSecond.Name = "TextBoxFirstSecond";
            this.TextBoxFirstSecond.Size = new System.Drawing.Size(61, 62);
            this.TextBoxFirstSecond.TabIndex = 10;
            this.TextBoxFirstSecond.Text = "00";
            // 
            // TextBoxFirstMinute
            // 
            this.TextBoxFirstMinute.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxFirstMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxFirstMinute.Location = new System.Drawing.Point(169, 163);
            this.TextBoxFirstMinute.MaxLength = 2;
            this.TextBoxFirstMinute.Name = "TextBoxFirstMinute";
            this.TextBoxFirstMinute.Size = new System.Drawing.Size(61, 62);
            this.TextBoxFirstMinute.TabIndex = 9;
            this.TextBoxFirstMinute.Text = "00";
            // 
            // TextBoxFirstHour
            // 
            this.TextBoxFirstHour.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxFirstHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxFirstHour.Location = new System.Drawing.Point(102, 163);
            this.TextBoxFirstHour.MaxLength = 2;
            this.TextBoxFirstHour.Name = "TextBoxFirstHour";
            this.TextBoxFirstHour.Size = new System.Drawing.Size(61, 62);
            this.TextBoxFirstHour.TabIndex = 8;
            this.TextBoxFirstHour.Text = "00";
            // 
            // TextBoxFirstYear
            // 
            this.TextBoxFirstYear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxFirstYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxFirstYear.Location = new System.Drawing.Point(209, 95);
            this.TextBoxFirstYear.MaxLength = 4;
            this.TextBoxFirstYear.Name = "TextBoxFirstYear";
            this.TextBoxFirstYear.Size = new System.Drawing.Size(115, 62);
            this.TextBoxFirstYear.TabIndex = 7;
            this.TextBoxFirstYear.Text = "0000";
            // 
            // ButtonClearToday
            // 
            this.ButtonClearToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClearToday.Location = new System.Drawing.Point(117, 130);
            this.ButtonClearToday.Name = "ButtonClearToday";
            this.ButtonClearToday.Size = new System.Drawing.Size(141, 48);
            this.ButtonClearToday.TabIndex = 22;
            this.ButtonClearToday.Text = "Очистить";
            this.ButtonClearToday.UseVisualStyleBackColor = true;
            this.ButtonClearToday.Click += new System.EventHandler(this.ButtonClearToday_Click);
            // 
            // TextBoxTodayMinute
            // 
            this.TextBoxTodayMinute.BackColor = System.Drawing.Color.White;
            this.TextBoxTodayMinute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTodayMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxTodayMinute.Location = new System.Drawing.Point(159, 78);
            this.TextBoxTodayMinute.MaxLength = 2;
            this.TextBoxTodayMinute.Name = "TextBoxTodayMinute";
            this.TextBoxTodayMinute.ReadOnly = true;
            this.TextBoxTodayMinute.Size = new System.Drawing.Size(54, 55);
            this.TextBoxTodayMinute.TabIndex = 169;
            this.TextBoxTodayMinute.TabStop = false;
            this.TextBoxTodayMinute.Text = "00";
            // 
            // TextBoxTodaySecond
            // 
            this.TextBoxTodaySecond.BackColor = System.Drawing.Color.White;
            this.TextBoxTodaySecond.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTodaySecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxTodaySecond.Location = new System.Drawing.Point(219, 78);
            this.TextBoxTodaySecond.MaxLength = 2;
            this.TextBoxTodaySecond.Name = "TextBoxTodaySecond";
            this.TextBoxTodaySecond.ReadOnly = true;
            this.TextBoxTodaySecond.Size = new System.Drawing.Size(54, 55);
            this.TextBoxTodaySecond.TabIndex = 171;
            this.TextBoxTodaySecond.TabStop = false;
            this.TextBoxTodaySecond.Text = "00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(199, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 55);
            this.label14.TabIndex = 170;
            this.label14.Text = ":";
            // 
            // TextBoxTodayHour
            // 
            this.TextBoxTodayHour.BackColor = System.Drawing.Color.White;
            this.TextBoxTodayHour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTodayHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxTodayHour.Location = new System.Drawing.Point(13, 78);
            this.TextBoxTodayHour.MaxLength = 999999;
            this.TextBoxTodayHour.Name = "TextBoxTodayHour";
            this.TextBoxTodayHour.ReadOnly = true;
            this.TextBoxTodayHour.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxTodayHour.Size = new System.Drawing.Size(137, 55);
            this.TextBoxTodayHour.TabIndex = 167;
            this.TextBoxTodayHour.TabStop = false;
            this.TextBoxTodayHour.Text = "00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(138, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 55);
            this.label15.TabIndex = 168;
            this.label15.Text = ":";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(111, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(151, 39);
            this.label16.TabIndex = 166;
            this.label16.Text = "Сегодня";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.TextBoxNewName);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.ButtonChange);
            this.tabPage4.Controls.Add(this.TextBoxOldName);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(277, 384);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Изменить";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // TextBoxNewName
            // 
            this.TextBoxNewName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxNewName.Location = new System.Drawing.Point(25, 145);
            this.TextBoxNewName.MaxLength = 999;
            this.TextBoxNewName.Name = "TextBoxNewName";
            this.TextBoxNewName.Size = new System.Drawing.Size(227, 35);
            this.TextBoxNewName.TabIndex = 142;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(52, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 37);
            this.label7.TabIndex = 143;
            this.label7.Text = "Новое имя";
            // 
            // ButtonChange
            // 
            this.ButtonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonChange.Location = new System.Drawing.Point(38, 320);
            this.ButtonChange.Name = "ButtonChange";
            this.ButtonChange.Size = new System.Drawing.Size(202, 57);
            this.ButtonChange.TabIndex = 140;
            this.ButtonChange.Text = "Изменить";
            this.ButtonChange.UseVisualStyleBackColor = true;
            this.ButtonChange.Click += new System.EventHandler(this.ButtonChange_Click);
            // 
            // TextBoxOldName
            // 
            this.TextBoxOldName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxOldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxOldName.Location = new System.Drawing.Point(25, 48);
            this.TextBoxOldName.MaxLength = 999;
            this.TextBoxOldName.Name = "TextBoxOldName";
            this.TextBoxOldName.Size = new System.Drawing.Size(227, 35);
            this.TextBoxOldName.TabIndex = 139;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 37);
            this.label1.TabIndex = 141;
            this.label1.Text = "Имя";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ButtonDelete);
            this.tabPage3.Controls.Add(this.TextBoxDelete);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(277, 384);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Удалить";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDelete.Location = new System.Drawing.Point(38, 320);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(202, 57);
            this.ButtonDelete.TabIndex = 137;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // TextBoxDelete
            // 
            this.TextBoxDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxDelete.Location = new System.Drawing.Point(25, 48);
            this.TextBoxDelete.MaxLength = 999;
            this.TextBoxDelete.Name = "TextBoxDelete";
            this.TextBoxDelete.Size = new System.Drawing.Size(227, 35);
            this.TextBoxDelete.TabIndex = 136;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(93, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 37);
            this.label5.TabIndex = 138;
            this.label5.Text = "Имя";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ButtonAddName);
            this.tabPage2.Controls.Add(this.TextBoxAddName);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(277, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ButtonAddName
            // 
            this.ButtonAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddName.Location = new System.Drawing.Point(38, 320);
            this.ButtonAddName.Name = "ButtonAddName";
            this.ButtonAddName.Size = new System.Drawing.Size(202, 57);
            this.ButtonAddName.TabIndex = 134;
            this.ButtonAddName.Text = "Добавить";
            this.ButtonAddName.UseVisualStyleBackColor = true;
            this.ButtonAddName.Click += new System.EventHandler(this.ButtonAddName_Click);
            // 
            // TextBoxAddName
            // 
            this.TextBoxAddName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAddName.Location = new System.Drawing.Point(25, 48);
            this.TextBoxAddName.MaxLength = 999;
            this.TextBoxAddName.Name = "TextBoxAddName";
            this.TextBoxAddName.Size = new System.Drawing.Size(227, 35);
            this.TextBoxAddName.TabIndex = 133;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(93, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 37);
            this.label4.TabIndex = 135;
            this.label4.Text = "Имя";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(285, 410);
            this.tabControl1.TabIndex = 1;
            // 
            // GroupBoxAdd
            // 
            this.GroupBoxAdd.Controls.Add(this.TextBoxFirstYear);
            this.GroupBoxAdd.Controls.Add(this.TextBoxFirstHour);
            this.GroupBoxAdd.Controls.Add(this.TextBoxFirstMinute);
            this.GroupBoxAdd.Controls.Add(this.TextBoxFirstSecond);
            this.GroupBoxAdd.Controls.Add(this.TextBoxFirstDay);
            this.GroupBoxAdd.Controls.Add(this.TextBoxFirstMonth);
            this.GroupBoxAdd.Controls.Add(this.label2);
            this.GroupBoxAdd.Controls.Add(this.TextBoxSecondYear);
            this.GroupBoxAdd.Controls.Add(this.TextBoxSecondHour);
            this.GroupBoxAdd.Controls.Add(this.TextBoxSecondMinute);
            this.GroupBoxAdd.Controls.Add(this.TextBoxSecondSecond);
            this.GroupBoxAdd.Controls.Add(this.ButtonAddTime);
            this.GroupBoxAdd.Controls.Add(this.TextBoxSecondDay);
            this.GroupBoxAdd.Controls.Add(this.TextBoxSecondMonth);
            this.GroupBoxAdd.Controls.Add(this.label3);
            this.GroupBoxAdd.Controls.Add(this.ButtonSetNowFirst);
            this.GroupBoxAdd.Controls.Add(this.ButtonSetNowSecond);
            this.GroupBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxAdd.Location = new System.Drawing.Point(309, 16);
            this.GroupBoxAdd.Name = "GroupBoxAdd";
            this.GroupBoxAdd.Size = new System.Drawing.Size(702, 406);
            this.GroupBoxAdd.TabIndex = 172;
            this.GroupBoxAdd.TabStop = false;
            this.GroupBoxAdd.Text = "Добавить потраченое время";
            this.GroupBoxAdd.Visible = false;
            // 
            // LabelAdd
            // 
            this.LabelAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelAdd.AutoSize = true;
            this.LabelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAdd.Location = new System.Drawing.Point(312, 354);
            this.LabelAdd.Name = "LabelAdd";
            this.LabelAdd.Size = new System.Drawing.Size(523, 55);
            this.LabelAdd.TabIndex = 147;
            this.LabelAdd.Text = "<---- Добавте элемент";
            this.LabelAdd.Visible = false;
            // 
            // GroupBoxTime
            // 
            this.GroupBoxTime.Controls.Add(this.TextBoxAllHour);
            this.GroupBoxTime.Controls.Add(this.TextBoxAllMinute);
            this.GroupBoxTime.Controls.Add(this.TextBoxAllSecond);
            this.GroupBoxTime.Controls.Add(this.TextBoxThisWeekSecond);
            this.GroupBoxTime.Controls.Add(this.TextBoxThisWeekMinute);
            this.GroupBoxTime.Controls.Add(this.TextBoxThisWeekHour);
            this.GroupBoxTime.Controls.Add(this.label16);
            this.GroupBoxTime.Controls.Add(this.label6);
            this.GroupBoxTime.Controls.Add(this.label8);
            this.GroupBoxTime.Controls.Add(this.ButtonClearToday);
            this.GroupBoxTime.Controls.Add(this.label10);
            this.GroupBoxTime.Controls.Add(this.TextBoxTodayMinute);
            this.GroupBoxTime.Controls.Add(this.TextBoxTodaySecond);
            this.GroupBoxTime.Controls.Add(this.label9);
            this.GroupBoxTime.Controls.Add(this.label14);
            this.GroupBoxTime.Controls.Add(this.TextBoxTodayHour);
            this.GroupBoxTime.Controls.Add(this.label15);
            this.GroupBoxTime.Controls.Add(this.label22);
            this.GroupBoxTime.Controls.Add(this.label21);
            this.GroupBoxTime.Controls.Add(this.ButtonClearAll);
            this.GroupBoxTime.Controls.Add(this.ButtonClearThisWeek);
            this.GroupBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxTime.Location = new System.Drawing.Point(309, 428);
            this.GroupBoxTime.Name = "GroupBoxTime";
            this.GroupBoxTime.Size = new System.Drawing.Size(702, 381);
            this.GroupBoxTime.TabIndex = 173;
            this.GroupBoxTime.TabStop = false;
            this.GroupBoxTime.Text = "Потраченое время";
            this.GroupBoxTime.Visible = false;
            // 
            // LabelSelect
            // 
            this.LabelSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSelect.AutoSize = true;
            this.LabelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSelect.Location = new System.Drawing.Point(312, 428);
            this.LabelSelect.Name = "LabelSelect";
            this.LabelSelect.Size = new System.Drawing.Size(554, 55);
            this.LabelSelect.TabIndex = 148;
            this.LabelSelect.Text = "<---- Выберите элемент";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 825);
            this.Controls.Add(this.LabelAdd);
            this.Controls.Add(this.LabelSelect);
            this.Controls.Add(this.GroupBoxTime);
            this.Controls.Add(this.GroupBoxAdd);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.GroupBoxAdd.ResumeLayout(false);
            this.GroupBoxAdd.PerformLayout();
            this.GroupBoxTime.ResumeLayout(false);
            this.GroupBoxTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ButtonClearAll;
        private System.Windows.Forms.Button ButtonClearThisWeek;
        private System.Windows.Forms.Button ButtonAddTime;
        private System.Windows.Forms.TextBox TextBoxThisWeekMinute;
        private System.Windows.Forms.TextBox TextBoxThisWeekSecond;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox TextBoxThisWeekHour;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TextBoxAllMinute;
        private System.Windows.Forms.TextBox TextBoxAllSecond;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBoxAllHour;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonSetNowSecond;
        private System.Windows.Forms.Button ButtonSetNowFirst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxSecondMonth;
        private System.Windows.Forms.TextBox TextBoxSecondDay;
        private System.Windows.Forms.TextBox TextBoxSecondSecond;
        private System.Windows.Forms.TextBox TextBoxSecondMinute;
        private System.Windows.Forms.TextBox TextBoxSecondHour;
        private System.Windows.Forms.TextBox TextBoxSecondYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxFirstMonth;
        private System.Windows.Forms.TextBox TextBoxFirstDay;
        private System.Windows.Forms.TextBox TextBoxFirstSecond;
        private System.Windows.Forms.TextBox TextBoxFirstMinute;
        private System.Windows.Forms.TextBox TextBoxFirstHour;
        private System.Windows.Forms.TextBox TextBoxFirstYear;
        private System.Windows.Forms.Button ButtonClearToday;
        private System.Windows.Forms.TextBox TextBoxTodayMinute;
        private System.Windows.Forms.TextBox TextBoxTodaySecond;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TextBoxTodayHour;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.TextBox TextBoxDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ButtonAddName;
        private System.Windows.Forms.TextBox TextBoxAddName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox GroupBoxAdd;
        private System.Windows.Forms.GroupBox GroupBoxTime;
        private System.Windows.Forms.TextBox TextBoxNewName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ButtonChange;
        private System.Windows.Forms.TextBox TextBoxOldName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelAdd;
        private System.Windows.Forms.Label LabelSelect;
    }
}

