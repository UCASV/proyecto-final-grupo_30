using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_BD_POO_FINAL.ProjectContext;

namespace PROYECTO_BD_POO_FINAL.View
{
    public partial class frmProcessType : Form
    {
        private Management aManagement { get; set; }
        public frmProcessType(Management aManagement)
        {
            InitializeComponent();
            this.aManagement = aManagement;
        }

        private void btnAppointmentTracking_Click(object sender, EventArgs e)
        {
            frmLoading loadingScreen = new frmLoading(3000, "Abriendo seguimiento de citas");
            loadingScreen.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCreateAppointment window = new frmCreateAppointment(aManagement);
            window.ShowDialog();
        }
    }
}
