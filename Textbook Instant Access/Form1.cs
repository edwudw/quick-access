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
using System.Data.SQLite;

namespace Textbook_Instant_Access
{
    public partial class Form1 : Form
    {
        SQLiteConnection m_dbConnection;
        public Form1()
        {
            InitializeComponent();
            m_dbConnection = new SQLiteConnection("Data Source=paths.db;Version=3;");
            m_dbConnection.Open();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            quickAccessBox.Items.Add(addTextBox.Text);
            string sql = "insert into PATHS (PATH) values ('" + addTextBox.Text + "')";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
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
        private void formLoaded(object sender, EventArgs e)
        {
            // Read saved entries from database
            string sql = "select * from PATHS";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                quickAccessBox.Items.Add(reader["PATH"]);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            string selected = quickAccessBox.SelectedItem.ToString();
            quickAccessBox.Items.Remove(quickAccessBox.SelectedItem);
            string sql = "delete from PATHS where PATH = '" + selected + "'";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }
    }
}
