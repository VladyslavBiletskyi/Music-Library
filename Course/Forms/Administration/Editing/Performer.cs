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

namespace Course.Forms.Administration.Editing
{
    public partial class Performer : Form
    {
        SqlConnection connection = new SqlConnection(MainForm.connectionString);
        DataTable dt = new DataTable();
        string path;
        public Performer()
        {
            InitializeComponent();
            ColorScheme.ApplyColor(this);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Performer", connection);
            adapter.Fill(dt);
            connection.Close();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                perfBox.Items.Add(dt.Rows[i][0]);
            }
        }

        private void perfBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = perfBox.SelectedIndex;
            nameBox.Text = (string)dt.Rows[id][0];
            dateTimePicker1.Value = (DateTime)dt.Rows[id][1];
            try
            {
                pictureBox1.Image = Image.FromFile((string)dt.Rows[id][2]);
                path = (string)dt.Rows[id][2];
            }
            catch { path = "ref for nophoto"; }
            bioBox.Text = (string)dt.Rows[id][3];
        }

        private void photoButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                if (openFileDialog1.FileName.Contains(Application.StartupPath))
                {
                    path = new string(openFileDialog1.FileName.ToCharArray(), Application.StartupPath.Length + 1, openFileDialog1.FileName.Length - Application.StartupPath.Length - 1);
                }
                else path = openFileDialog1.FileName;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("UPDATE Performer SET Name=@Name, Birth=@Birth, Photo=@Photo, Biography=@Biography WHERE Name='" + (string)perfBox.SelectedItem + "'", connection);
            try
            {
                update.Parameters.AddWithValue("@Name", nameBox.Text);
                update.Parameters.AddWithValue("@Birth", dateTimePicker1.Value.Date);
                update.Parameters.AddWithValue("@Photo", path);
                update.Parameters.AddWithValue("@Biography", bioBox.Text);
                connection.Open();
                update.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка! " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            MessageBox.Show("Изменения успешно сохранены");
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить редактирование?", "Отмена", MessageBoxButtons.OKCancel) == DialogResult.OK) this.Close();
        }

        private void Performer_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm");
        }
    }
}
