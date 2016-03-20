namespace marketingAcquisition
{
    partial class ContactList
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
            this.grdContactList = new System.Windows.Forms.DataGridView();
            this.pnlPager = new System.Windows.Forms.Panel();
            this.OrganizationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrgState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrgCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrgAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DomainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextCall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdContactList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdContactList
            // 
            this.grdContactList.AllowUserToAddRows = false;
            this.grdContactList.AllowUserToDeleteRows = false;
            this.grdContactList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grdContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContactList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrganizationId,
            this.OrgName,
            this.OrgState,
            this.OrgCity,
            this.OrgAddress,
            this.DomainName,
            this.CallStatusName,
            this.NextCall});
            this.grdContactList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grdContactList.Location = new System.Drawing.Point(3, 16);
            this.grdContactList.Name = "grdContactList";
            this.grdContactList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdContactList.Size = new System.Drawing.Size(571, 537);
            this.grdContactList.TabIndex = 0;
            this.grdContactList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdContactList_CellContentDoubleClick);
            // 
            // pnlPager
            // 
            this.pnlPager.Location = new System.Drawing.Point(3, 559);
            this.pnlPager.Name = "pnlPager";
            this.pnlPager.Size = new System.Drawing.Size(571, 41);
            this.pnlPager.TabIndex = 1;
            // 
            // OrganizationId
            // 
            this.OrganizationId.DataPropertyName = "OrganizationId";
            this.OrganizationId.HeaderText = "OrganizationId";
            this.OrganizationId.Name = "OrganizationId";
            this.OrganizationId.ReadOnly = true;
            this.OrganizationId.Visible = false;
            // 
            // OrgName
            // 
            this.OrgName.DataPropertyName = "OrgName";
            this.OrgName.HeaderText = "Org. Name";
            this.OrgName.Name = "OrgName";
            this.OrgName.ReadOnly = true;
            this.OrgName.Width = 125;
            // 
            // OrgState
            // 
            this.OrgState.DataPropertyName = "OrgState";
            this.OrgState.HeaderText = "Org. State";
            this.OrgState.Name = "OrgState";
            this.OrgState.ReadOnly = true;
            // 
            // OrgCity
            // 
            this.OrgCity.DataPropertyName = "OrgCity";
            this.OrgCity.HeaderText = "Org. City";
            this.OrgCity.Name = "OrgCity";
            this.OrgCity.ReadOnly = true;
            this.OrgCity.Visible = false;
            // 
            // OrgAddress
            // 
            this.OrgAddress.DataPropertyName = "OrgAddress";
            this.OrgAddress.HeaderText = "Org. Address";
            this.OrgAddress.Name = "OrgAddress";
            this.OrgAddress.ReadOnly = true;
            this.OrgAddress.Visible = false;
            // 
            // DomainName
            // 
            this.DomainName.DataPropertyName = "DomainName";
            this.DomainName.HeaderText = "Domain";
            this.DomainName.Name = "DomainName";
            this.DomainName.ReadOnly = true;
            // 
            // CallStatusName
            // 
            this.CallStatusName.DataPropertyName = "CallStatusName";
            this.CallStatusName.HeaderText = "Call Status";
            this.CallStatusName.Name = "CallStatusName";
            this.CallStatusName.ReadOnly = true;
            // 
            // NextCall
            // 
            this.NextCall.DataPropertyName = "NextCall";
            this.NextCall.HeaderText = "NextCall";
            this.NextCall.Name = "NextCall";
            this.NextCall.ReadOnly = true;
            // 
            // ContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pnlPager);
            this.Controls.Add(this.grdContactList);
            this.Name = "ContactList";
            this.Size = new System.Drawing.Size(577, 656);
            ((System.ComponentModel.ISupportInitialize)(this.grdContactList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdContactList;
        private System.Windows.Forms.Panel pnlPager;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrganizationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrgState;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrgCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrgAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NextCall;
    }
}
