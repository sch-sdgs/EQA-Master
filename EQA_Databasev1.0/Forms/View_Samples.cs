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
    public partial class View_Samples : Form
    {
        EQAMWeb WebMethods = new EQAMWeb();
        public View_Samples()
        {
            InitializeComponent();
            WebMethods.Credentials = System.Net.CredentialCache.DefaultCredentials;
            fillSampleView();
        
        }

        public void fillSampleView()
        {
            
            string inputSchemeLog = schemeLogIDSamples.Text;
            DataTable recordsTable = new DataTable();
            recordsTable.TableName = "SampleTable";
            recordsTable = WebMethods.DbGetSamples(inputSchemeLog, recordsTable);
            sampleViewBindingSource.DataSource = recordsTable;
            sampleGridView.DataSource = sampleViewBindingSource;

            
            
        }

        private void viewParticipantsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sampleGridView.SelectedRows.Count == 0)
                {

                    MessageBox.Show("Please select a record!");
                }
                else
                {
                    Staff_Involvement staffInvForm = new Staff_Involvement();
                    staffInvForm.Show();
                    staffInvForm.Activate();

                    DataGridViewRow selectedRow = sampleGridView.SelectedRows[0];
                    staffInvForm.getSRefText.Text = selectedRow.Cells[2].Value.ToString();

                }
            }


            catch
            {
                
            }
        }

       

        private void sampleViewClose_click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        

        
    }
}

