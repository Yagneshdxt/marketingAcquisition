using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace marketingAcquisition
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            if (!String.IsNullOrEmpty(txtUserName.Text) && !String.IsNullOrEmpty(txtPassword.Text)) {
                DBLayer objDBLayer = new DBLayer();
                SqlParameter[] para = new SqlParameter[]{
                    new SqlParameter("@UName",txtUserName.Text.Trim()),
                    new SqlParameter("@uPassword",txtPassword.Text.Trim())
                };
                ds = objDBLayer.getDataSet("Select top 1 userId, UName, ULName, UContactInfo, UAddress, uPassword, URole from UserInfo where UName = @UName and uPassword = @uPassword", para);
            }
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                LoginDetails objLoginDetail = new LoginDetails();
                objLoginDetail.userId = Convert.ToInt32(ds.Tables[0].Rows[0]["userId"]);
                objLoginDetail.userName = txtUserName.Text.Trim();
                objLoginDetail.userLName = Convert.ToString(ds.Tables[0].Rows[0]["ULName"]);
                objLoginDetail.ContactInfo = Convert.ToString(ds.Tables[0].Rows[0]["UContactInfo"]);
                objLoginDetail.Address = Convert.ToString(ds.Tables[0].Rows[0]["UAddress"]);
                objLoginDetail.Role = Convert.ToString(ds.Tables[0].Rows[0]["URole"]);
                Form1 objForm1 = new Form1(objLoginDetail);
                objForm1.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Could not log you In please check entered credentials.");
            }
        }
    }
}
