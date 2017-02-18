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
    public partial class Performer : Form
    {
        SqlConnection connection = new SqlConnection(MainForm.connectionString);
        DataTable dt = new DataTable();
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
            name.Text = (string)dt.Rows[id][0];
            date.Text = ((DateTime)dt.Rows[id][1]).ToLongDateString();
            try
            {
                pictureBox1.Image = Image.FromFile((string)dt.Rows[id][2]);
            }
            catch { }
            bioBox.Text = (string)dt.Rows[id][3];
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить редактирование?", "Отмена", MessageBoxButtons.OKCancel) == DialogResult.OK) this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DataTable comp = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Composition.Name, Composition.Id FROM Composition, Album, Containing WHERE Containing.Composition=Composition.Id and Containing.Album=Album.Id and Album.Performer='" + (string)perfBox.SelectedItem + "'", connection);
            try
            {
                connection.Open();
                adapter.Fill(comp);
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Ошибка! " + ex.Message);
                return;
            }
            finally
            {
                connection.Close();
            }
            string songs = "";
            for (int i = 0; i < comp.Rows.Count; i++) songs += (string)comp.Rows[i][0] + ", ";
            if (songs != "")
            {
                if (MessageBox.Show("Внимание! Композиции " + songs + "будут удалены вместе с исполнителем. Вы действительно хотите продолжить?", "Подтверждение удаления", MessageBoxButtons.OKCancel) != DialogResult.OK) return;
            }
            else
            {
                if (MessageBox.Show("Вы действительно хотите продолжить?", "Подтверждение удаления", MessageBoxButtons.OKCancel) != DialogResult.OK) return;
            }
            SqlCommand delete = new SqlCommand();
            #region удаление произведений
            for (int i = 0; i < comp.Rows.Count; i++)
            {
                delete = new SqlCommand("DELETE FROM Composition WHERE Id=@Id", connection);
                delete.Parameters.AddWithValue("@Id", (int)comp.Rows[i][1]);
                try
                {
                    connection.Open();
                    delete.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка! " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            #endregion
            #region удаление альбомов
            delete = new SqlCommand("DELETE FROM Album WHERE Performer='" + (string)perfBox.SelectedItem + "'", connection);
            try
            {
                connection.Open();
                delete.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка! " + ex.Message);
                return;
            }
            finally
            {
                connection.Close();
            }
            #endregion
            #region удаление исполнителя
            delete = new SqlCommand("DELETE FROM Performer WHERE Name='" + (string)perfBox.SelectedItem + "'", connection);
            try
            {
                connection.Open();
                delete.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка! " + ex.Message);
                return;
            }
            finally
            {
                connection.Close();
            }
            #endregion
            MessageBox.Show("Изменения успешно применены");
            this.Close();
        }

        private void Performer_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm");
        }
    }
}
