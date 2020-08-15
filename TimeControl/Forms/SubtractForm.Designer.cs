namespace TimeControl.Forms
{
    partial class SubtractForm
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
            this.hoursNumeric = new System.Windows.Forms.NumericUpDown();
            this.minutesNumeric = new System.Windows.Forms.NumericUpDown();
            this.secondsNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // hoursNumeric
            // 
            this.hoursNumeric.Location = new System.Drawing.Point(12, 45);
            this.hoursNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.hoursNumeric.Name = "hoursNumeric";
            this.hoursNumeric.Size = new System.Drawing.Size(100, 40);
            this.hoursNumeric.TabIndex = 11;
            // 
            // minutesNumeric
            // 
            this.minutesNumeric.Location = new System.Drawing.Point(161, 45);
            this.minutesNumeric.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesNumeric.Name = "minutesNumeric";
            this.minutesNumeric.Size = new System.Drawing.Size(53, 40);
            this.minutesNumeric.TabIndex = 13;
            // 
            // secondsNumeric
            // 
            this.secondsNumeric.Location = new System.Drawing.Point(254, 45);
            this.secondsNumeric.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondsNumeric.Name = "secondsNumeric";
            this.secondsNumeric.Size = new System.Drawing.Size(53, 40);
            this.secondsNumeric.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 33);
            this.label2.TabIndex = 16;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 33);
            this.label3.TabIndex = 17;
            this.label3.Text = "Hours";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Red;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(12, 127);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(135, 47);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Lime;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(172, 127);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(135, 47);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Subtract";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 33);
            this.label4.TabIndex = 20;
            this.label4.Text = "m.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 33);
            this.label5.TabIndex = 21;
            this.label5.Text = "sec.";
            // 
            // SubtractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 186);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondsNumeric);
            this.Controls.Add(this.minutesNumeric);
            this.Controls.Add(this.hoursNumeric);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "SubtractForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subtract";
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown hoursNumeric;
        private System.Windows.Forms.NumericUpDown minutesNumeric;
        private System.Windows.Forms.NumericUpDown secondsNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}