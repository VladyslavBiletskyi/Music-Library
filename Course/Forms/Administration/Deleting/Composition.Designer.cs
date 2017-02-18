namespace Course.Forms.Administration.Deleting
{
    partial class Composition
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
            this.compAlbum = new System.Windows.Forms.ComboBox();
            this.compAuthor = new System.Windows.Forms.ComboBox();
            this.compBox = new System.Windows.Forms.ComboBox();
            this.songBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.perf = new System.Windows.Forms.Label();
            this.albumBox = new System.Windows.Forms.ListView();
            this.name = new System.Windows.Forms.Label();
            this.charBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(579, 126);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(114, 23);
            this.filterButton.TabIndex = 80;
            this.filterButton.Text = "Сбросить фильтр";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // compAlbum
            // 
            this.compAlbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compAlbum.FormattingEnabled = true;
            this.compAlbum.Location = new System.Drawing.Point(378, 94);
            this.compAlbum.Name = "compAlbum";
            this.compAlbum.Size = new System.Drawing.Size(314, 21);
            this.compAlbum.TabIndex = 78;
            this.compAlbum.SelectedIndexChanged += new System.EventHandler(this.compAlbum_SelectedIndexChanged);
            // 
            // compAuthor
            // 
            this.compAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compAuthor.FormattingEnabled = true;
            this.compAuthor.Location = new System.Drawing.Point(420, 38);
            this.compAuthor.Name = "compAuthor";
            this.compAuthor.Size = new System.Drawing.Size(273, 21);
            this.compAuthor.TabIndex = 77;
            this.compAuthor.SelectedIndexChanged += new System.EventHandler(this.compAuthor_SelectedIndexChanged);
            // 
            // compBox
            // 
            this.compBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compBox.FormattingEnabled = true;
            this.compBox.Location = new System.Drawing.Point(12, 38);
            this.compBox.Name = "compBox";
            this.compBox.Size = new System.Drawing.Size(330, 21);
            this.compBox.TabIndex = 76;
            this.compBox.SelectedIndexChanged += new System.EventHandler(this.compBox_SelectedIndexChanged);
            // 
            // songBox
            // 
            this.songBox.BackColor = System.Drawing.SystemColors.Control;
            this.songBox.Location = new System.Drawing.Point(379, 155);
            this.songBox.Name = "songBox";
            this.songBox.ReadOnly = true;
            this.songBox.Size = new System.Drawing.Size(287, 194);
            this.songBox.TabIndex = 75;
            this.songBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 68;
            this.label4.Text = "Жанр:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(378, 355);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(142, 41);
            this.cancelButton.TabIndex = 71;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 69;
            this.label3.Text = "Альбомы";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(527, 355);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(139, 41);
            this.okButton.TabIndex = 72;
            this.okButton.Text = "Удалить произведение";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(373, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(290, 22);
            this.label7.TabIndex = 65;
            this.label7.Text = "Альбом удаляемого произведения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 70;
            this.label2.Text = "Автор:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(374, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 22);
            this.label6.TabIndex = 64;
            this.label6.Text = "Автор удаляемого произведения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 22);
            this.label5.TabIndex = 66;
            this.label5.Text = "Название удаляемого произведения:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 22);
            this.label1.TabIndex = 63;
            this.label1.Text = "Название произведения:";
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genre.Location = new System.Drawing.Point(7, 140);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(55, 22);
            this.genre.TabIndex = 68;
            this.genre.Text = "Жанр";
            // 
            // perf
            // 
            this.perf.AutoSize = true;
            this.perf.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perf.Location = new System.Drawing.Point(8, 184);
            this.perf.Name = "perf";
            this.perf.Size = new System.Drawing.Size(62, 22);
            this.perf.TabIndex = 70;
            this.perf.Text = "Автор";
            // 
            // albumBox
            // 
            this.albumBox.Location = new System.Drawing.Point(10, 242);
            this.albumBox.Name = "albumBox";
            this.albumBox.Size = new System.Drawing.Size(279, 107);
            this.albumBox.TabIndex = 81;
            this.albumBox.UseCompatibleStateImageBehavior = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(6, 90);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(200, 22);
            this.name.TabIndex = 63;
            this.name.Text = "Название произведения";
            // 
            // charBox
            // 
            this.charBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.charBox.FormattingEnabled = true;
            this.charBox.Items.AddRange(new object[] {
            "=",
            "<>"});
            this.charBox.Location = new System.Drawing.Point(377, 38);
            this.charBox.Name = "charBox";
            this.charBox.Size = new System.Drawing.Size(41, 21);
            this.charBox.TabIndex = 82;
            // 
            // Composition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 408);
            this.Controls.Add(this.charBox);
            this.Controls.Add(this.albumBox);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.compAlbum);
            this.Controls.Add(this.compAuthor);
            this.Controls.Add(this.compBox);
            this.Controls.Add(this.songBox);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.perf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Name = "Composition";
            this.Text = "Удаление произведения";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Composition_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.ComboBox compAlbum;
        private System.Windows.Forms.ComboBox compAuthor;
        private System.Windows.Forms.ComboBox compBox;
        private System.Windows.Forms.RichTextBox songBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Label perf;
        private System.Windows.Forms.ListView albumBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ComboBox charBox;

    }
}