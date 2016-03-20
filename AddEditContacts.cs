using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace marketingAcquisition
{
    public partial class AddEditContacts : UserControl
    {
        #region Properties

        public Int64 OrgID { get; set; }

        public Form1 ParentForm { get; set; }

        public List<PostionMaster> _PositionLst;// = new List<PostionMaster>();

        public List<ChatHistory> _ChatHistory;

        public List<ContactDetails> _contactDetails;

        public List<CallStatusMaster> _CallStatus;

        //public List<PostionMaster> PositionLst { get { return _PositionLst; } set { _PositionLst = value; } }

        #endregion

        public AddEditContacts(Int64 OrganizationId, Form1 ParentForm)
        {
            this.OrgID = OrganizationId;
            this.ParentForm = ParentForm;

            InitializeComponent();
            if (ParentForm.objLoginDetails.userId > 0)
            {
                SetInitalLoadData();
            }
            else
            {
                MessageBox.Show("User not logged In");
            }
        }

        private AddEditContacts()
        {
            InitializeComponent();
            SetInitalLoadData();
        }

        private void SetInitalLoadData()
        {
            try
            {
                cmbTalkedwith.Items.Clear();
                cmbTalkedwith.ValueMember = "ContactId";
                cmbTalkedwith.DisplayMember = "CntName";
                cmbTalkedwith.Items.Add(new ContactDetails { ContactId = 0, CntName = "--Select--" });
                cmbTalkedwith.SelectedIndex = 0;

                DBLayer objDblayer = new DBLayer();
                SqlParameter[] para = new SqlParameter[]{
                    new SqlParameter("@OrganisaztionId", OrgID)
                };
                DataSet ds = new DataSet();
                ds = objDblayer.getDataSet("GetAddEditContact", para, CommandType.StoredProcedure);


                if (ds != null && ds.Tables.Count > 0)
                {
                    if (ds.Tables.Contains("Table"))
                    {
                        // Empty Contact obj
                    }
                    if (ds.Tables.Contains("Table1"))
                    {
                        // contact grid position dropdown.
                        PostionMaster objPosMaster;
                        _PositionLst = new List<PostionMaster>();
                        _PositionLst.Add(new PostionMaster { PositionId = 0, PositionName = "--Select--" });
                        foreach (DataRow dr in ds.Tables[1].Rows)
                        {
                            if (!String.IsNullOrEmpty(Convert.ToString(dr["PositionId"])) && !String.IsNullOrEmpty(Convert.ToString(dr["PositionName"])))
                            {
                                objPosMaster = new PostionMaster();
                                objPosMaster.PositionId = Convert.ToInt64(dr["PositionId"]);
                                objPosMaster.PositionName = Convert.ToString(dr["PositionName"]);
                                _PositionLst.Add(objPosMaster);
                            }
                        }
                    }
                    ddlDomain.Items.Clear();
                    ddlDomain.DisplayMember = "DomainName";
                    ddlDomain.ValueMember = "DomainId";
                    ddlDomain.Items.Insert(0, new DomainMaster { DomainId = 0, DomainName = "--Select--" });
                    if (ds.Tables.Contains("Table2") && ds.Tables[2].Rows.Count > 0)
                    {
                        //Company Domain
                        //ddlDomain.DataSource = ds.Tables[2];
                        foreach (DataRow dr in ds.Tables[2].Rows)
                        {
                            ddlDomain.Items.Add(new DomainMaster { DomainId = Convert.ToInt64(dr["DomainId"]), DomainName = Convert.ToString(dr["DomainName"]) });
                        }

                    }
                    ddlDomain.SelectedIndex = 0;

                    if (ds.Tables.Contains("Table3") && ds.Tables[3].Rows.Count > 0)
                    {
                        txtOrgName.Text = Convert.ToString(ds.Tables[3].Rows[0]["OrgName"]);
                        txtState.Text = Convert.ToString(ds.Tables[3].Rows[0]["OrgState"]);
                        txtCity.Text = Convert.ToString(ds.Tables[3].Rows[0]["OrgCity"]);
                        txtOrgAdd.Text = Convert.ToString(ds.Tables[3].Rows[0]["OrgAddress"]);
                        //if (ddlDomain.ValueMember.Any(x => x.Equals(Convert.ToString(ds.Tables[3].Rows[0]["DomainId"]))))
                        {
                            ddlDomain.SelectedIndex = ddlDomain.FindString(Convert.ToString(ds.Tables[3].Rows[0]["DomainName"]));
                        }
                    }

                    DataGridViewComboBoxColumn objDgvCombobox = (Grdcont.Columns[2] as DataGridViewComboBoxColumn);
                    objDgvCombobox.DataSource = _PositionLst;
                    objDgvCombobox.DisplayMember = "PositionName";
                    objDgvCombobox.ValueMember = "PositionId";
                    objDgvCombobox.DataPropertyName = "PositionId";
                    objDgvCombobox.ValueType = typeof(Int32);

                    _contactDetails = new List<ContactDetails>();
                    ContactDetails objCntDtail;
                    if (ds.Tables.Contains("Table4") && ds.Tables[4].Rows.Count > 0)
                    {

                        //Grdcont.DataSource = ds.Tables[4];

                        //(Grdcont.Columns[2] as DataGridViewCheckBoxColumn).DataPropertyName = ""

                        foreach (DataRow dr in ds.Tables[4].Rows)
                        {
                            objCntDtail = new ContactDetails();
                            objCntDtail.CntName = Convert.ToString(dr["CntName"]);
                            objCntDtail.ContactId = Convert.ToInt64(dr["ContactId"]);
                            objCntDtail.ContNumber = Convert.ToString(dr["ContNumber"]);
                            objCntDtail.EmailId = Convert.ToString(dr["EmailId"]);
                            objCntDtail.InAction = Convert.ToBoolean(dr["InAction"]);
                            objCntDtail.OrganizationId = this.OrgID;
                            objCntDtail.PositionId = Convert.ToInt64(dr["PositionId"]);
                            _contactDetails.Add(objCntDtail);
                            cmbTalkedwith.Items.Add(new ContactDetails { ContactId = objCntDtail.ContactId, CntName = objCntDtail.CntName });
                        }
                    }

                    for (int i = ds.Tables[4].Rows.Count; i < 20; i++)
                    {
                        objCntDtail = new ContactDetails();
                        objCntDtail.CntName = "";
                        objCntDtail.ContactId = 0;
                        objCntDtail.ContNumber = "";
                        objCntDtail.EmailId = "";
                        objCntDtail.InAction = false;
                        objCntDtail.OrganizationId = 0;
                        objCntDtail.PositionId = 0;
                        _contactDetails.Add(objCntDtail);
                    }
                    Grdcont.AutoGenerateColumns = false;
                    Grdcont.DataSource = _contactDetails;

                    //bind chat history
                    _ChatHistory = new List<ChatHistory>();
                    ChatHistory objChtHtr;
                    grdChatHistory.AutoGenerateColumns = false;
                    if (ds.Tables.Contains("Table5") && ds.Tables[5].Rows.Count > 0)
                    {
                        grdChatHistory.DataSource = ds.Tables[5];
                        //objChtHtr = new ChatHistory();
                    }
                    grdChatHistory.DataSource = ds.Tables[5];

                    List<CallStatusMaster> _CallStatus = new List<CallStatusMaster>();
                    if (ds.Tables.Contains("Table6") && ds.Tables[6].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[6].Rows)
                        {
                            if (Convert.ToInt32(dr["CallStatusId"]) != 1)
                            {
                                _CallStatus.Add(new CallStatusMaster { CallStatusId = Convert.ToInt32(dr["CallStatusId"]), CallStatusName = Convert.ToString(dr["CallStatusName"]) });
                            }
                        }
                    }
                    cmbStatus.DisplayMember = "CallStatusName";
                    cmbStatus.ValueMember = "CallStatusId";
                    cmbStatus.DataSource = _CallStatus;

                }//end of dataset.

                this.dtTimePicker.CustomFormat = "hh:mm tt";
                this.dtTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                this.dtTimePicker.ShowUpDown = true;
                this.dtpicker.MinDate = DateTime.Now;

                //Readonly logic for appointment fields.
                dtpicker.Enabled = true;
                dtTimePicker.Enabled = true;
                cmbTalkedwith.Enabled = true;
                cmbStatus.Enabled = true;
                txtFeedback.Enabled = true;
                btnNextCall.Visible = true;
                if (OrgID <= 0)
                {
                    dtpicker.Enabled = false;
                    dtTimePicker.Enabled = false;
                    cmbTalkedwith.Enabled = false;
                    cmbStatus.Enabled = false;
                    txtFeedback.Enabled = false;
                    btnNextCall.Visible = false;
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void btnSaveUpCont_Click(object sender, EventArgs e)
        {
            if (ValidateSave())
            {
                DialogResult retResul = MessageBox.Show("Proceed With Save/Update?", "Save/Update Confirmation", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == retResul)
                {
                    String InsertUpdate = "";
                    DBLayer objDblayer = new DBLayer();
                    SqlConnection SqlCon = objDblayer.conn;
                    SqlCon.Open();
                    SqlTransaction objTran = SqlCon.BeginTransaction("AddContact");
                    Int16 chkSuccess = 0;
                    try
                    {
                        InsertUpdate = I_UOrganizationDetails(objTran, objDblayer);
                        I_UContactDetails(objTran, objDblayer);
                        objTran.Commit();
                        chkSuccess = 1;
                    }
                    catch (Exception ex)
                    {
                        objTran.Rollback();
                        chkSuccess = 0;
                    }
                    finally
                    {
                        SqlCon.Close();
                        if (InsertUpdate.ToLower() == "inserted")
                        {
                            this.OrgID = 0;
                            resetControl();
                        }
                    }
                    if (chkSuccess == 1)
                    {
                        SetInitalLoadData();
                        MessageBox.Show("Save/Update successfully");
                    }
                }
            }
        }

        private void resetControl()
        {
            this.txtCity.Text = "";
            this.txtState.Text = "";
            this.txtOrgAdd.Text = "";
            this.txtOrgName.Text = "";
        }

        public Boolean ValidateSave()
        {
            String ErrMsg = "";
            if (String.IsNullOrEmpty(txtOrgName.Text.Trim()))
            {
                ErrMsg += " Please enter Organization Name \n";
            }

            DomainMaster objdomainMst = (ddlDomain.SelectedItem as DomainMaster);
            if (String.IsNullOrEmpty(Convert.ToString(objdomainMst.DomainId)) || Convert.ToString(objdomainMst.DomainId) == "0")
            {
                ErrMsg += " Please select Organization Domain \n";
            }
            /*if (OrgID > 0)
            {
                if (String.IsNullOrEmpty(Convert.ToString(cmbTalkedwith.SelectedValue)) || Convert.ToString(cmbTalkedwith.SelectedValue) == "0") { 
                
                }
            }*/
            if (String.IsNullOrEmpty(ErrMsg))
            {
                return true;
            }
            else
            {
                MessageBox.Show("---------Please fix below Issue------ \n" + ErrMsg, "Save Error", MessageBoxButtons.OK);
                return false;
            }
        }

        public string I_UOrganizationDetails(SqlTransaction objTran, DBLayer objDblayer)
        {
            String InsertUpdate = "";
            List<SqlParameter> sqlPara = new List<SqlParameter>();
            sqlPara.Add(new SqlParameter("@OrgName", txtOrgName.Text.Trim()));
            sqlPara.Add(new SqlParameter("@DomainId", (ddlDomain.SelectedItem as DomainMaster).DomainId));
            if (!String.IsNullOrEmpty(txtState.Text.Trim()))
            {
                sqlPara.Add(new SqlParameter("@OrgState", txtState.Text.Trim()));
            }
            else
            {
                sqlPara.Add(new SqlParameter("@OrgState", DBNull.Value));
            }
            if (!String.IsNullOrEmpty(txtCity.Text.Trim()))
            {
                sqlPara.Add(new SqlParameter("@OrgCity", txtCity.Text.Trim()));
            }
            else
            {
                sqlPara.Add(new SqlParameter("@OrgCity", DBNull.Value));
            }
            if (!String.IsNullOrEmpty(txtOrgAdd.Text.Trim()))
            {
                sqlPara.Add(new SqlParameter("@OrgAddress", txtOrgAdd.Text.Trim()));
            }
            else
            {
                sqlPara.Add(new SqlParameter("@OrgAddress", DBNull.Value));
            }


            if (OrgID <= 0)
            {
                sqlPara.Add(new SqlParameter("@userId", ParentForm.objLoginDetails.userId));
                sqlPara.Add(new SqlParameter("@CallStatusId", 1));
                sqlPara.Add(new SqlParameter("@nextCall", DBNull.Value));

                objDblayer.ExecNonQuery(@"insert into OrganaizationDetails(OrgName,OrgState,OrgCity,OrgAddress,DomainId,userId,nextCall,CallStatusId)
                                              values(@OrgName,@OrgState,@OrgCity,@OrgAddress,@DomainId,@userId,@nextCall,@CallStatusId)",
                                         sqlPara.ToArray(), CommandType.Text, objTran);

                this.OrgID = Convert.ToInt64(objDblayer.SelectScalar("SELECT IDENT_CURRENT('OrganaizationDetails')", Sqltrn: objTran));

                InsertUpdate = "Inserted";
            }
            else
            {
                sqlPara.Add(new SqlParameter("@OrganizationId", this.OrgID));
                objDblayer.ExecNonQuery(@"update OrganaizationDetails set 
                                        OrgName = @OrgName, OrgState = @OrgState, OrgCity = @OrgCity, OrgAddress = @OrgAddress, DomainId = @DomainId, 
                                        nextCall = nextCall, CallStatusId = CallStatusId 
                                        where OrganizationId = @OrganizationId
                                        ",
                         sqlPara.ToArray(), CommandType.Text, objTran);
                InsertUpdate = "Updated";
            }
            return InsertUpdate;
        }

        public void I_UContactDetails(SqlTransaction objTran, DBLayer objDblayer)
        {

            Int64 RtCntDetId = 0;
            List<SqlParameter> sqlPara;
            ContactDetails cntDetails;
            foreach (DataGridViewRow dgvRow in Grdcont.Rows)
            {
                cntDetails = ((ContactDetails)dgvRow.DataBoundItem);
                if (!String.IsNullOrEmpty(cntDetails.CntName.Trim()))
                {
                    sqlPara = new List<SqlParameter>();
                    if (cntDetails.PositionId > 0)
                    {
                        sqlPara.Add(new SqlParameter("@PositionId", cntDetails.PositionId));
                    }
                    else
                    {
                        sqlPara.Add(new SqlParameter("@PositionId", DBNull.Value));
                    }
                    if (!String.IsNullOrEmpty(cntDetails.CntName.Trim()))
                    {
                        sqlPara.Add(new SqlParameter("@CntName", cntDetails.CntName));
                    }
                    else
                    {
                        sqlPara.Add(new SqlParameter("@CntName", DBNull.Value));
                    }
                    if (!String.IsNullOrEmpty(cntDetails.EmailId.Trim()))
                    {
                        sqlPara.Add(new SqlParameter("@EmailId", cntDetails.EmailId));
                    }
                    else
                    {
                        sqlPara.Add(new SqlParameter("@EmailId", DBNull.Value));
                    }
                    if (!String.IsNullOrEmpty(cntDetails.ContNumber.Trim()))
                    {
                        sqlPara.Add(new SqlParameter("@ContNumber", cntDetails.ContNumber));
                    }
                    else
                    {
                        sqlPara.Add(new SqlParameter("@ContNumber", DBNull.Value));
                    }
                    sqlPara.Add(new SqlParameter("@InAction", cntDetails.InAction));
                    if (cntDetails.ContactId <= 0)
                    {
                        sqlPara.Add(new SqlParameter("@OrganizationId", this.OrgID));
                        objDblayer.ExecNonQuery(@"insert into ContactDetails(OrganizationId, CntName, PositionId,EmailId,ContNumber, InAction)
                                                  values(@OrganizationId, @CntName, @PositionId, @EmailId, @ContNumber, @InAction)",
                                                sqlPara.ToArray(), CommandType.Text, objTran);
                    }
                    if (cntDetails.ContactId > 0)
                    {
                        sqlPara.Add(new SqlParameter("@ContactId", cntDetails.ContactId));

                        objDblayer.ExecNonQuery(@"update ContactDetails set CntName = @CntName, PositionId = @PositionId, EmailId = @EmailId, ContNumber = @ContNumber, InAction = @InAction where ContactId = @ContactId",
                                                sqlPara.ToArray(), CommandType.Text, objTran);
                    }
                }

            }
        }

        private void btnNextCall_Click(object sender, EventArgs e)
        {
            if (validateNextCall())
            {

                DBLayer objDblayer = new DBLayer();
                SqlConnection SqlCon = objDblayer.conn;
                SqlCon.Open();
                SqlTransaction objTran = SqlCon.BeginTransaction("SaveNextCall");
                Int16 chkSuccess = 0;
                try
                {
                    DateTime MyDateTime = ((DateTime) dtpicker.Value).Date.Add (((DateTime)dtTimePicker.Value).TimeOfDay);
                    List<SqlParameter> sqlPara = new List<SqlParameter>();
                    sqlPara.Add(new SqlParameter("@ContactId", (cmbTalkedwith.SelectedItem as ContactDetails).ContactId));
                    sqlPara.Add(new SqlParameter("@FeedBack", txtFeedback.Text));

                    objDblayer.ExecNonQuery(@"insert into ChatHistory(ContactId, TalkedOn, FeedBack) values(@ContactId, GETDATE(), @FeedBack)",
                                             sqlPara.ToArray(), CommandType.Text, objTran);

                    sqlPara.Clear();
                    sqlPara.Add(new SqlParameter("@nextCall", dtpicker.Text + " " + dtTimePicker.Text));
                    sqlPara.Add(new SqlParameter("@CallStatusId", (cmbStatus.SelectedItem as CallStatusMaster).CallStatusId));
                    sqlPara.Add(new SqlParameter("@OrganizationId", this.OrgID));

                    objDblayer.ExecNonQuery(@"update OrganaizationDetails set nextCall = Convert(Datetime, @nextCall, 103), CallStatusId = @CallStatusId where OrganizationId = @OrganizationId",
                                             sqlPara.ToArray(), CommandType.Text, objTran);

                    objTran.Commit();
                    chkSuccess = 1;
                }
                catch (Exception ex)
                {
                    objTran.Rollback();
                    chkSuccess = 0;
                }
                finally
                {
                    SqlCon.Close();
                }
                if (chkSuccess == 1)
                {
                    SetInitalLoadData();
                }

            }
        }

        public Boolean validateNextCall()
        {

            String ErrMsg = "";
            if ((cmbTalkedwith.SelectedItem as ContactDetails).ContactId <= 0)
            {
                ErrMsg += " Please select Talked With \n";
            }

            CallStatusMaster objdomainMst = (cmbStatus.SelectedItem as CallStatusMaster);
            if (String.IsNullOrEmpty(Convert.ToString(objdomainMst.CallStatusId)) || Convert.ToString(objdomainMst.CallStatusId) == "0")
            {
                ErrMsg += " Please select Status \n";
            }

            if (String.IsNullOrEmpty(Convert.ToString(txtFeedback.Text)))
            {
                ErrMsg += " Please Enter Feed back \n";
            }
            if (this.OrgID <= 0) {
                ErrMsg += " Organization could not be found. -- Some Error Occurred. \n";
            }
            if (String.IsNullOrEmpty(ErrMsg))
            {
                return true;
            }
            else
            {
                MessageBox.Show("---------Please fix below Issue------ \n" + ErrMsg, "Next Call", MessageBoxButtons.OK);
                return false;
            }
        }
    }
}
