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

namespace Course
{
    public partial class MainForm : Form
    {
        public const string connectionString= @"Data Source=VLADISLAV-PC;Initial Catalog=MusicalLibrary;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
        public MainForm()
        {
            InitializeComponent();
            ColorScheme.ApplyColor(this);
        }
        private void exitMenuStrip_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel=!(MessageBox.Show("Вы действвительно хотите закрыть программу?","Выход из программы" ,MessageBoxButtons.OKCancel) == DialogResult.OK );
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var p = new Forms.PerfSelect();
            p.Show();
        }
        private void addDirect_Click(object sender, EventArgs e)
        {
            var ad=new Forms.Administration.Adding.Direct();
            try { ad.Show(); }
            catch { }
        }
        private void addGenre_Click(object sender, EventArgs e)
        {
            var ag = new Forms.Administration.Adding.Genre();
            try { ag.Show(); }
            catch { }
        }
        private void addPerf_Click(object sender, EventArgs e)
        {
            var p = new Forms.Administration.Adding.Performer();
            try { p.Show(); }
            catch { }
        }
        private void addAlbum_Click(object sender, EventArgs e)
        {
            var a = new Forms.Administration.Adding.Album();
            try { a.Show(); }
            catch { }
        }
        private void addComp_Click(object sender, EventArgs e)
        {
            var c = new Forms.Administration.Adding.Composition();
            try { c.Show(); }
            catch { }
        }
        private void changePerf_Click(object sender, EventArgs e)
        {
            var p = new Forms.Administration.Editing.Performer();
            try { p.Show(); }
            catch {  }
        }
        private void changeDirect_Click(object sender, EventArgs e)
        {
            var d = new Forms.Administration.Editing.Direct();
            try { d.Show(); }
            catch { }
        }
        private void changeGenre_Click(object sender, EventArgs e)
        {
            var g = new Forms.Administration.Editing.Genre();
            try { g.Show(); }
            catch { }
        }
        private void changeComp_Click(object sender, EventArgs e)
        {
            var c = new Forms.Administration.Editing.Composition();
            try { c.Show(); }
            catch { }
        }
        private void queryEdit_Click(object sender, EventArgs e)
        {
            var q = new Forms.QueryEdit();
            q.Show();
        }
        private void changeAlbum_Click(object sender, EventArgs e)
        {
            var a = new Forms.Administration.Editing.Album();
            try { a.Show(); }
            catch { }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var a = new Forms.AlbumSelect();
            a.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var c = new Forms.CompSelect();
            c.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            var dg = new Forms.DirectGenre();
            dg.Show();
        }
        private void deleteComp_Click(object sender, EventArgs e)
        {
            var d = new Forms.Administration.Deleting.Composition();
            try { d.Show(); }
            catch { }
        }
        private void deleteAlbum_Click(object sender, EventArgs e)
        {
            var a = new Forms.Administration.Deleting.Album();
            try { a.Show(); }
            catch { }
        }
        private void deletePerf_Click(object sender, EventArgs e)
        {
            var p = new Forms.Administration.Deleting.Performer();
            try { p.Show(); }
            catch { }
        }
        private void deleteGenre_Click(object sender, EventArgs e)
        {
            var g = new Forms.Administration.Deleting.Genre();
            try { g.Show(); }
            catch { }
        }
        private void deleteDirect_Click(object sender, EventArgs e)
        {
            var d = new Forms.Administration.Deleting.Direct();
            try { d.Show(); }
            catch { }
        }

        private void MainForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm");
        }

        private void playList_Click(object sender, EventArgs e)
        {
            var p = new Forms.PlayList();
            p.Show();
        }
    }
}
