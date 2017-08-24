
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

//This form adds feedback information to existing schemes that have been logged in the database e.g.  details of meetings where the schemes were discussed. 

namespace EQA_Databasev1._0
{
    public partial class Add_Feedback : Form
    {
        EQAMWeb WebMethods = new EQAMWeb();

        public Add_Feedback()
        {
            InitializeComponent();
            WebMethods.Credentials = System.Net.CredentialCache.DefaultCredentials;
        }

        private void addFeedbackbtn_Click(object sender, EventArgs e) //click command submits data to the database
        {
            //convert text in all the form textboxes into strings with appropriate names
            string inputSchemeLogID = feedbackSchemeIDTBox.Text;
            string inputSchemeRefNo = feedbackSchemeRefNoTBox.Text;
            string inputFeedbackRecipient = feedbackRecipientTBox.Text;
            string inputDateFeedback = feedbackDateTBox.Text;
            string inputActionPoints = feedbackActionPointsTBox.Text;
            

            //If necessary boxes are empty, don't proceed with SQL Query, 
            if (string.IsNullOrEmpty(inputSchemeLogID) ||                
                string.IsNullOrEmpty(inputFeedbackRecipient) ||
                string.IsNullOrEmpty(inputDateFeedback) ||
                string.IsNullOrEmpty(inputActionPoints))
                    
                { //show error message if fields have been left blank
                    MessageBox.Show("Please enter all required fields!");
                    return;
                }

            //Add control where only dates in the correct format can be submited to the database. This is mitigated slightly now by the use of DateTimePicker controls instead of freefill textboxes.
            DateTime feedbackDate;

            if 
                (!DateTime.TryParseExact(inputDateFeedback, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out feedbackDate))
             {          //error message if date is not in the correct day/month/year format. 
                        MessageBox.Show("Please specify dates exactly in the form dd/mm/yyyy");
                        return;
                    }

              
              WebMethods.DbAddFeedback( inputSchemeLogID, inputSchemeRefNo, inputFeedbackRecipient, inputActionPoints, feedbackDate);
                        
            
            //if query is executed succesfully show messagebox to say information has been added
                        MessageBox.Show("Feedback has been added ");
                        
                        this.Hide();
                    
                }

        

        //Clicking of the close button will close the Add_Feedback form. 
        private void addFeedback_click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        }
    }

