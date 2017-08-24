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

//This form adds new Schemes to the database. I.e. if the department signed up to a new scheme, this is added here. 

namespace EQA_Databasev1._0
{
    public partial class Add_New_Scheme : Form
    {
        EQAMWeb WebMethods = new EQAMWeb();
      
        public Add_New_Scheme()
        {
            InitializeComponent();
            WebMethods.Credentials = System.Net.CredentialCache.DefaultCredentials;
            eqaBodySelectFill();
            HoSNameFill1();
            fillSchemeGrid();
            //coverNameFill();
            HoSNameFill2();
            //coverNameFill2();
        }

    //Fill the DataGridView with the EQA Schemes currently stored in the EQA Schemes database table. 
     private void fillSchemeGrid()
        { 

         DataTable schemeTable = new DataTable();
         schemeTable.TableName = "EQASchemeTable";
         schemeTable = WebMethods.DbFillEQASchemeGrid(schemeTable); //need to make a new wsdl!!!!
         schemeGridViewBSource.DataSource = schemeTable;
         schemeGridView.DataSource = schemeGridViewBSource;

         schemeGridView.Columns["SchemeID"].HeaderText = "Scheme ID #";
         schemeGridView.Columns["SchemeName"].HeaderText = "Scheme";
         schemeGridView.Columns["Gene/Test"].HeaderText = "Gene/Test";
         schemeGridView.Columns["EQABodyName"].HeaderText = "EQA Body";
         schemeGridView.Columns["RegDeadline"].HeaderText = "Registration Deadline";
         schemeGridView.Columns["DepartmentName"].HeaderText = "Department";
         schemeGridView.Columns["HoSName"].HeaderText = "EQA Lead";
         schemeGridView.Columns["CoverStaff"].HeaderText = "Line Manager";
        }


        public void eqaBodySelectFill()//Fill the EQABody Combo box with EQABodyNames from EQABody table in database
     {
            string sqlString = "SELECT * from dbo.EQABody ORDER BY EQABodyName";
            DataTable dtEQA = new DataTable();
            dtEQA.TableName = "EQABodyTable";
            //dtEQA.Rows.InsertAt(dtEQA.NewRow(), 0);
           
           dtEQA =  WebMethods.GetDataTable(sqlString, dtEQA);
            eqaBodySelect.ValueMember = "EQABodyID";
            eqaBodySelect.DisplayMember = "EQABodyName";
            eqaBodySelect.DataSource = dtEQA;
            eqaBodySelect.SelectedIndex = -1;
     }
        
    
        public void HoSNameFill1()//Fill the HoS Combo box with HoSNames from HoS table in database
        {

            string sqlString = "SELECT * from dbo.HoS";
            DataTable dtEQA = new DataTable();
            dtEQA.TableName = "HosTable";
            //dtEQA.Rows.InsertAt(dtEQA.NewRow(), 0);

            dtEQA = WebMethods.GetDataTable(sqlString, dtEQA);

            HoSName2.ValueMember = "HoSname";
            HoSName2.DisplayMember = "HoSName";
            HoSName2.DataSource = dtEQA;
            HoSName2.SelectedIndex = -1;
        }

       


        public void HoSNameFill2()//Fill the 2nd HoS Combo box with HoSNames from HoS table in database
        {

            string sqlString = "SELECT * from dbo.HoS";
            DataTable dtEQA = new DataTable();
            dtEQA.TableName = "HosTable";
            //dtEQA.Rows.InsertAt(dtEQA.NewRow(), 0);

            dtEQA = WebMethods.GetDataTable(sqlString, dtEQA);

                HoSComboBox.ValueMember = "HoSname";
                HoSComboBox.DisplayMember = "HoSName";
                HoSComboBox.DataSource = dtEQA;
                HoSComboBox.SelectedIndex = -1;
        }

      
       

        private void addNewScheme_click(object sender, EventArgs e) //Add data into new scheme when the button is clicked
        {
            //Convert text entered into fields into strings
            string inputEQABody = eqaBodySelect.Text;
            string inputSchemeName = addNewSchemeName.Text;
            string inputGeneTest = newSchemeGeneTest.Text;
            string inputHosName2 = HoSName2.Text;
            string inputRegDeadline = regDeadline.Text;
            string inputDepartment = departmentCBox.Text;
            //string inputCoverStaff = coverStaff_CBox.Text;

            //Create control so code can only progress if the necessary fields have been filled in. 
            if (string.IsNullOrEmpty(this.eqaBodySelect.Text) ||
                        string.IsNullOrEmpty(this.addNewSchemeName.Text) ||
                        string.IsNullOrEmpty(this.newSchemeGeneTest.Text) ||
                        string.IsNullOrEmpty(this.HoSName2.Text) || 
                        string.IsNullOrEmpty(this.regDeadline.Text) ||
                        string.IsNullOrEmpty(this.departmentCBox.Text))// ||
                        //string.IsNullOrEmpty(this.coverStaff_CBox.Text))
                {
                    MessageBox.Show("Please enter required fields!");
                    return;
                }

            DateTime regDeadlineOut;

            if
                (!DateTime.TryParseExact(inputRegDeadline, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out regDeadlineOut))
            {          //error message if date is not in the correct day/month/year format. 
                MessageBox.Show("Please specify dates exactly in the form dd/mm/yyyy");
                return;
            }

            //use new connection to execute SQL query

            WebMethods.DbAddNewScheme(inputEQABody, inputSchemeName, inputGeneTest, inputHosName2, regDeadlineOut, inputDepartment);
            
            
            MessageBox.Show("New EQA Scheme has been added");
            eqaBodySelect.SelectedIndex = -1;
            departmentCBox.SelectedIndex = -1;
            addNewScheme.Text = "";
            newSchemeGeneTest.Text = "";
            HoSName2.SelectedIndex = -1;
            fillSchemeGrid();
            //this.Hide();
                
            }


        private void updateScheme_click(object sender, EventArgs e)// SQL command to update an existing scheme is executed when button is pressed
        {
            string inputNewHoS = HoSComboBox.Text;
            string inputNewReg = newRegDeadline.Text;

            if (schemeGridView.SelectedRows.Count == 0) // If the selected row count is 0, exception handled to select a row
            {
                MessageBox.Show("Please select an EQA Scheme to update");
                return;
            }

            if (string.IsNullOrEmpty(this.HoSComboBox.Text)) //If no head of service to update to is selected, exception handled to select a head of service
            {
                MessageBox.Show("Please select a new Head of Service, or select the existing Head of Service");
                return;
            }
            if (string.IsNullOrEmpty(this.regDeadline.Text)) //If no head of service to update to is selected, exception handled to select a head of service
            {
                MessageBox.Show("Please select a new Registration Deadline, or repeat the existing deadline");
                return;
            }

            DateTime newRegDeadlineOut;

            if
                (!DateTime.TryParseExact(inputNewReg, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out newRegDeadlineOut))
            {          //error message if date is not in the correct day/month/year format. 
                MessageBox.Show("Please specify dates exactly in the form dd/mm/yyyy");
                return;
            }

            else
            {
                //Once both controls are passed, use the below SQL connection to execute the update query.
                DataGridViewRow selectedRow = schemeGridView.SelectedRows[0];
                string selectedRecord = selectedRow.Cells[0].Value.ToString(); //want to get SchemeID of seleced record to the string              

                WebMethods.DbUpdateExistingEQAScheme(selectedRecord, inputNewHoS, newRegDeadlineOut);

                MessageBox.Show("EQA Scheme details have been updated");
                HoSComboBox.SelectedIndex = -1;
        
                fillSchemeGrid();
                //this.Hide();
            }
        }

       // Close form when close button is clicked. 
        private void addSchemeClose_click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        }
    }


                    


