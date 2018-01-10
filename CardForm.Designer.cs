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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.biblioteca2DataSet = new BibliotecaN.Biblioteca2DataSet();
            this.biblioteca2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_membri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioteca2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioteca2DataSetBindingSource)).BeginInit();
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
            this.dataGrid_membri.EnableHeadersVisualStyles = false;
            this.dataGrid_membri.Location = new System.Drawing.Point(37, 63);
            this.dataGrid_membri.Name = "dataGrid_membri";
            this.dataGrid_membri.ReadOnly = true;
            this.dataGrid_membri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_membri.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_membri.RowTemplate.Height = 24;
            this.dataGrid_membri.Size = new System.Drawing.Size(734, 306);
            this.dataGrid_membri.TabIndex = 0;
            // 
            // Titlu
            // 
            this.Titlu.HeaderText = "Titlu";
            this.Titlu.Name = "Titlu";
            this.Titlu.ReadOnly = true;
            this.Titlu.Width = 64;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Width = 68;
            // 
            // Data_imprumut
            // 
            this.Data_imprumut.HeaderText = "Data imprumut";
            this.Data_imprumut.Name = "Data_imprumut";
            this.Data_imprumut.ReadOnly = true;
            this.Data_imprumut.Width = 129;
            // 
            // Data_returnare
            // 
            this.Data_returnare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Data_returnare.HeaderText = "Data de returnare";
            this.Data_returnare.Name = "Data_returnare";
            this.Data_returnare.ReadOnly = true;
            this.Data_returnare.Width = 150;
            // 
            // stare_retur
            // 
            this.stare_retur.HeaderText = "Stare retur";
            this.stare_retur.Name = "stare_retur";
            this.stare_retur.ReadOnly = true;
            this.stare_retur.Width = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // textBox_nume_membru
            // 
            this.textBox_nume_membru.Location = new System.Drawing.Point(168, 15);
            this.textBox_nume_membru.Name = "textBox_nume_membru";
            this.textBox_nume_membru.Size = new System.Drawing.Size(401, 22);
            this.textBox_nume_membru.TabIndex = 2;
            // 
            // button_cautare
            // 
            this.button_cautare.Location = new System.Drawing.Point(610, 12);
            this.button_cautare.Name = "button_cautare";
            this.button_cautare.Size = new System.Drawing.Size(161, 32);
            this.button_cautare.TabIndex = 3;
            this.button_cautare.Text = "Cautare";
            this.button_cautare.UseVisualStyleBackColor = true;
            this.button_cautare.Click += new System.EventHandler(this.button_cautare_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nume membru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modificare data returnare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Titlu carte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data noua";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(303, 422);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(557, 422);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 22);
            this.textBox2.TabIndex = 9;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(303, 471);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(149, 48);
            this.button_update.TabIndex = 10;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(554, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "(MM/DD/YYYY)";
            // 
            // biblioteca2DataSet
            // 
            this.biblioteca2DataSet.DataSetName = "Biblioteca2DataSet";
            this.biblioteca2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // biblioteca2DataSetBindingSource
            // 
            this.biblioteca2DataSetBindingSource.DataSource = this.biblioteca2DataSet;
            this.biblioteca2DataSetBindingSource.Position = 0;
            // 
            // CardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 649);
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
            this.Name = "CardForm";
            this.Text = "CardForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_membri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioteca2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioteca2DataSetBindingSource)).EndInit();
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
        private Biblioteca2DataSet biblioteca2DataSet;
        private System.Windows.Forms.DataGridView dataGrid_membri;
    }
}