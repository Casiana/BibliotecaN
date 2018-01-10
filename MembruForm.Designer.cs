namespace BibliotecaN
{
    partial class MembruForm
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
            this.buttonMember = new System.Windows.Forms.Button();
            this.buttonBookList = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonBorrow = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonBookRequest = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMember
            // 
            this.buttonMember.Location = new System.Drawing.Point(40, 107);
            this.buttonMember.Name = "buttonMember";
            this.buttonMember.Size = new System.Drawing.Size(137, 113);
            this.buttonMember.TabIndex = 0;
            this.buttonMember.Text = "Member Information";
            this.buttonMember.UseVisualStyleBackColor = true;
            this.buttonMember.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBookList
            // 
            this.buttonBookList.Location = new System.Drawing.Point(225, 107);
            this.buttonBookList.Name = "buttonBookList";
            this.buttonBookList.Size = new System.Drawing.Size(137, 113);
            this.buttonBookList.TabIndex = 1;
            this.buttonBookList.Text = "Book List";
            this.buttonBookList.UseVisualStyleBackColor = true;
            this.buttonBookList.Click += new System.EventHandler(this.buttonBookList_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(416, 107);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(137, 113);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search Book";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.Location = new System.Drawing.Point(591, 107);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(137, 113);
            this.buttonBorrow.TabIndex = 3;
            this.buttonBorrow.Text = "Borrow List";
            this.buttonBorrow.UseVisualStyleBackColor = true;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(40, 265);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(137, 113);
            this.buttonSettings.TabIndex = 4;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(225, 265);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(137, 113);
            this.buttonReport.TabIndex = 5;
            this.buttonReport.Text = "Report";
            this.buttonReport.UseVisualStyleBackColor = true;
            // 
            // buttonBookRequest
            // 
            this.buttonBookRequest.Location = new System.Drawing.Point(416, 265);
            this.buttonBookRequest.Name = "buttonBookRequest";
            this.buttonBookRequest.Size = new System.Drawing.Size(137, 113);
            this.buttonBookRequest.TabIndex = 6;
            this.buttonBookRequest.Text = "Book Request";
            this.buttonBookRequest.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(591, 265);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(137, 113);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // MembruForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 472);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonBookRequest);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonBorrow);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonBookList);
            this.Controls.Add(this.buttonMember);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(784, 511);
            this.MinimumSize = new System.Drawing.Size(784, 511);
            this.Name = "MembruForm";
            this.Text = "MembruForm";
            this.Load += new System.EventHandler(this.MembruForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMember;
        private System.Windows.Forms.Button buttonBookList;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonBorrow;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonBookRequest;
        private System.Windows.Forms.Button buttonLogout;
    }
}