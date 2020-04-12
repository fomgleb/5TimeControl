using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TimeControl
{
    public partial class Form1 : Form
    {
        int AllSecond;
        int ThisWeekSecond;
        int TodaySecond;
        int numberDayOfWeek;
        int numberDayOfYear;
        string selectedItem;

        SqlConnection sqlConnection;

        public Form1()
        {
            InitializeComponent();
            
            TextBoxAllThis_Show();
        }

        void NumberDayOfWeek_Update()
        {
            var dayOfWeek = DateTime.Now.DayOfWeek;
            var numberDayOfWeek2 = NumberManipulator.GetNumberDayOfWeek(dayOfWeek);

            if (numberDayOfWeek > numberDayOfWeek2)
            {
                numberDayOfWeek = numberDayOfWeek2;
                ThisWeekSecond = 0;

                TextBoxAllThis_Show();
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
                TodaySecond = 0;

                TextBoxAllThis_Show();
            }
        }

        void TextBoxAllThis_Show()
        {
            if (AllSecond < 0)
                AllSecond = 0;
            if (ThisWeekSecond < 0)
                ThisWeekSecond = 0;
            if (TodaySecond < 0)
                TodaySecond = 0;

            var aSeconds = TimeSpan.FromSeconds(AllSecond);
            var twSeconds = TimeSpan.FromSeconds(ThisWeekSecond);
            var tSeconds = TimeSpan.FromSeconds(TodaySecond);

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
                TextBoxAllHour.Text = NumberManipulator.AddZero((aDay * 24) + aHour);
            else
                TextBoxAllHour.Text = NumberManipulator.AddZero(aHour);
            TextBoxAllMinute.Text = NumberManipulator.AddZero(aMinute);
            TextBoxAllSecond.Text = NumberManipulator.AddZero(aSecond);

            if (twDay > 0)
                TextBoxThisWeekHour.Text = NumberManipulator.AddZero((twDay * 24) + twHour);
            else
                TextBoxThisWeekHour.Text = NumberManipulator.AddZero(twHour);
            TextBoxThisWeekMinute.Text = NumberManipulator.AddZero(twMinute);
            TextBoxThisWeekSecond.Text = NumberManipulator.AddZero(twSecond);

            if (tDay > 0)
                TextBoxTodayHour.Text = NumberManipulator.AddZero((tDay * 24) + tHour);
            else
                TextBoxTodayHour.Text = NumberManipulator.AddZero(tHour);
            TextBoxTodayMinute.Text = NumberManipulator.AddZero(tMinute);
            TextBoxTodaySecond.Text = NumberManipulator.AddZero(tSecond);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.TimeSaveDataBaseConnectionString;

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            listBox1_Update();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveItem(selectedItem);
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (selectedItem == null)
                    selectedItem = listBox1.SelectedItem.ToString();
                else
                {
                    SaveItem(selectedItem);
                    selectedItem = listBox1.SelectedItem.ToString();
                }

                LabelSelect.Visible = false;
                GroupBoxAdd.Visible = true;
                GroupBoxTime.Visible = true;

                TextBoxDelete.Text = selectedItem;
                TextBoxOldName.Text = selectedItem;
            }
            catch { }

            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand($"SELECT * FROM [TextBoxes] WHERE [Name]=@SelectName", sqlConnection);

            command.Parameters.AddWithValue("SelectName", selectedItem);

            try
            {
                sqlReader = command.ExecuteReader();

                while (sqlReader.Read())
                {
                    TextBoxFirstYear.Text = NumberManipulator.AddZero(Convert.ToInt32(sqlReader["FirstYear"]));
                    TextBoxFirstMonth.Text = NumberManipulator.AddZero(Convert.ToInt32(sqlReader["FirstMonth"]));
                    TextBoxFirstDay.Text = NumberManipulator.AddZero(Convert.ToInt32(sqlReader["FirstDay"]));
                    TextBoxFirstHour.Text = NumberManipulator.AddZero(Convert.ToInt32(sqlReader["FirstHour"]));
                    TextBoxFirstMinute.Text = NumberManipulator.AddZero(Convert.ToInt32(sqlReader["FirstMinute"]));
                    TextBoxFirstSecond.Text = NumberManipulator.AddZero(Convert.ToInt32(sqlReader["FirstSecond"]));
                    TextBoxSecondYear.Text = NumberManipulator.AddZero(Convert.ToInt32(sqlReader["SecondYear"]));
                    TextBoxSecondMonth.Text = NumberManipulator.AddZero(Convert.ToInt32(sqlReader["SecondMonth"]));
                    TextBoxSecondDay.Text = NumberManipulator.AddZero(Convert.ToInt32(sqlReader["SecondDay"]));
                    TextBoxSecondHour.Text = NumberManipulator.AddZero(Convert.ToInt32(sqlReader["SecondHour"]));
                    TextBoxSecondMinute.Text = NumberManipulator.AddZero(Convert.ToInt32(sqlReader["SecondMinute"]));
                    TextBoxSecondSecond.Text = NumberManipulator.AddZero(Convert.ToInt32(sqlReader["SecondSecond"]));
                    AllSecond = Convert.ToInt32(sqlReader["AllSecond"]);
                    ThisWeekSecond = Convert.ToInt32(sqlReader["ThisWeekSecond"]);
                    TodaySecond = Convert.ToInt32(sqlReader["TodaySecond"]);
                    numberDayOfWeek = Convert.ToInt32(sqlReader["NumberWeek"]);
                    numberDayOfYear = Convert.ToInt32(sqlReader["NumberDay"]);

                    NumberDayOfWeek_Update();
                    NumberDayOfYear_Update();

                    TextBoxAllThis_Show();
                }
            }
            catch (Exception) { }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }
    }
}
