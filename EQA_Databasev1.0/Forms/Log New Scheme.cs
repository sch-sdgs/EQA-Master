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
using System.IO;
using System.Globalization;

//There also needs to be a trigger on the Submission deadline entry - an automated email sent to HoS and CoverStaff reporting to them
//2 weeks prior to deadline and 1 week prior to deadline -- if this is allowed

namespace EQA_Databasev1._0
{

    public partial class Log_New_Scheme : Form
    {

        EQAMWeb WebMethods = new EQAMWeb();


        public Log_New_Scheme()
        {
            InitializeComponent();
            WebMethods.Credentials = System.Net.CredentialCache.DefaultCredentials;
            //Set initial value of textboxes to null when the form loads - so that incorrect empty date cannot be added
            sampleDateTextBox.CustomFormat = "";
            sampleDateTextBox.Format = DateTimePickerFormat.Custom;
            subDeadlineTextBox.CustomFormat = "";
            subDeadlineTextBox.Format = DateTimePickerFormat.Custom;
        }


        private void Log_New_Scheme_Load(object sender, EventArgs e)
        {
            
            //Create an instance for filling data into EQABody Combobox.
            fillBody();
            fillStaffDrop();
            //Select the starting contents of the eqaBodyBox combobox
            eqaBodyBox.SelectedItem = 0;
        }

       

        private void fillBody()
        {
            string sqlString = "SELECT * from dbo.EQABody ORDER BY EQABodyName";
            DataTable dtEQA = new DataTable();
            dtEQA.TableName = "BodyTable";
           
            dtEQA = WebMethods.GetDataTable(sqlString, dtEQA);
          
            //bind necessary columns from EqaBody table to combobox DisplayMember and Value
            eqaBodyBox.DataSource = dtEQA;
            eqaBodyBox.DisplayMember = "EQABodyName";
            eqaBodyBox.ValueMember = "EQABodyID";
            eqaBodyBox.SelectedIndex = -1;
        }

        private void fillScheme()
           
        {
            string sqlString = "SELECT SchemeName, SchemeID FROM dbo.EQAScheme WHERE EQAScheme.EQABodyID IN (Select EQABodyID from EQABody WHERE EQABody.EQABodyName = @BodyName )";
            string inputBodyName = eqaBodyBox.Text;
            DataTable dtEQA = new DataTable();
            dtEQA.TableName = "SchemeTable";
            dtEQA = WebMethods.DbFillEQASchemeDropDown(sqlString, inputBodyName, dtEQA);
            //bind necessary columns from EqaBody table to combobox DisplayMember and Value
            schemeNameBox.DataSource = dtEQA;
            schemeNameBox.ValueMember = "SchemeID";
            schemeNameBox.DisplayMember = "SchemeName";
            schemeNameBox.SelectedIndex = -1;
        }

        public void fillStaffDrop()
        {

            string sqlString = "SELECT * from dbo.HoS";
            DataTable dtEQA = new DataTable();
            dtEQA.TableName = "FillHosTable";
            // dtEQA.Rows.InsertAt(dtEQA.NewRow(), 0);
            dtEQA = WebMethods.GetDataTable(sqlString, dtEQA);

            schemeLead.DataSource = dtEQA;
            schemeLead.DisplayMember = "HoSName";
            schemeLead.ValueMember = "HoSName";
            schemeLead.SelectedIndex = -1;
        }

        private void eqaBodyBox_SelectedValueChanged(object sender, EventArgs e)
                {//If the EQABodyBox is not empty 
                    if (!string.IsNullOrEmpty(eqaBodyBox.Text))
                    {
                        //set SchemeName combobox
                        schemeNameBox.Enabled = true;
                        //Carry out FillScheme command
                        fillScheme();
                        schemeNameBox.SelectedItem = 0;
                    }                 
                }

        //sets the format of the datetimepicker to the short date format upon user choosing a date
        private void sampleDate_closeUp(object sender, EventArgs e)
        {
            sampleDateTextBox.Format = DateTimePickerFormat.Short;
        }

        private void subDeadline_closeUP(object sender, EventArgs e)
        {
            subDeadlineTextBox.Format = DateTimePickerFormat.Short;
        }     

        private void addScheme_click(object sender, EventArgs e)
        {
            //This button needs to do the following: Create new scheme log, enter schemeID(based on schemename), enter scheme name (from dropdown)
            //enter EQABodyID (based on schemeName), enter HosID(based on schemeName), enter the rest of informtion in the textboxes
            //into dbo.SchemeLog. 
            {
                {

                    string inputEQABody = eqaBodyBox.Text;
                    string inputSchemeName = schemeNameBox.Text;
                    string inputYear = schemeYearTextBox.Text;
                    string inputRefNo = schemeRefTextBox.Text;
                    //string inputInitDate = initDateTextBox.Text;
                    string inputSampleDate = sampleDateTextBox.Text;
                    string inputSubDeadline = subDeadlineTextBox.Text;
                    string inputStaffLead = schemeLead.Text;

                    //Don't proceed with sql command if any non null fields are empty
                    if (string.IsNullOrEmpty(inputEQABody) ||
                       string.IsNullOrEmpty(inputSchemeName) ||
                       string.IsNullOrEmpty(inputYear) ||

                      // string.IsNullOrEmpty(inputInitDate) ||
                       string.IsNullOrEmpty(inputSampleDate) ||
                       string.IsNullOrEmpty(inputSubDeadline) ||
                        string.IsNullOrEmpty(inputStaffLead) )
                    {
                        MessageBox.Show("Please enter required fields!");
                        return;
                    }

                    //Date string needs to be parsed into the correct format to enter database - onyl dd/mm/yyyy. Need to parse it to the datetime format so it is recognised by the database as 'date'
                    DateTime sampleDate, deadDate;

                    if (

                        //!DateTime.TryParseExact(inputInitDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out initDate) ||
                        !DateTime.TryParseExact(inputSampleDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out sampleDate) ||
                        !DateTime.TryParseExact(inputSubDeadline, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out deadDate))
                    {
                        MessageBox.Show("Please specify dates exactly in the form dd/mm/yyyy");
                        return;
                    }
                    else
                    {
                        WebMethods.DbLognewScheme(inputSchemeName, inputYear, inputRefNo,  sampleDate, deadDate, inputStaffLead);
                        MessageBox.Show("Scheme record has been added");
                        this.Hide();                   
                    }
                }
            }
        }

        
        private void logNewScheme_click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
        
        

       
        

        

       
    


