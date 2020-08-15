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
    public partial class EditForm : Form
    {
        public string NewDirectoryName { get; private set; }

        string oldDirectoryName;

        public EditForm(string oldDirectoryName)
        {
            InitializeComponent();

            this.oldDirectoryName = oldDirectoryName;
            nameTextBox.Text = oldDirectoryName;
            NewDirectoryName = nameTextBox.Text;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Storage.ChangeDirectoryName(oldDirectoryName, nameTextBox.Text);
            NewDirectoryName = nameTextBox.Text;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
