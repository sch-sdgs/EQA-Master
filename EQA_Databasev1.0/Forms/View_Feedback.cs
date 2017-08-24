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
    public partial class View_Feedback : Form
    {
        EQAMWeb WebMethods = new EQAMWeb();
        public View_Feedback()
        {
            InitializeComponent();
            WebMethods.Credentials = System.Net.CredentialCache.DefaultCredentials;
            fillFeedback();
        }

        public void fillFeedback()
    {
        string inputSchemeLog = schemeLogIDFeedback.Text;
        DataTable recordsTable = new DataTable();
        recordsTable.TableName = "FeedbackTable";
        recordsTable =  WebMethods.DbViewFeedbackInformation(inputSchemeLog, recordsTable);
        feedbackBindingSource.DataSource = recordsTable;
        feedbackGridView.DataSource = feedbackBindingSource;       
    }
     
        private void feedbackViewClose_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
