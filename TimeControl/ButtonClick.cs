using System;
using System.IO;
using System.Windows.Forms;

namespace TimeControl
{
    public partial class MainForm
    {
        //private void ButtonSetNowFirst_Click(object sender, EventArgs e)
        //{
        //    TextBoxFirstDays.Text = NumberManipulator.AddZero(DateTime.Now.Day);
        //    TextBoxFirstMonths.Text = NumberManipulator.AddZero(DateTime.Now.Month);
        //    TextBoxFirstYears.Text = NumberManipulator.AddZero(DateTime.Now.Year);

        //    TextBoxFirstHours.Text = NumberManipulator.AddZero(DateTime.Now.Hour);
        //    TextBoxFirstMinutes.Text = NumberManipulator.AddZero(DateTime.Now.Minute);
        //    TextBoxFirstSeconds.Text = NumberManipulator.AddZero(DateTime.Now.Second);
        //}

        //private void ButtonSetNowSecond_Click(object sender, EventArgs e)
        //{
        //    TextBoxSecondDays.Text = NumberManipulator.AddZero(DateTime.Now.Day);
        //    TextBoxSecondMonths.Text = NumberManipulator.AddZero(DateTime.Now.Month);
        //    TextBoxSecondYears.Text = NumberManipulator.AddZero(DateTime.Now.Year);

        //    TextBoxSecondHours.Text = NumberManipulator.AddZero(DateTime.Now.Hour);
        //    TextBoxSecondMinutes.Text = NumberManipulator.AddZero(DateTime.Now.Minute);
        //    TextBoxSecondSeconds.Text = NumberManipulator.AddZero(DateTime.Now.Second);
        //}

        //private void ButtonAddTime_Click(object sender, EventArgs e)
        //{
        //    int daysInSeconds;
        //    try
        //    {
        //        DateTime firstDate = new DateTime(Convert.ToInt32(TextBoxFirstYears.Text), Convert.ToInt32(TextBoxFirstMonths.Text),
        //                                          Convert.ToInt32(TextBoxFirstDays.Text), Convert.ToInt32(TextBoxFirstHours.Text),
        //                                          Convert.ToInt32(TextBoxFirstMinutes.Text), Convert.ToInt32(TextBoxFirstSeconds.Text));

        //        DateTime secondDate = new DateTime(Convert.ToInt32(TextBoxSecondYears.Text), Convert.ToInt32(TextBoxSecondMonths.Text),
        //                                           Convert.ToInt32(TextBoxSecondDays.Text), Convert.ToInt32(TextBoxSecondHours.Text),
        //                                           Convert.ToInt32(TextBoxSecondMinutes.Text), Convert.ToInt32(TextBoxSecondSeconds.Text));

        //        TimeSpan differenseDate = secondDate - firstDate;

        //        if (differenseDate.Days > 0)
        //            daysInSeconds = differenseDate.Days * 24 * 60 * 60;
        //        else
        //            daysInSeconds = 0;

        //        allSeconds += (differenseDate.Hours * 60 * 60) + (differenseDate.Minutes * 60) + (differenseDate.Seconds) + daysInSeconds;
        //        thisWeekSeconds += (differenseDate.Hours * 60 * 60) + (differenseDate.Minutes * 60) + (differenseDate.Seconds) + daysInSeconds;
        //        todaySeconds += (differenseDate.Hours * 60 * 60) + (differenseDate.Minutes * 60) + (differenseDate.Seconds) + daysInSeconds;

        //        int nowSeconds = (differenseDate.Hours * 60 * 60) + (differenseDate.Minutes * 60) + (differenseDate.Seconds) + daysInSeconds;
        //        var seconds = TimeSpan.FromSeconds(nowSeconds);
        //        string spent = "";
        //        if (seconds.Hours != 0)
        //            spent += $"{seconds.Hours} ч. ";
        //        if (seconds.Minutes != 0)
        //            spent += $"{seconds.Minutes} мин. ";
        //        if (seconds.Seconds != 0)
        //            spent += $"{seconds.Seconds} сек.";
        //        if (spent == "")
        //            spent = "0 сек.";
        //        string saveHistory = HistoryTextBox.Text;
        //        HistoryTextBox.Text = "";
        //        HistoryTextBox.Text += $"ОТ {TextBoxFirstDays.Text}.{TextBoxFirstMonths.Text}.{TextBoxFirstYears.Text} {TextBoxFirstHours.Text}:{TextBoxFirstMinutes.Text}:{TextBoxFirstSeconds.Text}\n" +
        //                               $"ДО {TextBoxSecondDays.Text}.{TextBoxSecondMonths.Text}.{TextBoxSecondYears.Text} {TextBoxSecondHours.Text}:{TextBoxSecondMinutes.Text}:{TextBoxSecondSeconds.Text}\n" +
        //                               $"ПОТРАЧЕНО {spent}\n\n";
        //        HistoryTextBox.Text += saveHistory;

        //        TextBoxAllThis_Show();
        //    }
        //    catch { }
        //}

        //private void ButtonClearAll_Click(object sender, EventArgs e)
        //{
        //    allSeconds = 0;
        //    thisWeekSeconds = 0;
        //    todaySeconds = 0;

        //    TextBoxAllThis_Show();
        //}

        //private void ButtonClearThisWeek_Click(object sender, EventArgs e)
        //{
        //    allSeconds -= thisWeekSeconds;
        //    thisWeekSeconds = 0;
        //    todaySeconds = 0;

        //    TextBoxAllThis_Show();
        //}

        //private void ButtonClearToday_Click(object sender, EventArgs e)
        //{
        //    allSeconds -= todaySeconds;
        //    thisWeekSeconds -= todaySeconds;
        //    todaySeconds = 0;

        //    TextBoxAllThis_Show();
        //}

        //private void ButtonDelete_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (TextBoxDelete.Text != "")
        //            Directory.Delete(pathToDir + "\\" + TextBoxDelete.Text, true);

        //        selectedItem = null;

        //        FromDirToListBox();

        //        VisiblityCheck();
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Такого элемента не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        //private void ButtonChange_Click(object sender, EventArgs e)
        //{
        //    string pathToOldFile = pathToDir + "\\" + TextBoxOldName.Text;
        //    string pathToNewFile = pathToDir + "\\" + TextBoxNewName.Text;
        //    try
        //    {
        //        if (TextBoxOldName.Text != "" && TextBoxNewName.Text != "" && TextBoxOldName.Text != TextBoxNewName.Text)
        //            Directory.Move(pathToOldFile, pathToNewFile);
        //        FromDirToListBox();
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Такого элемента не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //    if (selectedItem == TextBoxOldName.Text)
        //        selectedItem = TextBoxNewName.Text;
        //}

        //private void ButtonAddItem_Click(object sender, EventArgs e)
        //{
        //    string pathToFile = pathToDir + "\\" + TextBoxAddItem.Text;

        //    if (!Directory.Exists(pathToFile) && TextBoxAddItem.Text != "")
        //    {
        //        Directory.CreateDirectory(pathToFile);
        //        CreateEmptyFiles(TextBoxAddItem.Text);
        //        FromDirToListBox();
        //    }
        //    else if (Directory.Exists(pathToFile) && TextBoxAddItem.Text != "")
        //        MessageBox.Show("Такой элемент уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //    listBox1.SelectedItem = TextBoxAddItem.Text;
        //}
    }
}
