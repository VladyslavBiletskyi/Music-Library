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
    public partial class Album : Form
    {
        SqlConnection connection = new SqlConnection(MainForm.connectionString);
        DataTable dt = new DataTable();
        DataTable compCont = new DataTable();
        DataTable current = new DataTable();
        string path = "";
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
                    perfBox.Items.Add((string)dt.Rows[i][3]);
                }
            }
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
        private void albumPerf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (charBox.SelectedIndex == -1) { MessageBox.Show("Выберите критерий отбора"); return; }
            dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Album WHERE Performer"+(string)charBox.SelectedItem+"'"+(string)albumPerf.SelectedItem+"'", connection);
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
            nameBox.Text = (string)dt.Rows[id][1];
            dateTimePicker1.Value = (DateTime)dt.Rows[id][2];
            perfBox.SelectedIndex = perfBox.Items.IndexOf((string)dt.Rows[id][3]);
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
            compBox.Items.Clear();
            for (int i = 0; i < compCont.Rows.Count; i++) compBox.Items.Add((string)compCont.Rows[i][0]);
            current = new DataTable();
            adapter = new SqlDataAdapter("SELECT Composition.Name, Containing.Id FROM Composition, Containing, Album WHERE Containing.Composition=Composition.Id and Containing.Album=Album.Id and Album.Id='" + (int)dt.Rows[id][0] + "'", connection);
            connection.Open();
            adapter.Fill(current);
            connection.Close();
            compBox.SelectedItems.Clear();
            for (int i = 0; i < current.Rows.Count; i++) compBox.SelectedItems.Add((string)current.Rows[i][0]);
        }
        private void photoButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            if (openFileDialog1.FileName.Contains(Application.StartupPath))
            {
                path = new string(openFileDialog1.FileName.ToCharArray(), Application.StartupPath.Length + 1, openFileDialog1.FileName.Length - Application.StartupPath.Length - 1);
            }
            else path = openFileDialog1.FileName;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить редактирование?", "Отмена", MessageBoxButtons.OKCancel) == DialogResult.OK) this.Close();
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            int id=0;
            for (int i=0; i<dt.Rows.Count;i++) if ((string)dt.Rows[i][1]==(string)albumName.SelectedItem) id=(int)dt.Rows[i][0];
            #region создание списка произведений, входящих только в этот альбом
            DataTable uniq = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT Composition.Name FROM Composition, Containing WHERE Containing.Composition=Composition.Id and Album="+id+" and (SELECT Count(Containing.Id) FROM Containing WHERE Composition=Composition.Id)=1", connection))
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
            for (int i = 0; i < uniq.Rows.Count; i++)
            {
                if (!compBox.SelectedItems.Contains(uniq.Rows[i][0]))
                {
                    MessageBox.Show("Ошибка! Произведение "+ ((string)uniq.Rows[i][0])+" содержится только в этом альбоме! Удалите его вручную или оставьте в альбоме");
                    return;
                }
            }
            #region удаление старых связей альбом-произведение
                for (int i = 0; i < current.Rows.Count; i++)
                {
                    SqlCommand delete = new SqlCommand("DELETE FROM Containing WHERE Id=@Id", connection);
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
            #region изменение альбома
            SqlCommand update = new SqlCommand("UPDATE Album SET Name=@Name, Year=@Year, Performer=@Performer, Cover=@Cover WHERE Id=" + id, connection);
            update.Parameters.AddWithValue("@Name", nameBox.Text);
            update.Parameters.AddWithValue("@Year",dateTimePicker1.Value.Date);
            update.Parameters.AddWithValue("@Performer",(string)perfBox.SelectedItem);
            update.Parameters.AddWithValue("@Cover", path);
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
            #region создание связей альбом-произведение
            for (int i=0; i<compCont.Rows.Count; i++)
            {
                if (compBox.SelectedItems.Contains((string)compCont.Rows[i][0]))
                {
                    SqlCommand insert=new SqlCommand("INSERT INTO Containing VALUES ('"+id+"', '"+(int)compCont.Rows[i][1] + "')", connection);
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

        private void Album_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm");
        }
    }
}
