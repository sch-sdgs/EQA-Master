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
    public partial class Add_Staff_Lead : Form
    {
        EQAMWeb WebMethods = new EQAMWeb();
        public Add_Staff_Lead()
        {
            InitializeComponent();
            WebMethods.Credentials = System.Net.CredentialCache.DefaultCredentials;
           // fillHoSCombo();
            coverNameFill();
            
        }
        //private void fillHoSCombo()
        //{
        //    string sqlString = "SELECT * from dbo.HoS";
        //    DataTable dtEQA = new DataTable();
        //    dtEQA.TableName = "FillHostable";
        //    dtEQA = WebMethods.GetDataTable(sqlString, dtEQA);

        //    HoSComboBox.DataSource = dtEQA;
        //    HoSComboBox.DisplayMember = "HoSName";
        //    HoSComboBox.ValueMember = "HoSID";

        //}
        public void coverNameFill()//Fill the Cover staff Combobox with HoSNames from HoS table in database
        {

            string sqlString = "SELECT * from dbo.HoS";
            DataTable dtEQA = new DataTable();
            dtEQA.TableName = "HosTable";
            //dtEQA.Rows.InsertAt(dtEQA.NewRow(), 0);

            dtEQA = WebMethods.GetDataTable(sqlString, dtEQA);

            coverStaff_Drop.ValueMember = "HoSname";
            coverStaff_Drop.DisplayMember = "HoSName";
            coverStaff_Drop.DataSource = dtEQA;
            coverStaff_Drop.SelectedIndex = -1;
        }


        private void addNewStaffbtn_Click(object sender, EventArgs e)
        {
            string inputStaffName = staffNameTBox.Text;
            string inputStaffEmail = staffEmailTBox.Text;
            string inputCoverStaff = coverStaff_Drop.Text;

            if (string.IsNullOrEmpty(this.staffNameTBox.Text) || string.IsNullOrEmpty(this.staffEmailTBox.Text)|| string.IsNullOrEmpty(this.coverStaff_Drop.Text))
            {
                MessageBox.Show("Please enter all required fields!");
            }
            else
            {
                WebMethods.DbAddNewStaff(inputStaffName, inputStaffEmail, inputCoverStaff);

                MessageBox.Show("New Staff Lead Added!");
                this.Hide();
            }
        }

        //private void addCoverStaff_Click(object sender, EventArgs e)
        //{

        //    string inputCoverName = coverStaffName.Text;
        //    string inputCoverEmail = coverStaffEmail.Text;
        //    string inputHoSSelected = HoSComboBox.Text;


        //    if (string.IsNullOrEmpty(inputCoverName) || string.IsNullOrEmpty(inputCoverEmail) || string.IsNullOrEmpty(inputHoSSelected))
        //    {
        //        MessageBox.Show("Please enter all required fields!");
        //    }

        //    else
        //    {
        //        WebMethods.DbAddNewCoverStaff(inputCoverName, inputCoverEmail, inputHoSSelected);
        //        MessageBox.Show("New Cover Staff Added");
        //        this.Hide();
        //    }
                
        //    }

        private void addStaffClose_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editStaff_Click(object sender, EventArgs e)
        {
            Edit_Staff_Details addStaff = new Edit_Staff_Details();
            addStaff.Show();
                addStaff.Activate();
        }

        private void Add_Staff_Lead_Load(object sender, EventArgs e)
        {

        }
        
     }
}
              
         
     

