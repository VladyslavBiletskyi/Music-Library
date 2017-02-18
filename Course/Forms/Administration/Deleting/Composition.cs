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
    public partial class Composition : Form
    {
        SqlConnection connection = new SqlConnection(MainForm.connectionString);
        DataTable dt = new DataTable();
        public Composition()
        {
            InitializeComponent();
            ColorScheme.ApplyColor(this);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name FROM Performer", connection);
            connection.Open();
            adapter.Fill(dt);
            connection.Close();
            for (int i = 0; i < dt.Rows.Count; i++) compAuthor.Items.Add((string)dt.Rows[i][0]);
            adapter = new SqlDataAdapter("SELECT Name FROM Composition", connection);
            connection.Open();
            adapter.Fill(dt);
            connection.Close();
            adapter = new SqlDataAdapter("SELECT Composition.*,Album.Name, Album.Performer, Album.Id, Containing.Id FROM Composition,Containing,Album WHERE Containing.Album=Album.Id and Containing.Composition=Composition.Id", connection);
            dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!compBox.Items.Contains((string)dt.Rows[i][1])) compBox.Items.Add(dt.Rows[i][1]);
            }      
        }
        private void compAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (charBox.SelectedIndex == -1) { MessageBox.Show("Выберите критерий отбора"); return; }
            dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT Composition.*,Album.Name, Album.Performer, Album.Id FROM Composition,Containing,Album WHERE Containing.Album=Album.Id and Containing.Composition=Composition.Id and Album.Performer"+(string)charBox.SelectedItem +"'"+ (string)compAuthor.SelectedItem + "'", connection);
            adapter.Fill(dt);
            connection.Close();
            compBox.Items.Clear();
            compAlbum.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!compBox.Items.Contains((string)dt.Rows[i][1])) compBox.Items.Add(dt.Rows[i][1]);
                if (!compAlbum.Items.Contains(dt.Rows[i][4])) compAlbum.Items.Add(dt.Rows[i][4]);
            }           
        }
        private void compAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT Composition.*, Album.Name, Album.Performer, Album.Id FROM Composition,Containing,Album WHERE Containing.Album=Album.Id and Containing.Composition=Composition.Id and Album.Name='" + (string)compAlbum.SelectedItem + "'", connection);
            adapter.Fill(dt);
            connection.Close();
            compBox.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!compBox.Items.Contains((string)dt.Rows[i][1])) compBox.Items.Add(dt.Rows[i][1]);
            }
        }
        private void filterButton_Click(object sender, EventArgs e)
        {
            compAlbum.Items.Clear();
            compAuthor.SelectedIndex = -1;
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT Composition.*,Album.Name, Album.Performer, Album.Id, Containing.Id FROM Composition,Containing,Album WHERE Containing.Album=Album.Id and Containing.Composition=Composition.Id", connection);
            adapter.Fill(dt);
            connection.Close();
            compBox.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                compBox.Items.Add(dt.Rows[i][1]);
            }           
        }
        private void compBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            for (int i = 0; i < dt.Rows.Count; i++) if (dt.Rows[i][1] == compBox.SelectedItem) id = i;
            name.Text = (string)dt.Rows[id][1];
            genre.Text=((string)dt.Rows[id][3]);
            perf.Text=((string)dt.Rows[id][5]);
            #region создание списка альбомов с произведением
            DataTable albums = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT Album.Name FROM Album, Composition, Containing WHERE Containing.Album=Album.Id and Containing.Composition=Composition.Id and Composition.Name='" + (string)dt.Rows[id][1] + "'", connection))
            {
                try
                {
                    connection.Open();
                    adapter.Fill(albums);
                    albumBox.SelectedItems.Clear();
                    albumBox.Items.Clear();
                    for (int i = 0; i < albums.Rows.Count; i++) albumBox.Items.Add((string)albums.Rows[i][0]);
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
            try
            {
                songBox.Text = (string)dt.Rows[id][2];
            }
            catch { }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить редактирование?", "Отмена", MessageBoxButtons.OKCancel) == DialogResult.OK) this.Close();
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Внимание! Это действие нельзя будет отменить! вы действительно хотите удалить произведение?", "Удаление произведения", MessageBoxButtons.OKCancel) != DialogResult.OK) return;
            int compId = 0;
            for (int i = 0; i < dt.Rows.Count; i++) if ((string)dt.Rows[i][1] == (string)compBox.SelectedItem) compId = (int)dt.Rows[i][0];
            SqlCommand delete = new SqlCommand("DELETE FROM Containing WHERE Composition='" + compId + "'", connection);
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
            delete = new SqlCommand("DELETE FROM Composition WHERE Id='" + compId + "'", connection);
            try
            {
                connection.Open();
                delete.ExecuteNonQuery();
                MessageBox.Show("Произведение успешно удалено!");
                this.Close();
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
        }
        private void Composition_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm");
        }
    }
}
