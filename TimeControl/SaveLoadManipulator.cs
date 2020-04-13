using System;
using System.IO;

namespace TimeControl
{
    public partial class Form1
    {
        void FromTextBoxesToFiles(string Item)
        {
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "FirstYears.txt", TextBoxFirstYears.Text);
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "FirstMonths.txt", TextBoxFirstMonths.Text);
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "FirstDays.txt", TextBoxFirstDays.Text);
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "FirstHours.txt", TextBoxFirstHours.Text);
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "FirstMinutes.txt", TextBoxFirstMinutes.Text);
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "FirstSeconds.txt", TextBoxFirstSeconds.Text);
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "SecondYears.txt", TextBoxSecondYears.Text);
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "SecondMonths.txt", TextBoxSecondMonths.Text);
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "SecondDays.txt", TextBoxSecondDays.Text);
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "SecondHours.txt", TextBoxSecondHours.Text);
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "SecondMinutes.txt", TextBoxSecondMinutes.Text);
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "SecondSeconds.txt", TextBoxSecondSeconds.Text);
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "AllSeconds.txt", Convert.ToString(allSeconds));
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "ThisWeekSeconds.txt", Convert.ToString(thisWeekSeconds));
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "TodaySeconds.txt", Convert.ToString(todaySeconds));
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "NumberDayOfWeek.txt", Convert.ToString(numberDayOfWeek));
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "NumberDayOfYear.txt", Convert.ToString(numberDayOfYear));
        }

        void FromFilesToTextBoxes(string Item)
        {
            TextBoxFirstYears.Text = File.ReadAllText(pathToDir + "\\" + Item + "\\" + "FirstYears.txt");
            TextBoxFirstMonths.Text = File.ReadAllText(pathToDir + "\\" + Item + "\\" + "FirstMonths.txt");
            TextBoxFirstDays.Text = File.ReadAllText(pathToDir + "\\" + Item + "\\" + "FirstDays.txt");
            TextBoxFirstHours.Text = File.ReadAllText(pathToDir + "\\" + Item + "\\" + "FirstHours.txt");
            TextBoxFirstMinutes.Text = File.ReadAllText(pathToDir + "\\" + Item + "\\" + "FirstMinutes.txt");
            TextBoxFirstSeconds.Text = File.ReadAllText(pathToDir + "\\" + Item + "\\" + "FirstSeconds.txt");
            TextBoxSecondYears.Text = File.ReadAllText(pathToDir + "\\" + Item + "\\" + "SecondYears.txt");
            TextBoxSecondMonths.Text = File.ReadAllText(pathToDir + "\\" + Item + "\\" + "SecondMonths.txt");
            TextBoxSecondDays.Text = File.ReadAllText(pathToDir + "\\" + Item + "\\" + "SecondDays.txt");
            TextBoxSecondHours.Text = File.ReadAllText(pathToDir + "\\" + Item + "\\" + "SecondHours.txt");
            TextBoxSecondMinutes.Text = File.ReadAllText(pathToDir + "\\" + Item + "\\" + "SecondMinutes.txt");
            TextBoxSecondSeconds.Text = File.ReadAllText(pathToDir + "\\" + Item + "\\" + "SecondSeconds.txt");
            allSeconds = Convert.ToInt32(File.ReadAllText(pathToDir + "\\" + Item + "\\" + "AllSeconds.txt"));
            thisWeekSeconds = Convert.ToInt32(File.ReadAllText(pathToDir + "\\" + Item + "\\" + "ThisWeekSeconds.txt"));
            todaySeconds = Convert.ToInt32(File.ReadAllText(pathToDir + "\\" + Item + "\\" + "TodaySeconds.txt"));
            numberDayOfWeek = Convert.ToInt32(File.ReadAllText(pathToDir + "\\" + Item + "\\" + "NumberDayOfWeek.txt"));
            numberDayOfYear = Convert.ToInt32(File.ReadAllText(pathToDir + "\\" + Item + "\\" + "NumberDayOfYear.txt"));
        }

        void CreateEmptyFiles(string Item)
        {
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "FirstYears.txt", "0000");
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "FirstMonths.txt", "00");
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "FirstDays.txt", "00");
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "FirstHours.txt", "00");
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "FirstMinutes.txt", "00");
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "FirstSeconds.txt", "00");
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "SecondYears.txt", "0000");
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "SecondMonths.txt", "00");
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "SecondDays.txt", "00");
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "SecondHours.txt", "00");
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "SecondMinutes.txt", "00");
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "SecondSeconds.txt", "00");
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "AllSeconds.txt", "0");
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "ThisWeekSeconds.txt", "0");
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "TodaySeconds.txt", "0");
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "NumberDayOfWeek.txt", "0");
            File.WriteAllText(pathToDir + "\\" + Item + "\\" + "NumberDayOfYear.txt", "0");
        }

        void FromDirToListBox()
        {
            listBox1.Items.Clear();

            string[] items = Directory.GetDirectories(pathToDir);
            foreach (string item in items)
            {
                string dirName = new DirectoryInfo(item).Name;
                listBox1.Items.Add(dirName);
            }

            if (listBox1.Items.Count <= 0)
            {
                LabelAdd.Visible = true;
                LabelSelect.Visible = false;
                GroupBoxAdd.Visible = false;
                GroupBoxTime.Visible = false;
            }
            else if (listBox1.SelectedItem == null)
            {
                LabelAdd.Visible = false;
                LabelSelect.Visible = true;
                GroupBoxAdd.Visible = false;
                GroupBoxTime.Visible = false;
            }
        }
    }
}
