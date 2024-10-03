using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    // add this using directive for access to the sqlServer

/*
 There is a tutotial in Appendix B from our C# textbook that shows how to create a SQL Server database.
 Also the Tutorial 4 on page 371,  explains how to grab records from a table in the database and display it to a GUI Form
*/


namespace LoginFormWithUsersDatabase
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }

        private String getAuthorizedPassword(string userName)
        {
            //declare all necessary variables reading data from a sqlServer table
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {

                //right click on the .mdf file under the Solution Explorer and select Properties
                //then find its Full Path directory and copy and paste it below
                cn.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                                    H:\TEACHING\SPRING 2020\SE361\IN_CLASS_DEMOS\LoginFormWithUsersDatabase\LoginFormWithUsersDatabase\AuthorizedUsersDB.mdf";

                cmd.Connection = cn;

                cmd.CommandText = "SELECT userPassword FROM UserLoginCredential WHERE userName = @username";

                cmd.Parameters.AddWithValue("@username", userName);

                // open a connection to DB
                cn.Open();

                //read the table
                dr = cmd.ExecuteReader();

                //read a record from the data reader
                dr.Read();

                return dr.GetString(0);
            }
            catch (Exception err)
            {
                //it handles any other errors
                MessageBox.Show(err.Message, "Warning!");

                return null;
            }
            finally
            {
                cn.Close(); //Close connection regardless of any errors or not
            }
        }
    
    private void btnOK_Click(object sender, EventArgs e)
        {
            string enteredPassword = txtPassword.Text;

            try
            {
                // find the valid password for a given user from the database and compare it with the one entered by the user
                if (enteredPassword == getAuthorizedPassword(txtUserName.Text))
                {
                    this.DialogResult = DialogResult.OK; //tell this form that the OK button has been selected

                    MessageBox.Show("Welcome to the Database Management System!", "Successful Login!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Sorry. Invalid User Name and/or Password. Try again.", "Warning!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Focus();
                    txtUserName.SelectAll();
                }
            }
            catch (Exception err)
            {
                //it handles any other errors
                MessageBox.Show(err.Message, "Warning!");
            }
        }
    }
}
