namespace marketingAcquisition
{
    partial class todayUc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgToday = new System.Windows.Forms.DataGridView();
            this.InstuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContPerProfile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgToday)).BeginInit();
            this.SuspendLayout();
            // 
            // dgToday
            // 
            this.dgToday.AllowUserToAddRows = false;
            this.dgToday.AllowUserToDeleteRows = false;
            this.dgToday.AllowUserToResizeColumns = false;
            this.dgToday.AllowUserToResizeRows = false;
            this.dgToday.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgToday.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgToday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgToday.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InstuName,
            this.Domain,
            this.comAddress,
            this.ContactPerson,
            this.ContPerProfile,
            this.ContactNo,
            this.ConEmail});
            this.dgToday.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgToday.Location = new System.Drawing.Point(0, 60);
            this.dgToday.Name = "dgToday";
            this.dgToday.RowHeadersVisible = false;
            this.dgToday.Size = new System.Drawing.Size(735, 312);
            this.dgToday.TabIndex = 0;
            // 
            // InstuName
            // 
            this.InstuName.HeaderText = "Institution Name";
            this.InstuName.Name = "InstuName";
            this.InstuName.ReadOnly = true;
            // 
            // Domain
            // 
            this.Domain.HeaderText = "Domain";
            this.Domain.Name = "Domain";
            this.Domain.ReadOnly = true;
            // 
            // comAddress
            // 
            this.comAddress.HeaderText = "Comp. Add.";
            this.comAddress.Name = "comAddress";
            // 
            // ContactPerson
            // 
            this.ContactPerson.HeaderText = "Con. Person";
            this.ContactPerson.Name = "ContactPerson";
            this.ContactPerson.ReadOnly = true;
            // 
            // ContPerProfile
            // 
            this.ContPerProfile.HeaderText = "Profile";
            this.ContPerProfile.Name = "ContPerProfile";
            this.ContPerProfile.ReadOnly = true;
            // 
            // ContactNo
            // 
            this.ContactNo.HeaderText = "Con No.";
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.ReadOnly = true;
            // 
            // ConEmail
            // 
            this.ConEmail.HeaderText = "Con, Email";
            this.ConEmail.Name = "ConEmail";
            this.ConEmail.ReadOnly = true;
            // 
            // todayUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.dgToday);
            this.Name = "todayUc";
            this.Size = new System.Drawing.Size(738, 520);
            ((System.ComponentModel.ISupportInitialize)(this.dgToday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgToday;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domain;
        private System.Windows.Forms.DataGridViewTextBoxColumn comAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContPerProfile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConEmail;
    }
}
