using System;
using System.Windows.Forms;

namespace TimeControl.Forms
{
    public partial class AddForm : Form
    {
        public string AddedDirectory { get; private set; }

        public AddForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Storage.CreateDirectory(nameTextBox.Text);
            AddedDirectory = nameTextBox.Text;
            Close();
        }
    }
}
