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
    public partial class Add_Qpulse : Form
    {
        EQAMWeb WebMethods = new EQAMWeb();

        public Add_Qpulse()
        {
            InitializeComponent();
        }

        private void addAudit_click(object sender, EventArgs e)
        {
             
            string inputQPulseNum = addQPulseBox.Text;
            string inputschemeLogID = schemeLogIDBox.Text;
            try
            {
                if (string.IsNullOrEmpty(inputQPulseNum))
                {

                    MessageBox.Show("You have not entered a Q-Pulse number!");
                }
                else
                {
                WebMethods.DbAddQpulseAudit(inputQPulseNum, inputschemeLogID);
                MessageBox.Show("Qpulse detail added to record!");
                this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Error, could not enter QPulse details. Please contact system administrator");
            }

        }
    }
}
