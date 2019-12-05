using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable2_Login
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.SqlClient;
    using System.Windows.Forms;

        //Name:Andre Ofsoski
        //Student ID: 1314669
        class SQL
        {
            //generates the connection to the database       
            public static SqlConnection con = new SqlConnection(@"Data Source=cairo;Database=ajo20_Deliverable2;Integrated Security=True");
            public static SqlCommand cmd = new SqlCommand();
            public static SqlDataReader read;

            /// <summary>
            /// This excecutres the query, used mainly for 
            /// insert/delete/update statements etc. where we don't need
            /// to read from what we are doing.
            /// </summary>
            /// <param name="query"></param>
            public static void executeQuery(string query)
            {
                //try catch to catch any unforseen errors gracefully
                try
                {
                    con.Close();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    //error message
                    MessageBox.Show("Login attempt unsuccessful! Please check details");
                    return;
                }
            }

            /// <summary>
            /// Generates an SQL query based on the input
            /// </summary>
            /// <param name="query"></param>
            public static void selectQuery(string query)
            {
                try
                {
                    con.Close();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = query;
                    read = cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                        //error message
                        MessageBox.Show("Login attempt unsuccessful! Please check details");
                        return;
            }
            }


        public static void editChildInfo(String childQuery, ListBox listBox)
        {
            bool clear = true;

            ////The	SQL	select	query,	using	above	string
            SQL.selectQuery(childQuery);

            //clear the listbox previous data
            listBox.Items.Clear();

            try
            {
                //Check	that	data	has	been	returned
                //Then	loop	through	each	row,	printing	the	data	to	the	list	box
                //Check	that	there	is	something	to	write	into	list	box
                if (SQL.read.HasRows)
                {
                    //listBox.Items.Add("Results	for:	" + childID);
                    //loop	through	each	table	row	from	the	database
                    while (SQL.read.Read())
                    {
                        //get	the	data	values	and	store	them	in	variables
                        string childID = SQL.read[0].ToString();
                        string childNote = SQL.read[1].ToString();
                        string childLanguage = SQL.read[2].ToString();
                        string childGender = SQL.read[3].ToString();
                        string childIwi = SQL.read[4].ToString();
                        string childDoB = SQL.read[5].ToString();
                        string childFName = SQL.read[6].ToString();
                        string childLName = SQL.read[7].ToString();
                        string childMemberId = SQL.read[8].ToString();

                        //display	each	of	the	rows	in	a	nice	way
                        listBox.Items.Add("child ID: " + childID + "   Notes: " + childNote + "   Language: " + childLanguage +
                            "   Gender: " + childGender + "   Iwi: " + childIwi + "   DOB: " + childDoB + "   First Name: " + childFName
                            + "   Last Name: " + childLName + "   MemberID: " + childMemberId);
                    }
                }
                else //where	it	doesnt	have	any	successful	searches
                {
                    listBox.Items.Add("No	User	Sessions	found.");
                }
            }
            catch
            {
                //If an error happens here, it means error in locating data
                MessageBox.Show("Error in querying database.  Please check that the database is connected.");
            }
        }


    }

}
    

