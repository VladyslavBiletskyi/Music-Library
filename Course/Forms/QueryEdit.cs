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

namespace Course.Forms
{
    public partial class QueryEdit : Form
    {
        SqlConnection connection = new SqlConnection(MainForm.connectionString);
        public QueryEdit()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            query.Text = "SELECT";
        }

        private void execButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            connection.Open();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query.Text, connection);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Ошибка!" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void QueryEdit_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm");
        }
    }
}
