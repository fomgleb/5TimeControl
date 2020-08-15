using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using TimeControl.Forms;

namespace TimeControl
{
    public partial class MainForm : Form
    {
        int[] nowDateTime = new int[6];
        bool started = false, ended = false;
        string savedDirectorySelection;

        readonly public string pathToMainDir = Environment.CurrentDirectory + "\\TimeControlSaves";

        public MainForm()
        {
            InitializeComponent();

            Storage.CreateMainDirectory();
            ShowItemsInListBox();

            listBox.SelectedItem = Properties.Settings.Default.SelectedDirectory;

            if (listBox.SelectedItem != null)
            {
                TimeSpentForm timeSpentForm = new TimeSpentForm(listBox.SelectedItem.ToString());
                timeSpentForm.Close();
            }
        }

        public void ShowItemsInListBox()
        {
            List<string> selectableItems = GetSelectableItems();
            listBox.Items.Clear();
            foreach (var item in selectableItems) // запихивание айтэмов в лист бокс, чтобы из них потом выбирать
                listBox.Items.Add(item);
        }

        private void AllButtons_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            switch (button.Name)
            {
                case "startButton":
                    started = true;
                    SetStartVisiblity(true);
                    startTimeTextBox.Text = DateTime.Now.ToString().Split(' ')[1];
                    startDateTextBox.Text = DateTime.Now.ToString().Split(' ')[0];
                    break;

                case "endButton":
                    ended = true;
                    SetEndVisiblity(true);
                    endTimeTextBox.Text = DateTime.Now.ToString().Split(' ')[1];
                    endDateTextBox.Text = DateTime.Now.ToString().Split(' ')[0];
                    break;

                case "cancelButton":
                    ended = false;
                    started = false;
                    startPanel.Visible = false;
                    endButton.Visible = false;
                    endPanel.Visible = false;
                    confirmButton.Visible = false;
                    cancelButton.Visible = false;
                    break;

                case "confirmButton":
                    int daysInSeconds;
                    try
                    {
                        DateTime startDateTime = new DateTime(Convert.ToInt32(startDateTextBox.Text.Split('.')[2]), Convert.ToInt32(startDateTextBox.Text.Split('.')[1]), Convert.ToInt32(startDateTextBox.Text.Split('.')[0]),
                                                              Convert.ToInt32(startTimeTextBox.Text.Split(':')[0]), Convert.ToInt32(startTimeTextBox.Text.Split(':')[1]), Convert.ToInt32(startTimeTextBox.Text.Split(':')[2]));

                        DateTime endDateTime = new DateTime(Convert.ToInt32(endDateTextBox.Text.Split('.')[2]), Convert.ToInt32(endDateTextBox.Text.Split('.')[1]), Convert.ToInt32(endDateTextBox.Text.Split('.')[0]),
                                                            Convert.ToInt32(endTimeTextBox.Text.Split(':')[0]), Convert.ToInt32(endTimeTextBox.Text.Split(':')[1]), Convert.ToInt32(endTimeTextBox.Text.Split(':')[2]));

                        TimeSpan differenseDate = endDateTime - startDateTime;

                        if (differenseDate.Days > 0)
                            daysInSeconds = differenseDate.Days * 24 * 60 * 60;
                        else
                            daysInSeconds = 0;

                        string[] thisSecondsFileNames = new string[5] { "TotalSeconds", "ThisYearSeconds", "ThisMonthSeconds", "ThisWeekSeconds", "TodaySeconds" };

                        foreach (var fileName in thisSecondsFileNames)
                            Storage.Save(listBox.SelectedItem.ToString(), fileName, Convert.ToString(Convert.ToInt32(Storage.Load(listBox.SelectedItem.ToString(), fileName)) + 
                                    (differenseDate.Hours * 60 * 60) + (differenseDate.Minutes * 60) + (differenseDate.Seconds) + daysInSeconds));

                        //totalSeconds += (differenseDate.Hours * 60 * 60) + (differenseDate.Minutes * 60) + (differenseDate.Seconds) + daysInSeconds;
                        //thisYearSeconds += (differenseDate.Hours * 60 * 60) + (differenseDate.Minutes * 60) + (differenseDate.Seconds) + daysInSeconds;
                        //thisMonthSeconds += (differenseDate.Hours * 60 * 60) + (differenseDate.Minutes * 60) + (differenseDate.Seconds) + daysInSeconds;
                        //thisWeekSeconds += (differenseDate.Hours * 60 * 60) + (differenseDate.Minutes * 60) + (differenseDate.Seconds) + daysInSeconds;
                        //todaySeconds += (differenseDate.Hours * 60 * 60) + (differenseDate.Minutes * 60) + (differenseDate.Seconds) + daysInSeconds;

                        int nowSeconds = (differenseDate.Hours * 60 * 60) + (differenseDate.Minutes * 60) + (differenseDate.Seconds) + daysInSeconds;
                        var seconds = TimeSpan.FromSeconds(nowSeconds);
                        string spent = "";
                        if (seconds.Hours != 0)
                            spent += $"{seconds.Hours} ч. ";
                        if (seconds.Minutes != 0)
                            spent += $"{seconds.Minutes} мин. ";
                        if (seconds.Seconds != 0)
                            spent += $"{seconds.Seconds} сек.";
                        if (spent == "")
                            spent = "0 сек.";
                        string saveHistory = historyRichTextBox.Text;
                        historyRichTextBox.Text = "";
                        historyRichTextBox.Text += $"ОТ {startDateTextBox.Text} {startTimeTextBox.Text}\n" +
                                                   $"ДО {endDateTextBox.Text} {endTimeTextBox.Text}\n" +
                                                   $"ПОТРАЧЕНО {spent}\n\n";
                        historyRichTextBox.Text += saveHistory;

                        TimeSpentForm timeSpentForm1 = new TimeSpentForm(listBox.SelectedItem.ToString());
                        timeSpentForm1.Close();
                    }
                    catch 
                    {
                        ended = true;
                        started = true;
                        startPanel.Visible = true;
                        endButton.Visible = true;
                        endPanel.Visible = true;
                        confirmButton.Visible = true;
                        cancelButton.Visible = true;
                        break;
                    }
                    ended = false;
                    started = false;
                    startPanel.Visible = false;
                    endButton.Visible = false;
                    endPanel.Visible = false;
                    confirmButton.Visible = false;
                    cancelButton.Visible = false;
                    break;

                case "addButton":
                    AddForm addForm = new AddForm();
                    addForm.ShowDialog();
                    if (addForm.AddedDirectory != null)
                    {
                        ShowItemsInListBox();
                        listBox.SelectedItem = addForm.AddedDirectory;
                    }
                    break;

                case "deleteButton":
                    if (listBox.SelectedItem != null)
                    {
                        DialogResult dialogResult = MessageBox.Show($"Delete {listBox.SelectedItem} item?", "Deleting", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Storage.DeleteDirectory(listBox.SelectedItem.ToString());
                            ShowItemsInListBox();
                            savedDirectorySelection = null;
                            if (listBox.Items.Count > 0)
                                listBox.SelectedIndex = 0;
                            else
                            {
                                mainTableLayoutPanel.Visible = false;
                                historyTableLayoutPanel.Visible = false;
                            }
                        }
                    }
                    break;

                case "editButton":
                    if (listBox.SelectedItem != null)
                    {
                        EditForm editForm = new EditForm(listBox.SelectedItem.ToString());
                        editForm.ShowDialog();

                        ShowItemsInListBox();
                        savedDirectorySelection = editForm.NewDirectoryName;
                        listBox.SelectedItem = editForm.NewDirectoryName; 
                    }
                    break;

                case "showSpentButton":
                    TimeSpentForm timeSpentForm = new TimeSpentForm(listBox.SelectedItem.ToString());
                    timeSpentForm.ShowDialog();
                    timeSpentForm.Close();
                    break;
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null) // если в списке выбран один элемент
            {
                if (savedDirectorySelection != null) // если до этого выбраный элемент не равнялся ничему
                    SaveAllDatas(savedDirectorySelection);

                savedDirectorySelection = listBox.SelectedItem.ToString(); // новый выбраный элемент

                LoadAllDatas(savedDirectorySelection);

                if (started == true)
                {
                    SetStartVisiblity(true);
                    if (ended == true)
                        SetEndVisiblity(true);
                    else
                        SetEndVisiblity(false);
                }
                else
                    SetStartVisiblity(false);

                mainTableLayoutPanel.Visible = true;
                historyTableLayoutPanel.Visible = true;
            }
        }

        #region VisiblityController
        private void SetStartVisiblity(bool pressedStartButton)
        {
            if (pressedStartButton == true)
            {
                endButton.Visible = true;
                startPanel.Visible = true;
                cancelButton.Visible = true;
            }
            else
            {
                startPanel.Visible = false;
                endButton.Visible = false;
                endPanel.Visible = false;
                confirmButton.Visible = false;
                cancelButton.Visible = false;
            }
        }

        private void SetEndVisiblity(bool pressedEndButton)
        {
            if (pressedEndButton == true)
            {
                endButton.Visible = true;
                startPanel.Visible = true;
                endPanel.Visible = true;
                cancelButton.Visible = true;
                confirmButton.Visible = true;
            }
            else
            {
                endPanel.Visible = false;
                confirmButton.Visible = false;
            }
        }
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listBox.SelectedItem != null)
                SaveAllDatas(listBox.SelectedItem.ToString());
        }

        private List<string> GetSelectableItems()
        {
            string[] items = Directory.GetDirectories(pathToMainDir);
            List<string> result = new List<string>();

            foreach (string item in items)
                result.Add(new DirectoryInfo(item).Name);
            return result;
        }

        private void SaveAllDatas(string selectedDirectory)
        {
            string[] allDatas = new string[7] { startTimeTextBox.Text, startDateTextBox.Text, endTimeTextBox.Text, endDateTextBox.Text, historyRichTextBox.Text, started.ToString(), ended.ToString(),
                                                 /*totalSeconds.ToString(), thisYearSeconds.ToString(), thisMonthSeconds.ToString(), thisWeekSeconds.ToString(), todaySeconds.ToString()*/};

            for (int i = 0; i < allDatas.Length; i++) // сохраняем данные в файлы
                Storage.Save(selectedDirectory, Storage.allFileNamesForMainForm[i], allDatas[i]);

            Properties.Settings.Default.SelectedDirectory = selectedDirectory;
            Properties.Settings.Default.Save();
        }

        private void LoadAllDatas(string selectedDirectory)
        {
            startTimeTextBox.Text = Storage.Load(selectedDirectory, "StartTime"); // спросить про этот кусок кода у стековерфлова
            startDateTextBox.Text = Storage.Load(selectedDirectory, "StartDate");
            endTimeTextBox.Text = Storage.Load(selectedDirectory, "EndTime");
            endDateTextBox.Text = Storage.Load(selectedDirectory, "EndDate");
            historyRichTextBox.Text = (Storage.Load(selectedDirectory, "History"));
            started = Convert.ToBoolean(Storage.Load(selectedDirectory, "Started"));
            ended = Convert.ToBoolean(Storage.Load(selectedDirectory, "Ended"));
            //totalSeconds = Convert.ToInt32(Storage.Load(selectedDirectory, "TotalSeconds"));
            //thisYearSeconds = Convert.ToInt32(Storage.Load(selectedDirectory, "ThisYearSeconds"));
            //thisMonthSeconds = Convert.ToInt32(Storage.Load(selectedDirectory, "ThisMonthSeconds"));
            //thisWeekSeconds = Convert.ToInt32(Storage.Load(selectedDirectory, "ThisWeekSeconds"));
            //todaySeconds = Convert.ToInt32(Storage.Load(selectedDirectory, "TodaySeconds"));
        }

        //void NumberDayOfWeek_Update()
        //{
        //    var dayOfWeek = DateTime.Now.DayOfWeek;
        //    var numberDayOfWeek2 = NumberManipulator.GetNumberDayOfWeek(dayOfWeek);

        //    if (numberDayOfWeek > numberDayOfWeek2)
        //    {
        //        numberDayOfWeek = numberDayOfWeek2;
        //        thisWeekSeconds = 0;
        //    }
        //    else
        //        numberDayOfWeek = numberDayOfWeek2;
        //}

        //void NumberDayOfYear_Update()
        //{
        //    var numberDayOfYear2 = DateTime.Now.DayOfYear;

        //    if (numberDayOfYear != numberDayOfYear2)
        //    {
        //        numberDayOfYear = numberDayOfYear2;
        //        todaySeconds = 0;
        //    }
        //}

        //void TextBoxAllThis_Show()
        //{
        //    if (allSeconds < 0)
        //        allSeconds = 0;
        //    if (thisWeekSeconds < 0)
        //        thisWeekSeconds = 0;
        //    if (todaySeconds < 0)
        //        todaySeconds = 0;

        //    var aSeconds = TimeSpan.FromSeconds(allSeconds);
        //    var twSeconds = TimeSpan.FromSeconds(thisWeekSeconds);
        //    var tSeconds = TimeSpan.FromSeconds(todaySeconds);

        //    if (aSeconds.Days > 0)
        //        TextBoxAllHours.Text = NumberManipulator.AddZero((aSeconds.Days * 24) + aSeconds.Hours);
        //    else
        //        TextBoxAllHours.Text = NumberManipulator.AddZero(aSeconds.Hours);
        //    TextBoxAllMinutes.Text = NumberManipulator.AddZero(aSeconds.Minutes);
        //    TextBoxAllSeconds.Text = NumberManipulator.AddZero(aSeconds.Seconds);

        //    if (twSeconds.Days > 0)
        //        TextBoxThisWeekHours.Text = NumberManipulator.AddZero((twSeconds.Days * 24) + twSeconds.Hours);
        //    else
        //        TextBoxThisWeekHours.Text = NumberManipulator.AddZero(twSeconds.Hours);
        //    TextBoxThisWeekMinutes.Text = NumberManipulator.AddZero(twSeconds.Minutes);
        //    TextBoxThisWeekSeconds.Text = NumberManipulator.AddZero(twSeconds.Seconds);

        //    if (tSeconds.Days > 0)
        //        TextBoxTodayHours.Text = NumberManipulator.AddZero((tSeconds.Days * 24) + tSeconds.Hours);
        //    else
        //        TextBoxTodayHours.Text = NumberManipulator.AddZero(tSeconds.Hours);
        //    TextBoxTodayMinutes.Text = NumberManipulator.AddZero(tSeconds.Minutes);
        //    TextBoxTodaySeconds.Text = NumberManipulator.AddZero(tSeconds.Seconds);
        //}

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    if (!Directory.Exists(pathToDir))
        //        Directory.CreateDirectory(pathToDir);

        //    FromDirToListBox();
        //}

        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (selectedItem != null)
        //    {
        //        FromTextBoxesToFiles(selectedItem);
        //    }
        //}

        //private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (listBox1.SelectedItem != null)
        //    {
        //        if (selectedItem == null)
        //            selectedItem = listBox1.SelectedItem.ToString();
        //        else
        //        {
        //            FromTextBoxesToFiles(selectedItem);
        //            selectedItem = listBox1.SelectedItem.ToString();
        //        }

        //        VisiblityCheck();

        //        TextBoxDelete.Text = selectedItem;
        //        TextBoxOldName.Text = selectedItem;

        //        FromFilesToTextBoxes(selectedItem);
        //        NumberDayOfWeek_Update();
        //        NumberDayOfYear_Update();
        //        FromTextBoxesToFiles(selectedItem);

        //        TextBoxAllThis_Show();
        //    }
        //}

        //private void VisiblityCheck()
        //{
        //    if (listBox1.Items.Count <= 0)
        //    {
        //        LabelAdd.Visible = true;
        //        LabelSelect.Visible = GroupBoxAdd.Visible = GroupBoxTime.Visible = HistoryTextBox.Visible = HistoryLabel.Visible = false;
        //    }
        //    else if (listBox1.SelectedItem == null)
        //    {
        //        LabelSelect.Visible = true;
        //        LabelAdd.Visible = GroupBoxAdd.Visible = GroupBoxTime.Visible = HistoryTextBox.Visible = HistoryLabel.Visible = false;
        //    }
        //    else
        //    {
        //        LabelAdd.Visible = LabelSelect.Visible = false;
        //        GroupBoxAdd.Visible = GroupBoxTime.Visible = HistoryTextBox.Visible = HistoryLabel.Visible = true;
        //    }
        //}

        //private void общиеЗначенияToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}
    }
}
