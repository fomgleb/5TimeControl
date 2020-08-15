using System;
using System.Globalization;
using System.Windows.Forms;

namespace TimeControl.Forms
{
    public partial class TimeSpentForm : Form
    {
        string selectedDirectory;

        public TimeSpentForm(string selectedDirectory)
        {
            InitializeComponent();

            this.selectedDirectory = selectedDirectory;

            

            LoadAllDatas();
        }

        private void LoadAllDatas()
        {
            Label[] labels = new Label[13] { totalLabel, thisYearLabel, thisMonthLabel, thisWeekLabel, todayLabel, lastYearLabel, lastMonthLabel, lastWeekLabel, yesterdayLabel, maxInYearLabel, maxInMonthLabel,
                                             maxInWeekLabel, maxInDayLabel };

            SetAllTimeSpent();

            SetMaximumTimeSpent();

            for (int i = 0; i < labels.Length; i++)
            {
                TimeSpan timeSpan = TimeSpan.FromSeconds(Convert.ToInt32(Storage.Load(selectedDirectory, Storage.allIntegerFileNames[i])));
                labels[i].Text = $"{NumberManipulator.AddZero(timeSpan.Hours + timeSpan.Days * 24)}:{NumberManipulator.AddZero(timeSpan.Minutes)}:{NumberManipulator.AddZero(timeSpan.Seconds)}";
            }
        }

        private void SetAllTimeSpent()
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            if (Storage.Load(selectedDirectory, "Date") != "") // если в файле с датой что-то есть
            {
                // дни
                string date = Storage.Load(selectedDirectory, "Date");
                if (date != DateTime.Now.Date.ToString()) // если файл с датой не равняется сегодняшней датой
                {
                    if (date == DateTime.Now.Date.AddDays(-1).ToString()) // если файл с датой равняется вчерашнему дню
                        Storage.Save(selectedDirectory, "YesterdaySeconds", Storage.Load(selectedDirectory, "TodaySeconds")); // то копируем время из сегодня в вчера
                    else
                        Storage.Save(selectedDirectory, "YesterdaySeconds", "0"); // то потраченое врема вчера = 0
                    Storage.Save(selectedDirectory, "TodaySeconds", "0"); // записываем в файл с сегодняшним потраченым временем цыфру 0
                }

                // месяцы
                date = Storage.Load(selectedDirectory, "Date").Remove(0, 2).Insert(0, "1").Insert(0, "0"); // дата, но дни равняются нулю
                DateTime nowDate = DateTime.Now.Date.AddDays(-(DateTime.Now.Day-1)); // дата которая сейчас, но только дни равняются нулю
                if (date != nowDate.ToString()) // если файл с датой не равняется сегодняшней датой
                {
                    if (date == nowDate.AddMonths(-1).ToString()) // если файл с датой равняется прошлому месяцу
                        Storage.Save(selectedDirectory, "LastMonthSeconds", Storage.Load(selectedDirectory, "ThisMonthSeconds")); // то копируем время из сегодняшнего месяца в прошлый месяц
                    else
                        Storage.Save(selectedDirectory, "LastMonthSeconds", "0"); // то потраченое врема вчера = 0
                    Storage.Save(selectedDirectory, "ThisMonthSeconds", "0"); // записываем в файл с сегодняшним потраченым временем цыфру 0
                }

                // годы
                date = Convert.ToDateTime(Storage.Load(selectedDirectory, "Date")).Year.ToString();
                if (date != DateTime.Now.Year.ToString()) // если файл с датой не равняется сегодняшней датой
                {
                    if (date == (DateTime.Now.Year-1).ToString()) // если файл с датой равняется прошлому месяцу
                        Storage.Save(selectedDirectory, "LastYearSeconds", Storage.Load(selectedDirectory, "ThisYearSeconds")); // то копируем время из сегодняшнего месяца в прошлый месяц
                    else
                        Storage.Save(selectedDirectory, "LastYearSeconds", "0"); // то потраченое врема вчера = 0
                    Storage.Save(selectedDirectory, "ThisYearSeconds", "0"); // записываем в файл с сегодняшним потраченым временем цыфру 0
                }

                // недели
                if (Storage.Load(selectedDirectory, "WeekOfYear") != "")
                {
                    int weekOfYear = Convert.ToInt32(Storage.Load(selectedDirectory, "WeekOfYear"));
                    if (weekOfYear != dfi.Calendar.GetWeekOfYear(DateTime.Now, dfi.CalendarWeekRule, dfi.FirstDayOfWeek)) // если файл с номером недели в году не равняется сегодняшнему номеру недели в году
                    {
                        if (weekOfYear == dfi.Calendar.GetWeekOfYear(DateTime.Now, dfi.CalendarWeekRule, dfi.FirstDayOfWeek) - 1)
                            Storage.Save(selectedDirectory, "LastWeekSeconds", Storage.Load(selectedDirectory, "ThisWeekSeconds"));
                        else
                            Storage.Save(selectedDirectory, "LastWeekSeconds", "0");
                        Storage.Save(selectedDirectory, "ThisWeekSeconds", "0");
                    }
                }
            }
            Storage.Save(selectedDirectory, "WeekOfYear", dfi.Calendar.GetWeekOfYear(DateTime.Now, dfi.CalendarWeekRule, dfi.FirstDayOfWeek).ToString()); // номер недели в году
            Storage.Save(selectedDirectory, "Date", DateTime.Now.Date.ToString()); // записываем в файл сегодняшнюю дату
        }

        private void SetMaximumTimeSpent()
        {
            string[] allMaxFileNames = new string[4] { "MaxInYearSeconds", "MaxInMonthSeconds", "MaxInWeekSeconds", "MaxInDaySeconds" };
            string[] allThisFileNames = new string[4] { "ThisYearSeconds", "ThisMonthSeconds", "ThisWeekSeconds", "TodaySeconds" };

            for (int i = 0; i < allMaxFileNames.Length; i++)
            {
                int maxSeconds = Convert.ToInt32(Storage.Load(selectedDirectory, allMaxFileNames[i]));
                int thisSeconds = Convert.ToInt32(Storage.Load(selectedDirectory, allThisFileNames[i]));

                if (thisSeconds > maxSeconds)
                    Storage.Save(selectedDirectory, allMaxFileNames[i], thisSeconds.ToString());
            }       
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            SubtractForm subtractForm = new SubtractForm(selectedDirectory);
            subtractForm.ShowDialog();

            LoadAllDatas();
        }
    }
}
