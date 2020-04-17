using System;
using System.IO;
using System.Windows.Forms;

namespace TimeControl
{
    public partial class Form1 : Form
    {
        string pathToDir = Environment.CurrentDirectory + "\\TimeControlSaves";

        int allSeconds;
        int thisWeekSeconds;
        int todaySeconds;

        int numberDayOfWeek;
        int numberDayOfYear;

        string selectedItem;

        public Form1()
        {
            InitializeComponent();
        }

        void NumberDayOfWeek_Update()
        {
            var dayOfWeek = DateTime.Now.DayOfWeek;
            var numberDayOfWeek2 = NumberManipulator.GetNumberDayOfWeek(dayOfWeek);

            if (numberDayOfWeek > numberDayOfWeek2)
            {
                numberDayOfWeek = numberDayOfWeek2;
                thisWeekSeconds = 0;
            }
            else
                numberDayOfWeek = numberDayOfWeek2;
        }

        void NumberDayOfYear_Update()
        {
            var numberDayOfYear2 = DateTime.Now.DayOfYear;

            if (numberDayOfYear != numberDayOfYear2)
            {
                numberDayOfYear = numberDayOfYear2;
                todaySeconds = 0;
            }
        }

        void TextBoxAllThis_Show()
        {
            if (allSeconds < 0)
                allSeconds = 0;
            if (thisWeekSeconds < 0)
                thisWeekSeconds = 0;
            if (todaySeconds < 0)
                todaySeconds = 0;

            var aSeconds = TimeSpan.FromSeconds(allSeconds);
            var twSeconds = TimeSpan.FromSeconds(thisWeekSeconds);
            var tSeconds = TimeSpan.FromSeconds(todaySeconds);

            if (aSeconds.Days > 0)
                TextBoxAllHours.Text = NumberManipulator.AddZero((aSeconds.Days * 24) + aSeconds.Hours);
            else
                TextBoxAllHours.Text = NumberManipulator.AddZero(aSeconds.Hours);
            TextBoxAllMinutes.Text = NumberManipulator.AddZero(aSeconds.Minutes);
            TextBoxAllSeconds.Text = NumberManipulator.AddZero(aSeconds.Seconds);

            if (twSeconds.Days > 0)
                TextBoxThisWeekHours.Text = NumberManipulator.AddZero((twSeconds.Days * 24) + twSeconds.Hours);
            else
                TextBoxThisWeekHours.Text = NumberManipulator.AddZero(twSeconds.Hours);
            TextBoxThisWeekMinutes.Text = NumberManipulator.AddZero(twSeconds.Minutes);
            TextBoxThisWeekSeconds.Text = NumberManipulator.AddZero(twSeconds.Seconds);

            if (tSeconds.Days > 0)
                TextBoxTodayHours.Text = NumberManipulator.AddZero((tSeconds.Days * 24) + tSeconds.Hours);
            else
                TextBoxTodayHours.Text = NumberManipulator.AddZero(tSeconds.Hours);
            TextBoxTodayMinutes.Text = NumberManipulator.AddZero(tSeconds.Minutes);
            TextBoxTodaySeconds.Text = NumberManipulator.AddZero(tSeconds.Seconds);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(pathToDir))
                Directory.CreateDirectory(pathToDir);

            FromDirToListBox();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (selectedItem != null)
            {
                FromTextBoxesToFiles(selectedItem);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (selectedItem == null)
                    selectedItem = listBox1.SelectedItem.ToString();
                else
                {
                    FromTextBoxesToFiles(selectedItem);
                    selectedItem = listBox1.SelectedItem.ToString();
                }

                VisiblityCheck();

                TextBoxDelete.Text = selectedItem;
                TextBoxOldName.Text = selectedItem;

                FromFilesToTextBoxes(selectedItem);
                NumberDayOfWeek_Update();
                NumberDayOfYear_Update();
                FromTextBoxesToFiles(selectedItem);

                TextBoxAllThis_Show();
            }
        }

        private void VisiblityCheck()
        {
            if (listBox1.Items.Count <= 0)
            {
                LabelAdd.Visible = true;
                LabelSelect.Visible = GroupBoxAdd.Visible = GroupBoxTime.Visible = HistoryTextBox.Visible = HistoryLabel.Visible = false;
            }
            else if (listBox1.SelectedItem == null)
            {
                LabelSelect.Visible = true;
                LabelAdd.Visible = GroupBoxAdd.Visible = GroupBoxTime.Visible = HistoryTextBox.Visible = HistoryLabel.Visible = false;
            }
            else
            {
                LabelAdd.Visible = LabelSelect.Visible = false;
                GroupBoxAdd.Visible = GroupBoxTime.Visible = HistoryTextBox.Visible = HistoryLabel.Visible = true;
            }
        }
    }
}
