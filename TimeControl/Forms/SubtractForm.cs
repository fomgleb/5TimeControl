using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeControl.Forms
{
    public partial class SubtractForm : Form
    {
        string selectedDirectory;

        public SubtractForm(string selectedDirectory)
        {
            InitializeComponent();

            this.selectedDirectory = selectedDirectory;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string[] thisSecondsFileNamesArray = new string[5] { "TotalSeconds", "ThisYearSeconds", "ThisMonthSeconds", "ThisWeekSeconds", "TodaySeconds" }; // массив названий файлов которые будем использовать
            int subtractedSeconds = Convert.ToInt32(hoursNumeric.Value) * 60 * 60 + Convert.ToInt32(minutesNumeric.Value) * 60 + Convert.ToInt32(secondsNumeric.Value); // секунды которые нужно отнять от значений в файлах
            foreach (var fileName in thisSecondsFileNamesArray)
            {
                int fileSeconds = Convert.ToInt32(Storage.Load(selectedDirectory, fileName));
                if (fileSeconds - subtractedSeconds >= 0)
                    Storage.Save(selectedDirectory, fileName, (fileSeconds - subtractedSeconds).ToString()); // отнимаем, сохраняем
                else
                    Storage.Save(selectedDirectory, fileName, "0");
            }

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
