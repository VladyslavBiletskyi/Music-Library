namespace Course.Forms
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
            this.components = new System.ComponentModel.Container();
            this.nameLabel = new System.Windows.Forms.Label();
            this.songBox = new System.Windows.Forms.RichTextBox();
            this.listAlbums = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.perfLink = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.printButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(319, 39);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Название произведения";
            // 
            // songBox
            // 
            this.songBox.BackColor = System.Drawing.SystemColors.Control;
            this.songBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.songBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.songBox.Location = new System.Drawing.Point(51, 122);
            this.songBox.Name = "songBox";
            this.songBox.Size = new System.Drawing.Size(364, 239);
            this.songBox.TabIndex = 5;
            this.songBox.Text = "Текст песни недоступен";
            // 
            // listAlbums
            // 
            this.listAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listAlbums.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listAlbums.FormattingEnabled = true;
            this.listAlbums.HorizontalScrollbar = true;
            this.listAlbums.Location = new System.Drawing.Point(51, 402);
            this.listAlbums.Name = "listAlbums";
            this.listAlbums.Size = new System.Drawing.Size(328, 121);
            this.listAlbums.TabIndex = 9;
            this.listAlbums.SelectedIndexChanged += new System.EventHandler(this.listAlbums_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(51, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Список альбомов с произведением";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Исполнитель:";
            // 
            // perfLink
            // 
            this.perfLink.AutoSize = true;
            this.perfLink.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfLink.Location = new System.Drawing.Point(185, 51);
            this.perfLink.Name = "perfLink";
            this.perfLink.Size = new System.Drawing.Size(213, 33);
            this.perfLink.TabIndex = 11;
            this.perfLink.TabStop = true;
            this.perfLink.Text = "Имя исполнителя";
            this.perfLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.perfLink_LinkClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveButton,
            this.printButton});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 48);
            // 
            // saveButton
            // 
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(174, 22);
            this.saveButton.Text = "Сохранить отчет";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // printButton
            // 
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(174, 22);
            this.printButton.Text = "Распечатать отчет";
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // Composition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 534);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.perfLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listAlbums);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.songBox);
            this.Controls.Add(this.nameLabel);
            this.HelpButton = true;
            this.Name = "Composition";
            this.Text = "Детальная информация о произведении";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Composition_HelpRequested);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.RichTextBox songBox;
        private System.Windows.Forms.ListBox listAlbums;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel perfLink;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveButton;
        private System.Windows.Forms.ToolStripMenuItem printButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

    }
}