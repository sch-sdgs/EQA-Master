using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Novacode;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Xml;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace EQA_Databasev1._0.Classes
{
    class QPulseReport
    {


        public static bool createQpulse(string schemeLogID)
        {
            EQAMWeb WebMethods = new EQAMWeb();
            try
            {


                DataTable results = new DataTable();

                results = WebMethods.QpulseReport(schemeLogID, results);
                results.Columns["SampleReceiptDate"].ColumnName = "startDate";
                results.Columns["SubmissionDeadline"].ColumnName = "submissionDeadline";
                results.Columns["SubmissionDate"].ColumnName = "submissionDate";
                results.Columns["EQABodyName"].ColumnName = "eqaBody";
                results.Columns["SchemeName"].ColumnName = "eqaScheme";
                results.Columns["HoSName"].ColumnName = "eqaLead";
                results.Columns["ResultScore"].ColumnName = "resultScore";
                results.Columns["ResultStatus"].ColumnName = "resultStatus";
                results.Columns["Scheme_Comment"].ColumnName = "schemeComment";
                results.Columns["CAPAQuery"].ColumnName = "schemeCAPA";
               //results.Columns["SampleStarlimsRef"].ColumnName = "SNumber";
                //results.Columns["s_comment"].ColumnName = "sampleComment";
                //results.Columns["CAPAQuery"].ColumnName = "sampleCAPA";


                string start = results.Rows[0]["startDate"].ToString();
                string subDeadline = results.Rows[0]["submissionDeadline"].ToString();
                string subDate = results.Rows[0]["submissionDate"].ToString();
                string body = results.Rows[0]["eqaBody"].ToString();
                string scheme = results.Rows[0]["eqaScheme"].ToString();
                string eqaLead = results.Rows[0]["eqaLead"].ToString();
                string score = results.Rows[0]["resultScore"].ToString();
                string status = results.Rows[0]["resultStatus"].ToString();
                string schemeComment = results.Rows[0]["schemeComment"].ToString();
                string capa = results.Rows[0]["schemeCAPA"].ToString();

                using (DocX report = DocX.Load(@"N:\GEN\Shared\Sheffield Diagnostic Genetics Service\Bioinformatics\EQA-Master\QPulse_Report"))
                {

                    Table table = report.Tables[0];
                    table.Rows[1].Cells[1].Paragraphs.First().Append(start);
                    table.Rows[2].Cells[1].Paragraphs.First().Append(subDeadline);








                }
                //DocX report;
                //report = DocX.Load(@"N:\GEN\Shared\Sheffield Diagnostic Genetics Service\Bioinformatics\EQA-Master\QPulse_Report");


                //Table qPulse = report.Tables[0];


                return true;
                    }
                    catch
                    {
                        return false;
                    }

                }



            }
        }
    


