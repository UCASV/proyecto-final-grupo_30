﻿using Microsoft.Data.SqlClient;
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
                join vp in db.VaccinationPlaces on a.IdVaccinationPlace equals vp.IdVaccinationPlace 
                from vac in db.Vaccinations.DefaultIfEmpty()
                let DUI = c.Dui
                let Nombre = c.CitizenName
                let Cita_1 = a.DateTimeAppointment1
                let Cita_2 = a.DateTimeAppointment2
                let Lugar_Vacunacion = vp.VaccinationPlace1
                let Dosis_1 = vac.DateTimeVaccine1
                let Dosis_2 = vac.DateTimeVaccine2
            select new
                {
                    DUI,
                    Nombre,
                    Cita_1,
                    Cita_2,
                    Lugar_Vacunacion,
                    Dosis_1,
                    Dosis_2
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
                    addToWaitingList();
                }
                else
                {
                    MessageBox.Show("El usuario tiene que dar su consentimiento para poder vacunarse", "Consentimiento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var db = new ProjectContext.PROJECTContext();

            var citizenList = db.Citizens
                .ToList();

            var result = citizenList.Where(
                c => c.Dui.Equals(txtDUI.Text)
            ).ToList();

            if (result.Count == 0)
            {
                MessageBox.Show("No ha sido encontrada una cita que coincida con su número de DUI", "Vacunación Covid",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var query = from a in db.Appointments
                            join c in db.Citizens.Where(a=> a.Dui == txtDUI.Text) on a.IdCitizen equals c.IdCitizen
                            join vp in db.VaccinationPlaces on a.IdVaccinationPlace equals vp.IdVaccinationPlace
                            from vac in db.Vaccinations.DefaultIfEmpty()
                            let DUI = c.Dui
                            let Nombre = c.CitizenName
                            let Cita_1 = a.DateTimeAppointment1
                            let Cita_2 = a.DateTimeAppointment2
                            let Lugar_Vacunacion = vp.VaccinationPlace1
                            let Dosis_1 = vac.DateTimeVaccine1
                            let Dosis_2 = vac.DateTimeVaccine2
                           
                            select new
                            {
                                DUI,
                                Nombre,
                                Cita_1,
                                Cita_2,
                                Lugar_Vacunacion,
                                Dosis_1,
                                Dosis_2
                            };

                dataGridAppointments.DataSource = query.ToList();

                foreach (var user in query)
                {
                    lblName.Text = user.Nombre;
                    lblDUI.Text = user.DUI;
                    lblPriorityGroupData.Text = "*********";
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            frmVaccinationProcess_Shown(sender, e);
            txtDUI.Text = "";
        }

        private void addToWaitingList()
        {
            var db = new ProjectContext.PROJECTContext();
            string time = DateTime.Now.ToString("h:mm:ss tt");
            string date = DateTime.UtcNow.ToString("MM-dd-yyyy");

            var query = from a in db.Appointments
                        join c in db.Citizens.Where(a => a.Dui == txtDUI.Text) on a.IdCitizen equals c.IdCitizen
                        join vp in db.VaccinationPlaces on a.IdVaccinationPlace equals vp.IdVaccinationPlace
                        join i in db.Institutions on c.IdInstitution equals i.IdInstitution
                        from vac in db.Vaccinations.DefaultIfEmpty()
                        let DUI = c.Dui
                        let Nombre = c.CitizenName
                        let Cita_1 = a.DateTimeAppointment1
                        let Cita_2 = a.DateTimeAppointment2
                        let Lugar_Vacunacion = vp.VaccinationPlace1
                        let Dosis_1 = vac.DateTimeVaccine1
                        let Dosis_2 = vac.DateTimeVaccine2
                        let priorityGroup = i.Institution1

                        select new
                        {
                            DUI,
                            Nombre,
                            priorityGroup
                        };

            foreach (var user in query)
            {
                lblName.Text = user.Nombre;
                lblDUI.Text = user.DUI;
                lblPriorityGroupData.Text = user.priorityGroup;
            }

            lblDateData.Text = date;
            lblHourData.Text = time;
        }

        private void btnAddWaitingInfo_Click(object sender, EventArgs e)
        {
            var db = new ProjectContext.PROJECTContext();
            var user = db.Set<Citizen>()
                .SingleOrDefault(m => m.Dui == txtDUI.Text);

            var appointent = db.Set<Appointment>()
                .SingleOrDefault(m => m.IdCitizen == user.IdCitizen);

            string time = DateTime.Now.ToString("h:mm:ss tt");
            string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
            string dateTime = $"{date} {time}";

            Vaccination vaccination = new Vaccination();

            db.Add(vaccination);
            db.SaveChanges();

        }
    }
}
