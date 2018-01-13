namespace BibliotecaN
{
    partial class FormImprumutate
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
            this.dataGridViewImprumutate = new System.Windows.Forms.DataGridView();
            this.comboBoxBorrow = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImprumutate)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(673, 437);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridViewImprumutate
            // 
            this.dataGridViewImprumutate.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewImprumutate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImprumutate.Location = new System.Drawing.Point(12, 103);
            this.dataGridViewImprumutate.Name = "dataGridViewImprumutate";
            this.dataGridViewImprumutate.Size = new System.Drawing.Size(736, 328);
            this.dataGridViewImprumutate.TabIndex = 2;
            // 
            // comboBoxBorrow
            // 
            this.comboBoxBorrow.FormattingEnabled = true;
            this.comboBoxBorrow.Items.AddRange(new object[] {
            "Titlu",
            "Autor",
            "Editura",
            "Domeniu",
            "Data_retur"});
            this.comboBoxBorrow.Location = new System.Drawing.Point(166, 32);
            this.comboBoxBorrow.Name = "comboBoxBorrow";
            this.comboBoxBorrow.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBorrow.TabIndex = 3;
            this.comboBoxBorrow.SelectedIndexChanged += new System.EventHandler(this.comboBoxBorrow_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxBorrow);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 73);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sorteaza dupa:";
            // 
            // FormImprumutate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BibliotecaN.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(768, 472);
            this.Controls.Add(this.dataGridViewImprumutate);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(784, 511);
            this.MinimumSize = new System.Drawing.Size(784, 511);
            this.Name = "FormImprumutate";
            this.Text = "Carti Imprumutate";
            this.Load += new System.EventHandler(this.FormImprumutate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImprumutate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridViewImprumutate;
        private System.Windows.Forms.ComboBox comboBoxBorrow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}