namespace BibliotecaN
{
    partial class AdministratorForm
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
            this.add_book = new System.Windows.Forms.Button();
            this.add_domain = new System.Windows.Forms.Button();
            this.add_author = new System.Windows.Forms.Button();
            this.domain_text = new System.Windows.Forms.TextBox();
            this.author_text = new System.Windows.Forms.TextBox();
            this.publisher_text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.membru_combo = new System.Windows.Forms.ComboBox();
            this.carte_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_show = new System.Windows.Forms.Button();
            this.button_retur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_book
            // 
            this.add_book.Location = new System.Drawing.Point(62, 311);
            this.add_book.Name = "add_book";
            this.add_book.Size = new System.Drawing.Size(143, 89);
            this.add_book.TabIndex = 0;
            this.add_book.Text = "Adauga carte";
            this.add_book.UseVisualStyleBackColor = true;
            this.add_book.Click += new System.EventHandler(this.add_book_Click);
            // 
            // add_domain
            // 
            this.add_domain.Location = new System.Drawing.Point(62, 105);
            this.add_domain.Name = "add_domain";
            this.add_domain.Size = new System.Drawing.Size(143, 79);
            this.add_domain.TabIndex = 1;
            this.add_domain.Text = "Adauga domeniu";
            this.add_domain.UseVisualStyleBackColor = true;
            this.add_domain.Click += new System.EventHandler(this.add_domain_Click);
            // 
            // add_author
            // 
            this.add_author.Location = new System.Drawing.Point(308, 105);
            this.add_author.Name = "add_author";
            this.add_author.Size = new System.Drawing.Size(151, 79);
            this.add_author.TabIndex = 2;
            this.add_author.Text = "Adauga autor";
            this.add_author.UseVisualStyleBackColor = true;
            this.add_author.Click += new System.EventHandler(this.add_author_Click);
            // 
            // domain_text
            // 
            this.domain_text.Location = new System.Drawing.Point(62, 206);
            this.domain_text.Name = "domain_text";
            this.domain_text.Size = new System.Drawing.Size(143, 22);
            this.domain_text.TabIndex = 3;
            // 
            // author_text
            // 
            this.author_text.Location = new System.Drawing.Point(308, 206);
            this.author_text.Name = "author_text";
            this.author_text.Size = new System.Drawing.Size(151, 22);
            this.author_text.TabIndex = 4;
            // 
            // publisher_text
            // 
            this.publisher_text.Location = new System.Drawing.Point(561, 206);
            this.publisher_text.Name = "publisher_text";
            this.publisher_text.Size = new System.Drawing.Size(159, 22);
            this.publisher_text.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(560, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 79);
            this.button1.TabIndex = 5;
            this.button1.Text = "Adauga editura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(829, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 79);
            this.button2.TabIndex = 7;
            this.button2.Text = "Adauga Imprumut";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // membru_combo
            // 
            this.membru_combo.FormattingEnabled = true;
            this.membru_combo.Location = new System.Drawing.Point(884, 204);
            this.membru_combo.Name = "membru_combo";
            this.membru_combo.Size = new System.Drawing.Size(170, 24);
            this.membru_combo.TabIndex = 8;
            // 
            // carte_combo
            // 
            this.carte_combo.FormattingEnabled = true;
            this.carte_combo.Location = new System.Drawing.Point(884, 239);
            this.carte_combo.Name = "carte_combo";
            this.carte_combo.Size = new System.Drawing.Size(170, 24);
            this.carte_combo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(815, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Membru:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(815, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Carte:";
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(308, 311);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(151, 89);
            this.button_show.TabIndex = 13;
            this.button_show.Text = "Fise de imprumut";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_library_card_Click);
            // 
            // button_retur
            // 
            this.button_retur.Location = new System.Drawing.Point(931, 105);
            this.button_retur.Name = "button_retur";
            this.button_retur.Size = new System.Drawing.Size(97, 79);
            this.button_retur.TabIndex = 14;
            this.button_retur.Text = "Adauga retur";
            this.button_retur.UseVisualStyleBackColor = true;
            this.button_retur.Click += new System.EventHandler(this.button_retur_Click);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 577);
            this.Controls.Add(this.button_retur);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carte_combo);
            this.Controls.Add(this.membru_combo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.publisher_text);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.author_text);
            this.Controls.Add(this.domain_text);
            this.Controls.Add(this.add_author);
            this.Controls.Add(this.add_domain);
            this.Controls.Add(this.add_book);
            this.Name = "AdministratorForm";
            this.Text = "AdministratorForm";
            this.Load += new System.EventHandler(this.AdministratorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_book;
        private System.Windows.Forms.Button add_domain;
        private System.Windows.Forms.Button add_author;
        private System.Windows.Forms.TextBox domain_text;
        private System.Windows.Forms.TextBox author_text;
        private System.Windows.Forms.TextBox publisher_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox membru_combo;
        private System.Windows.Forms.ComboBox carte_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Button button_retur;
    }
}