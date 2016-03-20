using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace marketingAcquisition
{
    /*
     Paging code taken from http://www.aspsnippets.com/Articles/Implement-Paging-DataGridView-in-Windows-Forms-WinForms-Application-using-C-and-VBNet.aspx
     */

    public partial class ContactList : UserControl
    {
        public Form1 ParentForm { get; set; }

        public List<OrganaizationDetails> LstOrgDetail;

        public Boolean IsToday { get; set; }

        int PageSize = Convert.ToInt32(ConfigurationManager.AppSettings["PageSize"].ToString()) ;

        public ContactList(Form1 ParentForm, Boolean IsTodayWorks)
        {
            InitializeComponent();
            this.ParentForm = ParentForm;
            this.IsToday = IsTodayWorks;

            if (ParentForm.objLoginDetails.userId > 0)
            {
                BindGrid(1);
            }
            else
            {
                MessageBox.Show("User not logged In");
            }
        }

        private ContactList()
        {
            InitializeComponent();
        }

        private void BindGrid(int pageIndex)
        {
            try
            {
                DBLayer objDblayer = new DBLayer();
                SqlParameter[] para = new SqlParameter[]{
                    new SqlParameter("@userId", ParentForm.objLoginDetails.userId),
                    new SqlParameter("@IsTodayWork", IsToday),
                    new SqlParameter("@PageIndex", pageIndex),
                    new SqlParameter("@PageSize", PageSize),
                    new SqlParameter("@RecordCount", SqlDbType.Int, 4),
                };
                Dictionary<String, String> opPara = new Dictionary<string, string>();
                opPara.Add("@RecordCount", "0");
                DataSet ds = new DataSet();
                ds = objDblayer.GetDataSetWithOutParameter("ContactList", para, ref opPara,  CommandType.StoredProcedure);

                if (ds != null && ds.Tables.Count > 0)
                {
                    /*LstOrgDetail = new List<OrganaizationDetails>();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        LstOrgDetail.Add(new OrganaizationDetails {
                            OrgName = Convert.ToString(dr["OrgName"]),
                            OrgCity = Convert.ToString(dr["OrgCity"]),
                            DomainName = Convert.ToString(dr["DomainName"]),
                            CallStatusName = Convert.ToString(dr["CallStatusName"]),
                        });
                    }*/
                    grdContactList.AutoGenerateColumns = false;
                    grdContactList.DataSource = ds.Tables[0];
                    int recordCount = Convert.ToInt32(opPara["@RecordCount"]);
                    this.PopulatePager(recordCount, pageIndex);
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void PopulatePager(int recordCount, int currentPage)
        {
            List<Page> pages = new List<Page>();
            int startIndex, endIndex;
            int pagerSpan = 5;

            //Calculate the Start and End Index of pages to be displayed.
            double dblPageCount = (double)((decimal)recordCount / Convert.ToDecimal(PageSize));
            int pageCount = (int)Math.Ceiling(dblPageCount);
            startIndex = currentPage > 1 && currentPage + pagerSpan - 1 < pagerSpan ? currentPage : 1;
            endIndex = pageCount > pagerSpan ? pagerSpan : pageCount;
            if (currentPage > pagerSpan % 2)
            {
                if (currentPage == 2)
                {
                    endIndex = 5;
                }
                else
                {
                    endIndex = currentPage + 2;
                }
            }
            else
            {
                endIndex = (pagerSpan - currentPage) + 1;
            }

            if (endIndex - (pagerSpan - 1) > startIndex)
            {
                startIndex = endIndex - (pagerSpan - 1);
            }

            if (endIndex > pageCount)
            {
                endIndex = pageCount;
                startIndex = ((endIndex - pagerSpan) + 1) > 0 ? (endIndex - pagerSpan) + 1 : 1;
            }

            //Add the First Page Button.
            if (currentPage > 1)
            {
                pages.Add(new Page { Text = "First", Value = "1" });
            }

            //Add the Previous Button.
            if (currentPage > 1)
            {
                pages.Add(new Page { Text = "<<", Value = (currentPage - 1).ToString() });
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                pages.Add(new Page { Text = i.ToString(), Value = i.ToString(), Selected = i == currentPage });
            }

            //Add the Next Button.
            if (currentPage < pageCount)
            {
                pages.Add(new Page { Text = ">>", Value = (currentPage + 1).ToString() });
            }

            //Add the Last Button.
            if (currentPage != pageCount)
            {
                pages.Add(new Page { Text = "Last", Value = pageCount.ToString() });
            }

            //Clear existing Pager Buttons.
            pnlPager.Controls.Clear();

            //Loop and add Buttons for Pager.
            int count = 0;
            foreach (Page page in pages)
            {
                Button btnPage = new Button();
                btnPage.Location = new System.Drawing.Point(38 * count, 5);
                btnPage.Size = new System.Drawing.Size(35, 20);
                btnPage.Name = page.Value;
                btnPage.Text = page.Text;
                btnPage.BackColor = Color.AliceBlue;
                btnPage.Enabled = !page.Selected;
                btnPage.Click += new System.EventHandler(this.Page_Click);
                pnlPager.Controls.Add(btnPage);
                count++;
            }
        }

        private void Page_Click(object sender, EventArgs e)
        {
            Button btnPager = (sender as Button);
            this.BindGrid(int.Parse(btnPager.Name));
        }

        private void grdContactList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string orgIdStr = Convert.ToString(grdContactList["OrganizationId", e.RowIndex].Value);
                Int64 OrgId = 0;
                Int64.TryParse(orgIdStr, out OrgId);
                if (OrgId != 0)
                {
                    (this.ParentForm.controlPanel).Controls.Clear();
                    (this.ParentForm.controlPanel).Controls.Add(new AddEditContacts(OrgId, this.ParentForm));
                    this.Dispose();
                }
            }
        }


    }
}
