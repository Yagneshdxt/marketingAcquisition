using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace marketingAcquisition
{
    public partial class Form1 : Form
    {
        public LoginDetails objLoginDetails;

        public Form1(LoginDetails LoginDetails)
        {
            InitializeComponent();
            objLoginDetails = new LoginDetails();
            objLoginDetails = LoginDetails;
        }

        /*private Form1()
        {
            InitializeComponent();
        }*/

        public Panel controlPanel { get { return this.pnlBody; } }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(new ContactList(this, true));

        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(new ContactList(this, true));
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(new ContactList(this, false));    
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(new AddEditContacts(0, this));    
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAssignWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are not authorized for this action.");
        }

        private void btnDataUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are not authorized for this action.");
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are not authorized for this action.");
        }



    }

}
