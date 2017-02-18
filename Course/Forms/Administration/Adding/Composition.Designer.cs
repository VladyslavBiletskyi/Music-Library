namespace Course.Forms.Administration.Adding
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
            this.perfBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.albumBox = new System.Windows.Forms.ComboBox();
            this.songBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.genreBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // perfBox
            // 
            this.perfBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.perfBox.FormattingEnabled = true;
            this.perfBox.Location = new System.Drawing.Point(22, 103);
            this.perfBox.Name = "perfBox";
            this.perfBox.Size = new System.Drawing.Size(287, 21);
            this.perfBox.TabIndex = 47;
            this.perfBox.SelectedIndexChanged += new System.EventHandler(this.perfBox_SelectedIndexChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(22, 439);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(103, 23);
            this.cancelButton.TabIndex = 45;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(198, 439);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(111, 23);
            this.okButton.TabIndex = 46;
            this.okButton.Text = "Ок";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 44;
            this.label2.Text = "Автор";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(22, 50);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(287, 20);
            this.nameBox.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "Название произведения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 44;
            this.label3.Text = "Альбом";
            // 
            // albumBox
            // 
            this.albumBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.albumBox.FormattingEnabled = true;
            this.albumBox.Location = new System.Drawing.Point(22, 153);
            this.albumBox.Name = "albumBox";
            this.albumBox.Size = new System.Drawing.Size(287, 21);
            this.albumBox.TabIndex = 47;
            // 
            // songBox
            // 
            this.songBox.BackColor = System.Drawing.SystemColors.Control;
            this.songBox.Location = new System.Drawing.Point(22, 239);
            this.songBox.Name = "songBox";
            this.songBox.Size = new System.Drawing.Size(287, 194);
            this.songBox.TabIndex = 48;
            this.songBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(18, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 22);
            this.label4.TabIndex = 44;
            this.label4.Text = "Жанр";
            // 
            // genreBox
            // 
            this.genreBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreBox.FormattingEnabled = true;
            this.genreBox.Location = new System.Drawing.Point(22, 203);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(287, 21);
            this.genreBox.TabIndex = 47;
            // 
            // Composition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 480);
            this.Controls.Add(this.songBox);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.albumBox);
            this.Controls.Add(this.perfBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Name = "Composition";
            this.Text = "Добавление произведения";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Composition_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox perfBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox albumBox;
        private System.Windows.Forms.RichTextBox songBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox genreBox;
    }
}