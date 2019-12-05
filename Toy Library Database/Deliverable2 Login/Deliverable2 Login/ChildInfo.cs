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
        public ChildInfo()
        {
            InitializeComponent();
            string childQueryInfo= "Select * from Child";
            SQL.editChildInfo(childQueryInfo, listBoxChildInfo);
        }

      
        private void ChildInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
