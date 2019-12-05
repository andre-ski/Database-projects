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
    public partial class ToyCategory : Form
    {
        int _id;

        public ToyCategory(string id)
        {
            InitializeComponent();
            _id = int.Parse(id);
            updateMember();
            string toyCategoryQuery = "Select * from Category";
            SQL.showToyCategory(toyCategoryQuery, listBoxToy, comboBoxToy);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string toyCategoryQuery = "Select * from Category Where title = '" + comboBoxToy.Items[comboBoxToy.SelectedIndex] + "'";
           // SQL.showToyCategory(toyCategoryQuery, listBoxToy, comboBoxToy);

            SQL.showFiltered(toyCategoryQuery, listBoxToy, comboBoxToy);
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            
            int toyID = 0;
            int childID = 0;
            int memberID = _id;

            listBoxStatus.Items.Clear();
            listBoxStatus.Items.Insert(0,"not available");
            string name = listBoxToy.SelectedItem.ToString();  
            MessageBox.Show("You are now borrowing toy: " + name);
            // can use ID to make lending 
            string checkQuery = "Select toyID from Toy where toyName ='" + name + "'";
            //string memberQuery 
            SQL.selectQuery(checkQuery);
            if(SQL.read.HasRows)
            {
                SQL.read.Read();
                toyID = int.Parse(SQL.read[0].ToString());
               // MessageBox.Show(toyID + " read");

            }
            else
            {
                MessageBox.Show("No toy selected");
            }
            string checkAvailable = "Select toyStatus from Toy where toyID = " + toyID;
            SQL.selectQuery(checkAvailable);
            if (SQL.read.HasRows)
            {
                SQL.read.Read();
                string status = SQL.read[0].ToString();
                if (!(status.Equals("available")))
                    {
                    MessageBox.Show("This toy is already being borrowed");
                    return;
                    }
            }

            string checkChild = "Select childID from Child where membershipID =" + memberID ;
            //MessageBox.Show(memberID + " is logged in");
            SQL.selectQuery(checkChild);
            if(SQL.read.HasRows)
            {
                SQL.read.Read();
                childID = int.Parse(SQL.read[0].ToString());
               // MessageBox.Show("Child ID: " + childID + " is linked to this member");
            }

            string getLendingID = "Select MAX(lendingID) from Lending";
            SQL.selectQuery(getLendingID);
             int lendingID =0;
            if(SQL.read.HasRows)
            {
                SQL.read.Read();
                lendingID = int.Parse(SQL.read[0].ToString());
                lendingID++;              
            }
            
            string query = "UPDATE Toy set toyStatus = 'not available' Where toyID = " + toyID.ToString();
            SQL.executeQuery(query);
            query = "INSERT INTO Lending Values(" + lendingID.ToString() + ", '2018-06-08','2018-06-22', null, '', '', " + childID.ToString() + ", " + toyID.ToString() + ")";
            SQL.executeQuery(query);
            updateAvailable();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {          
            this.Hide();
            LoginPage login = new LoginPage();
            login.ShowDialog();
            this.Close();
        }

        private void listBoxToy_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string statusQuery = "Select toyStatus from Toy Where toyName ='" + listBoxToy.Items[listBoxToy.SelectedIndex] + "'";
                SQL.showToyStatus(statusQuery, listBoxToy, listBoxStatus);
            }
            catch
            {
                MessageBox.Show("Please select a toy");
            }
        }

        private void buttonAvailable_Click(object sender, EventArgs e)
        {
            updateAvailable();
        }

        private void listBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ToyCategory_Load(object sender, EventArgs e)
        {

        }

        private void labelMemberID_Click(object sender, EventArgs e)
        {
            
        }

        private void updateMember()
        {
            this.labelMemberID.Text = _id.ToString();
        }
        private void updateAvailable()
        {
            string availableToys = "Select toyName from Toy where toyStatus like 'available'";
            SQL.showAvailable(availableToys, listBoxToy, listBoxStatus);
        }
    }
}
