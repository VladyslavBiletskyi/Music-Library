using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Course.Forms
{
    public partial class AlbumSelect : Form
    {
        SqlConnection connection = new SqlConnection(MainForm.connectionString);
        DataTable dt = new DataTable();
        public AlbumSelect()
        {
            InitializeComponent();
            ColorScheme.ApplyColor(this);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((LinkLabel)sender).LinkVisited = true;
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name, Id FROM Album WHERE [Name] LIKE '" + ((LinkLabel)sender).Text + "%'", connection);
            dt = new DataTable();
            adapter.Fill(dt);
            listPerf.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++) listPerf.Items.Add((String)dt.Rows[i][0]);
            connection.Close();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchBox.Text == "") { MessageBox.Show("Ошибка! Не введен текст для поиска!"); return; }
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name, Id FROM Album WHERE [Name] LIKE '%" + searchBox.Text + "%'", connection);
            dt = new DataTable();
            adapter.Fill(dt);
            listPerf.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++) listPerf.Items.Add((String)dt.Rows[i][0]);
            connection.Close();
        }
        private void listPerf_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if ((string)dt.Rows[i][0] == (string)listPerf.SelectedItem) id =(int)dt.Rows[i][1];
            }
                if (listPerf.SelectedIndex != -1)
                {
                    var a = new Forms.Album(id);
                    try { a.Show(); }
                    catch { }
                    listPerf.ClearSelected();
                }
        }
        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) searchButton_Click(searchButton, new EventArgs());
        }
        private void allButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name, Id FROM Album ", connection);
            dt = new DataTable();
            adapter.Fill(dt);
            listPerf.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++) listPerf.Items.Add((String)dt.Rows[i][0]);
            connection.Close();
        }

        private void AlbumSelect_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm");
        }
    }
}
