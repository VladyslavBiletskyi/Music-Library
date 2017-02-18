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
    public partial class Direct : Form
    {
        SqlConnection connection = new SqlConnection(MainForm.connectionString);
        public Direct()
        {
            InitializeComponent();
            ColorScheme.ApplyColor(this);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "" || defBox.Text == "")
            {
                MessageBox.Show("Ошибка добавления! Не все поля заполнены правильно");
                return;
            }
            string query = "INSERT INTO Direction VALUES ('"+nameBox.Text+"', '"+defBox.Text+"')";
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить редактирование?", "Отмена", MessageBoxButtons.OKCancel) == DialogResult.OK) this.Close();
        }

        private void Direct_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm");
        }
    }
}
