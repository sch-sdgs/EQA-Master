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
    public partial class Add_Scheme_Comment : Form
    {
        EQAMWeb WebMethods = new EQAMWeb();
        public Add_Scheme_Comment()
        {
            InitializeComponent();
            WebMethods.Credentials = System.Net.CredentialCache.DefaultCredentials;
        }

        private void addSchComment_click(object sender, EventArgs e)
        {
            string inputSchemeLogID = SchemeLogID.Text;
            string inputSampleComment = SchemeComment.Text;
            string inputCAPAQuery = capaQuery.Text;
         

            if (string.IsNullOrEmpty(inputSchemeLogID) ||
                string.IsNullOrEmpty(inputSampleComment) ||
                string.IsNullOrEmpty(inputCAPAQuery))
            {
                MessageBox.Show("Please enter required fields!");
                return;
            }
            else
            {
                WebMethods.DbAddSchemeComment(inputSchemeLogID, inputSampleComment, inputCAPAQuery);
                MessageBox.Show("Scheme comment has been added!");
                SchemeComment.Text = "";
                capaQuery.SelectedIndex = -1;
            }
        }

        private void close_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
