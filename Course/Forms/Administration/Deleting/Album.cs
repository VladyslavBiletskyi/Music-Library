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
    public partial class Album : Form
    {
        SqlConnection connection = new SqlConnection(MainForm.connectionString);
        DataTable dt = new DataTable();
        DataTable compCont = new DataTable();
        DataTable current = new DataTable();
        public Album()
        {
            InitializeComponent();
            ColorScheme.ApplyColor(this);
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG)|*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG";
            openFileDialog1.InitialDirectory = @"Images\";
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Album", connection);
            connection.Open();
            adapter.Fill(dt);
            connection.Close();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                albumName.Items.Add((string)dt.Rows[i][1]);
                if (!albumPerf.Items.Contains((string)dt.Rows[i][3]))
                {
                    albumPerf.Items.Add((string)dt.Rows[i][3]);
                }
            }
        }
        private void albumPerf_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Album WHERE Performer='" + (string)albumPerf.SelectedItem + "'", connection);
            connection.Open();
            adapter.Fill(dt);
            connection.Close();
            albumName.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                albumName.Items.Add(dt.Rows[i][1]);
            }           
        }
        private void albumName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = albumName.SelectedIndex;
            name.Text = (string)dt.Rows[id][1];
            date.Text = ((DateTime)dt.Rows[id][2]).ToShortDateString();
            perf.Text=((string)dt.Rows[id][3]);
            try
            {
                pictureBox1.Image = Image.FromFile((string)dt.Rows[id][4]);
            }
            catch
            {
                pictureBox1.Image = Image.FromFile(@"Images\no_image.gif");
            }
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT Composition.Name, Composition.Id FROM Composition, Containing, Album WHERE Containing.Composition=Composition.Id and Containing.Album=Album.Id and Album.Performer='" + (string)dt.Rows[id][3] + "'", connection);
            compCont = new DataTable();
            connection.Open();
            adapter.Fill(compCont);
            connection.Close();
            current = new DataTable();
            adapter = new SqlDataAdapter("SELECT Composition.Name, Containing.Id FROM Composition, Containing, Album WHERE Containing.Composition=Composition.Id and Containing.Album=Album.Id and Album.Id='" + (int)dt.Rows[id][0] + "'", connection);
            connection.Open();
            adapter.Fill(current);
            connection.Close();
            compBox.Items.Clear();
            for (int i = 0; i < current.Rows.Count; i++) compBox.Items.Add((string)current.Rows[i][0]);
        }
        private void filterButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Album", connection);
            dt = new DataTable();
            albumPerf.Items.Clear();
            connection.Open();
            adapter.Fill(dt);
            connection.Close();
            albumName.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                albumName.Items.Add((string)dt.Rows[i][1]);
                if (!albumPerf.Items.Contains((string)dt.Rows[i][3])) albumPerf.Items.Add((string)dt.Rows[i][3]);
            }     
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Вы уверены, что хотите отменить редактирование?", "Отмена", MessageBoxButtons.OKCancel) == DialogResult.OK) this.Close();
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            SqlCommand delete = new SqlCommand();
            int id = 0;
            for (int i = 0; i < dt.Rows.Count; i++) if ((string)dt.Rows[i][1] == (string)albumName.SelectedItem) id = (int)dt.Rows[i][0];
            #region создание списка произведений, входящих только в этот альбом
            DataTable uniq = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT Composition.Name, Composition.Id FROM Composition, Containing WHERE Containing.Composition=Composition.Id and Album=" + id + " and (SELECT Count(Containing.Id) FROM Containing WHERE Composition=Composition.Id)=1", connection))
            {
                try
                {
                    connection.Open();
                    adapter.Fill(uniq);
                }
                finally
                {
                    connection.Close();
                }
            }
            #endregion
            string un = "";
            for (int i = 0; i < uniq.Rows.Count; i++)
            {
                if (!compBox.Items.Contains(new ListViewItem((string)uniq.Rows[i][0])))
                {                   
                    un+=(string)uniq.Rows[i][0]+", ";
                }               
            }
            if (uniq.Rows.Count != 0)
            {
                if (MessageBox.Show("Внимание! Произведения " + un + " содержатся только в этом альбоме! Удаление альбома приведет также к удалению указанных произведений. Вы уверенны, что хотите продолжить?", "Удаление альбома", MessageBoxButtons.OKCancel) != DialogResult.OK) return;
            }
            #region удаление связей альбом-произведение
                for (int i = 0; i < current.Rows.Count; i++)
                {
                    delete = new SqlCommand("DELETE FROM Containing WHERE Id=@Id", connection);
                    delete.Parameters.AddWithValue("@Id", (int)current.Rows[i][1]);
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
                }
            #endregion
            #region удаление произведений
                for (int i = 0; i < uniq.Rows.Count; i++)
                {
                    delete = new SqlCommand("DELETE FROM Composition WHERE Id='" + (int)uniq.Rows[i][1] + "'", connection);
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
                }
                #endregion
            #region удаление альбома
            delete = new SqlCommand("DELETE FROM Album WHERE Id='" + id + "'", connection);
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
        }

        private void Album_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm");
        }
    }
}
