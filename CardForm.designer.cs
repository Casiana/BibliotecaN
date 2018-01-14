namespace BibliotecaN
{
    partial class CardForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardForm));
            this.dataGrid_membri = new System.Windows.Forms.DataGridView();
            this.Titlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_imprumut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_returnare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stare_retur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nume_membru = new System.Windows.Forms.TextBox();
            this.button_cautare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.biblioteca2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_membri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioteca2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_membri
            // 
            this.dataGrid_membri.AllowUserToAddRows = false;
            this.dataGrid_membri.AllowUserToDeleteRows = false;
            this.dataGrid_membri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid_membri.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGrid_membri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_membri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titlu,
            this.ISBN,
            this.Data_imprumut,
            this.Data_returnare,
            this.stare_retur});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_membri.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid_membri.EnableHeadersVisualStyles = false;
            this.dataGrid_membri.Location = new System.Drawing.Point(28, 51);
            this.dataGrid_membri.Margin = new System.Windows.Forms.Padding(2);
            this.dataGrid_membri.Name = "dataGrid_membri";
            this.dataGrid_membri.ReadOnly = true;
            this.dataGrid_membri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_membri.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid_membri.RowTemplate.Height = 24;
            this.dataGrid_membri.Size = new System.Drawing.Size(550, 249);
            this.dataGrid_membri.TabIndex = 0;
            // 
            // Titlu
            // 
            this.Titlu.HeaderText = "Titlu";
            this.Titlu.Name = "Titlu";
            this.Titlu.ReadOnly = true;
            this.Titlu.Width = 52;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Width = 57;
            // 
            // Data_imprumut
            // 
            this.Data_imprumut.HeaderText = "Data imprumut";
            this.Data_imprumut.Name = "Data_imprumut";
            this.Data_imprumut.ReadOnly = true;
            this.Data_imprumut.Width = 92;
            // 
            // Data_returnare
            // 
            this.Data_returnare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Data_returnare.HeaderText = "Data de returnare";
            this.Data_returnare.Name = "Data_returnare";
            this.Data_returnare.ReadOnly = true;
            this.Data_returnare.Width = 105;
            // 
            // stare_retur
            // 
            this.stare_retur.HeaderText = "Stare retur";
            this.stare_retur.Name = "stare_retur";
            this.stare_retur.ReadOnly = true;
            this.stare_retur.Width = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // textBox_nume_membru
            // 
            this.textBox_nume_membru.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_nume_membru.Location = new System.Drawing.Point(126, 12);
            this.textBox_nume_membru.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_nume_membru.Name = "textBox_nume_membru";
            this.textBox_nume_membru.Size = new System.Drawing.Size(302, 20);
            this.textBox_nume_membru.TabIndex = 2;
            // 
            // button_cautare
            // 
            this.button_cautare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cautare.Location = new System.Drawing.Point(458, 10);
            this.button_cautare.Margin = new System.Windows.Forms.Padding(2);
            this.button_cautare.Name = "button_cautare";
            this.button_cautare.Size = new System.Drawing.Size(121, 26);
            this.button_cautare.TabIndex = 3;
            this.button_cautare.Text = "Cautare";
            this.button_cautare.UseVisualStyleBackColor = true;
            this.button_cautare.Click += new System.EventHandler(this.button_cautare_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nume membru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 326);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modificare data returnare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 326);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Titlu carte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data noua";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(208, 343);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.Location = new System.Drawing.Point(416, 343);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 20);
            this.textBox2.TabIndex = 9;
            // 
            // button_update
            // 
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(208, 379);
            this.button_update.Margin = new System.Windows.Forms.Padding(2);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(332, 39);
            this.button_update.TabIndex = 10;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 363);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "(MM/DD/YYYY)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(582, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 239);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(29, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 136);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // CardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BibliotecaN.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(829, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_cautare);
            this.Controls.Add(this.textBox_nume_membru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_membri);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CardForm";
            this.Text = "la ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_membri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioteca2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nume_membru;
        private System.Windows.Forms.Button button_cautare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_imprumut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_returnare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn stare_retur;
        private System.Windows.Forms.BindingSource biblioteca2DataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGrid_membri;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.GroupBox groupBox1;
        //private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}