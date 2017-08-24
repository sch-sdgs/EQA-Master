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
using System.Web;
using System.Web.Services;
using EQA_Databasev1._0.Forms;


namespace EQA_Databasev1._0
{
    public partial class Scheme_Records_View : Form
    {
        EQAMWeb EQAWebMethods = new EQAMWeb();
        //StarLimsWeb StarLimsWebMethods = new StarLimsWeb();

        public Scheme_Records_View()
        {
            InitializeComponent();

            EQAWebMethods.Credentials = System.Net.CredentialCache.DefaultCredentials;
            //fillScheme();
            fillBody();
            //fillDepartment();
            fillYear();
            fillDataGridFull();
           
            

        }

        private void fillDataGridFull() //This method fills the gridView with all schemes in SchemeLog when the form opens 
        {
            DataTable fillSchemeTable = new DataTable();
            fillSchemeTable.TableName = "FullSchemeTable";
            fillSchemeTable = EQAWebMethods.DbFillSchemeViewGrid(fillSchemeTable);

            recordViewBindingSource.DataSource = fillSchemeTable;
            recordViewGrid.DataSource = recordViewBindingSource;

            foreach (DataGridViewRow row in recordViewGrid.Rows)
            {
                DataGridViewLinkCell urlLink = new DataGridViewLinkCell();
                urlLink.Value = row.Cells[4].Value;
                row.Cells[4] = urlLink;
            }

            recordViewGrid.Columns["SchemeLogID"].HeaderText = "Scheme Log #";
            recordViewGrid.Columns["DepartmentName"].HeaderText = "Department";
            recordViewGrid.Columns["SchemeName"].HeaderText = "Scheme";
            recordViewGrid.Columns["EQABodyName"].HeaderText = "EQA Body ";
            recordViewGrid.Columns["EQAURL"].HeaderText = "EQA URL";
            recordViewGrid.Columns["HoSName"].HeaderText = "Scheme Lead";
            recordViewGrid.Columns["SchemeRefNo"].HeaderText = "Scheme Ref #";
            recordViewGrid.Columns["SchemeYear"].HeaderText = "Year";
            recordViewGrid.Columns["SampleReceiptDate"].HeaderText = "Date of Sample Receipt";
            recordViewGrid.Columns["SubmissionDeadline"].HeaderText = "Submission Deadline";
            recordViewGrid.Columns["SubmissionDate"].HeaderText = "Date of Submission";
            recordViewGrid.Columns["DateResultsDownload"].HeaderText = "Date or Results Download";
            recordViewGrid.Columns["ResultScore"].HeaderText = "Result Score";
            recordViewGrid.Columns["ResultStatus"].HeaderText = "Result Status";
            recordViewGrid.Columns["QPulseEntryNo"].HeaderText = "QPulse #";
            recordViewGrid.Columns["AppealDeadline"].HeaderText = "Appeal Deadline";
            recordViewGrid.Columns["DateAppealSubmission"].HeaderText = "Date of Appeal Submission";
            recordViewGrid.Columns["AppealStatus"].HeaderText = "Status of Appeal";
            recordViewGrid.Columns["PostAppealResult"].HeaderText = "Appeal Results";
            recordViewGrid.Columns["DateAppealResultDownload"].HeaderText = "Date of Appeal Download";
        }


        private void fillYear()
        {
            string sqlString = "SELECT DISTINCT SchemeYear FROM SchemeLog";
            DataTable dtEQA = new DataTable();
            dtEQA.TableName = "YearTable";
            // dtEQA.Rows.InsertAt(dtEQA.NewRow(), 0);
            dtEQA = EQAWebMethods.GetDataTable(sqlString, dtEQA);
            //bind necessary columns from EqaBody table to combobox DisplayMember and Value
            yearCBox.DataSource = dtEQA;
            yearCBox.DisplayMember = "SchemeYear";
            yearCBox.ValueMember = "SchemeYear";
            yearCBox.SelectedIndex = -1;
        }


        private void fillBody()
        {


            DataTable dtEqaBody = new DataTable();
            dtEqaBody.TableName = "BodyTable";
            //dtEqaBody.Rows.InsertAt(dtEqaBody.NewRow(), 0);
            dtEqaBody.TableName = "EQABodyTable";
            // using sql connection so connection will remain open for the command
            dtEqaBody = EQAWebMethods.DbFillEQABodyDropDownDeptParam( dtEqaBody);

            //bind necessary columns from EqaBody table to combobox DisplayMember and Value
            eqaBodyCBox.DataSource = dtEqaBody;
            eqaBodyCBox.DisplayMember = "EQABodyName";
            eqaBodyCBox.ValueMember = "EQABodyName";
            eqaBodyCBox.SelectedIndex = -1;
        }

        private void filterResults_Click(object sender, EventArgs e)
        {
            int inputYearSelect = 0;
            Int32.TryParse(yearCBox.Text, out inputYearSelect);
            string inputDeptSelect = deptFilterBox.Text;
            string inputBodySelect = eqaBodyCBox.Text;


            if (string.IsNullOrEmpty(inputDeptSelect) && inputYearSelect == 0 && string.IsNullOrEmpty(inputBodySelect))
            {
                MessageBox.Show("Please select some filter parameters from the dropdown lists!");
            }


            else if (inputYearSelect == 0 && string.IsNullOrEmpty(inputBodySelect) && (inputDeptSelect != null))
            {
                //search only on Dept
                DataTable recordsTable = new DataTable("RecordsTable");
                recordsTable = EQAWebMethods.DbDeptBoxSelectedValueFilter(inputDeptSelect, recordsTable);
                recordViewBindingSource.DataSource = recordsTable;
                recordViewGrid.DataSource = recordViewBindingSource;

                deptFilterBox.SelectedIndex = -1;

                foreach (DataGridViewRow row in recordViewGrid.Rows)
                {
                    DataGridViewLinkCell urlLink = new DataGridViewLinkCell();
                    urlLink.Value = row.Cells[4].Value;
                    row.Cells[4] = urlLink;
                }

            }
            else if (string.IsNullOrEmpty(inputDeptSelect) && string.IsNullOrEmpty(inputBodySelect))
            {

                //search only on Year
                DataTable recordsTable = new DataTable("RecordsTable");
                recordsTable =EQAWebMethods.DbYearBoxSelectedValueFilter(inputYearSelect, recordsTable);
                recordViewBindingSource.DataSource = recordsTable;
                recordViewGrid.DataSource = recordViewBindingSource;

                yearCBox.SelectedIndex = -1;

                foreach (DataGridViewRow row in recordViewGrid.Rows)
                {
                    DataGridViewLinkCell urlLink = new DataGridViewLinkCell();
                    urlLink.Value = row.Cells[4].Value;
                    row.Cells[4] = urlLink;
                }
            }
            else if (inputYearSelect == 0 && string.IsNullOrEmpty(inputDeptSelect))
            {

                //search only on Body
                DataTable recordsTable = new DataTable("RecordsTable");
                recordsTable = EQAWebMethods.DbBodyBoxSelectedValueFilter(inputBodySelect, recordsTable);
                recordViewBindingSource.DataSource = recordsTable;
                recordViewGrid.DataSource = recordViewBindingSource;

                eqaBodyCBox.SelectedIndex = -1;
                foreach (DataGridViewRow row in recordViewGrid.Rows)
                {
                    DataGridViewLinkCell urlLink = new DataGridViewLinkCell();
                    urlLink.Value = row.Cells[4].Value;
                    row.Cells[4] = urlLink;
                }
            }
            else if (string.IsNullOrEmpty(inputDeptSelect))
            {

                //search on Year and Body
                DataTable recordsTable = new DataTable("RecordsTable");
                recordsTable = EQAWebMethods.DbFilterYear_Body(inputYearSelect, inputBodySelect, recordsTable);
                recordViewBindingSource.DataSource = recordsTable;
                recordViewGrid.DataSource = recordViewBindingSource;

                yearCBox.SelectedIndex = -1;
                eqaBodyCBox.SelectedIndex = -1;

                foreach (DataGridViewRow row in recordViewGrid.Rows)
                {
                    DataGridViewLinkCell urlLink = new DataGridViewLinkCell();
                    urlLink.Value = row.Cells[4].Value;
                    row.Cells[4] = urlLink;
                }
            }
            else if (inputYearSelect == 0)
            {

                //search on Dept and Body
                DataTable recordsTable = new DataTable("RecordsTable");
                recordsTable = EQAWebMethods.DbFilterSection_Body(inputDeptSelect, inputBodySelect, recordsTable);
                recordViewBindingSource.DataSource = recordsTable;
                recordViewGrid.DataSource = recordViewBindingSource;

                deptFilterBox.SelectedIndex = -1;
                eqaBodyCBox.SelectedIndex = -1;

                foreach (DataGridViewRow row in recordViewGrid.Rows)
                {
                    DataGridViewLinkCell urlLink = new DataGridViewLinkCell();
                    urlLink.Value = row.Cells[4].Value;
                    row.Cells[4] = urlLink;
                }
            }
            else if (string.IsNullOrEmpty(inputBodySelect))
            {

                //search on Dept and Year
                DataTable recordsTable = new DataTable("RecordsTable");
                recordsTable = EQAWebMethods.DbFilterYear_Section(inputYearSelect, inputDeptSelect, recordsTable);
                recordViewBindingSource.DataSource = recordsTable;
                recordViewGrid.DataSource = recordViewBindingSource;

                deptFilterBox.SelectedIndex = -1;
                yearCBox.SelectedIndex = -1;

                foreach (DataGridViewRow row in recordViewGrid.Rows)
                {
                    DataGridViewLinkCell urlLink = new DataGridViewLinkCell();
                    urlLink.Value = row.Cells[4].Value;
                    row.Cells[4] = urlLink;
                }
            }

            else
            {
                //search on all 3, Dept, Year and Body
                DataTable recordsTable = new DataTable("RecordsTable");
                recordsTable = EQAWebMethods.DbFilterYear_Section_Body(inputYearSelect, inputDeptSelect, inputBodySelect, recordsTable);
                recordViewBindingSource.DataSource = recordsTable;
                recordViewGrid.DataSource = recordViewBindingSource;

                deptFilterBox.SelectedIndex = -1;
                yearCBox.SelectedIndex = -1;
                eqaBodyCBox.SelectedIndex = -1;

                foreach (DataGridViewRow row in recordViewGrid.Rows)
                {
                    DataGridViewLinkCell urlLink = new DataGridViewLinkCell();
                    urlLink.Value = row.Cells[4].Value;
                    row.Cells[4] = urlLink;
                }
            }
        }


        private void displayAllBtn_Click(object sender, EventArgs e)
        {
            fillDataGridFull();
        }


        private void urlLink_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex != -1)
            {

                System.Diagnostics.Process.Start("iexplore.exe", this.recordViewGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
        }

        //The following events are to enable exportation of the gridview to an excel spreadsheet file. 
        private static void ToCsV(DataGridView dGV, string filename) //code adapted from http://www.codeproject.com/Tips/545456/Exporting-DataGridview-To-Excel
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "Scheme Log ID No." + "\t" + "Department" + "\t" + "Scheme Name" + "\t" + "EQA Body" + "\t" + "EQAURL" + "\t" + "Head of Service " + "\t" + "Scheme Ref. No" + "\t" + "Scheme Year" + "\t" + "\t" + "Scheme Inititaion Date" + "\t" + "Sample Receipt Date" + "\t" + "Starlims Ref." + "\t" + "Submission Deadline" + "\t" + "Date of Submission" + "\t" + "Date of Results Download" + "\t" + "Score" + "\t" + "Status" + "\t" + "Action Points" + "\t" + "QPulse No." + "\t" + "Appeal Deadline" + "\t" + "Date of Appeal Submission" + "\t" + "Appeal Status" + "\t" + "Appeal Result" + "\t" + "Date of Appeal Results";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString();
            stOutput += sHeaders + "\r\n"; // \r\n is a new line in windows 


            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void exportExcel_Click(object sender, MouseEventArgs e) //code from http://www.codeproject.com/Tips/545456/Exporting-DataGridview-To-Excel
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "NameMe.xls";



            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ToCsV(recordViewGrid, sfd.FileName);
            }

        }

       

      

       
        private void qpulseReport_Click(object sender, EventArgs e)
        {
            if (recordViewGrid.SelectedRows.Count == 0)
            {

                MessageBox.Show("Please select a record!");
            }
            else
            {
                //MessageBox.Show("Sorry, this feature is not active yet");
                DataGridViewRow selectedRow = recordViewGrid.SelectedRows[0];
                string schemeLogID = selectedRow.Cells[0].Value.ToString();
                EQA_Databasev1._0.Classes.QPulseReport.createQpulse(schemeLogID);
               

            }

        }


        private void recordView_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getQuarterlyReview_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, this feature is not active yet");
        }

        private void getYearlyReview_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, this feature is not active yet");
        }

       

        

    }
}
