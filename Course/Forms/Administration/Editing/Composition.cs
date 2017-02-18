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
    public partial class Composition : Form
    {
        SqlConnection connection = new SqlConnection(MainForm.connectionString);
        DataTable dt = new DataTable();
        public Composition()
        {
            InitializeComponent();
            ColorScheme.ApplyColor(this);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name FROM Performer", connection);
            adapter.Fill(dt);
            connection.Close();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                perfBox.Items.Add(dt.Rows[i][0]);
                compAuthor.Items.Add(dt.Rows[i][0]);
            }
            dt = new DataTable();
            connection.Open();
            adapter = new SqlDataAdapter("SELECT Name FROM Genre", connection);
            adapter.Fill(dt);
            connection.Close();
            for (int i = 0; i < dt.Rows.Count; i++)
                genreBox.Items.Add(dt.Rows[i][0]);
            dt = new DataTable();
            connection.Open();
            adapter = new SqlDataAdapter("SELECT Name FROM Album", connection);
            adapter.Fill(dt);
            connection.Close();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                albumBox.Items.Add(dt.Rows[i][0]);
            }
            dt = new DataTable();
            connection.Open();
            adapter = new SqlDataAdapter("SELECT DISTINCT Composition.*,Album.Name, Album.Performer, Album.Id, Containing.Id FROM Composition,Containing,Album WHERE Containing.Album=Album.Id and Containing.Composition=Composition.Id", connection);
            adapter.Fill(dt);
            connection.Close();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!compBox.Items.Contains((string)dt.Rows[i][1]))compBox.Items.Add(dt.Rows[i][1]);
            }
        }
        private void compBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            for (int i = 0; i < dt.Rows.Count; i++) if (dt.Rows[i][1] == compBox.SelectedItem) id = i;
            nameBox.Text = (string)dt.Rows[id][1];
            genreBox.SelectedIndex = genreBox.Items.IndexOf((string)dt.Rows[id][3]);
            perfBox.SelectedIndex = perfBox.Items.IndexOf((string)dt.Rows[id][5]);
            #region создание списка альбомов с произведением
            DataTable albums = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT Album.Name FROM Album, Composition, Containing WHERE Containing.Album=Album.Id and Containing.Composition=Composition.Id and Composition.Name='" + (string)dt.Rows[id][1]+"'", connection))
            {
                try
                {
                    connection.Open();
                    adapter.Fill(albums);
                    albumBox.SelectedItems.Clear();
                    for (int i = 0; i < albums.Rows.Count; i++) albumBox.SelectedItems.Add((string)albums.Rows[i][0]);
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Ошибка! " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            #endregion
            albumBox.SelectedIndex = albumBox.Items.IndexOf((string)dt.Rows[id][4]);
            try
            {
                songBox.Text = (string)dt.Rows[id][2];
            }
            catch { }           
        }
        private void compAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (charBox.SelectedIndex == -1) { MessageBox.Show("Выберите критерий отбора"); return; }
            dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT Composition.* ,Album.Name, Album.Performer, Album.Id, Containing.Id FROM Composition,Containing,Album WHERE Containing.Album=Album.Id and Containing.Composition=Composition.Id and Album.Performer" + (string)charBox.SelectedItem + "'" + (string)compAuthor.SelectedItem + "'", connection);
            adapter.Fill(dt);
            connection.Close();
            compBox.Items.Clear();
            compAlbum.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if(!compBox.Items.Contains((string)dt.Rows[i][1]))compBox.Items.Add(dt.Rows[i][1]);
                if (!compAlbum.Items.Contains((string)dt.Rows[i][4]))compAlbum.Items.Add(dt.Rows[i][4]);
            }           
        }
        private void compAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT Composition.*, Album.Name, Album.Performer, Album.Id, Containing.Id FROM Composition,Containing,Album WHERE Containing.Album=Album.Id and Containing.Composition=Composition.Id and Album.Name='" + (string)compAlbum.SelectedItem + "'", connection);
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
        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить редактирование?", "Отмена", MessageBoxButtons.OKCancel) == DialogResult.OK) this.Close();
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            if (albumBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Ошибка! Выберите хотя бы один альбом");
                return;
            }
            int compId = 0;
            DataTable aId = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name, Id FROM Album", connection);
            connection.Open();
            adapter.Fill(aId);
            connection.Close();
            #region удаление свазей с альбомом
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
            #endregion
            #region изменение информации о произведении
            SqlCommand update = new SqlCommand("UPDATE Composition SET Name=@Name, Text=@Text, Genre=@Genre WHERE Id=" + compId, connection);
            update.Parameters.AddWithValue("@Name", nameBox.Text);
            update.Parameters.AddWithValue("@Text", songBox.Text);
            update.Parameters.AddWithValue("@Genre", (string)genreBox.SelectedItem);
            try
            {
                connection.Open();
                update.ExecuteNonQuery();
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
            #region создание новых связей
            for (int i=0; i<aId.Rows.Count; i++)
            {
                if (albumBox.SelectedItems.Contains(aId.Rows[i][0]))
                {
                    SqlCommand insert = new SqlCommand("INSERT INTO Containing VALUES ('" + (int)aId.Rows[i][1] + "', '" + compId + "')", connection);
                    try
                    {
                        connection.Open();
                        insert.ExecuteNonQuery();
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
            }
            #endregion
            MessageBox.Show("Изменения успешно сохранены");
            this.Close();
        }
        private void Composition_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm");
        }
    }
}
