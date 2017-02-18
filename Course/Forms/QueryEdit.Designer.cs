namespace Course.Forms
{
    partial class QueryEdit
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
            this.query = new System.Windows.Forms.RichTextBox();
            this.execButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // query
            // 
            this.query.BackColor = System.Drawing.SystemColors.Control;
            this.query.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.query.Location = new System.Drawing.Point(13, 13);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(381, 99);
            this.query.TabIndex = 0;
            this.query.Text = "SELECT";
            // 
            // execButton
            // 
            this.execButton.BackColor = System.Drawing.SystemColors.Control;
            this.execButton.Location = new System.Drawing.Point(401, 13);
            this.execButton.Name = "execButton";
            this.execButton.Size = new System.Drawing.Size(75, 40);
            this.execButton.TabIndex = 1;
            this.execButton.Text = "Выполнить запрос";
            this.execButton.UseVisualStyleBackColor = false;
            this.execButton.Click += new System.EventHandler(this.execButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(401, 72);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 40);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Очистить поле";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(463, 235);
            this.dataGridView1.TabIndex = 2;
            // 
            // QueryEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 366);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.execButton);
            this.Controls.Add(this.query);
            this.HelpButton = true;
            this.Name = "QueryEdit";
            this.Text = "Произвольный запрос к базе";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.QueryEdit_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox query;
        private System.Windows.Forms.Button execButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}