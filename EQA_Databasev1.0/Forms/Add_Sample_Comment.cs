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

namespace EQA_Databasev1._0.Forms
{
    public partial class Add_Sample_Comment : Form
    {
        EQAMWeb WebMethods = new EQAMWeb();
        //string inputID = "";

        public Add_Sample_Comment()
        {
            InitializeComponent();
            WebMethods.Credentials = System.Net.CredentialCache.DefaultCredentials;
            //SampleDropDownFill();     
                        
        }

        
        private void sampleDropDown_click(object sender, EventArgs e)
        {
            string inputID = SchemeLogID.Text;
          

            DataTable dtSample = new DataTable();
            dtSample.TableName = "SampleDropDown";


            dtSample = WebMethods.DbFillSampleDropdown(inputID, dtSample);
            SampleDropDown.DataSource = dtSample;
            SampleDropDown.DisplayMember = "SampleStarlimsRef";
            SampleDropDown.ValueMember = "SampleID";
            SampleDropDown.SelectedIndex = -1;

        }
        
        //public void SampleDropDownFill()
        //{

           
        //   }


        private void addComment_click(object sender, EventArgs e)
        {

            string inputSNumber = SampleDropDown.Text;
            string inputSampleComment = SampleComment.Text;
            string inputCAPAQuery = capaQuery.Text;

            if (string.IsNullOrEmpty(inputSNumber) ||
                string.IsNullOrEmpty(inputSNumber) ||
                string.IsNullOrEmpty(inputCAPAQuery))
            {
                MessageBox.Show("Please enter required fields!");
                return;
            }
            else
            {
                WebMethods.DbAddSampleComment(inputSNumber, inputSampleComment, inputCAPAQuery);
                MessageBox.Show("Sample comment has been added!");
                SampleDropDown.SelectedIndex = -1;
                SampleComment.Text = "";
                capaQuery.SelectedIndex = -1;

            }
        }

        private void close_click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        

        

        
       




    }
}
