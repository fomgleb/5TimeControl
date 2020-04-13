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
            this.TextBoxThisWeekMinutes = new System.Windows.Forms.TextBox();
            this.TextBoxThisWeekSeconds = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.TextBoxThisWeekHours = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.TextBoxAllMinutes = new System.Windows.Forms.TextBox();
            this.TextBoxAllSeconds = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxAllHours = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonSetNowSecond = new System.Windows.Forms.Button();
            this.ButtonSetNowFirst = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxSecondMonths = new System.Windows.Forms.TextBox();
            this.TextBoxSecondDays = new System.Windows.Forms.TextBox();
            this.TextBoxSecondSeconds = new System.Windows.Forms.TextBox();
            this.TextBoxSecondMinutes = new System.Windows.Forms.TextBox();
            this.TextBoxSecondHours = new System.Windows.Forms.TextBox();
            this.TextBoxSecondYears = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxFirstMonths = new System.Windows.Forms.TextBox();
            this.TextBoxFirstDays = new System.Windows.Forms.TextBox();
            this.TextBoxFirstSeconds = new System.Windows.Forms.TextBox();
            this.TextBoxFirstMinutes = new System.Windows.Forms.TextBox();
            this.TextBoxFirstHours = new System.Windows.Forms.TextBox();
            this.TextBoxFirstYears = new System.Windows.Forms.TextBox();
            this.ButtonClearToday = new System.Windows.Forms.Button();
            this.TextBoxTodayMinutes = new System.Windows.Forms.TextBox();
            this.TextBoxTodaySeconds = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TextBoxTodayHours = new System.Windows.Forms.TextBox();
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
            this.ButtonAddItem = new System.Windows.Forms.Button();
            this.TextBoxAddItem = new System.Windows.Forms.TextBox();
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
            // TextBoxThisWeekMinutes
            // 
            this.TextBoxThisWeekMinutes.BackColor = System.Drawing.Color.White;
            this.TextBoxThisWeekMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxThisWeekMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxThisWeekMinutes.Location = new System.Drawing.Point(445, 75);
            this.TextBoxThisWeekMinutes.MaxLength = 2;
            this.TextBoxThisWeekMinutes.Name = "TextBoxThisWeekMinutes";
            this.TextBoxThisWeekMinutes.ReadOnly = true;
            this.TextBoxThisWeekMinutes.Size = new System.Drawing.Size(54, 55);
            this.TextBoxThisWeekMinutes.TabIndex = 158;
            this.TextBoxThisWeekMinutes.TabStop = false;
            this.TextBoxThisWeekMinutes.Text = "00";
            // 
            // TextBoxThisWeekSeconds
            // 
            this.TextBoxThisWeekSeconds.BackColor = System.Drawing.Color.White;
            this.TextBoxThisWeekSeconds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxThisWeekSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxThisWeekSeconds.Location = new System.Drawing.Point(505, 75);
            this.TextBoxThisWeekSeconds.MaxLength = 2;
            this.TextBoxThisWeekSeconds.Name = "TextBoxThisWeekSeconds";
            this.TextBoxThisWeekSeconds.ReadOnly = true;
            this.TextBoxThisWeekSeconds.Size = new System.Drawing.Size(54, 55);
            this.TextBoxThisWeekSeconds.TabIndex = 160;
            this.TextBoxThisWeekSeconds.TabStop = false;
            this.TextBoxThisWeekSeconds.Text = "00";
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
            // TextBoxThisWeekHours
            // 
            this.TextBoxThisWeekHours.BackColor = System.Drawing.Color.White;
            this.TextBoxThisWeekHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxThisWeekHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxThisWeekHours.Location = new System.Drawing.Point(278, 75);
            this.TextBoxThisWeekHours.MaxLength = 999999;
            this.TextBoxThisWeekHours.Name = "TextBoxThisWeekHours";
            this.TextBoxThisWeekHours.ReadOnly = true;
            this.TextBoxThisWeekHours.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxThisWeekHours.Size = new System.Drawing.Size(158, 55);
            this.TextBoxThisWeekHours.TabIndex = 156;
            this.TextBoxThisWeekHours.TabStop = false;
            this.TextBoxThisWeekHours.Text = "00";
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
            // TextBoxAllMinutes
            // 
            this.TextBoxAllMinutes.BackColor = System.Drawing.Color.White;
            this.TextBoxAllMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxAllMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAllMinutes.Location = new System.Drawing.Point(320, 250);
            this.TextBoxAllMinutes.MaxLength = 2;
            this.TextBoxAllMinutes.Name = "TextBoxAllMinutes";
            this.TextBoxAllMinutes.ReadOnly = true;
            this.TextBoxAllMinutes.Size = new System.Drawing.Size(54, 55);
            this.TextBoxAllMinutes.TabIndex = 153;
            this.TextBoxAllMinutes.TabStop = false;
            this.TextBoxAllMinutes.Text = "00";
            // 
            // TextBoxAllSeconds
            // 
            this.TextBoxAllSeconds.BackColor = System.Drawing.Color.White;
            this.TextBoxAllSeconds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxAllSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAllSeconds.Location = new System.Drawing.Point(380, 250);
            this.TextBoxAllSeconds.MaxLength = 2;
            this.TextBoxAllSeconds.Name = "TextBoxAllSeconds";
            this.TextBoxAllSeconds.ReadOnly = true;
            this.TextBoxAllSeconds.Size = new System.Drawing.Size(54, 55);
            this.TextBoxAllSeconds.TabIndex = 155;
            this.TextBoxAllSeconds.TabStop = false;
            this.TextBoxAllSeconds.Text = "00";
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
            // TextBoxAllHours
            // 
            this.TextBoxAllHours.BackColor = System.Drawing.Color.White;
            this.TextBoxAllHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxAllHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAllHours.Location = new System.Drawing.Point(153, 250);
            this.TextBoxAllHours.MaxLength = 999999;
            this.TextBoxAllHours.Name = "TextBoxAllHours";
            this.TextBoxAllHours.ReadOnly = true;
            this.TextBoxAllHours.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxAllHours.Size = new System.Drawing.Size(158, 55);
            this.TextBoxAllHours.TabIndex = 151;
            this.TextBoxAllHours.TabStop = false;
            this.TextBoxAllHours.Text = "00";
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
            // TextBoxSecondMonths
            // 
            this.TextBoxSecondMonths.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxSecondMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSecondMonths.Location = new System.Drawing.Point(460, 95);
            this.TextBoxSecondMonths.MaxLength = 2;
            this.TextBoxSecondMonths.Name = "TextBoxSecondMonths";
            this.TextBoxSecondMonths.Size = new System.Drawing.Size(61, 62);
            this.TextBoxSecondMonths.TabIndex = 14;
            this.TextBoxSecondMonths.Text = "00";
            // 
            // TextBoxSecondDays
            // 
            this.TextBoxSecondDays.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxSecondDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSecondDays.Location = new System.Drawing.Point(393, 95);
            this.TextBoxSecondDays.MaxLength = 2;
            this.TextBoxSecondDays.Name = "TextBoxSecondDays";
            this.TextBoxSecondDays.Size = new System.Drawing.Size(61, 62);
            this.TextBoxSecondDays.TabIndex = 13;
            this.TextBoxSecondDays.Text = "00";
            // 
            // TextBoxSecondSeconds
            // 
            this.TextBoxSecondSeconds.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxSecondSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSecondSeconds.Location = new System.Drawing.Point(554, 163);
            this.TextBoxSecondSeconds.MaxLength = 2;
            this.TextBoxSecondSeconds.Name = "TextBoxSecondSeconds";
            this.TextBoxSecondSeconds.Size = new System.Drawing.Size(61, 62);
            this.TextBoxSecondSeconds.TabIndex = 18;
            this.TextBoxSecondSeconds.Text = "00";
            // 
            // TextBoxSecondMinutes
            // 
            this.TextBoxSecondMinutes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxSecondMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSecondMinutes.Location = new System.Drawing.Point(487, 163);
            this.TextBoxSecondMinutes.MaxLength = 2;
            this.TextBoxSecondMinutes.Name = "TextBoxSecondMinutes";
            this.TextBoxSecondMinutes.Size = new System.Drawing.Size(61, 62);
            this.TextBoxSecondMinutes.TabIndex = 17;
            this.TextBoxSecondMinutes.Text = "00";
            // 
            // TextBoxSecondHours
            // 
            this.TextBoxSecondHours.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxSecondHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSecondHours.Location = new System.Drawing.Point(420, 163);
            this.TextBoxSecondHours.MaxLength = 2;
            this.TextBoxSecondHours.Name = "TextBoxSecondHours";
            this.TextBoxSecondHours.Size = new System.Drawing.Size(61, 62);
            this.TextBoxSecondHours.TabIndex = 16;
            this.TextBoxSecondHours.Text = "00";
            // 
            // TextBoxSecondYears
            // 
            this.TextBoxSecondYears.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxSecondYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSecondYears.Location = new System.Drawing.Point(527, 95);
            this.TextBoxSecondYears.MaxLength = 4;
            this.TextBoxSecondYears.Name = "TextBoxSecondYears";
            this.TextBoxSecondYears.Size = new System.Drawing.Size(115, 62);
            this.TextBoxSecondYears.TabIndex = 15;
            this.TextBoxSecondYears.Text = "0000";
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
            // TextBoxFirstMonths
            // 
            this.TextBoxFirstMonths.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxFirstMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxFirstMonths.Location = new System.Drawing.Point(142, 95);
            this.TextBoxFirstMonths.MaxLength = 2;
            this.TextBoxFirstMonths.Name = "TextBoxFirstMonths";
            this.TextBoxFirstMonths.Size = new System.Drawing.Size(61, 62);
            this.TextBoxFirstMonths.TabIndex = 6;
            this.TextBoxFirstMonths.Text = "00";
            // 
            // TextBoxFirstDays
            // 
            this.TextBoxFirstDays.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxFirstDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxFirstDays.Location = new System.Drawing.Point(75, 95);
            this.TextBoxFirstDays.MaxLength = 2;
            this.TextBoxFirstDays.Name = "TextBoxFirstDays";
            this.TextBoxFirstDays.Size = new System.Drawing.Size(61, 62);
            this.TextBoxFirstDays.TabIndex = 5;
            this.TextBoxFirstDays.Text = "00";
            // 
            // TextBoxFirstSeconds
            // 
            this.TextBoxFirstSeconds.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxFirstSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxFirstSeconds.Location = new System.Drawing.Point(236, 163);
            this.TextBoxFirstSeconds.MaxLength = 2;
            this.TextBoxFirstSeconds.Name = "TextBoxFirstSeconds";
            this.TextBoxFirstSeconds.Size = new System.Drawing.Size(61, 62);
            this.TextBoxFirstSeconds.TabIndex = 10;
            this.TextBoxFirstSeconds.Text = "00";
            // 
            // TextBoxFirstMinutes
            // 
            this.TextBoxFirstMinutes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxFirstMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxFirstMinutes.Location = new System.Drawing.Point(169, 163);
            this.TextBoxFirstMinutes.MaxLength = 2;
            this.TextBoxFirstMinutes.Name = "TextBoxFirstMinutes";
            this.TextBoxFirstMinutes.Size = new System.Drawing.Size(61, 62);
            this.TextBoxFirstMinutes.TabIndex = 9;
            this.TextBoxFirstMinutes.Text = "00";
            // 
            // TextBoxFirstHours
            // 
            this.TextBoxFirstHours.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxFirstHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxFirstHours.Location = new System.Drawing.Point(102, 163);
            this.TextBoxFirstHours.MaxLength = 2;
            this.TextBoxFirstHours.Name = "TextBoxFirstHours";
            this.TextBoxFirstHours.Size = new System.Drawing.Size(61, 62);
            this.TextBoxFirstHours.TabIndex = 8;
            this.TextBoxFirstHours.Text = "00";
            // 
            // TextBoxFirstYears
            // 
            this.TextBoxFirstYears.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxFirstYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxFirstYears.Location = new System.Drawing.Point(209, 95);
            this.TextBoxFirstYears.MaxLength = 4;
            this.TextBoxFirstYears.Name = "TextBoxFirstYears";
            this.TextBoxFirstYears.Size = new System.Drawing.Size(115, 62);
            this.TextBoxFirstYears.TabIndex = 7;
            this.TextBoxFirstYears.Text = "0000";
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
            // TextBoxTodayMinutes
            // 
            this.TextBoxTodayMinutes.BackColor = System.Drawing.Color.White;
            this.TextBoxTodayMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTodayMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxTodayMinutes.Location = new System.Drawing.Point(159, 78);
            this.TextBoxTodayMinutes.MaxLength = 2;
            this.TextBoxTodayMinutes.Name = "TextBoxTodayMinutes";
            this.TextBoxTodayMinutes.ReadOnly = true;
            this.TextBoxTodayMinutes.Size = new System.Drawing.Size(54, 55);
            this.TextBoxTodayMinutes.TabIndex = 169;
            this.TextBoxTodayMinutes.TabStop = false;
            this.TextBoxTodayMinutes.Text = "00";
            // 
            // TextBoxTodaySeconds
            // 
            this.TextBoxTodaySeconds.BackColor = System.Drawing.Color.White;
            this.TextBoxTodaySeconds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTodaySeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxTodaySeconds.Location = new System.Drawing.Point(219, 78);
            this.TextBoxTodaySeconds.MaxLength = 2;
            this.TextBoxTodaySeconds.Name = "TextBoxTodaySeconds";
            this.TextBoxTodaySeconds.ReadOnly = true;
            this.TextBoxTodaySeconds.Size = new System.Drawing.Size(54, 55);
            this.TextBoxTodaySeconds.TabIndex = 171;
            this.TextBoxTodaySeconds.TabStop = false;
            this.TextBoxTodaySeconds.Text = "00";
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
            // TextBoxTodayHours
            // 
            this.TextBoxTodayHours.BackColor = System.Drawing.Color.White;
            this.TextBoxTodayHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTodayHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxTodayHours.Location = new System.Drawing.Point(13, 78);
            this.TextBoxTodayHours.MaxLength = 999999;
            this.TextBoxTodayHours.Name = "TextBoxTodayHours";
            this.TextBoxTodayHours.ReadOnly = true;
            this.TextBoxTodayHours.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextBoxTodayHours.Size = new System.Drawing.Size(137, 55);
            this.TextBoxTodayHours.TabIndex = 167;
            this.TextBoxTodayHours.TabStop = false;
            this.TextBoxTodayHours.Text = "00";
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
            this.TextBoxNewName.TabIndex = 2;
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
            this.ButtonChange.TabIndex = 3;
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
            this.TextBoxOldName.TabIndex = 1;
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
            this.ButtonDelete.TabIndex = 2;
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
            this.TextBoxDelete.TabIndex = 1;
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
            this.tabPage2.Controls.Add(this.ButtonAddItem);
            this.tabPage2.Controls.Add(this.TextBoxAddItem);
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
            // ButtonAddItem
            // 
            this.ButtonAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddItem.Location = new System.Drawing.Point(38, 320);
            this.ButtonAddItem.Name = "ButtonAddItem";
            this.ButtonAddItem.Size = new System.Drawing.Size(202, 57);
            this.ButtonAddItem.TabIndex = 2;
            this.ButtonAddItem.Text = "Добавить";
            this.ButtonAddItem.UseVisualStyleBackColor = true;
            this.ButtonAddItem.Click += new System.EventHandler(this.ButtonAddItem_Click);
            // 
            // TextBoxAddItem
            // 
            this.TextBoxAddItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAddItem.Location = new System.Drawing.Point(25, 48);
            this.TextBoxAddItem.MaxLength = 999;
            this.TextBoxAddItem.Name = "TextBoxAddItem";
            this.TextBoxAddItem.Size = new System.Drawing.Size(227, 35);
            this.TextBoxAddItem.TabIndex = 1;
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
            this.GroupBoxAdd.Controls.Add(this.TextBoxFirstYears);
            this.GroupBoxAdd.Controls.Add(this.TextBoxFirstHours);
            this.GroupBoxAdd.Controls.Add(this.TextBoxFirstMinutes);
            this.GroupBoxAdd.Controls.Add(this.TextBoxFirstSeconds);
            this.GroupBoxAdd.Controls.Add(this.TextBoxFirstDays);
            this.GroupBoxAdd.Controls.Add(this.TextBoxFirstMonths);
            this.GroupBoxAdd.Controls.Add(this.label2);
            this.GroupBoxAdd.Controls.Add(this.TextBoxSecondYears);
            this.GroupBoxAdd.Controls.Add(this.TextBoxSecondHours);
            this.GroupBoxAdd.Controls.Add(this.TextBoxSecondMinutes);
            this.GroupBoxAdd.Controls.Add(this.TextBoxSecondSeconds);
            this.GroupBoxAdd.Controls.Add(this.ButtonAddTime);
            this.GroupBoxAdd.Controls.Add(this.TextBoxSecondDays);
            this.GroupBoxAdd.Controls.Add(this.TextBoxSecondMonths);
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
            this.LabelAdd.Size = new System.Drawing.Size(499, 55);
            this.LabelAdd.TabIndex = 147;
            this.LabelAdd.Text = "<---- Добавь элемент";
            this.LabelAdd.Visible = false;
            // 
            // GroupBoxTime
            // 
            this.GroupBoxTime.Controls.Add(this.ButtonClearAll);
            this.GroupBoxTime.Controls.Add(this.TextBoxAllHours);
            this.GroupBoxTime.Controls.Add(this.TextBoxAllMinutes);
            this.GroupBoxTime.Controls.Add(this.TextBoxAllSeconds);
            this.GroupBoxTime.Controls.Add(this.TextBoxThisWeekSeconds);
            this.GroupBoxTime.Controls.Add(this.TextBoxThisWeekMinutes);
            this.GroupBoxTime.Controls.Add(this.TextBoxThisWeekHours);
            this.GroupBoxTime.Controls.Add(this.label16);
            this.GroupBoxTime.Controls.Add(this.label6);
            this.GroupBoxTime.Controls.Add(this.label8);
            this.GroupBoxTime.Controls.Add(this.ButtonClearToday);
            this.GroupBoxTime.Controls.Add(this.label10);
            this.GroupBoxTime.Controls.Add(this.TextBoxTodayMinutes);
            this.GroupBoxTime.Controls.Add(this.TextBoxTodaySeconds);
            this.GroupBoxTime.Controls.Add(this.label9);
            this.GroupBoxTime.Controls.Add(this.label14);
            this.GroupBoxTime.Controls.Add(this.TextBoxTodayHours);
            this.GroupBoxTime.Controls.Add(this.label15);
            this.GroupBoxTime.Controls.Add(this.label22);
            this.GroupBoxTime.Controls.Add(this.label21);
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
            this.LabelSelect.Size = new System.Drawing.Size(505, 55);
            this.LabelSelect.TabIndex = 148;
            this.LabelSelect.Text = "<---- Выбери элемент";
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
            this.Text = "TimeControl";
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
        private System.Windows.Forms.TextBox TextBoxThisWeekMinutes;
        private System.Windows.Forms.TextBox TextBoxThisWeekSeconds;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox TextBoxThisWeekHours;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TextBoxAllMinutes;
        private System.Windows.Forms.TextBox TextBoxAllSeconds;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBoxAllHours;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonSetNowSecond;
        private System.Windows.Forms.Button ButtonSetNowFirst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxSecondMonths;
        private System.Windows.Forms.TextBox TextBoxSecondDays;
        private System.Windows.Forms.TextBox TextBoxSecondSeconds;
        private System.Windows.Forms.TextBox TextBoxSecondMinutes;
        private System.Windows.Forms.TextBox TextBoxSecondHours;
        private System.Windows.Forms.TextBox TextBoxSecondYears;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxFirstMonths;
        private System.Windows.Forms.TextBox TextBoxFirstDays;
        private System.Windows.Forms.TextBox TextBoxFirstSeconds;
        private System.Windows.Forms.TextBox TextBoxFirstMinutes;
        private System.Windows.Forms.TextBox TextBoxFirstHours;
        private System.Windows.Forms.TextBox TextBoxFirstYears;
        private System.Windows.Forms.Button ButtonClearToday;
        private System.Windows.Forms.TextBox TextBoxTodayMinutes;
        private System.Windows.Forms.TextBox TextBoxTodaySeconds;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TextBoxTodayHours;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.TextBox TextBoxDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ButtonAddItem;
        private System.Windows.Forms.TextBox TextBoxAddItem;
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

