using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EQA_Databasev1._0
{
    static class Program
    {
        /// 
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
     
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login ());
            //Application.Run(new StartUp_Form());
            //Application.Run(new Log_New_Scheme());
            //Application.Run(new Update_Record());
            //Application.Run(new Add_New_Scheme());
            //Application.Run(new Scheme_Records_View());
            //Application.Run(new Add_Feedback());
            //Application.Run(new Add_Scheme_Outcome());
            //Application.Run(new Add_Staff_Lead());
            //Application.Run(new Samples());
            //Application.Run(new View_Feedback());
            //Application.Run(new View_Samples());
            //Application.Run(new Add_Appeal());
        
        }
    }
}
