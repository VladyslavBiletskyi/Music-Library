namespace Course.Forms.Administration.Deleting
{
    partial class Album
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filterButton = new System.Windows.Forms.Button();
            this.albumPerf = new System.Windows.Forms.ComboBox();
            this.albumName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.compBox = new System.Windows.Forms.ListView();
            this.name = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.perf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(493, 62);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(108, 33);
            this.filterButton.TabIndex = 78;
            this.filterButton.Text = "Сбросить фильтр";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // albumPerf
            // 
            this.albumPerf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.albumPerf.FormattingEnabled = true;
            this.albumPerf.Location = new System.Drawing.Point(360, 35);
            this.albumPerf.Name = "albumPerf";
            this.albumPerf.Size = new System.Drawing.Size(241, 21);
            this.albumPerf.TabIndex = 76;
            this.albumPerf.SelectedIndexChanged += new System.EventHandler(this.albumPerf_SelectedIndexChanged);
            // 
            // albumName
            // 
            this.albumName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.albumName.FormattingEnabled = true;
            this.albumName.Location = new System.Drawing.Point(19, 35);
            this.albumName.Name = "albumName";
            this.albumName.Size = new System.Drawing.Size(276, 21);
            this.albumName.TabIndex = 77;
            this.albumName.SelectedIndexChanged += new System.EventHandler(this.albumName_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(356, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 22);
            this.label5.TabIndex = 67;
            this.label5.Text = "Автор удаляемого альбома";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 22);
            this.label4.TabIndex = 64;
            this.label4.Text = "Название удалемого альбома:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Course.Properties.Resources.no_image;
            this.pictureBox1.Location = new System.Drawing.Point(360, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(18, 336);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(103, 28);
            this.cancelButton.TabIndex = 70;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(194, 336);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(111, 28);
            this.okButton.TabIndex = 71;
            this.okButton.Text = "Ок";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(16, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 22);
            this.label6.TabIndex = 68;
            this.label6.Text = "Произведения в альбоме";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 69;
            this.label2.Text = "Автор:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 22);
            this.label3.TabIndex = 63;
            this.label3.Text = "Дата создания:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 65;
            this.label1.Text = "Название альбома:";
            // 
            // compBox
            // 
            this.compBox.Location = new System.Drawing.Point(20, 227);
            this.compBox.Name = "compBox";
            this.compBox.Size = new System.Drawing.Size(275, 103);
            this.compBox.TabIndex = 79;
            this.compBox.UseCompatibleStateImageBehavior = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(16, 78);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(158, 22);
            this.name.TabIndex = 65;
            this.name.Text = "Название альбома";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Location = new System.Drawing.Point(16, 129);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(133, 22);
            this.date.TabIndex = 63;
            this.date.Text = "Дата создания";
            // 
            // perf
            // 
            this.perf.AutoSize = true;
            this.perf.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perf.Location = new System.Drawing.Point(16, 173);
            this.perf.Name = "perf";
            this.perf.Size = new System.Drawing.Size(62, 22);
            this.perf.TabIndex = 69;
            this.perf.Text = "Автор";
            // 
            // Album
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 371);
            this.Controls.Add(this.compBox);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.albumPerf);
            this.Controls.Add(this.albumName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.perf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Name = "Album";
            this.Text = "Удаление альбома";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Album_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.ComboBox albumPerf;
        private System.Windows.Forms.ComboBox albumName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView compBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label perf;
    }
}