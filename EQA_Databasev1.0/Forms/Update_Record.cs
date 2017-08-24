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
    public partial class Update_Record : Form
    {
        EQAMWeb WebMethods = new EQAMWeb();

        public Update_Record()
        {
            InitializeComponent();
            WebMethods.Credentials = System.Net.CredentialCache.DefaultCredentials; 
            fillBody();      
            fillYear();
            fillDataGridFull();
        }

        public void fillDataGridFull() //This method fills the gridView with all schemes in SchemeLog when the form opens 
        {
            try
            {
                DataTable fillSchemeTable = new DataTable();
                fillSchemeTable.TableName = "FullSchemeTable";
                fillSchemeTable = WebMethods.DbFillSchemeViewGrid(fillSchemeTable);

                schemeLogBindingSource.DataSource = fillSchemeTable;
                schemeLogDataGrid.DataSource = schemeLogBindingSource;

                schemeLogDataGrid.Columns["SchemeLogID"].HeaderText = "Scheme Log #";
                schemeLogDataGrid.Columns["DepartmentName"].HeaderText = "Department";
                schemeLogDataGrid.Columns["SchemeName"].HeaderText = "Scheme";
                schemeLogDataGrid.Columns["HoSName"].HeaderText = "Scheme Lead";
                schemeLogDataGrid.Columns["EQAURL"].HeaderText = "EQA URL";
                schemeLogDataGrid.Columns["SchemeRefNo"].HeaderText = "Scheme Ref #";
                schemeLogDataGrid.Columns["SchemeYear"].HeaderText = "Year";
                schemeLogDataGrid.Columns["SampleReceiptDate"].HeaderText = "Date of Sample Receipt";
                schemeLogDataGrid.Columns["SubmissionDeadline"].HeaderText = "Submission Deadline";
                schemeLogDataGrid.Columns["SubmissionDate"].HeaderText = "Date of Submission";
                schemeLogDataGrid.Columns["DateResultsDownload"].HeaderText = "Date or Results Download";
                schemeLogDataGrid.Columns["ResultScore"].HeaderText = "Result Score";
                schemeLogDataGrid.Columns["ResultStatus"].HeaderText = "Result Status";            
                schemeLogDataGrid.Columns["QPulseEntryNo"].HeaderText = "QPulse #";
                schemeLogDataGrid.Columns["AppealDeadline"].HeaderText = "Appeal Deadline";
                schemeLogDataGrid.Columns["DateAppealSubmission"].HeaderText = "Date of Appeal Submission";
                schemeLogDataGrid.Columns["AppealStatus"].HeaderText = "Status of Appeal";
                schemeLogDataGrid.Columns["DateAppealResultDownload"].HeaderText = "Date of Appeal Download";

            }
            catch
            {
                MessageBox.Show("Error, please contact system administrator!");
            }

        }
        public void colourChange_event(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            foreach (DataGridViewRow rw in schemeLogDataGrid.Rows)
            {
                string qpulseText = rw.Cells[14].Value.ToString();
                string resultStatus = rw.Cells[13].Value.ToString();

                if( (qpulseText == "") && (resultStatus != ""))
                {
                    rw.DefaultCellStyle.BackColor = Color.LightPink;
                }
        
            }
        }
                
      
        private void fillYear()
        {
            string sqlString = "SELECT DISTINCT  SchemeYear FROM SchemeLog";
            DataTable dtEQA = new DataTable();
            dtEQA.TableName = "YearTable";
            dtEQA = WebMethods.GetDataTable(sqlString, dtEQA);
            //bind necessary columns from EqaBody table to combobox DisplayMember and Value
            searchSchemeYear.DataSource = dtEQA;
            searchSchemeYear.DisplayMember = "SchemeYear";
            searchSchemeYear.ValueMember = "SchemeYear";
            searchSchemeYear.SelectedIndex = -1;    
        }


        private void fillBody()
        {
          

            DataTable dtEqaBody = new DataTable();
            dtEqaBody.TableName = "BodyTable";
            dtEqaBody.TableName = "EQABodyTable";

            // using sql connection so connection will remain open for the command
            dtEqaBody = WebMethods.DbFillEQABodyDropDownDeptParam(dtEqaBody);

            //bind necessary columns from EqaBody table to combobox DisplayMember and Value
            searchBodyCBox.DataSource = dtEqaBody;
            searchBodyCBox.DisplayMember = "EQABodyName";
            searchBodyCBox.ValueMember = "EQABodyName";
            searchBodyCBox.SelectedIndex = -1;
        }

        private void filterResults_click(object sender, EventArgs e)
        {
            int inputYearSelect = 0;
            Int32.TryParse(searchSchemeYear.Text, out inputYearSelect);
            string inputDeptSelect = deptFilterBox.Text;
            string inputBodySelect = searchBodyCBox.Text;


            if (string.IsNullOrEmpty(inputDeptSelect) && inputYearSelect == 0 && string.IsNullOrEmpty(inputBodySelect))
            {
                MessageBox.Show("Please select some filter parameters from the dropdown lists!");
            }


            else if (inputYearSelect == 0 && string.IsNullOrEmpty(inputBodySelect) && (inputDeptSelect != null))
            {   
                //search only on Dept
                DataTable recordsTable = new DataTable("RecordsTable");
                recordsTable = WebMethods.DbDeptBoxSelectedValueFilter(inputDeptSelect, recordsTable);
                schemeLogBindingSource.DataSource = recordsTable;
                schemeLogDataGrid.DataSource = schemeLogBindingSource;

                deptFilterBox.SelectedIndex = -1;
               
            }
            else  if (string.IsNullOrEmpty(inputDeptSelect) && string.IsNullOrEmpty(inputBodySelect))
            {

                //search only on Year
                DataTable recordsTable = new DataTable("RecordsTable");
                recordsTable = WebMethods.DbYearBoxSelectedValueFilter(inputYearSelect, recordsTable);
                schemeLogBindingSource.DataSource = recordsTable;
                schemeLogDataGrid.DataSource = schemeLogBindingSource;
                
                searchSchemeYear.SelectedIndex = -1;
            }
            else if (inputYearSelect == 0 && string.IsNullOrEmpty(inputDeptSelect))
            {

                //search only on Body
                DataTable recordsTable = new DataTable("RecordsTable");
                recordsTable = WebMethods.DbBodyBoxSelectedValueFilter(inputBodySelect, recordsTable);
                schemeLogBindingSource.DataSource = recordsTable;
                schemeLogDataGrid.DataSource = schemeLogBindingSource;

                searchBodyCBox.SelectedIndex = -1;
            }
            else if (string.IsNullOrEmpty(inputDeptSelect))
            {

                //search on Year and Body
                DataTable recordsTable = new DataTable("RecordsTable");
                recordsTable = WebMethods.DbFilterYear_Body(inputYearSelect, inputBodySelect, recordsTable);
                schemeLogBindingSource.DataSource = recordsTable;
                schemeLogDataGrid.DataSource = schemeLogBindingSource;
                searchSchemeYear.SelectedIndex = -1;
                searchBodyCBox.SelectedIndex = -1;
            }
            else if (inputYearSelect == 0)
            {

                //search on Dept and Body
                DataTable recordsTable = new DataTable("RecordsTable");
                recordsTable = WebMethods.DbFilterSection_Body(inputDeptSelect, inputBodySelect, recordsTable);
                schemeLogBindingSource.DataSource = recordsTable;
                schemeLogDataGrid.DataSource = schemeLogBindingSource;

                deptFilterBox.SelectedIndex = -1;
                searchBodyCBox.SelectedIndex = -1;
            }
            else if (string.IsNullOrEmpty(inputBodySelect))
            {

                //search on Dept and Year
                DataTable recordsTable = new DataTable("RecordsTable");
                recordsTable = WebMethods.DbFilterYear_Section(inputYearSelect, inputDeptSelect, recordsTable);
                schemeLogBindingSource.DataSource = recordsTable;
                schemeLogDataGrid.DataSource = schemeLogBindingSource;

                deptFilterBox.SelectedIndex = -1;
                searchSchemeYear.SelectedIndex = -1;
            }

            else
            {
                //search on all 3, Dept, Year and Body
                DataTable recordsTable = new DataTable("RecordsTable");
                recordsTable = WebMethods.DbFilterYear_Section_Body(inputYearSelect, inputDeptSelect, inputBodySelect, recordsTable);
                schemeLogBindingSource.DataSource = recordsTable;
                schemeLogDataGrid.DataSource = schemeLogBindingSource;

                deptFilterBox.SelectedIndex = -1;
                searchSchemeYear.SelectedIndex = -1;
                searchBodyCBox.SelectedIndex = -1;
            }
        }
      
        public void deleteRecord_Click(object sender, EventArgs e)
        {

            if (schemeLogDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select record to delete!");
            }

            else if (MessageBox.Show(string.Format("Do you want to delete this Scheme Record?", schemeLogDataGrid.SelectedRows.Count), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataGridViewRow selectedRows = schemeLogDataGrid.SelectedRows[0];
                string inputSchemeLogID = selectedRows.Cells[0].Value.ToString();
                WebMethods.DbDeleteRecord(inputSchemeLogID);

                MessageBox.Show("Record has been deleted!");
            }
        }

       
        public void AddSample_Click(object sender, EventArgs e)
        {//Open the AddSample window and add the scheme name and SchemeLogID from teh Datagrid view into the textboxes in Add_Sample form.
            if (schemeLogDataGrid.SelectedRows.Count == 0)
            {

                MessageBox.Show("Please select a record!");
            }
            else
            {      
                Samples samplesForm = new Samples();
                DataGridViewRow selectedRow = schemeLogDataGrid.SelectedRows[0];
                samplesForm.samplesSchemeIDTBox.Text = selectedRow.Cells[0].Value.ToString();
                samplesForm.ShowDialog();
                samplesForm.Activate();
         
            }
             
        }

        public void AddOutcome_Click(object sender, EventArgs e)
        {
            if (schemeLogDataGrid.SelectedRows.Count == 0)
            {

                MessageBox.Show("Please select a record!");
            }

            //if SelectedRow Cell[14] already contains text, ask "This record already contains an outcome, do you want to overwrite this outcome?" Yes/No..proceed)
            else
            {
                DataGridViewRow currentRowOutcome = schemeLogDataGrid.SelectedRows[0];
                string resStatusCell = currentRowOutcome.Cells[13].Value.ToString();
                string subDateCell = currentRowOutcome.Cells[10].Value.ToString();

                string string0 = currentRowOutcome.Cells[0].Value.ToString(); //schemelogid
                string string1 = currentRowOutcome.Cells[1].Value.ToString(); //Department
                string string2 = currentRowOutcome.Cells[2].Value.ToString();//Scheme
                string string3 = currentRowOutcome.Cells[3].Value.ToString();//Body
                string string4 = currentRowOutcome.Cells[4].Value.ToString();//Body URL
                string string5 = currentRowOutcome.Cells[5].Value.ToString();//Scheme Lead
                string string6 = currentRowOutcome.Cells[6].Value.ToString();//Scheme Ref #
                string string7 = currentRowOutcome.Cells[7].Value.ToString();//Year
                string string8 = currentRowOutcome.Cells[8].Value.ToString();//Date of samples
                string string9 = currentRowOutcome.Cells[9].Value.ToString();//submission deadline
                string string10 = currentRowOutcome.Cells[10].Value.ToString();//Date of submission
                string string11 = currentRowOutcome.Cells[11].Value.ToString();//date of results download
                string string12 = currentRowOutcome.Cells[12].Value.ToString();//result score
                string string13 = currentRowOutcome.Cells[13].Value.ToString();//result status
                string string14 = currentRowOutcome.Cells[14].Value.ToString();//Qpulse #
                string string15 = currentRowOutcome.Cells[15].Value.ToString();//Appeal Deadline
                string string16 = currentRowOutcome.Cells[16].Value.ToString();//Date of Appeal 
                string string17 = currentRowOutcome.Cells[17].Value.ToString();
                string string18 = currentRowOutcome.Cells[18].Value.ToString();




                if (!String.IsNullOrEmpty(resStatusCell))
                {

                  if (MessageBox.Show("This record already contains an Outcome, do you want to overwrite this Outcome?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                  
                    {
                        Add_Scheme_Outcome outcomeForm = new Add_Scheme_Outcome();
                        DataGridViewRow selectedRow = schemeLogDataGrid.SelectedRows[0];
                        outcomeForm.outcomeSchemeIDTBox.Text = selectedRow.Cells[0].Value.ToString();
                        outcomeForm.subDateTextBox.Text = selectedRow.Cells[10].Value.ToString();
                        outcomeForm.qPulseTextBox.Text = selectedRow.Cells[14].Value.ToString();
                        outcomeForm.ShowDialog();
                        outcomeForm.Activate();                
                    }                  
                }
                else if (String.IsNullOrEmpty(resStatusCell) & (!String.IsNullOrEmpty(subDateCell)))
                {
                    Add_Scheme_Outcome outcomeForm = new Add_Scheme_Outcome();
                    DataGridViewRow selectedRow = schemeLogDataGrid.SelectedRows[0];
                    outcomeForm.outcomeSchemeIDTBox.Text = selectedRow.Cells[0].Value.ToString();                  
                    outcomeForm.subDateTextBox.Text = selectedRow.Cells[10].Value.ToString();
                    outcomeForm.qPulseTextBox.Text = selectedRow.Cells[14].Value.ToString();
                    outcomeForm.ShowDialog();
                    outcomeForm.Activate();                   
                }
                else if (String.IsNullOrEmpty(resStatusCell)) 
                {
                    Add_Scheme_Outcome outcomeForm = new Add_Scheme_Outcome();
                    DataGridViewRow selectedRow = schemeLogDataGrid.SelectedRows[0];
                    outcomeForm.outcomeSchemeIDTBox.Text = selectedRow.Cells[0].Value.ToString();
                    outcomeForm.qPulseTextBox.Text = selectedRow.Cells[14].Value.ToString();
                    outcomeForm.ShowDialog();
                    outcomeForm.Activate();
                }
            }
        }

        public void AddAppeal_Click(object sender, EventArgs e)
        {
            if (schemeLogDataGrid.SelectedRows.Count == 0)
            {

                MessageBox.Show("Please select a record!");
            }
            else
            {
                DataGridViewRow currentRowAppeal = schemeLogDataGrid.SelectedRows[0];
                string appealdateCell = currentRowAppeal.Cells[16].Value.ToString();

                if (!String.IsNullOrEmpty(appealdateCell))
                {

                    if (MessageBox.Show("This record already contains an Appeal, do you want to overwrite this Appeal?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Add_Appeal appealForm = new Add_Appeal();
                        DataGridViewRow selectedRow = schemeLogDataGrid.SelectedRows[0];
                        appealForm.appealSchemeIDTBox.Text = selectedRow.Cells[0].Value.ToString();
                        appealForm.ShowDialog();
                        appealForm.Activate();                       
                    }
                }

                else if (String.IsNullOrEmpty(appealdateCell))
                {
                    Add_Appeal appealForm = new Add_Appeal();
                    DataGridViewRow selectedRow = schemeLogDataGrid.SelectedRows[0];
                    appealForm.appealSchemeIDTBox.Text = selectedRow.Cells[0].Value.ToString();
                    appealForm.ShowDialog();
                    appealForm.Activate();                 
                }

            }
        }

        private void addFeedback_Click(object sender, EventArgs e)
        {

            if (schemeLogDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record!");
            }
            
            else

            {
                Add_Feedback feedbackForm = new Add_Feedback();
                DataGridViewRow selectedRow = schemeLogDataGrid.SelectedRows[0];
                feedbackForm.feedbackSchemeIDTBox.Text = selectedRow.Cells[0].Value.ToString();
                feedbackForm.ShowDialog();
                feedbackForm.Activate();              
            }
        }

        private void addQPulse_Click(object sender, EventArgs e)
        {
            if (schemeLogDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record!");
            }
            else
            {
                DataGridViewRow currentRowQPulse = schemeLogDataGrid.SelectedRows[0];
                string qPulseNumCell = currentRowQPulse.Cells[14].Value.ToString();

                if (!String.IsNullOrEmpty(qPulseNumCell))
                {
                    if (MessageBox.Show("This record already has an audit number, do you want to overwrite this number?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        EQA_Databasev1._0.Forms.Add_Qpulse qPulseForm = new EQA_Databasev1._0.Forms.Add_Qpulse();
                        DataGridViewRow selectedRow = schemeLogDataGrid.SelectedRows[0];
                        qPulseForm.schemeLogIDBox.Text = selectedRow.Cells[0].Value.ToString();
                        qPulseForm.ShowDialog();
                        qPulseForm.Activate();
                    }
                }
                else if (String.IsNullOrEmpty(qPulseNumCell))
                {
                    EQA_Databasev1._0.Forms.Add_Qpulse qPulseForm = new EQA_Databasev1._0.Forms.Add_Qpulse();
                    DataGridViewRow selectedRow = schemeLogDataGrid.SelectedRows[0];
                    qPulseForm.schemeLogIDBox.Text = selectedRow.Cells[0].Value.ToString();
                    qPulseForm.ShowDialog();
                    qPulseForm.Activate();
                }             
            }
        }

        private void checkForComments()
        {
            DataGridViewButtonColumn view_comments = new DataGridViewButtonColumn();
            view_comments.Name = "Comments";
            view_comments.Text = "View Comments";


            foreach (DataGridViewRow row in schemeLogDataGrid.Rows)
            {//make a link in the comments cell in schemelogdatagrid and add link word saying view comments 
                string inputSchemeLogID = Convert.ToString(row.Cells[0].Value); //this needs to be for each line the schemelogid

                DataTable checkScheme = new DataTable("checkScheme");
                DataTable checkSample = new DataTable("checkSample");

                checkScheme = WebMethods.DbViewSchemeComments(inputSchemeLogID, checkScheme);
                checkSample = WebMethods.DbViewSampleComments(inputSchemeLogID, checkSample);

                int schemecheck = Convert.ToInt32(checkScheme.Rows.Count.ToString());
                int sampleCheck = Convert.ToInt32(checkSample.Rows.Count.ToString());

                int comments_total = schemecheck + sampleCheck;
                if (comments_total > 0)
                {                                  
                   schemeLogDataGrid.Columns.Insert(14, view_comments);
                }
                
            }

        }
        private void updateClose_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void displayAllBtn_Click(object sender, EventArgs e)
        {
            fillDataGridFull();           
        }
  
        private void logNewScheme_Click(object sender, EventArgs e)
        {

            Log_New_Scheme schLog = new Log_New_Scheme();
            schLog.ShowDialog();
            schLog.Activate();
        }

        private void viewSamples_click(object sender, EventArgs e)
        {
            //Open the samples listed for selected scheme
            if (schemeLogDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record!");
            }
            else
            {
                View_Samples viewSamplesForm = new View_Samples();
                DataGridViewRow selectedRow = schemeLogDataGrid.SelectedRows[0];
                viewSamplesForm.schemeLogIDSamples.Text = selectedRow.Cells[0].Value.ToString();
                viewSamplesForm.fillSampleView();
                viewSamplesForm.ShowDialog(this);
                viewSamplesForm.Activate();
            }
        }

        private void viewFeedbacl_Click(object sender, EventArgs e)
        {
            //Open the feedback listed for selected scheme
            if (schemeLogDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record!");
            }

            else
            {
                View_Feedback viewFeedbackForm = new View_Feedback();
                DataGridViewRow selectedRow = schemeLogDataGrid.SelectedRows[0];
                viewFeedbackForm.schemeLogIDFeedback.Text = selectedRow.Cells[0].Value.ToString();
                viewFeedbackForm.fillFeedback();
                viewFeedbackForm.ShowDialog();
                viewFeedbackForm.Activate();
            }
        }

        private void viewComments_Click(object sender, EventArgs e)
        {
            if (schemeLogDataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record!");
            }
            else
            {
                EQA_Databasev1._0.Forms.ViewComments viewCommentsForm = new EQA_Databasev1._0.Forms.ViewComments();
                DataGridViewRow selectedRow = schemeLogDataGrid.SelectedRows[0];
                viewCommentsForm.schemeLogID.Text = selectedRow.Cells[0].Value.ToString();
                viewCommentsForm.fillSampleComments();
                viewCommentsForm.fillSchemeComments();
                viewCommentsForm.ShowDialog();
                viewCommentsForm.Activate();
            }
        }       
    }
}






