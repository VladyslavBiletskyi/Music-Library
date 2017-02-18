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

namespace Course.Forms.Administration.Deleting
{
    public partial class Genre : Form
    {
        SqlConnection connection = new SqlConnection(MainForm.connectionString);
        DataTable dt = new DataTable();
        public Genre()
        {
            InitializeComponent();
            ColorScheme.ApplyColor(this);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Genre", connection);
            dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                genreBox.Items.Add(dt.Rows[i][0]);
            }
            
        }

        private void genreBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = genreBox.SelectedIndex;
            name.Text = (string)dt.Rows[id][0];
            defBox.Text = (string)dt.Rows[id][1];
            direct.Text=((string)dt.Rows[id][2]);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить редактирование?", "Отмена", MessageBoxButtons.OKCancel) == DialogResult.OK) this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SqlCommand delete = new SqlCommand("DELETE FROM Genre WHERE Name='" + (string)genreBox.SelectedItem + "'", connection);
            try
            {
                connection.Open();
                delete.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Ошибка! Невозможно удалить жанр, определенный в произведениях");
                return;
            }
            finally
            {
                connection.Close();
            }
            MessageBox.Show("Изменения успешно применены!");
            this.Close();
        }

        private void Genre_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm");
        }
    }
}
