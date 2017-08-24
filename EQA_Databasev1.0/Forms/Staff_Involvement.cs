using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EQA_Databasev1._0
{
    public partial class Staff_Involvement : Form
    {
       StarLimsWeb StarlimsWebMethods = new StarLimsWeb();
    
        public Staff_Involvement()
        {
            InitializeComponent();
            //fill_viewSampleLog();
            //fill_viewReportingLog();
        }

        private void fill_viewSampleLog()
        {
            string folderNo = getSRefText.Text;
            DataTable sampleTable = new DataTable();
            sampleTable.TableName = "SampleUsers";
            sampleTable = StarlimsWebMethods.GetSampleUsers(folderNo);
            samplesBindingSource.DataSource = sampleTable;
            viewSampleLog.DataSource = samplesBindingSource;

        }

        private void fill_viewReportingLog()
        {
            string folderNo = getSRefText.Text;
            DataTable reportsTable = new DataTable();
            reportsTable.TableName = "ReportingUsers";
            reportsTable = StarlimsWebMethods.GetReportingUsers(folderNo);
            reportingBindingSource.DataSource = reportsTable;
            viewReportingLog.DataSource = reportingBindingSource;

        }

        private void sampleLog_click(object sender, EventArgs e)
        {
            fill_viewSampleLog();
        }

        private void rptLog_click(object sender, EventArgs e)
        {
            fill_viewReportingLog();
        }

        
       
    }
}


//@folderNo is what the commands will be filtered by - S number 





