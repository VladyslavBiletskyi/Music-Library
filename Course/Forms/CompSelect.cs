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
    public partial class CompSelect : Form
    {
        SqlConnection connection = new SqlConnection(MainForm.connectionString);
        DataTable dt = new DataTable();
        public CompSelect()
        {
            InitializeComponent();
            ColorScheme.ApplyColor(this);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Count(Id) as Max FROM Composition", connection);
            DataTable max = new DataTable();
            try
            {
                connection.Open();
                adapter.Fill(max);
            }
            finally
            {
                connection.Close();
            }
            numericUpDown1.Maximum = (int)max.Rows[0][0];
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((LinkLabel)sender).LinkVisited = true;
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name, Id, Text FROM Composition WHERE [Name] LIKE '" + ((LinkLabel)sender).Text + "%'", connection);
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
                if ((string)dt.Rows[i][0] == (string)listPerf.SelectedItem) id = (int)dt.Rows[i][1];
            }
            if (listPerf.SelectedIndex != -1)
            {
                var c = new Forms.Composition(id);
                c.Show();
                listPerf.ClearSelected();
            }
        }
        private void searchButton1_Click(object sender, EventArgs e)
        {
            if (searchName.Text == "") { MessageBox.Show("Ошибка! Не введен текст для поиска!"); return; }
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name, Id, Text FROM Composition WHERE [Name] LIKE '%" + searchName.Text + "%'", connection);
            dt = new DataTable();
            adapter.Fill(dt);
            listPerf.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++) listPerf.Items.Add((String)dt.Rows[i][0]);
            connection.Close();
        }
        private void searchButton2_Click(object sender, EventArgs e)
        {
            if (searchText.Text == "") { MessageBox.Show("Ошибка! Не введен текст для поиска!"); return; }
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name, Id, Text FROM Composition WHERE [Text] LIKE '%" + searchText.Text + "%'", connection);
            dt = new DataTable();
            adapter.Fill(dt);
            listPerf.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++) listPerf.Items.Add((String)dt.Rows[i][0]);
            connection.Close();
        }
        private void searchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) searchButton1_Click(searchButton1, new EventArgs());
        }
        private void searchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) searchButton2_Click(searchButton2, new EventArgs());
        }
        private void allButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name, Id FROM Composition", connection);
            dt = new DataTable();
            adapter.Fill(dt);
            listPerf.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++) listPerf.Items.Add((String)dt.Rows[i][0]);
            connection.Close();
        }
        private void CompSelect_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm");
        }
        private void lastButton_Click(object sender, EventArgs e)
        {
            listPerf.Items.Clear();
            dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name,Id FROM Composition ORDER BY Id DESC", connection);
            try
            {
                connection.Open();
                adapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            for (int i = 0; i < numericUpDown1.Value; i++) listPerf.Items.Add(dt.Rows[i][0]);
        }
    }
}
