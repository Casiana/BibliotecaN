namespace BibliotecaN
{
    partial class BookList
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOrdonare = new System.Windows.Forms.ComboBox();
            this.checkBoxAsc = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(671, 437);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(691, 312);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ordoneaza dupa:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxOrdonare
            // 
            this.comboBoxOrdonare.FormattingEnabled = true;
            this.comboBoxOrdonare.Items.AddRange(new object[] {
            "Titlu",
            "Autor",
            "Domeniu",
            "Editura"});
            this.comboBoxOrdonare.Location = new System.Drawing.Point(128, 32);
            this.comboBoxOrdonare.Name = "comboBoxOrdonare";
            this.comboBoxOrdonare.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrdonare.TabIndex = 4;
            // 
            // checkBoxAsc
            // 
            this.checkBoxAsc.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.checkBoxAsc.AutoSize = true;
            this.checkBoxAsc.Checked = true;
            this.checkBoxAsc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAsc.Location = new System.Drawing.Point(284, 34);
            this.checkBoxAsc.Name = "checkBoxAsc";
            this.checkBoxAsc.Size = new System.Drawing.Size(44, 17);
            this.checkBoxAsc.TabIndex = 5;
            this.checkBoxAsc.Text = "Asc";
            this.checkBoxAsc.UseVisualStyleBackColor = true;
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 472);
            this.Controls.Add(this.checkBoxAsc);
            this.Controls.Add(this.comboBoxOrdonare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBack);
            this.MaximumSize = new System.Drawing.Size(784, 511);
            this.MinimumSize = new System.Drawing.Size(784, 511);
            this.Name = "BookList";
            this.Text = "BookList";
            this.Load += new System.EventHandler(this.BookList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOrdonare;
        private System.Windows.Forms.CheckBox checkBoxAsc;
    }
}