using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Textbook_Instant_Access
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            quickAccessBox.Items.Add(addTextBox.Text);
        }

        private void quickAccessBox_doubleClick(object sender, EventArgs e)
        {
            string selectItem = quickAccessBox.SelectedItem.ToString();
            if (selectItem != "")
            {
                Process.Start(selectItem);
            }
            else
            {
                MessageBox.Show("No Path Entered.");
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            String path = fileDialog.FileName;
            addTextBox.Text = path;
            fileDialog.Dispose();

        }
    }
}
