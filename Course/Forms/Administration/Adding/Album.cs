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
    public partial class Album : Form
    {
        SqlConnection connection = new SqlConnection(MainForm.connectionString);
        string path = "";
        public Album()
        {
            InitializeComponent();
            ColorScheme.ApplyColor(this);
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG)|*.BMP;*.JPG;*.GIF;*.JPEG;*.PNG";
            openFileDialog1.InitialDirectory = @"Images\";
            DataTable dt = new DataTable();
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name FROM Performer", connection);
            adapter.Fill(dt);
            connection.Close();
            for (int i = 0; i < dt.Rows.Count; i++) perfBox.Items.Add(dt.Rows[i][0]);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить редактирование?", "Отмена", MessageBoxButtons.OKCancel) == DialogResult.OK) this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "" || perfBox.SelectedIndex==-1)
            {
                MessageBox.Show("Ошибка добавления! Не все поля заполнены правильно");
                return;
            }
            string query = "INSERT INTO Album VALUES (@Name,@Year,@Performer,@Cover)";
            SqlCommand save = new SqlCommand(query, connection);
            try
            {
                save.Parameters.AddWithValue("@Name", nameBox.Text);
                save.Parameters.AddWithValue("@Year", dateTimePicker1.Value.Date);
                save.Parameters.AddWithValue("@Performer", (string)perfBox.SelectedItem);
                if (path != "") save.Parameters.AddWithValue("@Cover", path);
                else save.Parameters.AddWithValue("@Cover", "link for nophoto");
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
            this.Close();
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

        private void Album_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm");
        }
    }
}
