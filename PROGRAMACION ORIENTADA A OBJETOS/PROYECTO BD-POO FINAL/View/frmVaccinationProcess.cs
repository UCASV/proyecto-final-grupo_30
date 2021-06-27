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
    public partial class frmVaccinationProcess : Form
    {

        public frmVaccinationProcess()
        {
            InitializeComponent();
        }

        private void frmVaccinationProcess_Shown(object sender, EventArgs e)
        {
            var db = new ProjectContext.PROJECTContext();

            var query = from a in db.Appointments
                join c in db.Citizens on a.IdCitizen equals c.IdCitizen
                join v in db.VaccinationPlaces on a.IdVaccinationPlace equals v.IdVaccinationPlace
                let DUI = c.Dui 
                let Nombre = c.CitizenName
                let Dosis_1 = a.DateTimeAppointment1
                let Dosis_2 = a.DateTimeAppointment2
                let Lugar_Vacunacion = v.VaccinationPlace1
                select new
                {
                    DUI,
                    Nombre,
                    Dosis_1,
                    Dosis_2,
                    Lugar_Vacunacion
                };

            dataGridAppointments.DataSource = query.ToList();
        }

        private void btnProceedToStep2_Click(object sender, EventArgs e)
        {
            using (frmUserConsent formConsent = new frmUserConsent())
            {
                DialogResult resultado = formConsent.ShowDialog();

                if(resultado == DialogResult.OK)
                {
                    tabControl1.SelectTab(1);
                }
                else
                {
                    MessageBox.Show("El usuario tiene que dar su consentimiento para poder vacunarse", "Consentimiento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
