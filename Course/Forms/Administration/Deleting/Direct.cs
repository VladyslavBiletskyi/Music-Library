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
    public partial class Direct : Form
    {
        SqlConnection connection = new SqlConnection(MainForm.connectionString);
        DataTable dt = new DataTable();
        public Direct()
        {
            InitializeComponent();
            ColorScheme.ApplyColor(this);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Direction", connection);
            adapter.Fill(dt);
            connection.Close();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                directBox.Items.Add(dt.Rows[i][0]);
            }           
        }

        private void directBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = directBox.SelectedIndex;
            name.Text = (string)dt.Rows[id][0];
            defBox.Text = (string)dt.Rows[id][1];
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить редактирование?", "Отмена", MessageBoxButtons.OKCancel) == DialogResult.OK) this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SqlCommand delete = new SqlCommand("DELETE FROM Direction WHERE Name='" + (string)directBox.SelectedItem + "'", connection);
            try
            {
                connection.Open();
                delete.ExecuteNonQuery();
            }
            catch(SqlException)
            {
                MessageBox.Show("Ошибка! Невозможно удалить направление, определенное в жанрах");
                return;
            }
            finally
            {
                connection.Close();
            }
            MessageBox.Show("Изменения успешно применены");
            this.Close();
        }

        private void Direct_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm");
        }

        private void Direct_Load(object sender, EventArgs e)
        {

        }
    }
}
