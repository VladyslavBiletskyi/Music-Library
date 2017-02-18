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
    public partial class PlayList : Form
    {
        List<List<string>> varLst;
        int t = 220;
        SqlConnection connection = new SqlConnection(MainForm.connectionString);
        DataTable dt = new DataTable();
        public PlayList()
        {
            InitializeComponent();
            ColorScheme.ApplyColor(this);
            #region заполнение списка исполнителей
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name FROM Performer", connection);
            try
            {
                connection.Open();
                adapter.Fill(dt);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                perfBox.Items.Add((string)dt.Rows[i][0]);
            }
            #endregion
            #region заполнение списка жанров
            adapter = new SqlDataAdapter("SELECT Name FROM Genre", connection);
            dt = new DataTable();
            try
            {
                connection.Open();
                adapter.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            for (int i = 0; i < dt.Rows.Count; i++) genreBox.Items.Add((string)dt.Rows[i][0]);
            #endregion
            SqlDataAdapter m = new SqlDataAdapter("SELECT COUNT(Id) as 'Max' FROM Composition",connection);
            DataTable d=new DataTable();
            connection.Open(); m.Fill(d); connection.Close();
            numericUpDown1.Maximum = (int)d.Rows[0][0] * t / 60;
        }
        private void listComps_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            varBox.Items.Clear();
            int len = Convert.ToInt16(numericUpDown1.Value);
            listComps.Items.Clear();
            string query = "SELECT DISTINCT Composition.Name, Composition.Id, Album.Performer, Composition.Genre FROM Composition, Album, Containing WHERE Containing.Composition=Composition.Id and Containing.Album=Album.Id and Album.Performer IN ( ";
            if (perfBox.CheckedItems.Count == 0 && genreBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Ошибка! Нужно выбрать хоть один из пунктов");
                return;
            }
            #region формирование полного запроса
            string perf = ""; bool containperf = false;
            if (perfBox.CheckedItems.Count != 0)
            {
                for (int i = 0; i < perfBox.CheckedItems.Count; i++)
                {
                        containperf = true;
                        perf += "'"+(string)perfBox.CheckedItems[i] + "', ";                  
                }
            }
            string genre = ""; bool containgenre = false;
            if (genreBox.CheckedItems.Count != 0)
            {
                for (int i = 0; i < genreBox.CheckedItems.Count; i++)
                {
                    containgenre = true;
                    genre +="'"+(string)genreBox.CheckedItems[i]+"', ";
                }
            }
            if (containperf)
            {
                for (int i=0; i<perf.Length-2;i++)
                {
                    query += perf[i];
                }
                query += ")";
            }
            else
            {
                query += "SELECT Name FROM Performer) ";
            }
            if (containgenre)
            {
                query += "and Composition.Genre IN (";
                for (int i = 0; i < genre.Length - 2; i++)
                {
                    query += genre[i];
                }
                query += ")";
            }
            #endregion
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            dt = new DataTable();
            try
            {
                connection.Open();
                adapter.Fill(dt);
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            varLst = new List<List<string>>();
            List<string> max = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                max.Add((string)dt.Rows[i][2]+": "+(string)dt.Rows[i][0]+" Жанр: "+(string)dt.Rows[i][3]+" Подходит на 100%");
            }
            varLst.Add(max);
            varBox.Items.Add(1);
            #region если получено больше, чем ожидалось
            if (max.Count * t / 60 > len)
            {
                if (MessageBox.Show("Примерная длительность полученного плейлиста составляет " + (max.Count * t / 60) + " минут. Предложить другие варианты?", "Подтверждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int count = (max.Count * t / 60) / len;
                    int step = 0;
                    for (int i = 0; i < count; i++)
                    {
                        List<string> temp = new List<string>();
                        for (int j = step; j < max.Count / count + step; j++)
                        {
                            temp.Add(max[j]);
                        }
                        step += max.Count / count;
                        varLst.Add(temp);
                        varBox.Items.Add(Convert.ToInt16(varBox.Items[varBox.Items.Count - 1]) + 1);
                    }
                }

                else
                {
                    varBox.SelectedIndex = 0;
                }
            }
            #endregion
            else
            {
                if (MessageBox.Show("Примерная длительность полученного плейлиста составляет только " + (max.Count * t / 60) + " минут. Предложить другие варианты?", "Подтверждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    
#region попытка дополнения песнями исполнителя
                    if (containperf)
                    {
                        List<string> temp = new List<string>();
                        foreach (var element in max) temp.Add(element);
                        dt = new DataTable();
                        query = "SELECT DISTINCT Composition.Name, Composition.Id,Album.Performer, Composition.Genre FROM Composition, Album, Containing WHERE Containing.Composition=Composition.Id and Containing.Album=Album.Id and Album.Performer IN ( ";
                        for (int i = 0; i < perf.Length - 2; i++)
                        {
                            query += perf[i];
                        }
                        query += ")";
                        SqlDataAdapter add = new SqlDataAdapter(query, connection);
                        try
                        {
                            connection.Open();
                            add.Fill(dt);
                        }
                        finally
                        {
                            connection.Close();
                        }
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (!temp.Contains((string)dt.Rows[i][2]+": "+(string)dt.Rows[i][0]+" Жанр: "+(string)dt.Rows[i][3]+" Подходит на 100%")) temp.Add((string)dt.Rows[i][2] + ": " + (string)dt.Rows[i][0] + " Жанр: " + (string)dt.Rows[i][3] + " Подходит на 80%");
                            if (temp.Count * t / 60 >= len) break;
                        }
                        varLst.Add(temp);
                        varBox.Items.Add(Convert.ToInt16(varBox.Items[varBox.Items.Count - 1]) + 1);
                    }
#endregion
                    if (varLst[varLst.Count-1].Count * t / 60 < len)
                    {
                        #region попытка дополнения песнями жанра
                        List<string> temp = new List<string>();
                        foreach (var element in varLst[varLst.Count - 1]) temp.Add(element);
                        if (containgenre)
                        {
                            dt = new DataTable();
                            query = "SELECT DISTINCT Composition.Name, Composition.Id, Album.Performer, Composition.Genre FROM Composition,Album,Containing WHERE Containing.Composition=Composition.Id and Containing.Album=Album.Id and Composition.Genre IN ( ";
                            for (int i = 0; i < genre.Length - 2; i++)
                            {
                                query += genre[i];
                            }
                            query += ")";
                            SqlDataAdapter gen = new SqlDataAdapter(query, connection);
                            try
                            {
                                connection.Open();
                                gen.Fill(dt);
                            }
                            finally
                            {
                                connection.Close();
                            }
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                if (!temp.Contains((string)dt.Rows[i][2] + ": " + (string)dt.Rows[i][0] + " Жанр: " + (string)dt.Rows[i][3] + " Подходит на 80%") && !temp.Contains((string)dt.Rows[i][2] + ": " + (string)dt.Rows[i][0] + " Жанр: " + (string)dt.Rows[i][3] + " Подходит на 100%"))
                                temp.Add((string)dt.Rows[i][2] + ": " + (string)dt.Rows[i][0] + " Жанр: " + (string)dt.Rows[i][3] + " Подходит на 60%");
                                if (temp.Count * t / 60 >= len) break;
                            }
                            varLst.Add(temp);
                            varBox.Items.Add(Convert.ToInt16(varBox.Items[varBox.Items.Count - 1]) + 1);
                        }
                        #endregion
                    }
                    if (varLst[varLst.Count - 1].Count * t / 60 < len)
                    {
                        #region попытка дополнения произведениями направления
                        List<string> dir = new List<string>();
                        if (containgenre)
                        {
                            DataTable n = new DataTable();
                            query = "SELECT Composition.Name, Composition.Id, Album.Performer, Composition.Genre FROM Composition, Containing, Album, Genre, Direction WHERE Containing.Composition=Composition.Id and Containing.Album=Album.Id and Composition.Genre=Genre.Name and Direction.Name=Genre.Direct and Direction.Name IN (SELECT Direct FROM Genre WHERE Name IN(";
                            for (int i = 0; i < genre.Length - 2; i++)
                            {
                                query += genre[i];
                            }
                            query += "))";
                            SqlDataAdapter direct = new SqlDataAdapter(query, connection);
                            try
                            {
                                connection.Open();
                                direct.Fill(n);
                            }
                            finally
                            {
                                connection.Close();
                            }
                            for (int i = 0; i < n.Rows.Count; i++)
                            {
                                dir.Add((string)n.Rows[i][2] + ": " + (string)n.Rows[i][0] + " Жанр: " + (string)n.Rows[i][3] + " Подходит на 40%");                                
                            }
                            List<string> forty = new List<string>();
                            for (int i = 0; i < varLst[varLst.Count - 1].Count; i++)
                            {
                                forty.Add(varLst[varLst.Count - 1][i]);
                            }
                            for (int i = 0; i < n.Rows.Count; i++)
                            {
                                 if (!forty.Contains((string)n.Rows[i][2] + ": " + (string)n.Rows[i][0] + " Жанр: " + (string)n.Rows[i][3] + " Подходит на 80%") &&
                                     !forty.Contains((string)n.Rows[i][2] + ": " + (string)n.Rows[i][0] + " Жанр: " + (string)n.Rows[i][3] + " Подходит на 60%")&&
                                     !forty.Contains((string)n.Rows[i][2] + ": " + (string)n.Rows[i][0] + " Жанр: " + (string)n.Rows[i][3] + " Подходит на 100%")&&
                                     !forty.Contains((string)n.Rows[i][2] + ": " + (string)n.Rows[i][0] + " Жанр: " + (string)n.Rows[i][3] + " Подходит на 40%"))
                                 {
                                     forty.Add((string)n.Rows[i][2] + ": " + (string)n.Rows[i][0] + " Жанр: " + (string)n.Rows[i][3] + " Подходит на 40%");
                                 }
                                 if (forty.Count * t / 60 > len) break;
                            }
                            varLst.Add(forty);
                            varBox.Items.Add(Convert.ToInt16(varBox.Items[varBox.Items.Count - 1]) + 1);
                        }
                    }
                        #endregion
                }
                else
                {
                    varBox.SelectedIndex = 0;
                }
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string [] lines=new string [listComps.Items.Count+1];
            lines[0] = "Плейлист:";
            for (int i=0; i<listComps.Items.Count;i++) lines[i+1]=(string)listComps.Items[i];
            saveFileDialog1.Filter = "Txt|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllLines(saveFileDialog1.FileName, lines,Encoding.Unicode);
                MessageBox.Show("Плейлист успешно сохранен");
            }
        }
        private void PlayList_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm");
        }
        private void varBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listComps.Items.Clear();
            if (varBox.SelectedIndex != -1)
            {
                foreach (var element in varLst[varBox.SelectedIndex]) if (!listComps.Items.Contains(element))listComps.Items.Add(element);
            }
            len.Text = ""+listComps.Items.Count * t / 60;
        }
    }
}
