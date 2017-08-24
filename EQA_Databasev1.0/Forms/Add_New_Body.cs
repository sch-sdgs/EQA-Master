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

//This form adds new EQA bodies the database, i.e. when a new scheme is signed up to, if it is a EQA Body not seen before, you can add it to the system.

namespace EQA_Databasev1._0
{
    public partial class Add_New_Body : Form
    {
        EQAMWeb WebMethods = new EQAMWeb();

        public Add_New_Body()
        {
            InitializeComponent();
            WebMethods.Credentials = System.Net.CredentialCache.DefaultCredentials;
            fillEQABodyGrid();
        }

        // Fill the DatagridView with details of EQA Bodies that are currently registered in the database
        private void fillEQABodyGrid()
        {
            //A DataTable represents one table from a DataSet - a table of in-memory relational data (almost like a copy of the sql database table in the request)
            DataTable bodyTable = new DataTable();
            bodyTable.TableName = "EQABodyTable";
            bodyTable = WebMethods.DbGetEQABodies(bodyTable);
            eqaBodyBSource.DataSource = bodyTable; //BSource is BindingSource, this provides a bilateral bridge between the database and your control
            eqabodyGridView.DataSource = eqaBodyBSource;

            eqabodyGridView.Columns["EQABodyID"].HeaderText = "EQA Body #";
            eqabodyGridView.Columns["EQABodyName"].HeaderText = "EQA Body";
            eqabodyGridView.Columns["EQAURL"].HeaderText = "Website URL";
        }

 
        //Clicking updateBody button will excute an SQL update command to alter details in the tables. 
        private void updateBodyURL_Click(object sender, EventArgs e)
        {
            

            //Check whether a row in the grid has been selected to update.
           if (eqabodyGridView.SelectedRows.Count == 0) //Count the number of rows in "SelectedRows" 
                {   //If counted rows is 0, error message is displayed telling user to select a record before the button click will work
                    MessageBox.Show("Please select an EQA Body to update!");
                        return;
                }

           if (string.IsNullOrEmpty(this.updateURLTBox.Text)) //check whether all fields contain text before proceeding with button click
           {
               MessageBox.Show("Please enter a new URL for selected EQA Body!");
               return;
           }

           else
           {
               DataGridViewRow selectedRow = eqabodyGridView.SelectedRows[0];
               string SelectedRecord = selectedRow.Cells[0].Value.ToString();
               string inputNewURL = updateURLTBox.Text;
               WebMethods.DbUpdateEQABody(SelectedRecord, inputNewURL);

               MessageBox.Show("EQA Body URL has been updated!");
               fillEQABodyGrid();
               return;
           }
            
        }

        
        //Clicking updateBody button will excute an SQL update command to add a new EQA Body to the database
        private void addNewEQABody_click(object sender, EventArgs e)
        {  
            string inputBodyName = newEQABodyName.Text;
            string inputBodyURL = newEQABodyURL.Text;
          

            //Control so code can only progress if the necessary fields have been filled in. 
            if (string.IsNullOrEmpty(inputBodyName) ||
                string.IsNullOrEmpty(inputBodyURL))
            {
                MessageBox.Show("Please enter required fields!");
                return;
            }

            WebMethods.DbAddNewEQABody(inputBodyName, inputBodyURL);

                if (!string.IsNullOrEmpty(newEQABodyName.Text) || !string.IsNullOrEmpty(newEQABodyURL.Text))
                {
                    this.newEQABodyName.Clear();
                    this.newEQABodyURL.Clear();
                }
                
            
            MessageBox.Show("New EQA Body has been added");
            fillEQABodyGrid();
            return;
        }

        
        //Close Add_New_Body Window when Close button is pressed
        private void updateBodyClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }   
    }
}
