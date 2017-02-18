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
    public partial class Performer : Form
    {
        SqlConnection connection=new SqlConnection(MainForm.connectionString);
        List<int> idComps; List<int> idAlbums;
        string n; bool desc = false;
        public Performer(string name)
        {
            n = name;
            InitializeComponent();
            ColorScheme.ApplyColor(this);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Photo, Biography, Birth FROM Performer WHERE [Name]='" + name+"'", connection);
            DataTable dt = new DataTable();
            string path=""; string bio="";
            try
            {
                adapter.Fill(dt);
                path = (string)dt.Rows[0][0];
                bio = (string)dt.Rows[0][1];
                dateLabel.Text += ((DateTime)dt.Rows[0][2]).ToLongDateString();
            }
            catch { }
            adapter = new SqlDataAdapter("SELECT DISTINCT Composition.Name, Composition.Id FROM Composition, Album, Containing WHERE Album.Performer='" + name + "' and Containing.Album=Album.Id and Containing.Composition=Composition.Id ORDER BY Composition.Name", connection);
            dt = new DataTable();
            adapter.Fill(dt);
            List<string> comps = new List<string>();
            List<string> albums = new List<string>();
            idComps = new List<int>();
            idAlbums = new List<int>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comps.Add((string)dt.Rows[i][0]);
                idComps.Add((int)dt.Rows[i][1]);
            }
            connection.Close();
            connection.Open();
            adapter = new SqlDataAdapter("SELECT Name, Id FROM Album WHERE Performer='" + name + "'", connection);
            dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!idAlbums.Contains((int)dt.Rows[i][1]))
                {
                    albums.Add((string)dt.Rows[i][0]);
                    idAlbums.Add((int)dt.Rows[i][1]);
                }
            }
                try
                {
                    pictureBox.Image = Image.FromFile(path);
                }
                catch
                {

                }
            nameLabel.Text = name;
            biographyBox.Text = bio;
            foreach (string element in comps)
                listComp.Items.Add(element);
            foreach (string element in albums)
                listAlbums.Items.Add(element);
        }

        private void listComp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listComp.SelectedIndex!=-1)
            {
                var c = new Forms.Composition(idComps[listComp.SelectedIndex]);
                c.Show();
                listComp.ClearSelected();
            }
        }

        private void listAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAlbums.SelectedIndex != -1)
            {
                var a = new Forms.Album(idAlbums[listAlbums.SelectedIndex]);
                try { a.Show(); }
                catch { }
                listAlbums.ClearSelected();
            }
        }
        private void printButton_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(500);
            Printing p = new Printing(this);
            MessageBox.Show("Распечатка завершена успешно");
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

        private void Performer_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adapter;
            DataTable dt;
            connection.Open();
            if (desc)
            {
                
                adapter = new SqlDataAdapter("SELECT DISTINCT Composition.Name, Composition.Id FROM Composition, Album, Containing WHERE Album.Performer='" + n + "' and Containing.Album=Album.Id and Containing.Composition=Composition.Id ORDER BY Composition.Name", connection);
                dt = new DataTable();
                adapter.Fill(dt);
                idComps = new List<int>();
                listComp.Items.Clear();
                for (int i=0;i<dt.Rows.Count;i++)
                {
                    listComp.Items.Add(dt.Rows[i][0]);
                    idComps.Add((int)dt.Rows[i][1]);
                }
                
            }
            else
            {
                adapter = new SqlDataAdapter("SELECT DISTINCT Composition.Name, Composition.Id FROM Composition, Album, Containing WHERE Album.Performer='" + n + "' and Containing.Album=Album.Id and Containing.Composition=Composition.Id ORDER BY Composition.Name DESC", connection);
                dt = new DataTable();
                adapter.Fill(dt);
                idComps = new List<int>();
                listComp.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listComp.Items.Add(dt.Rows[i][0]);
                    idComps.Add((int)dt.Rows[i][1]);
                }
            }
            connection.Close();
            desc = !desc;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
