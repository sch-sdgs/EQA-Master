using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EQA_Databasev1._0.Forms
{
    public partial class ViewComments : Form
    {
        EQAMWeb WebMethods = new EQAMWeb();
        public ViewComments()
        {
            InitializeComponent();
            WebMethods.Credentials = System.Net.CredentialCache.DefaultCredentials;
            fillSchemeComments();
            fillSampleComments();
        }

        //public void fillSchemeComments()

        //{
        //    string inputSchemeLogID = schemeLogID.Text;
           
        //    DataTable viewSchemeComment = new DataTable();
        //    viewSchemeComment.TableName = "SchemeComment";
        //    viewSchemeComment = WebMethods.DbViewSchemeComments(inputSchemeLogID, viewSchemeComment);

        //    schemeComment_bind.DataSource = viewSchemeComment;
        //    schemeCommentGrid.DataSource = schemeComment_bind; 
        //}

        public void fillSchemeComments()
        {
            string inputSchemeLogID = schemeLogID.Text;

            DataTable viewSchemeComment = new DataTable();
            viewSchemeComment.TableName = "SchemeComment";
            viewSchemeComment = WebMethods.DbViewSchemeComments(inputSchemeLogID, viewSchemeComment);

            schemeComment_bind.DataSource = viewSchemeComment;
            schemeCommentGrid.DataSource = schemeComment_bind;
        }

        public void fillSampleComments()
       {
           string inputSchemeLogID = schemeLogID.Text;

           DataTable viewSampleComment = new DataTable();
           viewSampleComment.TableName = "SchemeComment";
           viewSampleComment = WebMethods.DbViewSampleComments(inputSchemeLogID, viewSampleComment);

           sampleComment_bind.DataSource = viewSampleComment;
           sampleCommentsGrid.DataSource = sampleComment_bind; 

       }

        private void closeComments_click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}


