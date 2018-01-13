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
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_book
            // 
            this.add_book.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_book.ForeColor = System.Drawing.Color.Black;
            this.add_book.Location = new System.Drawing.Point(24, 374);
            this.add_book.Name = "add_book";
            this.add_book.Size = new System.Drawing.Size(209, 63);
            this.add_book.TabIndex = 0;
            this.add_book.Text = "Adauga carte";
            this.add_book.UseVisualStyleBackColor = true;
            this.add_book.Click += new System.EventHandler(this.add_book_Click);
            // 
            // add_domain
            // 
            this.add_domain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_domain.ForeColor = System.Drawing.Color.Black;
            this.add_domain.Location = new System.Drawing.Point(24, 91);
            this.add_domain.Name = "add_domain";
            this.add_domain.Size = new System.Drawing.Size(209, 67);
            this.add_domain.TabIndex = 1;
            this.add_domain.Text = "Adauga domeniu";
            this.add_domain.UseVisualStyleBackColor = true;
            this.add_domain.Click += new System.EventHandler(this.add_domain_Click);
            // 
            // add_author
            // 
            this.add_author.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_author.ForeColor = System.Drawing.Color.Black;
            this.add_author.Location = new System.Drawing.Point(24, 186);
            this.add_author.Name = "add_author";
            this.add_author.Size = new System.Drawing.Size(209, 73);
            this.add_author.TabIndex = 2;
            this.add_author.Text = "Adauga autor";
            this.add_author.UseVisualStyleBackColor = true;
            this.add_author.Click += new System.EventHandler(this.add_author_Click);
            // 
            // domain_text
            // 
            this.domain_text.Location = new System.Drawing.Point(248, 113);
            this.domain_text.Name = "domain_text";
            this.domain_text.Size = new System.Drawing.Size(159, 25);
            this.domain_text.TabIndex = 3;
            // 
            // author_text
            // 
            this.author_text.Location = new System.Drawing.Point(248, 210);
            this.author_text.Name = "author_text";
            this.author_text.Size = new System.Drawing.Size(159, 25);
            this.author_text.TabIndex = 4;
            // 
            // publisher_text
            // 
            this.publisher_text.Location = new System.Drawing.Point(248, 299);
            this.publisher_text.Name = "publisher_text";
            this.publisher_text.Size = new System.Drawing.Size(159, 25);
            this.publisher_text.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(24, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 67);
            this.button1.TabIndex = 5;
            this.button1.Text = "Adauga editura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(621, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 67);
            this.button2.TabIndex = 7;
            this.button2.Text = "Adauga Imprumut";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // membru_combo
            // 
            this.membru_combo.FormattingEnabled = true;
            this.membru_combo.Location = new System.Drawing.Point(691, 194);
            this.membru_combo.Name = "membru_combo";
            this.membru_combo.Size = new System.Drawing.Size(270, 25);
            this.membru_combo.TabIndex = 8;
            // 
            // carte_combo
            // 
            this.carte_combo.FormattingEnabled = true;
            this.carte_combo.Location = new System.Drawing.Point(691, 234);
            this.carte_combo.Name = "carte_combo";
            this.carte_combo.Size = new System.Drawing.Size(270, 25);
            this.carte_combo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(622, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Membru:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Carte:";
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(621, 299);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(340, 67);
            this.button_show.TabIndex = 13;
            this.button_show.Text = "Fise de imprumut";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_library_card_Click);
            // 
            // button_retur
            // 
            this.button_retur.Location = new System.Drawing.Point(796, 91);
            this.button_retur.Name = "button_retur";
            this.button_retur.Size = new System.Drawing.Size(165, 67);
            this.button_retur.TabIndex = 14;
            this.button_retur.Text = "Adauga retur";
            this.button_retur.UseVisualStyleBackColor = true;
            this.button_retur.Click += new System.EventHandler(this.button_retur_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(621, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(340, 63);
            this.button3.TabIndex = 15;
            this.button3.Text = "Creare raport";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 613);
            this.Controls.Add(this.button3);
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
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AdministratorForm";
            this.Text = "AdministratorForm";
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
        private System.Windows.Forms.Button button3;
    }
}