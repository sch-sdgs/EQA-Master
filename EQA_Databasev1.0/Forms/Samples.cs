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
    public partial class Samples : Form
    { 
        EQAMWeb WebMethods = new EQAMWeb();
        public Samples()
        {
            InitializeComponent();
            WebMethods.Credentials = System.Net.CredentialCache.DefaultCredentials;
        }

        private void addSampleBtn_Click(object sender, EventArgs e)
        {
            string inputSchemeLogID = samplesSchemeIDTBox.Text;
            string inputSampleType = sampleTypeTextBox.Text;
            string inputStarLims = starLimsRefTextBox.Text;

            if (string.IsNullOrEmpty(inputSchemeLogID) ||
                string.IsNullOrEmpty(inputSampleType))
            {
                MessageBox.Show("Please enter all required fields!");
                return;
            }
            else
            {
                
                WebMethods.DbAddSchemeSamples(inputSchemeLogID, inputSampleType, inputStarLims);

                MessageBox.Show("Sample has been added ");
                //samplesSchemeIDTBox.Text = String.Empty;
                sampleTypeTextBox.Text = String.Empty;
                starLimsRefTextBox.Text = String.Empty;
            }
        }

       
        private void samplesClose_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
      }
  }




 
