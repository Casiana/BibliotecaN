﻿namespace BibliotecaN
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
            this.SuspendLayout();
            // 
            // add_book
            // 
            this.add_book.Location = new System.Drawing.Point(12, 12);
            this.add_book.Name = "add_book";
            this.add_book.Size = new System.Drawing.Size(141, 33);
            this.add_book.TabIndex = 0;
            this.add_book.Text = "Adauga carte";
            this.add_book.UseVisualStyleBackColor = true;
            this.add_book.Click += new System.EventHandler(this.add_book_Click);
            // 
            // add_domain
            // 
            this.add_domain.Location = new System.Drawing.Point(12, 61);
            this.add_domain.Name = "add_domain";
            this.add_domain.Size = new System.Drawing.Size(141, 33);
            this.add_domain.TabIndex = 1;
            this.add_domain.Text = "Adauga domeniu";
            this.add_domain.UseVisualStyleBackColor = true;
            this.add_domain.Click += new System.EventHandler(this.add_domain_Click);
            // 
            // add_author
            // 
            this.add_author.Location = new System.Drawing.Point(12, 111);
            this.add_author.Name = "add_author";
            this.add_author.Size = new System.Drawing.Size(141, 33);
            this.add_author.TabIndex = 2;
            this.add_author.Text = "Adauga autor";
            this.add_author.UseVisualStyleBackColor = true;
            this.add_author.Click += new System.EventHandler(this.add_author_Click);
            // 
            // domain_text
            // 
            this.domain_text.Location = new System.Drawing.Point(159, 66);
            this.domain_text.Name = "domain_text";
            this.domain_text.Size = new System.Drawing.Size(131, 22);
            this.domain_text.TabIndex = 3;
            // 
            // author_text
            // 
            this.author_text.Location = new System.Drawing.Point(159, 116);
            this.author_text.Name = "author_text";
            this.author_text.Size = new System.Drawing.Size(131, 22);
            this.author_text.TabIndex = 4;
            // 
            // publisher_text
            // 
            this.publisher_text.Location = new System.Drawing.Point(159, 168);
            this.publisher_text.Name = "publisher_text";
            this.publisher_text.Size = new System.Drawing.Size(131, 22);
            this.publisher_text.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Adauga editura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 485);
            this.Controls.Add(this.publisher_text);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.author_text);
            this.Controls.Add(this.domain_text);
            this.Controls.Add(this.add_author);
            this.Controls.Add(this.add_domain);
            this.Controls.Add(this.add_book);
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
    }
}