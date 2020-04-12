using System;
using System.Data.SqlClient;

namespace TimeControl
{
    public partial class Form1
    {
        private void ButtonSetNowFirst_Click(object sender, EventArgs e)
        {
            TextBoxFirstDay.Text = NumberManipulator.AddZero(DateTime.Now.Day);
            TextBoxFirstMonth.Text = NumberManipulator.AddZero(DateTime.Now.Month);
            TextBoxFirstYear.Text = NumberManipulator.AddZero(DateTime.Now.Year);

            TextBoxFirstHour.Text = NumberManipulator.AddZero(DateTime.Now.Hour);
            TextBoxFirstMinute.Text = NumberManipulator.AddZero(DateTime.Now.Minute);
            TextBoxFirstSecond.Text = NumberManipulator.AddZero(DateTime.Now.Second);
        }

        private void ButtonSetNowSecond_Click(object sender, EventArgs e)
        {
            TextBoxSecondDay.Text = NumberManipulator.AddZero(DateTime.Now.Day);
            TextBoxSecondMonth.Text = NumberManipulator.AddZero(DateTime.Now.Month);
            TextBoxSecondYear.Text = NumberManipulator.AddZero(DateTime.Now.Year);

            TextBoxSecondHour.Text = NumberManipulator.AddZero(DateTime.Now.Hour);
            TextBoxSecondMinute.Text = NumberManipulator.AddZero(DateTime.Now.Minute);
            TextBoxSecondSecond.Text = NumberManipulator.AddZero(DateTime.Now.Second);
        }

        private void ButtonAddTime_Click(object sender, EventArgs e)
        {
            int daysInSeconds;
            try
            {
                DateTime firstDate = new DateTime(Convert.ToInt32(TextBoxFirstYear.Text), Convert.ToInt32(TextBoxFirstMonth.Text),
                                                  Convert.ToInt32(TextBoxFirstDay.Text), Convert.ToInt32(TextBoxFirstHour.Text),
                                                  Convert.ToInt32(TextBoxFirstMinute.Text), Convert.ToInt32(TextBoxFirstSecond.Text));

                DateTime secondDate = new DateTime(Convert.ToInt32(TextBoxSecondYear.Text), Convert.ToInt32(TextBoxSecondMonth.Text),
                                                   Convert.ToInt32(TextBoxSecondDay.Text), Convert.ToInt32(TextBoxSecondHour.Text),
                                                   Convert.ToInt32(TextBoxSecondMinute.Text), Convert.ToInt32(TextBoxSecondSecond.Text));

                TimeSpan differenseDate = secondDate - firstDate;

                if (differenseDate.Days > 0)
                    daysInSeconds = differenseDate.Days * 24 * 60 * 60;
                else
                    daysInSeconds = 0;

                AllSecond += (differenseDate.Hours * 60 * 60) + (differenseDate.Minutes * 60) + (differenseDate.Seconds) + daysInSeconds;
                ThisWeekSecond += (differenseDate.Hours * 60 * 60) + (differenseDate.Minutes * 60) + (differenseDate.Seconds) + daysInSeconds;
                TodaySecond += (differenseDate.Hours * 60 * 60) + (differenseDate.Minutes * 60) + (differenseDate.Seconds) + daysInSeconds;

                TextBoxAllThis_Show();
            }
            catch { }
        }

        private void ButtonClearAll_Click(object sender, EventArgs e)
        {
            AllSecond = 0;
            ThisWeekSecond = 0;
            TodaySecond = 0;

            TextBoxAllThis_Show();
        }

        private void ButtonClearThisWeek_Click(object sender, EventArgs e)
        {
            AllSecond -= ThisWeekSecond;
            ThisWeekSecond = 0;
            TodaySecond = 0;

            TextBoxAllThis_Show();
        }

        private void ButtonClearToday_Click(object sender, EventArgs e)
        {
            AllSecond -= TodaySecond;
            ThisWeekSecond -= TodaySecond;
            TodaySecond = 0;

            TextBoxAllThis_Show();
        }

        private async void ButtonDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [TextBoxes] WHERE [Name]=@Name", sqlConnection);

            command.Parameters.AddWithValue("Name", TextBoxDelete.Text.Replace(" ", "_"));

            await command.ExecuteNonQueryAsync();

            listBox1_Update();
        }
        private void ButtonChange_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"SELECT * FROM [TextBoxes] WHERE (Name)=@Name", sqlConnection);
            command.Parameters.AddWithValue("Name", TextBoxNewName.Text.Replace(" ", "_"));
            int temp = Convert.ToInt16(command.ExecuteScalar());
            if (temp == 0)
            {
                command = new SqlCommand("UPDATE [TextBoxes] SET [Name]=@NewName WHERE [Name]=@OldName", sqlConnection);

                command.Parameters.AddWithValue("OldName", TextBoxOldName.Text.Replace(" ", "_"));
                command.Parameters.AddWithValue("NewName", TextBoxNewName.Text.Replace(" ", "_"));

                command.ExecuteNonQuery();

                selectedItem = TextBoxNewName.Text.Replace(" ", "_");

                listBox1_Update();
            }
        }

        private void ButtonAddName_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"SELECT * FROM [TextBoxes] WHERE (Name)=@Name", sqlConnection);
            command.Parameters.AddWithValue("Name", TextBoxAddName.Text.Replace(" ", "_"));
            int temp = Convert.ToInt16(command.ExecuteScalar());
            if (TextBoxAddName.Text != "" && temp == 0)
            {
                command = new SqlCommand("INSERT INTO [TextBoxes] (Name)VALUES(@Name)", sqlConnection);

                command.Parameters.AddWithValue("Name", TextBoxAddName.Text.Replace(" ", "_"));

                command.ExecuteNonQuery();

                listBox1_Update();
            }
        }
    }
}
