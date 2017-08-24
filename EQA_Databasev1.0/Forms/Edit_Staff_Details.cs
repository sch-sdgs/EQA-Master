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
    public partial class Edit_Staff_Details : Form
    {
        EQAMWeb WebMethods = new EQAMWeb();
        public Edit_Staff_Details()
        {
            InitializeComponent();
            WebMethods.Credentials = System.Net.CredentialCache.DefaultCredentials;
            //fillStaffDrop();
            //fillCoverDrop();
        }

        public void fillStaffDrop()
       {
           
           string sqlString = "SELECT * from dbo.HoS";
           DataTable dtEQA = new DataTable();
           dtEQA.TableName = "FillHosTable";
          // dtEQA.Rows.InsertAt(dtEQA.NewRow(), 0);
          dtEQA =  WebMethods.GetDataTable(sqlString, dtEQA);

           staffComboBox.DataSource = dtEQA;
           staffComboBox.DisplayMember = "HoSName";
           staffComboBox.ValueMember = "HoSName";
           staffComboBox.SelectedIndex = -1;
    }
        private void fill_Click(object sender, EventArgs e)
        {
            fillStaffDrop();
        }
        //public void fillCoverDrop()

        //{
        //    string sqlString = "SELECT StaffName from CoverStaff";
        //    DataTable dtEQA = new DataTable();
        //    dtEQA.TableName = "FillCoverTable";
        //    //dtEQA.Rows.InsertAt(dtEQA.NewRow(), 0);
        //    dtEQA = WebMethods.GetDataTable(sqlString, dtEQA);

        //     //bind necessary columns from EqaBody table to combobox DisplayMember and Value
        //      coverComboBox.DataSource = dtEQA;
        //      coverComboBox.DisplayMember = "StaffName";
        //      coverComboBox.ValueMember = "StaffName";
                        
        //}
        //private void fillcover_click(object sender, EventArgs e)
        //{
        //    fillCoverDrop();
        //}

        

        //private void addStaff_Click(object sender, EventArgs e)
        //{
        //    Add_Staff_Lead addStaff = new Add_Staff_Lead();
        //    addStaff.Show();
        //    addStaff.Activate();
        //}

        private void editStaffBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.staffComboBox.Text))
            {

                string inputOldName = staffComboBox.Text;
                string inputNewName = newNameTBox.Text;
                string inputNewEmail = newEmailTBox.Text;


                //Create control so code can only progress if the necessary fields have been filled in. 
                if (string.IsNullOrEmpty(this.staffComboBox.Text) ||
                            string.IsNullOrEmpty(this.newNameTBox.Text) ||
                            string.IsNullOrEmpty(this.newEmailTBox.Text))
                {
                    MessageBox.Show("Please enter both name and email address!");
                    return;
                }
                else
                {
                    WebMethods.DbEditHoSDetails(inputOldName, inputNewName, inputNewEmail);

                    MessageBox.Show("Head of Service has been updated");
                    this.Hide();
                }

            }
        }
        //   if (!string.IsNullOrEmpty(this.coverComboBox.Text) && (string.IsNullOrEmpty(this.staffComboBox.Text)))
        //   {
        //       string inputOldCName = coverComboBox.Text;
        //       string inputNewCName = newEmailTBox.Text;
        //       string inputNewCEmail = newEmailTBox.Text;


        //       //Create control so code can only progress if the necessary fields have been filled in. 
        //       if (string.IsNullOrEmpty(this.coverComboBox.Text) ||
        //                   string.IsNullOrEmpty(this.newNameTBox.Text) ||
        //                   string.IsNullOrEmpty(this.newEmailTBox.Text))
        //       {
        //           MessageBox.Show("Please enter both name and email address!");
        //           return;
        //       }
        //       else
        //       { 
        //       //use new connection
        //           WebMethods.DbEdtiCoverStaffDetails(inputOldCName, inputNewCName, inputNewCEmail);
        //           MessageBox.Show("Staff member has been updated");
        //           this.Hide();
        //       }
        //   }
        //   else if (string.IsNullOrEmpty(this.staffComboBox.Text) && (string.IsNullOrEmpty(this.coverComboBox.Text)))
        //   {
        //       MessageBox.Show("Please chose either Cover Staff or Head of Service to update!");

        //   }

        //}

        
        private void closeWindow_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        

        
    }
}
