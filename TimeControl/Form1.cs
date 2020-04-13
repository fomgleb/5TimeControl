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

            var aDay = aSeconds.Days;
            var aHour = aSeconds.Hours;
            var aMinute = aSeconds.Minutes;
            var aSecond = aSeconds.Seconds;

            var twDay = twSeconds.Days;
            var twHour = twSeconds.Hours;
            var twMinute = twSeconds.Minutes;
            var twSecond = twSeconds.Seconds;

            var tDay = tSeconds.Days;
            var tHour = tSeconds.Hours;
            var tMinute = tSeconds.Minutes;
            var tSecond = tSeconds.Seconds;

            if (aDay > 0)
                TextBoxAllHours.Text = NumberManipulator.AddZero((aDay * 24) + aHour);
            else
                TextBoxAllHours.Text = NumberManipulator.AddZero(aHour);
            TextBoxAllMinutes.Text = NumberManipulator.AddZero(aMinute);
            TextBoxAllSeconds.Text = NumberManipulator.AddZero(aSecond);

            if (twDay > 0)
                TextBoxThisWeekHours.Text = NumberManipulator.AddZero((twDay * 24) + twHour);
            else
                TextBoxThisWeekHours.Text = NumberManipulator.AddZero(twHour);
            TextBoxThisWeekMinutes.Text = NumberManipulator.AddZero(twMinute);
            TextBoxThisWeekSeconds.Text = NumberManipulator.AddZero(twSecond);

            if (tDay > 0)
                TextBoxTodayHours.Text = NumberManipulator.AddZero((tDay * 24) + tHour);
            else
                TextBoxTodayHours.Text = NumberManipulator.AddZero(tHour);
            TextBoxTodayMinutes.Text = NumberManipulator.AddZero(tMinute);
            TextBoxTodaySeconds.Text = NumberManipulator.AddZero(tSecond);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(pathToDir))
                Directory.CreateDirectory(pathToDir);

            FromDirToListBox();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FromTextBoxesToFiles(selectedItem);
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

                LabelAdd.Visible = false;
                LabelSelect.Visible = false;
                GroupBoxAdd.Visible = true;
                GroupBoxTime.Visible = true;

                TextBoxDelete.Text = selectedItem;
                TextBoxOldName.Text = selectedItem;

                FromFilesToTextBoxes(selectedItem);
                NumberDayOfWeek_Update();
                NumberDayOfYear_Update();
                FromTextBoxesToFiles(selectedItem);

                TextBoxAllThis_Show();
            }
        }
    }
}
