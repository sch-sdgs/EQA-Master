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
using EQA_Databasev1._0.Forms;

//This form enables information about the results of a scheme to be appended to existing records in the SchemeLog view. It uses the update command to add the information. 

namespace EQA_Databasev1._0
{
    public partial class Add_Scheme_Outcome : Form
    {
        EQAMWeb WebMethods = new EQAMWeb();
        

        public Add_Scheme_Outcome()
        {
            InitializeComponent();
            WebMethods.Credentials = System.Net.CredentialCache.DefaultCredentials;       
            //subDateTextBox.CustomFormat = " ";
            //subDateTextBox.Format = DateTimePickerFormat.Custom;
            resultDownloadTextBox.CustomFormat = " ";
            resultDownloadTextBox.Format = DateTimePickerFormat.Custom;
            appealDeadlineTextBox.CustomFormat = " ";
            appealDeadlineTextBox.Format = DateTimePickerFormat.Custom;
            
            
        }

        private void addAddsubDate_click(object sender, EventArgs e)
        {
            string inputSchemeLogID = outcomeSchemeIDTBox.Text;
            string inputSubDate = subDateTextBox.Text;

            DateTime subDate;
            if (!DateTime.TryParseExact(inputSubDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out subDate))  
                    {
                        //block query from initiating if any dates are in the incorrect format
                        MessageBox.Show("Please specify dates exactly in the form dd/mm/yyyy");
                        return;
                    }
        
                     
        
             WebMethods.DbSubmissionDate(inputSchemeLogID,  subDate);

                    MessageBox.Show("Submission Date has been added");
                    this.Hide();
        
        }

    
        private void addOutcome_Click(object sender, EventArgs e) // Adds the data entered into fields on the form into the SchemeLog table against the selcted record (identifiable through the SchemeLogID)
        {

                {
                    //Convert form fields to strings. 
                    string inputSchemeLogID = outcomeSchemeIDTBox.Text;
                    string inputSubDate = subDateTextBox.Text;
                    string inputResDownload = resultDownloadTextBox.Text;
                    string inputResScore = resScoreTextBox.Text;
                    string inputResStatus = resultStatusTextBox.Text;
                    //string inputActionPoints = actionPointsTextBox.Text;
                    string inputQPulse = qPulseTextBox.Text;
                    string inputAppealDeadline = appealDeadlineTextBox.Text;

                    //Don't proceed with sql command if any fields are empty
                    if (string.IsNullOrEmpty(inputSchemeLogID) ||
                        string.IsNullOrEmpty(inputSubDate) ||
                        string.IsNullOrEmpty(inputResDownload) ||
                        //string.IsNullOrEmpty(inputActionPoints) ||
                        //string.IsNullOrEmpty(inputQPulse) ||
                        string.IsNullOrEmpty(inputAppealDeadline))
                    {
                        MessageBox.Show("Please enter required fields!");
                        return;
                    }

                    //Parse the string entered from all dates into the format dd/mm/yyyy
                    DateTime subDate, resDownloadDate, appealDeadline;

                    //out parameter modifier = the parameter has no official value before going into the function, it only goes out, it is not initialised. 
                    if (!DateTime.TryParseExact(inputSubDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out subDate) ||
                        !DateTime.TryParseExact(inputResDownload, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out resDownloadDate) ||
                        !DateTime.TryParseExact(inputAppealDeadline, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out appealDeadline))
                    {
                        //block query from initiating if any dates are in the incorrect format
                        MessageBox.Show("Please specify dates exactly in the form dd/mm/yyyy");
                        return;

                    }
                    //REMOVE ACTIONS POINTS FROM HERE AND FROM SQL IN WEB SERVICE

                    WebMethods.DbAddSchemeOutcome(inputSchemeLogID, inputResScore, inputResStatus, inputQPulse, subDate, resDownloadDate, appealDeadline);

                    MessageBox.Show("Scheme log has been updated");
                    this.Hide();
                }
            
        }

        

        //Button to close and exit form. 
        private void addOutcome_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addSchComment_click(object sender, EventArgs e)
        {
            Add_Scheme_Comment addSchComment = new Add_Scheme_Comment();
            addSchComment.SchemeLogID.Text = outcomeSchemeIDTBox.Text;
            addSchComment.ShowDialog();
            addSchComment.Activate();
            

        }

        private void addSamComment_click(object sender, EventArgs e)
        {
            Add_Sample_Comment addSamComment = new Add_Sample_Comment();
            addSamComment.SchemeLogID.Text = outcomeSchemeIDTBox.Text;
            addSamComment.ShowDialog();
            addSamComment.Activate();
            
            

        }

        private void subdate_closeUP(object sender, EventArgs e)
        {
            subDateTextBox.Format = DateTimePickerFormat.Short;
        }

        private void resultsDownload_closeUp(object sender, EventArgs e)
        {
            resultDownloadTextBox.Format = DateTimePickerFormat.Short;
        }

        private void appeal_closeUp(object sender, EventArgs e)
        {
            appealDeadlineTextBox.Format = DateTimePickerFormat.Short;
        }

       


    }
}

       
        
    

        

