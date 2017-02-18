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
    public partial class Genre : Form
    {
        SqlConnection connection = new SqlConnection(MainForm.connectionString);
        public Genre()
        {
            InitializeComponent();
            ColorScheme.ApplyColor(this);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name FROM Direction",connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();
            for (int i = 0; i < dt.Rows.Count; i++) directBox.Items.Add(dt.Rows[i][0]);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "" || defBox.Text == ""|| directBox.SelectedIndex==-1)
            {
                MessageBox.Show("Ошибка добавления! Не все поля заполнены правильно");
                return;
            }
            string query = "INSERT INTO Genre VALUES ('" + nameBox.Text + "', '" + defBox.Text + "', '"+(string)directBox.SelectedItem+"')";
            SqlCommand save = new SqlCommand(query, connection);
            try
            {
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

        private void Genre_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm");
        }
    }
}
