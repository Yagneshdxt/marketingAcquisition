namespace marketingAcquisition
{
    partial class AddEditContacts
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
            this.txtOrgName = new System.Windows.Forms.TextBox();
            this.lblComName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrgAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlDomain = new System.Windows.Forms.ComboBox();
            this.Grdcont = new System.Windows.Forms.DataGridView();
            this.ChkinTalk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cntName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddlPosition = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EmailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveUpCont = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grdChatHistory = new System.Windows.Forms.DataGridView();
            this.ContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Feedback = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTalkedwith = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNextCall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grdcont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdChatHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOrgName
            // 
            this.txtOrgName.Location = new System.Drawing.Point(96, 5);
            this.txtOrgName.Name = "txtOrgName";
            this.txtOrgName.Size = new System.Drawing.Size(401, 20);
            this.txtOrgName.TabIndex = 0;
            // 
            // lblComName
            // 
            this.lblComName.AutoSize = true;
            this.lblComName.Location = new System.Drawing.Point(8, 8);
            this.lblComName.Name = "lblComName";
            this.lblComName.Size = new System.Drawing.Size(58, 13);
            this.lblComName.TabIndex = 1;
            this.lblComName.Text = "Org. Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Org. Add";
            // 
            // txtOrgAdd
            // 
            this.txtOrgAdd.Location = new System.Drawing.Point(96, 69);
            this.txtOrgAdd.Multiline = true;
            this.txtOrgAdd.Name = "txtOrgAdd";
            this.txtOrgAdd.Size = new System.Drawing.Size(401, 51);
            this.txtOrgAdd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Org. State";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Org. City";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(96, 39);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(155, 20);
            this.txtState.TabIndex = 2;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(335, 39);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(162, 20);
            this.txtCity.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Org. Domain";
            // 
            // ddlDomain
            // 
            this.ddlDomain.FormattingEnabled = true;
            this.ddlDomain.Location = new System.Drawing.Point(96, 134);
            this.ddlDomain.Name = "ddlDomain";
            this.ddlDomain.Size = new System.Drawing.Size(401, 21);
            this.ddlDomain.TabIndex = 5;
            // 
            // Grdcont
            // 
            this.Grdcont.AllowUserToAddRows = false;
            this.Grdcont.AllowUserToDeleteRows = false;
            this.Grdcont.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Grdcont.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grdcont.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChkinTalk,
            this.cntName,
            this.ddlPosition,
            this.EmailId,
            this.ContNo,
            this.ContactId});
            this.Grdcont.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Grdcont.Location = new System.Drawing.Point(11, 172);
            this.Grdcont.Name = "Grdcont";
            this.Grdcont.RowHeadersVisible = false;
            this.Grdcont.Size = new System.Drawing.Size(577, 122);
            this.Grdcont.TabIndex = 6;
            // 
            // ChkinTalk
            // 
            this.ChkinTalk.DataPropertyName = "InAction";
            this.ChkinTalk.Frozen = true;
            this.ChkinTalk.HeaderText = "Active";
            this.ChkinTalk.Name = "ChkinTalk";
            this.ChkinTalk.ReadOnly = true;
            this.ChkinTalk.Width = 50;
            // 
            // cntName
            // 
            this.cntName.DataPropertyName = "CntName";
            this.cntName.Frozen = true;
            this.cntName.HeaderText = "cntName";
            this.cntName.Name = "cntName";
            this.cntName.Width = 140;
            // 
            // ddlPosition
            // 
            this.ddlPosition.DataPropertyName = "PositionId";
            this.ddlPosition.Frozen = true;
            this.ddlPosition.HeaderText = "Position";
            this.ddlPosition.Name = "ddlPosition";
            // 
            // EmailId
            // 
            this.EmailId.DataPropertyName = "EmailId";
            this.EmailId.Frozen = true;
            this.EmailId.HeaderText = "EmailId";
            this.EmailId.Name = "EmailId";
            this.EmailId.Width = 140;
            // 
            // ContNo
            // 
            this.ContNo.DataPropertyName = "ContNumber";
            this.ContNo.Frozen = true;
            this.ContNo.HeaderText = "ContactNo";
            this.ContNo.Name = "ContNo";
            this.ContNo.Width = 140;
            // 
            // ContactId
            // 
            this.ContactId.DataPropertyName = "ContactId";
            this.ContactId.Frozen = true;
            this.ContactId.HeaderText = "ContId";
            this.ContactId.Name = "ContactId";
            this.ContactId.ReadOnly = true;
            this.ContactId.Visible = false;
            // 
            // btnSaveUpCont
            // 
            this.btnSaveUpCont.Location = new System.Drawing.Point(503, 3);
            this.btnSaveUpCont.Name = "btnSaveUpCont";
            this.btnSaveUpCont.Size = new System.Drawing.Size(85, 68);
            this.btnSaveUpCont.TabIndex = 11;
            this.btnSaveUpCont.Text = "Save/Update";
            this.btnSaveUpCont.UseVisualStyleBackColor = true;
            this.btnSaveUpCont.Click += new System.EventHandler(this.btnSaveUpCont_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Next Call";
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(85, 541);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(487, 51);
            this.txtFeedback.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 556);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Feedback";
            // 
            // grdChatHistory
            // 
            this.grdChatHistory.AllowUserToAddRows = false;
            this.grdChatHistory.AllowUserToDeleteRows = false;
            this.grdChatHistory.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grdChatHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdChatHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContactName,
            this.Date,
            this.Feedback});
            this.grdChatHistory.Location = new System.Drawing.Point(9, 321);
            this.grdChatHistory.Name = "grdChatHistory";
            this.grdChatHistory.ReadOnly = true;
            this.grdChatHistory.RowHeadersVisible = false;
            this.grdChatHistory.Size = new System.Drawing.Size(579, 150);
            this.grdChatHistory.TabIndex = 18;
            // 
            // ContactName
            // 
            this.ContactName.DataPropertyName = "CntName";
            this.ContactName.HeaderText = "Name";
            this.ContactName.Name = "ContactName";
            this.ContactName.ReadOnly = true;
            this.ContactName.Width = 120;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "TalkedOn";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 150;
            // 
            // Feedback
            // 
            this.Feedback.DataPropertyName = "FeedBack";
            this.Feedback.HeaderText = "Feedback";
            this.Feedback.Name = "Feedback";
            this.Feedback.ReadOnly = true;
            this.Feedback.Width = 300;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Past Chats";
            // 
            // cmbTalkedwith
            // 
            this.cmbTalkedwith.FormattingEnabled = true;
            this.cmbTalkedwith.Location = new System.Drawing.Point(85, 512);
            this.cmbTalkedwith.Name = "cmbTalkedwith";
            this.cmbTalkedwith.Size = new System.Drawing.Size(151, 21);
            this.cmbTalkedwith.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 517);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Talked With";
            // 
            // dtTimePicker
            // 
            this.dtTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTimePicker.Location = new System.Drawing.Point(242, 483);
            this.dtTimePicker.Name = "dtTimePicker";
            this.dtTimePicker.Size = new System.Drawing.Size(102, 20);
            this.dtTimePicker.TabIndex = 23;
            // 
            // dtpicker
            // 
            this.dtpicker.CustomFormat = "dd/MM/yyyy";
            this.dtpicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpicker.Location = new System.Drawing.Point(85, 483);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(151, 20);
            this.dtpicker.TabIndex = 22;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(301, 514);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(151, 21);
            this.cmbStatus.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(246, 517);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Status";
            // 
            // btnNextCall
            // 
            this.btnNextCall.Location = new System.Drawing.Point(9, 598);
            this.btnNextCall.Name = "btnNextCall";
            this.btnNextCall.Size = new System.Drawing.Size(123, 48);
            this.btnNextCall.TabIndex = 26;
            this.btnNextCall.Text = "Fix Next Call";
            this.btnNextCall.UseVisualStyleBackColor = true;
            this.btnNextCall.Click += new System.EventHandler(this.btnNextCall_Click);
            // 
            // AddEditContacts
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnNextCall);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dtTimePicker);
            this.Controls.Add(this.dtpicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbTalkedwith);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grdChatHistory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSaveUpCont);
            this.Controls.Add(this.Grdcont);
            this.Controls.Add(this.ddlDomain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrgAdd);
            this.Controls.Add(this.lblComName);
            this.Controls.Add(this.txtOrgName);
            this.Name = "AddEditContacts";
            this.Size = new System.Drawing.Size(591, 673);
            ((System.ComponentModel.ISupportInitialize)(this.Grdcont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdChatHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrgName;
        private System.Windows.Forms.Label lblComName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrgAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlDomain;
        private System.Windows.Forms.DataGridView Grdcont;
        private System.Windows.Forms.Button btnSaveUpCont;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grdChatHistory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ChkinTalk;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ddlPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactId;
        private System.Windows.Forms.ComboBox cmbTalkedwith;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtTimePicker;
        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Feedback;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNextCall;
    }
}
