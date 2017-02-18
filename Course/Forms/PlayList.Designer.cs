namespace Course.Forms
{
    partial class PlayList
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
            this.perfBox = new System.Windows.Forms.CheckedListBox();
            this.genreBox = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listComps = new System.Windows.Forms.ListBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.varBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.len = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // perfBox
            // 
            this.perfBox.CheckOnClick = true;
            this.perfBox.FormattingEnabled = true;
            this.perfBox.Location = new System.Drawing.Point(12, 61);
            this.perfBox.Name = "perfBox";
            this.perfBox.Size = new System.Drawing.Size(282, 109);
            this.perfBox.TabIndex = 0;
            // 
            // genreBox
            // 
            this.genreBox.CheckOnClick = true;
            this.genreBox.FormattingEnabled = true;
            this.genreBox.Location = new System.Drawing.Point(300, 61);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(282, 109);
            this.genreBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(81, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(439, 22);
            this.label5.TabIndex = 67;
            this.label5.Text = "Выберите интересующие вас жанры и исполнителей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(127, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 22);
            this.label3.TabIndex = 67;
            this.label3.Text = "Ваш плейлист:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 39);
            this.button1.TabIndex = 81;
            this.button1.Text = "Подобрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listComps
            // 
            this.listComps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listComps.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listComps.FormattingEnabled = true;
            this.listComps.HorizontalScrollbar = true;
            this.listComps.Location = new System.Drawing.Point(42, 275);
            this.listComps.Name = "listComps";
            this.listComps.Size = new System.Drawing.Size(404, 199);
            this.listComps.TabIndex = 82;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(467, 341);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(115, 49);
            this.SaveButton.TabIndex = 83;
            this.SaveButton.Text = "Сохранить плейлист";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // varBox
            // 
            this.varBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.varBox.FormattingEnabled = true;
            this.varBox.Location = new System.Drawing.Point(266, 250);
            this.varBox.Name = "varBox";
            this.varBox.Size = new System.Drawing.Size(45, 21);
            this.varBox.TabIndex = 84;
            this.varBox.SelectedIndexChanged += new System.EventHandler(this.varBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 22);
            this.label1.TabIndex = 67;
            this.label1.Text = "Предполагаемая длительность";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(283, 197);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(37, 20);
            this.numericUpDown1.TabIndex = 85;
            this.numericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(326, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 67;
            this.label2.Text = "минут";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 22);
            this.label4.TabIndex = 67;
            this.label4.Text = "Примерная длительность плейлиста:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(381, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 22);
            this.label6.TabIndex = 67;
            this.label6.Text = "минут";
            // 
            // len
            // 
            this.len.AutoSize = true;
            this.len.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.len.Location = new System.Drawing.Point(338, 507);
            this.len.Name = "len";
            this.len.Size = new System.Drawing.Size(19, 22);
            this.len.TabIndex = 67;
            this.len.Text = "0";
            // 
            // PlayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 551);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.varBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.listComps);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.len);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.perfBox);
            this.HelpButton = true;
            this.Name = "PlayList";
            this.Text = "PlayList";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.PlayList_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox perfBox;
        private System.Windows.Forms.CheckedListBox genreBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listComps;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox varBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label len;
    }
}