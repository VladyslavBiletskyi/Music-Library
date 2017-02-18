namespace Course.Forms.Administration.Editing
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
            this.songBox = new System.Windows.Forms.RichTextBox();
            this.genreBox = new System.Windows.Forms.ComboBox();
            this.perfBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.compBox = new System.Windows.Forms.ComboBox();
            this.albumBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.compAuthor = new System.Windows.Forms.ComboBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.compAlbum = new System.Windows.Forms.ComboBox();
            this.charBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // songBox
            // 
            this.songBox.BackColor = System.Drawing.SystemColors.Control;
            this.songBox.Location = new System.Drawing.Point(379, 165);
            this.songBox.Name = "songBox";
            this.songBox.Size = new System.Drawing.Size(287, 183);
            this.songBox.TabIndex = 59;
            this.songBox.Text = "";
            // 
            // genreBox
            // 
            this.genreBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreBox.FormattingEnabled = true;
            this.genreBox.Location = new System.Drawing.Point(11, 141);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(287, 21);
            this.genreBox.TabIndex = 56;
            // 
            // perfBox
            // 
            this.perfBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.perfBox.FormattingEnabled = true;
            this.perfBox.Location = new System.Drawing.Point(12, 191);
            this.perfBox.Name = "perfBox";
            this.perfBox.Size = new System.Drawing.Size(287, 21);
            this.perfBox.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 22);
            this.label4.TabIndex = 51;
            this.label4.Text = "Жанр";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(378, 354);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(142, 41);
            this.cancelButton.TabIndex = 54;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 52;
            this.label3.Text = "Альбом";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(527, 354);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(139, 41);
            this.okButton.TabIndex = 55;
            this.okButton.Text = "Ок";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 53;
            this.label2.Text = "Автор";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(11, 94);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(287, 20);
            this.nameBox.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 22);
            this.label1.TabIndex = 49;
            this.label1.Text = "Название произведения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(343, 22);
            this.label5.TabIndex = 49;
            this.label5.Text = "Название редактируемого произведения:";
            // 
            // compBox
            // 
            this.compBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compBox.FormattingEnabled = true;
            this.compBox.Location = new System.Drawing.Point(12, 37);
            this.compBox.Name = "compBox";
            this.compBox.Size = new System.Drawing.Size(330, 21);
            this.compBox.TabIndex = 60;
            this.compBox.SelectedIndexChanged += new System.EventHandler(this.compBox_SelectedIndexChanged);
            // 
            // albumBox
            // 
            this.albumBox.BackColor = System.Drawing.SystemColors.Control;
            this.albumBox.FormattingEnabled = true;
            this.albumBox.Location = new System.Drawing.Point(12, 240);
            this.albumBox.Name = "albumBox";
            this.albumBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.albumBox.Size = new System.Drawing.Size(287, 134);
            this.albumBox.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(374, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(319, 22);
            this.label6.TabIndex = 49;
            this.label6.Text = "Автор редактируемого произведения:";
            // 
            // compAuthor
            // 
            this.compAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compAuthor.FormattingEnabled = true;
            this.compAuthor.Location = new System.Drawing.Point(425, 37);
            this.compAuthor.Name = "compAuthor";
            this.compAuthor.Size = new System.Drawing.Size(268, 21);
            this.compAuthor.TabIndex = 60;
            this.compAuthor.SelectedIndexChanged += new System.EventHandler(this.compAuthor_SelectedIndexChanged);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(579, 136);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(114, 23);
            this.filterButton.TabIndex = 62;
            this.filterButton.Text = "Сбросить фильтр";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(374, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(329, 22);
            this.label7.TabIndex = 49;
            this.label7.Text = "Альбом редактируемого произведения:";
            // 
            // compAlbum
            // 
            this.compAlbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compAlbum.FormattingEnabled = true;
            this.compAlbum.Location = new System.Drawing.Point(379, 109);
            this.compAlbum.Name = "compAlbum";
            this.compAlbum.Size = new System.Drawing.Size(314, 21);
            this.compAlbum.TabIndex = 60;
            this.compAlbum.SelectedIndexChanged += new System.EventHandler(this.compAlbum_SelectedIndexChanged);
            // 
            // charBox
            // 
            this.charBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.charBox.FormattingEnabled = true;
            this.charBox.Items.AddRange(new object[] {
            "=",
            "<>"});
            this.charBox.Location = new System.Drawing.Point(379, 37);
            this.charBox.Name = "charBox";
            this.charBox.Size = new System.Drawing.Size(41, 21);
            this.charBox.TabIndex = 64;
            // 
            // Composition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 407);
            this.Controls.Add(this.charBox);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.albumBox);
            this.Controls.Add(this.compAlbum);
            this.Controls.Add(this.compAuthor);
            this.Controls.Add(this.compBox);
            this.Controls.Add(this.songBox);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.perfBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Name = "Composition";
            this.Text = "Редактирование произведения";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Composition_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox songBox;
        private System.Windows.Forms.ComboBox genreBox;
        private System.Windows.Forms.ComboBox perfBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox compBox;
        private System.Windows.Forms.ListBox albumBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox compAuthor;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox compAlbum;
        private System.Windows.Forms.ComboBox charBox;
    }
}