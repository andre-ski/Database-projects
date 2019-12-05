using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deliverable2_Login
{
    public partial class ChildInfo : Form
    {
        int _staffid;
        public ChildInfo(string id)
        {
            InitializeComponent();
            _staffid = int.Parse(id);
            updateStaffID();
            string childQueryInfo = "Select * from Child";
            SQL.editChildInfo(childQueryInfo, listBoxChildInfo);
        }


        private void ChildInfo_Load(object sender, EventArgs e)
        {

        }

        private void listBoxChildInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateStaffID()
        {
            this.labelStaffID.Text = _staffid.ToString();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage login = new LoginPage();
            login.ShowDialog();
            this.Close();
        }
    }
}
