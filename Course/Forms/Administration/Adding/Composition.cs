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

namespace Course.Forms.Administration.Adding
{
    public partial class Composition : Form
    {
        SqlConnection connection = new SqlConnection(MainForm.connectionString);
        List<int> albumId = new List<int>();
        public Composition()
        {
            InitializeComponent();
            ColorScheme.ApplyColor(this);
            DataTable dt = new DataTable();
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name FROM Performer", connection);
            adapter.Fill(dt);
            connection.Close();
            for (int i = 0; i < dt.Rows.Count; i++)
                perfBox.Items.Add(dt.Rows[i][0]);
            dt = new DataTable();
            connection.Open();
            adapter = new SqlDataAdapter("SELECT Name FROM Genre", connection);
            adapter.Fill(dt);
            connection.Close();
            for (int i = 0; i < dt.Rows.Count; i++)
                genreBox.Items.Add(dt.Rows[i][0]);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить редактирование?", "Отмена", MessageBoxButtons.OKCancel) == DialogResult.OK) this.Close();
        }

        private void perfBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            albumId.Clear();
            albumBox.Items.Clear();
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name, Id FROM Album WHERE Performer='" + (string)perfBox.SelectedItem + "'", connection);
            adapter.Fill(dt);
            connection.Close();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                albumBox.Items.Add(dt.Rows[i][0]);
                albumId.Add((int)dt.Rows[i][1]);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "" || albumBox.SelectedIndex == -1 || genreBox.SelectedIndex == -1)
            {
                MessageBox.Show("Ошибка добавления! Не все поля заполнены правильно");
                return;
            }
            #region создание произведения
            string query = "INSERT INTO Composition VALUES (@Name,@Text,@Genre)";
            SqlCommand save = new SqlCommand(query, connection);
            try
            {
                save.Parameters.AddWithValue("@Name", nameBox.Text);
                save.Parameters.AddWithValue("@Text", songBox.Text);
                save.Parameters.AddWithValue("@Genre", (string)genreBox.SelectedItem);
                connection.Open();
                save.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка!" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            #endregion
            #region добавление в альбом
            DataTable dt = new DataTable();
            int id;
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT MAX(Id) as Column1 FROM Composition", connection);
            adapter.Fill(dt);
            connection.Close();
            id = (int)dt.Rows[0][0];
            query = "INSERT INTO Containing VALUES (@Album,@Composition)";
            save = new SqlCommand(query, connection);
            try
            {
                save.Parameters.AddWithValue("@Album", albumId[albumBox.SelectedIndex]);
                save.Parameters.AddWithValue("@Composition", id);
                connection.Open();
                save.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка!" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            MessageBox.Show("Изменения успешно сохранены");
            #endregion
            this.Close();
        }

        private void Composition_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm");
        }
    }
}
