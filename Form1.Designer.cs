namespace marketingAcquisition
{
    partial class Form1
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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnAddEdit = new System.Windows.Forms.Button();
            this.btnAssignWork = new System.Windows.Forms.Button();
            this.btnDataUpload = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.AutoSize = true;
            this.pnlBody.Location = new System.Drawing.Point(0, 46);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(594, 652);
            this.pnlBody.TabIndex = 0;
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(0, 3);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(84, 37);
            this.btnToday.TabIndex = 1;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnContact
            // 
            this.btnContact.Location = new System.Drawing.Point(90, 3);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(85, 37);
            this.btnContact.TabIndex = 2;
            this.btnContact.Text = "Contact";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnAddEdit
            // 
            this.btnAddEdit.Location = new System.Drawing.Point(181, 3);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.Size = new System.Drawing.Size(114, 37);
            this.btnAddEdit.TabIndex = 3;
            this.btnAddEdit.Text = "Add Contact";
            this.btnAddEdit.UseVisualStyleBackColor = true;
            this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
            // 
            // btnAssignWork
            // 
            this.btnAssignWork.Location = new System.Drawing.Point(301, 3);
            this.btnAssignWork.Name = "btnAssignWork";
            this.btnAssignWork.Size = new System.Drawing.Size(86, 37);
            this.btnAssignWork.TabIndex = 4;
            this.btnAssignWork.Text = "Assign Work";
            this.btnAssignWork.UseVisualStyleBackColor = true;
            this.btnAssignWork.Click += new System.EventHandler(this.btnAssignWork_Click);
            // 
            // btnDataUpload
            // 
            this.btnDataUpload.Location = new System.Drawing.Point(393, 3);
            this.btnDataUpload.Name = "btnDataUpload";
            this.btnDataUpload.Size = new System.Drawing.Size(80, 37);
            this.btnDataUpload.TabIndex = 5;
            this.btnDataUpload.Text = "Data Upload";
            this.btnDataUpload.UseVisualStyleBackColor = true;
            this.btnDataUpload.Click += new System.EventHandler(this.btnDataUpload_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.Location = new System.Drawing.Point(479, 3);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(80, 37);
            this.btnStatistic.TabIndex = 6;
            this.btnStatistic.Text = "Statistic";
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(594, 698);
            this.Controls.Add(this.btnStatistic);
            this.Controls.Add(this.btnDataUpload);
            this.Controls.Add(this.btnAssignWork);
            this.Controls.Add(this.btnAddEdit);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.pnlBody);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnAddEdit;
        private System.Windows.Forms.Button btnAssignWork;
        private System.Windows.Forms.Button btnDataUpload;
        private System.Windows.Forms.Button btnStatistic;



    }
}

