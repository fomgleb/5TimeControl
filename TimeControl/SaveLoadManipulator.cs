using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TimeControl
{
    public partial class Form1
    {
        void SaveItem(string Item)
        {
            try
            {
                SqlCommand command = new SqlCommand("UPDATE [TextBoxes] SET [FirstYear]=@NewFirstYear, [FirstMonth]=@NewFirstMonth," +
                                                                                       "[FirstDay]=@NewFirstDay, [FirstHour]=@NewFirstHour," +
                                                                                       "[FirstMinute]=@NewFirstMinute, [FirstSecond]=@NewFirstSecond," +
                                                                                       "[SecondYear]=@NewSecondYear, [SecondMonth]=@NewSecondMonth," +
                                                                                       "[SecondDay]=@NewSecondDay, [SecondHour]=@NewSecondHour," +
                                                                                       "[SecondMinute]=@NewSecondMinute, [SecondSecond]=@NewSecondSecond," +
                                                                                       $"[AllSecond]=@NewAllSecond, [ThisWeekSecond]=@NewThisWeekSecond, [TodaySecond]=@NewTodaySecond, [NumberWeek]=@NewNumberWeek, [NumberDay]=@NewNumberDay WHERE [Name]=@{Item}", sqlConnection);

                command.Parameters.AddWithValue("NewFirstYear", TextBoxFirstYear.Text);
                command.Parameters.AddWithValue("NewFirstMonth", TextBoxFirstMonth.Text);
                command.Parameters.AddWithValue("NewFirstDay", TextBoxFirstDay.Text);
                command.Parameters.AddWithValue("NewFirstHour", TextBoxFirstHour.Text);
                command.Parameters.AddWithValue("NewFirstMinute", TextBoxFirstMinute.Text);
                command.Parameters.AddWithValue("NewFirstSecond", TextBoxFirstSecond.Text);
                command.Parameters.AddWithValue("NewSecondYear", TextBoxSecondYear.Text);
                command.Parameters.AddWithValue("NewSecondMonth", TextBoxSecondMonth.Text);
                command.Parameters.AddWithValue("NewSecondDay", TextBoxSecondDay.Text);
                command.Parameters.AddWithValue("NewSecondHour", TextBoxSecondHour.Text);
                command.Parameters.AddWithValue("NewSecondMinute", TextBoxSecondMinute.Text);
                command.Parameters.AddWithValue("NewSecondSecond", TextBoxSecondSecond.Text);
                command.Parameters.AddWithValue("NewAllSecond", AllSecond);
                command.Parameters.AddWithValue("NewThisWeekSecond", ThisWeekSecond);
                command.Parameters.AddWithValue("NewTodaySecond", TodaySecond);
                command.Parameters.AddWithValue("NewNumberWeek", numberDayOfWeek);
                command.Parameters.AddWithValue("NewNumberDay", numberDayOfYear);
                command.Parameters.AddWithValue($"{Item}", Item);

                command.ExecuteNonQuery();
            }
            catch { }
        }

        void listBox1_Update()
        {
            listBox1.Items.Clear();

            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [TextBoxes]", sqlConnection);

            try
            {
                sqlReader = command.ExecuteReader();

                while (sqlReader.Read())
                {
                    listBox1.Items.Add(Convert.ToString(sqlReader["Name"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
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
            listBox1.SelectedItem = selectedItem;
        }
    }
}
