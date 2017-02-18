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
    public partial class Album : Form
    {
        SqlConnection connection = new SqlConnection(MainForm.connectionString);
        List<int> idComp = new List<int>();
        bool desc = false;
        public Album(int num)
        {
            InitializeComponent();
            ColorScheme.ApplyColor(this);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Performer.Name, Composition.Name, Album.Name,Album.Cover, Composition.Id FROM Performer,Composition, Containing, Album WHERE Album.Id=" + num + " and Containing.Album=Album.Id and Containing.Composition=Composition.Id and Performer.Name=Album.Performer ORDER BY Composition.Name", connection);
            DataTable dt = new DataTable();
            string name = ""; string perf = ""; List<string> comps = new List<string>();
            try
            {
                adapter.Fill(dt);
                perf = (string)dt.Rows[0][0];
                name = (string)dt.Rows[0][2];
                try { pictureBox.Image = Image.FromFile((string)dt.Rows[0][3]); }
                catch { }
            }
            catch 
            {
                MessageBox.Show("К сожалению, информация об альбоме неполная. Добавьте в альбом хотя бы одно произведение");
                this.Close();
            }
            finally
            {
                connection.Close();
            }
            perfLink.Text = perf;
            nameLabel.Text = name;
            for (int i = 0; i < dt.Rows.Count; i++) { listComps.Items.Add(dt.Rows[i][1]); idComp.Add((int)dt.Rows[i][4]); }
        }
        private void perfLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            perfLink.LinkVisited = true;
            var p = new Forms.Performer(perfLink.Text);
            p.Show();
        }
        private void listComps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listComps.SelectedIndex != -1)
            {
                var c = new Forms.Composition(idComp[listComps.SelectedIndex]);
                c.Show();
                listComps.ClearSelected();
            }
        }
        private void printButton_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(500);
            Printing p=new Printing(this);
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
        private void Album_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm");
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(); connection.Open();
            if (desc)
            {
                adapter=new SqlDataAdapter("SELECT Composition.Name, Composition.Id FROM Composition, Containing, Album WHERE Containing.Composition=Composition.Id and Containing.Album=Album.Id and Album.Name='"+nameLabel.Text+"' ORDER BY Composition.Name",connection);
                adapter.Fill(dt);
                idComp.Clear(); listComps.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listComps.Items.Add(dt.Rows[i][0]);
                    idComp.Add((int)dt.Rows[i][1]);
                }
            }
            else
            {
                adapter = new SqlDataAdapter("SELECT Composition.Name, Composition.Id FROM Composition, Containing, Album WHERE Containing.Composition=Composition.Id and Containing.Album=Album.Id and Album.Name='" + nameLabel.Text + "' ORDER BY Composition.Name DESC", connection);
                adapter.Fill(dt);
                idComp.Clear(); listComps.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listComps.Items.Add(dt.Rows[i][0]);
                    idComp.Add((int)dt.Rows[i][1]);
                }
            }
            connection.Close();
            desc = !desc;
        }
    }
}
