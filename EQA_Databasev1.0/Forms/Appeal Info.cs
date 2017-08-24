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
using System.Globalization;


namespace EQA_Databasev1._0
{

    public partial class Add_Appeal : Form
    {
        EQAMWeb WebMethods = new EQAMWeb();
        public Add_Appeal()
        {
            InitializeComponent();
            WebMethods.Credentials = System.Net.CredentialCache.DefaultCredentials;
        }

        private void addAppealBtn_Click(object sender, EventArgs e) // Code behind the add appeal button
        {
            string inputSchemeID = appealSchemeIDTBox.Text;
            string inputAppealSubDate = appealSubDateTBox.Text;
            string inputAppealStatus = appealStatusTBox.Text;
            string inputAppealResult = postAppealResTBox.Text;
            string inputAppealResDate = appealResDateTBox.Text;

            //Don't proceed through the code if any required fields are empty
            if (string.IsNullOrEmpty(this.appealSchemeIDTBox.Text) ||
                string.IsNullOrEmpty(this.appealSubDateTBox.Text) ||
                string.IsNullOrEmpty(this.appealStatusTBox.Text) ||
                string.IsNullOrEmpty(this.postAppealResTBox.Text) ||
                string.IsNullOrEmpty(this.appealResDateTBox.Text))
            {
                //Exception if some fields are empty
                MessageBox.Show("Please enter all required fields!");
                return;
            }

            //Date fields need to be passed to the correct format
            DateTime appealSubDate, appealResDate;

            if (
                        !DateTime.TryParseExact(inputAppealSubDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out appealSubDate) ||
                        !DateTime.TryParseExact(inputAppealResDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out appealResDate))
            {
                MessageBox.Show("Please specify dates exactly in the form dd/mm/yyyy");
                return;
            }

            else
            {
               
                WebMethods.DbAddSchemeAppeal(inputSchemeID, inputAppealStatus, inputAppealResult, appealSubDate, appealResDate);

                MessageBox.Show("Scheme has been updated");

                this.Hide();
            }
        }

        

        private void addAppealClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
            }
        
        }

      
    

