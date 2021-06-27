using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_BD_POO_FINAL.View
{
    public partial class frmUserConsent : Form
    {
        private string AgreementText = "Help protect your website and its users with clear and fair website terms and conditions. These terms and conditions for a website set out key issues such as acceptable use, privacy, cookies, registration and passwords, intellectual property, links to other sites, termination and disclaimers of responsibility. Terms and conditions are used and necessary to protect a website owner from liability of a user relying on the information or the goods provided from the site then suffering a loss.\n \n Making your own terms and conditions for your website is hard, not impossible, to do. It can take a few hours to few days for a person with no legal background to make.But worry no more; we are here to help you out.\n \nAll you need to do is fill up the blank spaces and then you will receive an email with your personalized terms and conditions.";
        public frmUserConsent()
        {
            InitializeComponent();
            richTextBox1.Text = AgreementText;
        }
    }
}
