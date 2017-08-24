using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Novacode;
using HtmlAgilityPack;



namespace EQA_Databasev1._0.Classes
{
    class QPulse_report
    {

        public static bool GenerateQPulseReport(string filepath)
        {

            try
            {
                DocX template;
                template = DocX.Load(@"N:\GEN\Shared\Sheffield Diagnostic Genetics Service\Bioinformatics\EQA-Master\QPulse Report");

                Table report = template.Tables[0];

                //if number of rows in query is greater than 1 it means there is more than one sample comment, for the second row put the 
                //sample comment info from subsequent rows in samplecomment2 and samplecomment3 of the report. 





            }

            catch
            {

            }

            return report;
        }

        
    }
}
