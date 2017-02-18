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
    public partial class DirectGenre : Form
    {
        SqlConnection connection = new SqlConnection(MainForm.connectionString);
        public DirectGenre()
        {
            InitializeComponent();
            ColorScheme.ApplyColor(this);
            tabControl.TabPages.Clear();
            DataTable direct = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Direction", connection);
            connection.Open();
            adapter.Fill(direct);
            connection.Close();
            DataTable genres = new DataTable();
            for (int i = 0; i < direct.Rows.Count; i++)
            {
                genres = new DataTable();
                adapter = new SqlDataAdapter("SELECT * FROM Genre WHERE Direct='" + (string)direct.Rows[i][0]+"'", connection);
                connection.Open();
                adapter.Fill(genres);
                connection.Close();
                tabControl.TabPages.Add((string)direct.Rows[i][0]);
                for (int j = 0; j < genres.Rows.Count; j++)
                {
                        tabControl.TabPages[i].Controls.Add(new RichTextBox());
                        var temp = tabControl.TabPages[i].Controls[tabControl.TabPages[i].Controls.Count - 1];
                        ((RichTextBox)temp).Font = new Font("Trebuchet MS", 9);
                        ((RichTextBox)temp).Dock = DockStyle.Top;
                        ((RichTextBox)temp).Text = (string)genres.Rows[j][1];
                        tabControl.TabPages[i].Controls.Add(new TextBox());
                        temp = tabControl.TabPages[i].Controls[tabControl.TabPages[i].Controls.Count - 1];
                        ((TextBox)temp).Font = new Font("Trebuchet MS", 10);
                        ((TextBox)temp).Dock = DockStyle.Top;
                        ((TextBox)temp).Text = (string)genres.Rows[j][0];
                        ((TextBox)temp).BackColor = this.BackColor;
                }
                TextBox genrelabel = new TextBox();
                genrelabel.Font = new Font("Trebuchet MS", 19);
                genrelabel.Text = "Жанры:";
                genrelabel.BackColor = this.BackColor;
                genrelabel.Dock = DockStyle.Top;
                tabControl.TabPages[i].Controls.Add(genrelabel);
                genrelabel.ReadOnly = true;
                genrelabel.TabStop = false;
                RichTextBox text = new RichTextBox();
                text.Font = new Font("Trebuchet MS", 9);
                text.Dock = DockStyle.Top;
                text.Text = (string)direct.Rows[i][1];
                tabControl.TabPages[i].Controls.Add(text);
                tabControl.TabPages[i].AutoScroll = true;
            }
        }

        private void DirectGenre_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm");
        }
    }
}
