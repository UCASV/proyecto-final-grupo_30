using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_BD_POO_FINAL.ProjectContext;

namespace PROYECTO_BD_POO_FINAL.View
{
    public partial class frmSideEffect : Form
    {
        public frmSideEffect()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            nudBlush.Maximum = 30;
            nudBlush.Minimum = 0;
        }

        private void btnEnterObervation_Click(object sender, EventArgs e)
        {
            var db = new ProjectContext.PROJECTContext();

            if (cbBlush.Checked)
            {
                //VaccinationxSideEffect vaccinationxSideEffect = new VaccinationxSideEffect()
            }

            if (cbHeadache.Checked)
            {

            }

            if (cbMialgia.Checked)
            {

            }

            if (cbAnafilaxia.Checked)
            {

            }

            if (cbFatigue.Checked)
            {

            }

            if (cbFever.Checked)
            {

            }

            if (cbArtralgia.Checked)
            {

            }
        }
    }
}
