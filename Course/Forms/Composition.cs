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
    public partial class Composition : Form
    {
        SqlConnection connection = new SqlConnection(MainForm.connectionString);
        List<int> idAlbums = new List<int>();
        public Composition(int num)
        {
            InitializeComponent();
            ColorScheme.ApplyColor(this);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Performer.Name, Composition.Name, Album.Name,Text,Album.Id FROM Performer,Composition, Containing, Album WHERE Composition.Id=" + num + " and Containing.Album=Album.Id and Containing.Composition=Composition.Id and Performer.Name=Album.Performer", connection);
            DataTable dt = new DataTable();
            string text = "Текст песни недоступен"; string name = ""; string perf = ""; List<string> albums = new List<string>();
            try
            {
                adapter.Fill(dt);
                perf = (string)dt.Rows[0][0];
                name = (string)dt.Rows[0][1];
                text = (string)dt.Rows[0][3];
            }
            catch { }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!albums.Contains((string)dt.Rows[i][2])) albums.Add((string)dt.Rows[i][2]);
                idAlbums.Add((int)dt.Rows[i][4]);
            }
            connection.Close();
            nameLabel.Text = name;
            perfLink.Text = perf;
            songBox.Text = text;
            foreach (string element in albums) listAlbums.Items.Add(element);
        }

        private void perfLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            perfLink.LinkVisited = true;
            var p = new Forms.Performer(perfLink.Text);
            p.Show();
        }

        private void listAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAlbums.SelectedIndex != -1)
            {
                var c = new Forms.Album(idAlbums[listAlbums.SelectedIndex]);
                try { c.Show(); }
                catch { }
                listAlbums.ClearSelected();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Jpeg Image|*.jpg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.Threading.Thread.Sleep(500);
                Printing p = new Printing(this, saveFileDialog1.FileName);
                MessageBox.Show("Сохранение завершено успешно");
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(500);
            Printing p = new Printing(this);
            MessageBox.Show("Распечатка завершена успешно");
        }

        private void Composition_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm");
        }
    }
}
