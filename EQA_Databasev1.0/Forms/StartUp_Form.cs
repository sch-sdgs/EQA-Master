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
    public partial class StartUp_Form : Form
    {
        public StartUp_Form()
        {
            InitializeComponent();
            
        }

        private void LogNewSchemeOption_click(object sender, EventArgs e)
        {
            Log_New_Scheme schLog = new Log_New_Scheme();
            schLog.ShowDialog();
            schLog.Activate();
        }

        private void updateSchemeOption_click(object sender, EventArgs e)
        {
            Update_Record updRec = new Update_Record();
            updRec.ShowDialog();
            updRec.Activate();


        }

        private void addNewSchemeOption_click(object sender, EventArgs e)
        {
            Add_New_Scheme addSch = new Add_New_Scheme();
            addSch.ShowDialog();
            addSch.Activate();
        }

        private void addStaffLead_Click(object sender, EventArgs e)
        {
            Add_Staff_Lead editStaff = new Add_Staff_Lead();
            editStaff.ShowDialog();
            editStaff.Activate();
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
            //Login_Page login = new Login_Page();
            //login.Show();
        }

        private void viewRecordsBtn_Click(object sender, EventArgs e)
        {
            Scheme_Records_View viewRecord = new Scheme_Records_View();
            viewRecord.ShowDialog();
            viewRecord.Activate();
        }

        private void updateBodyOption_Click(object sender, EventArgs e)
        {
           Add_New_Body addBody = new Add_New_Body();
            addBody.ShowDialog();
            addBody.Activate();
        }

        private void StartUp_Form_Load(object sender, EventArgs e)
        {

        }

       

    }
}
 