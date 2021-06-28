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
    public partial class frmSideEffect : Form
    {
        public frmSideEffect()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 30;
            numericUpDown1.Minimum = 0;
        }

        private void btnEnterObervation_Click(object sender, EventArgs e)
        {
            var db = new ProjectContext.PROJECTContext();
            

            DataSet ds = new DataSet();

            DataRow row = ds.Tables[0].NewRow();
        
            CheckBox[] checkBoxes = new CheckBox[] { cbBlush, cbFatigue, cbHeadache, cbFever, cbMialgia, cbArtralgia, cbAnafilaxia, cbNone};

            for (int i = 1; i <= checkBoxes.Length; i++)
            {

                row[1] = i;
                ds.Tables[0].Rows.Add(row);
            }

            
        }
    }
}
