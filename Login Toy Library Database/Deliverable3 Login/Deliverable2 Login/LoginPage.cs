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
    public partial class LoginPage : Form
    {
        string id = "";
        string staffid = "";
        public LoginPage()
        {
            InitializeComponent();
            //This line of code allows us to obscure the password visually and limit the max chars in textbox
            textBoxPassword.PasswordChar = '*';     //password character to hide password characters
            textBoxPassword.MaxLength = 20;         //max textbox character count
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Variables to be used: 1x bool, 4x string
            bool loggedIn = false;
            string username = "", password = "";

            //check if boxes are empty, the Trim removes white space in text from either side
            if ("".Equals(textBoxUsername.Text.Trim()) || "".Equals(textBoxPassword.Text.Trim()))
            {
                MessageBox.Show("Please make sure you enter a Username and Password");
                return;
            }

            //(1) GET the username and password from the text boxes, is good to put them in a try catch
            try
            {
                username = textBoxUsername.Text.Trim();
                password = textBoxPassword.Text.Trim();
            }
            catch
            {
                //Error message, more useful when you are storing numbers etc. into the database.
                MessageBox.Show("Username or Password given is in an incorrect format.");
                return;
            }

            //(2) SELECT statement getting all data from members, i.e. SELECT * FROM Members
            SQL.selectQuery("SELECT	*	from	Membership");

            //(3) IF it returns some data, THEN check each username and password combination, ELSE There are no registered users
            if (SQL.read.HasRows)
            {
                //cycle	through	all	users	checking	if	the	username	exists	and	if	the	password	matches
                while (SQL.read.Read())
                {
                    //SQL.read[i]:	i=0	is	UserName	...	i=4	is	Password
                    if (username.Equals(SQL.read[2].ToString()) && password.Equals(SQL.read[1].ToString()))
                    {
                        //Username	and	Password	correct,	get	fname,	lname	to	display
                        id = SQL.read[0].ToString();
                        loggedIn = true;
                        break; //stops	the	while	loop	since	they	have	logged	in
                    }
                }
            }
            else
            {
                //Error	message	to	show	that	no	users	have	been	registered
                MessageBox.Show("No	users	have	been	registered with these details.");
                return;
            }

            //if logged in display a success message
            if (loggedIn)
            {
                //message stating we logged in good
                MessageBox.Show("Successfully logged in as: " + username);
                initialiseTextBoxes();
                this.Hide();
                //ChildInfo childPage = new ChildInfo();
                //childPage.ShowDialog();

                ToyCategory toyPage = new ToyCategory(id);
                toyPage.ShowDialog();
                this.Close();

            }
            else
            {
                //message stating we couldn't log in
                MessageBox.Show("Login attempt unsuccessful! Please check details");
                textBoxUsername.Focus();
                return;
            }
        }

        public void initialiseTextBoxes()
        {
            //goes through and clears all of the textboxes
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Clear();
                }
            }
            //makes next place user types the text box
            textBoxUsername.Focus();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxPassword.Clear();
            textBoxUsername.Clear();
            textBoxUsername.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void buttonBrowse_Click(object sender, EventArgs e)
        //{

        //    Hide();
        //    ChildInfo browse = new ChildInfo();
        //    browse.ShowDialog();
        //    Close();
        //}

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            bool staffLoggedIn = false;
            string staffUsername = "", staffPassword = "";

            //check if boxes are empty, the Trim removes white space in text from either side
            if ("".Equals(textBoxUsername.Text.Trim()) || "".Equals(textBoxPassword.Text.Trim()))
            {
                MessageBox.Show("Please make sure you enter a Username and Password");
                return;
            }

            //(1) GET the username and password from the text boxes, is good to put them in a try catch
            try
            {
                staffUsername = textBoxUsername.Text.Trim();
                staffPassword = textBoxPassword.Text.Trim();
            }
            catch
            {
                //Error message, more useful when you are storing numbers etc. into the database.
                MessageBox.Show("Username or Password given is in an incorrect format.");
                return;
            }

            //(2) SELECT statement getting all data from members, i.e. SELECT * FROM Members
            SQL.selectQuery("SELECT	*	from	Staff");

            //(3) IF it returns some data, THEN check each username and password combination, ELSE There are no registered users
            if (SQL.read.HasRows)
            {
                //cycle	through	all	users	checking	if	the	username	exists	and	if	the	password	matches
                while (SQL.read.Read())
                {
                    //SQL.read[i]:	i=0	is	UserName	...	i=4	is	Password
                    if (staffUsername.Equals(SQL.read[2].ToString()) && staffPassword.Equals(SQL.read[1].ToString()))
                    {
                        //Username	and	Password	correct,	get	fname,	lname	to	display
                        staffid = SQL.read[0].ToString();
                        staffLoggedIn = true;
                        break; //stops	the	while	loop	since	they	have	logged	in
                    }
                }
            }
            else
            {
                //Error	message	to	show	that	no	users	have	been	registered
                MessageBox.Show("No	users	have	been	registered with these details.");
                return;
            }

            //if logged in display a success message
            if (staffLoggedIn)
            {
                //message stating we logged in good
                MessageBox.Show("Successfully logged in as Staff Member: " + staffUsername);
                initialiseTextBoxes();
                this.Hide();
                ChildInfo childPage = new ChildInfo(staffid);
                childPage.ShowDialog();
                this.Close();
            }
            else
            {
                //message stating we couldn't log in
                MessageBox.Show("Login attempt unsuccessful! Please check details");
                textBoxUsername.Focus();
                return;
            }
        }
    }
}