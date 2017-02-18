namespace Course.Forms.Administration.Editing
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.photoButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.perfBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.albumName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.albumPerf = new System.Windows.Forms.ComboBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.compBox = new System.Windows.Forms.ListBox();
            this.charBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Course.Properties.Resources.no_image;
            this.pictureBox1.Location = new System.Drawing.Point(362, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // photoButton
            // 
            this.photoButton.Location = new System.Drawing.Point(362, 335);
            this.photoButton.Name = "photoButton";
            this.photoButton.Size = new System.Drawing.Size(218, 28);
            this.photoButton.TabIndex = 48;
            this.photoButton.Text = "Выбрать фото";
            this.photoButton.UseVisualStyleBackColor = true;
            this.photoButton.Click += new System.EventHandler(this.photoButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(20, 335);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(103, 28);
            this.cancelButton.TabIndex = 46;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(196, 335);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(111, 28);
            this.okButton.TabIndex = 47;
            this.okButton.Text = "Ок";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 45;
            this.label2.Text = "Автор";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(21, 81);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(315, 20);
            this.nameBox.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 22);
            this.label3.TabIndex = 42;
            this.label3.Text = "Дата создания:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 43;
            this.label1.Text = "Название альбома:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // perfBox
            // 
            this.perfBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.perfBox.FormattingEnabled = true;
            this.perfBox.Location = new System.Drawing.Point(21, 176);
            this.perfBox.Name = "perfBox";
            this.perfBox.Size = new System.Drawing.Size(276, 21);
            this.perfBox.TabIndex = 51;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // albumName
            // 
            this.albumName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.albumName.FormattingEnabled = true;
            this.albumName.Location = new System.Drawing.Point(21, 34);
            this.albumName.Name = "albumName";
            this.albumName.Size = new System.Drawing.Size(276, 21);
            this.albumName.TabIndex = 52;
            this.albumName.SelectedIndexChanged += new System.EventHandler(this.albumName_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(22, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 22);
            this.label4.TabIndex = 43;
            this.label4.Text = "Название изменяемого альбома:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(358, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 22);
            this.label5.TabIndex = 45;
            this.label5.Text = "Автор изменяемого альбома";
            // 
            // albumPerf
            // 
            this.albumPerf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.albumPerf.FormattingEnabled = true;
            this.albumPerf.Location = new System.Drawing.Point(362, 34);
            this.albumPerf.Name = "albumPerf";
            this.albumPerf.Size = new System.Drawing.Size(241, 21);
            this.albumPerf.TabIndex = 52;
            this.albumPerf.SelectedIndexChanged += new System.EventHandler(this.albumPerf_SelectedIndexChanged);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(488, 61);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(115, 33);
            this.filterButton.TabIndex = 53;
            this.filterButton.Text = "Сбросить фильтр";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(18, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 22);
            this.label6.TabIndex = 45;
            this.label6.Text = "Произведения в альбоме";
            // 
            // compBox
            // 
            this.compBox.BackColor = System.Drawing.SystemColors.Control;
            this.compBox.FormattingEnabled = true;
            this.compBox.Location = new System.Drawing.Point(21, 234);
            this.compBox.Name = "compBox";
            this.compBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.compBox.Size = new System.Drawing.Size(287, 95);
            this.compBox.TabIndex = 62;
            // 
            // charBox
            // 
            this.charBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.charBox.FormattingEnabled = true;
            this.charBox.Items.AddRange(new object[] {
            "=",
            "<>"});
            this.charBox.Location = new System.Drawing.Point(441, 61);
            this.charBox.Name = "charBox";
            this.charBox.Size = new System.Drawing.Size(41, 21);
            this.charBox.TabIndex = 63;
            // 
            // Album
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 377);
            this.Controls.Add(this.charBox);
            this.Controls.Add(this.compBox);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.albumPerf);
            this.Controls.Add(this.albumName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.photoButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.perfBox);
            this.Controls.Add(this.dateTimePicker1);
            this.HelpButton = true;
            this.Name = "Album";
            this.Text = "Редактирование альбома";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Album_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button photoButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox perfBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox albumName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox albumPerf;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox compBox;
        private System.Windows.Forms.ComboBox charBox;
    }
}