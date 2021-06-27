using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmVaccinationProcess : Form
    {

        public frmVaccinationProcess()
        {
            InitializeComponent();
        }

        private void frmVaccinationProcess_Shown(object sender, EventArgs e)
        {
            var db = new ProjectContext.PROJECTContext();
            var appointments = db.Appointments
                .Include(a => a.DateTimeAppointment1)
                .Include(a => a.DateTimeAppointment2)
                .ToList();

            dataGridAppointments.DataSource = null;
            dataGridAppointments.DataSource = appointments;

            //DataTable fillAppointments = new DataTable();
            //SqlDataAdapter dal = new SqlDataAdapter("SELECT CITIZEN.dui, CITIZEN.citizen_name, APPOINTMENT.date_time_appointment_1, APPOINTMENT.date_time_appointment_2, VACCINATION_PLACE.vaccination_place FROM APPOINTMENT, CITIZEN, VACCINATION_PLACE WHERE APPOINTMENT.id_citizen = CITIZEN.id_citizen AND APPOINTMENT.id_vaccination_place = VACCINATION_PLACE.id_vaccination_place");

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
