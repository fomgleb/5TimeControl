namespace TimeControl
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.historyTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.showSpentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.historyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.endPanel = new System.Windows.Forms.TableLayoutPanel();
            this.endDateTextBox = new System.Windows.Forms.TextBox();
            this.endTimeTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.startPanel = new System.Windows.Forms.TableLayoutPanel();
            this.startDateTextBox = new System.Windows.Forms.TextBox();
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.historyTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.endPanel.SuspendLayout();
            this.startPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.Controls.Add(this.historyTableLayoutPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1252, 424);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // historyTableLayoutPanel
            // 
            this.historyTableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.historyTableLayoutPanel.ColumnCount = 1;
            this.historyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.historyTableLayoutPanel.Controls.Add(this.showSpentButton, 0, 2);
            this.historyTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.historyTableLayoutPanel.Controls.Add(this.historyRichTextBox, 0, 1);
            this.historyTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyTableLayoutPanel.Location = new System.Drawing.Point(902, 0);
            this.historyTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.historyTableLayoutPanel.Name = "historyTableLayoutPanel";
            this.historyTableLayoutPanel.RowCount = 3;
            this.historyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.historyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.historyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.historyTableLayoutPanel.Size = new System.Drawing.Size(350, 424);
            this.historyTableLayoutPanel.TabIndex = 1;
            this.historyTableLayoutPanel.Visible = false;
            // 
            // showSpentButton
            // 
            this.showSpentButton.BackColor = System.Drawing.Color.Lime;
            this.showSpentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showSpentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showSpentButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showSpentButton.Location = new System.Drawing.Point(15, 359);
            this.showSpentButton.Margin = new System.Windows.Forms.Padding(15);
            this.showSpentButton.Name = "showSpentButton";
            this.showSpentButton.Size = new System.Drawing.Size(320, 50);
            this.showSpentButton.TabIndex = 4;
            this.showSpentButton.Text = "Show time spent";
            this.showSpentButton.UseVisualStyleBackColor = false;
            this.showSpentButton.Click += new System.EventHandler(this.AllButtons_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "History";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // historyRichTextBox
            // 
            this.historyRichTextBox.BackColor = System.Drawing.Color.White;
            this.historyRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyRichTextBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyRichTextBox.Location = new System.Drawing.Point(0, 25);
            this.historyRichTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.historyRichTextBox.Name = "historyRichTextBox";
            this.historyRichTextBox.Size = new System.Drawing.Size(350, 319);
            this.historyRichTextBox.TabIndex = 0;
            this.historyRichTextBox.Text = "ОТ 27.05.2020 22:58:55\nДО 28.05.2020 00:30:08\nПОТРАЧЕНО 1 ч. 10 мин. 33 сек.\nДела" +
    "л тетрис\n\nОТ 27.05.2020 20:20:50\nДО 27.05.2020 21:39:01\nПОТРАЧЕНО 1 ч. 18 мин. 1" +
    "1 сек.\nДелал тетрис";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.94255F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.05744F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.mainTableLayoutPanel, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(902, 424);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.listBox, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.39309F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.60691F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(297, 424);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.editButton, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.addButton, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.deleteButton, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 366);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(297, 58);
            this.tableLayoutPanel5.TabIndex = 4;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Yellow;
            this.editButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.Location = new System.Drawing.Point(203, 5);
            this.editButton.Margin = new System.Windows.Forms.Padding(5);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(89, 48);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.AllButtons_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Lime;
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(5, 5);
            this.addButton.Margin = new System.Windows.Forms.Padding(5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(89, 48);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AllButtons_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(104, 5);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(89, 48);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.AllButtons_Click);
            // 
            // listBox
            // 
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 24;
            this.listBox.Items.AddRange(new object[] {
            "Download..."});
            this.listBox.Location = new System.Drawing.Point(0, 0);
            this.listBox.Margin = new System.Windows.Forms.Padding(0);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(297, 366);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.mainTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.Controls.Add(this.endPanel, 1, 1);
            this.mainTableLayoutPanel.Controls.Add(this.startButton, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.endButton, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.startPanel, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.cancelButton, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.confirmButton, 1, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(297, 0);
            this.mainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(605, 424);
            this.mainTableLayoutPanel.TabIndex = 4;
            this.mainTableLayoutPanel.Visible = false;
            // 
            // endPanel
            // 
            this.endPanel.ColumnCount = 1;
            this.endPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.endPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.endPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.endPanel.Controls.Add(this.endDateTextBox, 0, 1);
            this.endPanel.Controls.Add(this.endTimeTextBox, 0, 0);
            this.endPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endPanel.Location = new System.Drawing.Point(303, 141);
            this.endPanel.Margin = new System.Windows.Forms.Padding(0);
            this.endPanel.Name = "endPanel";
            this.endPanel.RowCount = 2;
            this.endPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.endPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.endPanel.Size = new System.Drawing.Size(301, 140);
            this.endPanel.TabIndex = 5;
            this.endPanel.Visible = false;
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.endDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDateTextBox.Location = new System.Drawing.Point(10, 88);
            this.endDateTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.endDateTextBox.MaxLength = 10;
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.Size = new System.Drawing.Size(281, 33);
            this.endDateTextBox.TabIndex = 4;
            this.endDateTextBox.Text = "00.00.0000";
            this.endDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // endTimeTextBox
            // 
            this.endTimeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.endTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endTimeTextBox.Location = new System.Drawing.Point(10, 18);
            this.endTimeTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.endTimeTextBox.MaxLength = 8;
            this.endTimeTextBox.Name = "endTimeTextBox";
            this.endTimeTextBox.Size = new System.Drawing.Size(281, 33);
            this.endTimeTextBox.TabIndex = 3;
            this.endTimeTextBox.Text = "00:00:00";
            this.endTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Lime;
            this.startButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(16, 16);
            this.startButton.Margin = new System.Windows.Forms.Padding(15);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(271, 109);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start spending time";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.AllButtons_Click);
            // 
            // endButton
            // 
            this.endButton.BackColor = System.Drawing.Color.Yellow;
            this.endButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.endButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endButton.Location = new System.Drawing.Point(318, 16);
            this.endButton.Margin = new System.Windows.Forms.Padding(15);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(271, 109);
            this.endButton.TabIndex = 1;
            this.endButton.Text = "End spending time";
            this.endButton.UseVisualStyleBackColor = false;
            this.endButton.Visible = false;
            this.endButton.Click += new System.EventHandler(this.AllButtons_Click);
            // 
            // startPanel
            // 
            this.startPanel.ColumnCount = 1;
            this.startPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.startPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.startPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.startPanel.Controls.Add(this.startDateTextBox, 0, 1);
            this.startPanel.Controls.Add(this.startTimeTextBox, 0, 0);
            this.startPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startPanel.Location = new System.Drawing.Point(1, 141);
            this.startPanel.Margin = new System.Windows.Forms.Padding(0);
            this.startPanel.Name = "startPanel";
            this.startPanel.RowCount = 2;
            this.startPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.startPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.startPanel.Size = new System.Drawing.Size(301, 140);
            this.startPanel.TabIndex = 4;
            this.startPanel.Visible = false;
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDateTextBox.Location = new System.Drawing.Point(10, 88);
            this.startDateTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.startDateTextBox.MaxLength = 10;
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.Size = new System.Drawing.Size(281, 33);
            this.startDateTextBox.TabIndex = 3;
            this.startDateTextBox.Text = "00.00.0000";
            this.startDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startTimeTextBox
            // 
            this.startTimeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startTimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTimeTextBox.Location = new System.Drawing.Point(10, 18);
            this.startTimeTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.startTimeTextBox.MaxLength = 8;
            this.startTimeTextBox.Name = "startTimeTextBox";
            this.startTimeTextBox.Size = new System.Drawing.Size(281, 33);
            this.startTimeTextBox.TabIndex = 2;
            this.startTimeTextBox.Text = "00:00:00";
            this.startTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Red;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(16, 297);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(15);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(271, 111);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.AllButtons_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.Lime;
            this.confirmButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmButton.Location = new System.Drawing.Point(318, 297);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(15);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(271, 111);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Visible = false;
            this.confirmButton.Click += new System.EventHandler(this.AllButtons_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 424);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1268, 463);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.historyTableLayoutPanel.ResumeLayout(false);
            this.historyTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.endPanel.ResumeLayout(false);
            this.endPanel.PerformLayout();
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel historyTableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox historyRichTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TableLayoutPanel endPanel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.TableLayoutPanel startPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button showSpentButton;
        private System.Windows.Forms.TextBox startTimeTextBox;
        private System.Windows.Forms.TextBox endDateTextBox;
        private System.Windows.Forms.TextBox endTimeTextBox;
        private System.Windows.Forms.TextBox startDateTextBox;
    }
}

