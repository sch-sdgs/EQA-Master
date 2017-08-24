using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EQA_Databasev1._0
{
    public partial class Login : Form
    {
        EQAMWeb WebMethods = new EQAMWeb();
        UserAuthentication UserAuth = new UserAuthentication();
        public Login()
        {
            InitializeComponent();
        }

        string _guid;
        public string GUID
        {
            get
            {
                return _guid;
            }
            set
            {
                _guid = value;
            }
        }


        public string Username
        {
            get
            {
                return usernameTBox.Text;
            }
            set
            {
                usernameTBox.Text = value;
            }
        }

        private void userName_Enter(object sender, EventArgs e)
        {
            if (usernameTBox.Text == "username")
            {
                //remove the word username from the box
                usernameTBox.Text = "";
            }
        }

        private void userName_Leave(object sender, EventArgs e)
        {
            //insert username if the field is left empty
            if (usernameTBox.Text == "")
            {
                usernameTBox.Text = "username";
            }
        }

        private void pswrd_Enter(object sender, EventArgs e)
        {
            if (passwordTBox.Text == "password")
            {
                //remove word password from the box and set the password character
                passwordTBox.Text = "";
                passwordTBox.PasswordChar = '*';
            }
        }

        private void pswrd_Leave(object sender, EventArgs e)
        {
            //if field is empty remove the password character and insert word password
            if (passwordTBox.Text == "")
            {
                passwordTBox.PasswordChar = '\0';
                passwordTBox.Text = "password";
            }
        }
        //#endregion
        //bool _canClose = false;

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (usernameTBox.Text == "" || usernameTBox.Text == "username" || passwordTBox.Text == "" || passwordTBox.Text == "password")
                {
                    MessageBox.Show("Please enter your username and password");
                    return;
                }

                else if (usernameTBox.Text != "" || usernameTBox.Text != "username" || passwordTBox.Text != "" || passwordTBox.Text != "password")
                {
                    string inputUserName = usernameTBox.Text;
                    DataTable validateUsers = new DataTable();
                    validateUsers.TableName = "ValidateUsers";
                    validateUsers = WebMethods.DbValidateUsers(inputUserName, validateUsers);

                    if (validateUsers.Rows[0][0].ToString() != "1")
                    {
                        MessageBox.Show("You do not have permission to use this application.\nPlease contact the system administrator if you wish to use EQA-Master. ");

                    }

                    else if (validateUsers.Rows[0][0].ToString() == "1")
                    {
                        _guid = UserAuth.GetUserAuth(usernameTBox.Text, passwordTBox.Text, 2);
                        if (_guid == "False")
                        {
                            MessageBox.Show("The username and password entered are not correct.");
                            return;

                        }
                        else if (_guid == "invalid permission")
                        {
                            MessageBox.Show("You do not have permission to use this application.\nPlease contact the system administrator if you wish to use Probe Master.");
                            return;
                        }

                        else
                        {
                            this.Hide();
                            StartUp_Form start = new StartUp_Form();
                            start.Show();
                            start.Activate();
                        }

                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Failure to connect to EQA-Master, please contact the administrator.");

            }
        }

        private void exitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }




    }
}



