namespace Course
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addComp = new System.Windows.Forms.ToolStripMenuItem();
            this.addAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.addPerf = new System.Windows.Forms.ToolStripMenuItem();
            this.addGenre = new System.Windows.Forms.ToolStripMenuItem();
            this.addDirect = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteComp = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePerf = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteGenre = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDirect = new System.Windows.Forms.ToolStripMenuItem();
            this.изменениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeComp = new System.Windows.Forms.ToolStripMenuItem();
            this.changeAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.changePerf = new System.Windows.Forms.ToolStripMenuItem();
            this.changeGenre = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDirect = new System.Windows.Forms.ToolStripMenuItem();
            this.queryEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.playList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.directGenre = new System.Windows.Forms.Button();
            this.compSelect = new System.Windows.Forms.Button();
            this.albumSelect = new System.Windows.Forms.Button();
            this.prefSelect = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Music library";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStrip,
            this.администрированиеToolStripMenuItem,
            this.queryEdit,
            this.playList});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStrip
            // 
            this.fileToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuStrip});
            this.fileToolStrip.Name = "fileToolStrip";
            this.fileToolStrip.Size = new System.Drawing.Size(48, 20);
            this.fileToolStrip.Text = "Файл";
            // 
            // exitMenuStrip
            // 
            this.exitMenuStrip.Name = "exitMenuStrip";
            this.exitMenuStrip.Size = new System.Drawing.Size(108, 22);
            this.exitMenuStrip.Text = "Выход";
            this.exitMenuStrip.Click += new System.EventHandler(this.exitMenuStrip_Click);
            // 
            // администрированиеToolStripMenuItem
            // 
            this.администрированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавлениеToolStripMenuItem,
            this.удалениеToolStripMenuItem,
            this.изменениеToolStripMenuItem});
            this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.администрированиеToolStripMenuItem.Text = "Администрирование";
            // 
            // добавлениеToolStripMenuItem
            // 
            this.добавлениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addComp,
            this.addAlbum,
            this.addPerf,
            this.addGenre,
            this.addDirect});
            this.добавлениеToolStripMenuItem.Name = "добавлениеToolStripMenuItem";
            this.добавлениеToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.добавлениеToolStripMenuItem.Text = "Добавление";
            // 
            // addComp
            // 
            this.addComp.Name = "addComp";
            this.addComp.Size = new System.Drawing.Size(244, 22);
            this.addComp.Text = "Добавить произведение";
            this.addComp.Click += new System.EventHandler(this.addComp_Click);
            // 
            // addAlbum
            // 
            this.addAlbum.Name = "addAlbum";
            this.addAlbum.Size = new System.Drawing.Size(244, 22);
            this.addAlbum.Text = "Добавить альбом";
            this.addAlbum.Click += new System.EventHandler(this.addAlbum_Click);
            // 
            // addPerf
            // 
            this.addPerf.Name = "addPerf";
            this.addPerf.Size = new System.Drawing.Size(244, 22);
            this.addPerf.Text = "Добавить исполнителя/группу";
            this.addPerf.Click += new System.EventHandler(this.addPerf_Click);
            // 
            // addGenre
            // 
            this.addGenre.Name = "addGenre";
            this.addGenre.Size = new System.Drawing.Size(244, 22);
            this.addGenre.Text = "Добавить жанр";
            this.addGenre.Click += new System.EventHandler(this.addGenre_Click);
            // 
            // addDirect
            // 
            this.addDirect.Name = "addDirect";
            this.addDirect.Size = new System.Drawing.Size(244, 22);
            this.addDirect.Text = "Добавить направление";
            this.addDirect.Click += new System.EventHandler(this.addDirect_Click);
            // 
            // удалениеToolStripMenuItem
            // 
            this.удалениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteComp,
            this.deleteAlbum,
            this.deletePerf,
            this.deleteGenre,
            this.deleteDirect});
            this.удалениеToolStripMenuItem.Name = "удалениеToolStripMenuItem";
            this.удалениеToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.удалениеToolStripMenuItem.Text = "Удаление";
            // 
            // deleteComp
            // 
            this.deleteComp.Name = "deleteComp";
            this.deleteComp.Size = new System.Drawing.Size(236, 22);
            this.deleteComp.Text = "Удалить произведение";
            this.deleteComp.Click += new System.EventHandler(this.deleteComp_Click);
            // 
            // deleteAlbum
            // 
            this.deleteAlbum.Name = "deleteAlbum";
            this.deleteAlbum.Size = new System.Drawing.Size(236, 22);
            this.deleteAlbum.Text = "Удалить альбом";
            this.deleteAlbum.Click += new System.EventHandler(this.deleteAlbum_Click);
            // 
            // deletePerf
            // 
            this.deletePerf.Name = "deletePerf";
            this.deletePerf.Size = new System.Drawing.Size(236, 22);
            this.deletePerf.Text = "Удалить исполнителя/группу";
            this.deletePerf.Click += new System.EventHandler(this.deletePerf_Click);
            // 
            // deleteGenre
            // 
            this.deleteGenre.Name = "deleteGenre";
            this.deleteGenre.Size = new System.Drawing.Size(236, 22);
            this.deleteGenre.Text = "Удалить жанр";
            this.deleteGenre.Click += new System.EventHandler(this.deleteGenre_Click);
            // 
            // deleteDirect
            // 
            this.deleteDirect.Name = "deleteDirect";
            this.deleteDirect.Size = new System.Drawing.Size(236, 22);
            this.deleteDirect.Text = "Удалить направление";
            this.deleteDirect.Click += new System.EventHandler(this.deleteDirect_Click);
            // 
            // изменениеToolStripMenuItem
            // 
            this.изменениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeComp,
            this.changeAlbum,
            this.changePerf,
            this.changeGenre,
            this.changeDirect});
            this.изменениеToolStripMenuItem.Name = "изменениеToolStripMenuItem";
            this.изменениеToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.изменениеToolStripMenuItem.Text = "Изменение";
            // 
            // changeComp
            // 
            this.changeComp.Name = "changeComp";
            this.changeComp.Size = new System.Drawing.Size(246, 22);
            this.changeComp.Text = "Изменить произведение";
            this.changeComp.Click += new System.EventHandler(this.changeComp_Click);
            // 
            // changeAlbum
            // 
            this.changeAlbum.Name = "changeAlbum";
            this.changeAlbum.Size = new System.Drawing.Size(246, 22);
            this.changeAlbum.Text = "Изменить альбом";
            this.changeAlbum.Click += new System.EventHandler(this.changeAlbum_Click);
            // 
            // changePerf
            // 
            this.changePerf.Name = "changePerf";
            this.changePerf.Size = new System.Drawing.Size(246, 22);
            this.changePerf.Text = "Изменить исполнителя/группу";
            this.changePerf.Click += new System.EventHandler(this.changePerf_Click);
            // 
            // changeGenre
            // 
            this.changeGenre.Name = "changeGenre";
            this.changeGenre.Size = new System.Drawing.Size(246, 22);
            this.changeGenre.Text = "Изменить жанр";
            this.changeGenre.Click += new System.EventHandler(this.changeGenre_Click);
            // 
            // changeDirect
            // 
            this.changeDirect.Name = "changeDirect";
            this.changeDirect.Size = new System.Drawing.Size(246, 22);
            this.changeDirect.Text = "Изменить направление";
            this.changeDirect.Click += new System.EventHandler(this.changeDirect_Click);
            // 
            // queryEdit
            // 
            this.queryEdit.Name = "queryEdit";
            this.queryEdit.Size = new System.Drawing.Size(144, 20);
            this.queryEdit.Text = "Произвольный запрос";
            this.queryEdit.Click += new System.EventHandler(this.queryEdit_Click);
            // 
            // playList
            // 
            this.playList.Name = "playList";
            this.playList.Size = new System.Drawing.Size(134, 20);
            this.playList.Text = "Подобрать плейлист";
            this.playList.Click += new System.EventHandler(this.playList_Click);
            // 
            // directGenre
            // 
            this.directGenre.BackgroundImage = global::Course.Properties.Resources.index;
            this.directGenre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.directGenre.Location = new System.Drawing.Point(163, 90);
            this.directGenre.Name = "directGenre";
            this.directGenre.Size = new System.Drawing.Size(266, 99);
            this.directGenre.TabIndex = 5;
            this.toolTip1.SetToolTip(this.directGenre, "О жанрах и направлениях");
            this.directGenre.UseVisualStyleBackColor = true;
            this.directGenre.Click += new System.EventHandler(this.button4_Click);
            // 
            // compSelect
            // 
            this.compSelect.BackgroundImage = global::Course.Properties.Resources.ha1fTYAOPho;
            this.compSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.compSelect.Location = new System.Drawing.Point(204, 212);
            this.compSelect.Name = "compSelect";
            this.compSelect.Size = new System.Drawing.Size(188, 129);
            this.compSelect.TabIndex = 4;
            this.toolTip1.SetToolTip(this.compSelect, "Поиск по произведениям");
            this.compSelect.UseVisualStyleBackColor = true;
            this.compSelect.Click += new System.EventHandler(this.button3_Click);
            // 
            // albumSelect
            // 
            this.albumSelect.BackgroundImage = global::Course.Properties.Resources.wpapers_ru_Золотые_диски;
            this.albumSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.albumSelect.Location = new System.Drawing.Point(12, 212);
            this.albumSelect.Name = "albumSelect";
            this.albumSelect.Size = new System.Drawing.Size(186, 129);
            this.albumSelect.TabIndex = 3;
            this.toolTip1.SetToolTip(this.albumSelect, "Поиск по альбомам");
            this.albumSelect.UseVisualStyleBackColor = true;
            this.albumSelect.Click += new System.EventHandler(this.button2_Click);
            // 
            // prefSelect
            // 
            this.prefSelect.BackgroundImage = global::Course.Properties.Resources.live_music_vector_silhouettes;
            this.prefSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prefSelect.Location = new System.Drawing.Point(400, 212);
            this.prefSelect.Name = "prefSelect";
            this.prefSelect.Size = new System.Drawing.Size(186, 129);
            this.prefSelect.TabIndex = 2;
            this.toolTip1.SetToolTip(this.prefSelect, "Поиск по исполнителям");
            this.prefSelect.UseVisualStyleBackColor = true;
            this.prefSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 376);
            this.Controls.Add(this.directGenre);
            this.Controls.Add(this.compSelect);
            this.Controls.Add(this.albumSelect);
            this.Controls.Add(this.prefSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Music Library";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.MainForm_HelpRequested);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem exitMenuStrip;
        private System.Windows.Forms.Button prefSelect;
        private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAlbum;
        private System.Windows.Forms.ToolStripMenuItem addPerf;
        private System.Windows.Forms.ToolStripMenuItem addDirect;
        private System.Windows.Forms.ToolStripMenuItem addGenre;
        private System.Windows.Forms.ToolStripMenuItem addComp;
        private System.Windows.Forms.ToolStripMenuItem удалениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAlbum;
        private System.Windows.Forms.ToolStripMenuItem deletePerf;
        private System.Windows.Forms.ToolStripMenuItem deleteDirect;
        private System.Windows.Forms.ToolStripMenuItem deleteGenre;
        private System.Windows.Forms.ToolStripMenuItem deleteComp;
        private System.Windows.Forms.ToolStripMenuItem изменениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeAlbum;
        private System.Windows.Forms.ToolStripMenuItem changePerf;
        private System.Windows.Forms.ToolStripMenuItem changeDirect;
        private System.Windows.Forms.ToolStripMenuItem changeGenre;
        private System.Windows.Forms.ToolStripMenuItem changeComp;
        private System.Windows.Forms.ToolStripMenuItem queryEdit;
        private System.Windows.Forms.Button albumSelect;
        private System.Windows.Forms.Button directGenre;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button compSelect;
        private System.Windows.Forms.ToolStripMenuItem playList;
    }
}

