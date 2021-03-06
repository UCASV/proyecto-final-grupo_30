using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_BD_POO_FINAL.ProjectContext;

namespace PROYECTO_BD_POO_FINAL.View
{
    public partial class frmVaccinationProcess : Form
    {
        private string dgvDui;

        public frmVaccinationProcess()
        {
            InitializeComponent();           
        }

        private void btnProceedToStep2_Click(object sender, EventArgs e)
        {
            using (frmUserConsent formConsent = new frmUserConsent())
            {
                DialogResult resultado = formConsent.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    tabControl1.SelectTab("tabPage2");
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
                btnProceedToStep2.Enabled = true;

                var query2 = from a in db.Appointments
                             join c in db.Citizens.Where(a => a.Dui == txtDUI.Text) on a.IdCitizen equals c.IdCitizen
                             join vp in db.VaccinationPlaces on a.IdVaccinationPlace equals vp.IdVaccinationPlace
                             from vac in db.Vaccinations.DefaultIfEmpty().Where(v => v.IdCitizen.Equals(c.IdCitizen))
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

                dataGridAppointments.DataSource = null;
                dataGridAppointments.DataSource = query2.Take(1).ToList();

                foreach (var user in query2)
                {
                    lblName.Text = user.Nombre;
                    lblDUI.Text = user.DUI;
                    lblPriorityGroupData.Text = "*********";
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            frmVaccinationProcess_Load(sender, e);
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

            var appointment = db.Set<Appointment>()
                .SingleOrDefault(m => m.IdCitizen == user.IdCitizen);

            var vaccinationExist = db.Vaccinations
                .Where(v => v.IdCitizen.Equals(user.IdCitizen))
                .ToList();

            if (user.Waiting == false)
            {
                if (vaccinationExist.Count == 0)
                {
                    DateTime datetime = DateTime.Now;

                    Vaccination vaccination = new Vaccination(datetime, appointment.IdCitizen, appointment.IdVaccinationPlace);

                    db.Add(vaccination);
                    db.SaveChanges();

                    Citizen citizen = db.Citizens.FirstOrDefault(c => c.IdCitizen.Equals(appointment.IdCitizen));

                    citizen.Waiting = true;

                    db.Update(citizen);
                    db.SaveChanges();
                }
                else if (vaccinationExist.Count != 0 && vaccinationExist[0].DateTimeVaccine2 == null)
                {
                    Vaccination vaccination = db.Vaccinations.FirstOrDefault(v => v.IdCitizen.Equals(user.IdCitizen));
                    DateTime dateTime = DateTime.Now;

                    vaccination.DateTimeWait2 = dateTime;

                    db.Update(vaccination);
                    db.SaveChanges();

                    Citizen citizen = db.Citizens.FirstOrDefault(c => c.IdCitizen.Equals(appointment.IdCitizen));

                    citizen.Waiting = true;

                    db.Update(citizen);
                    db.SaveChanges();
                }
                else if (vaccinationExist.Count != 0 && vaccinationExist[0].DateTimeWait1 != null && vaccinationExist[0].DateTimeWait2 != null)
                {
                    MessageBox.Show("El usuario ya ha recibido sus dos dosis", "Vacunación Covid",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Citizen citizenn = db.Citizens.FirstOrDefault(c => c.IdCitizen.Equals(appointment.IdCitizen));

                    citizenn.Waiting = false;

                    db.Update(citizenn);
                    db.SaveChanges();
                }
                showWaitingList();
            } 
            else
            {
                showWaitingList();
            }
            tabControl1.SelectTab("tabPage3");
        }

        private void showWaitingList()
        {
            var db = new ProjectContext.PROJECTContext();
            var query = from a in db.Appointments
                        join c in db.Citizens.Where(c => c.Waiting == true) on a.IdCitizen equals c.IdCitizen
                        join vac in db.Vaccinations on c.IdCitizen equals vac.IdCitizen
                        let DUI = c.Dui
                        let Nombre = c.CitizenName
                        let Inicio_Tiempo_Espera = vac.DateTimeVaccine1.HasValue ? vac.DateTimeWait2 : vac.DateTimeWait1
                        let Numero_Dosis = vac.DateTimeVaccine1.HasValue ? "Segunda dosis" : "Primera dosis"
                        group c by c.IdCitizen into ci
                        select new
                        {
                            DUI = ci.Max(x => x.Dui),
                            Nombre = ci.Max(y => y.CitizenName)
                            //Inicio_Tiempo_Espera,
                            //Numero_Dosis
                        };

            dgvPeopleReadyForVaccine.DataSource = null; 
            dgvPeopleReadyForVaccine.DataSource = query.ToList();
        }

        private void frmVaccinationProcess_Load(object sender, EventArgs e)
        {
            btnProceedToStep2.Enabled = false;
            tabControl1.ItemSize = new Size(0, 1);

            var db = new ProjectContext.PROJECTContext();

            var query = from a in db.Appointments
                        join c in db.Citizens on a.IdCitizen equals c.IdCitizen
                        join v in db.VaccinationPlaces on a.IdVaccinationPlace equals v.IdVaccinationPlace
                        let DUI = c.Dui
                        let Nombre = c.CitizenName
                        let Cita_1 = a.DateTimeAppointment1
                        let Cita_2 = a.DateTimeAppointment2
                        let Lugar_Vacunacion = v.VaccinationPlace1
                        select new
                        {
                            DUI,
                            Nombre,
                            Cita_1,
                            Cita_2,
                            Lugar_Vacunacion
                        };

            dataGridAppointments.DataSource = null;
            dataGridAppointments.DataSource = query.ToList();
        }
        private void dgvPeopleReadyForVaccine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvPeopleReadyForVaccine.Rows[index];
            dgvDui = selectedRow.Cells[0].Value.ToString();

            var db = new ProjectContext.PROJECTContext();

            var citizen = db.Citizens
                .Where(c => c.Dui.Equals(dgvDui))
                .ToList();

            var vaccinationList = db.Vaccinations
                .Where(v => v.IdCitizen.Equals(citizen[0].IdCitizen))
                .ToList();

            DateTime dateTimeWait = (Convert.ToDateTime(vaccinationList[0].DateTimeWait1)); 
            DateTime dateTimeVaccine = DateTime.Now;
            int idCitizen = vaccinationList[0].IdCitizen;
            int vaccinationPlace = vaccinationList[0].IdVaccinationPlace;
            int idVaccination = vaccinationList[0].IdVaccination;

            Vaccination aVaccination = db.Vaccinations.FirstOrDefault(v => v.IdVaccination.Equals(idVaccination));

            if (aVaccination.DateTimeVaccine1 == null)
            {
                MessageBox.Show("El ciudadano ha recibido la primera dosis", "Vacunación Covid",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                aVaccination.DateTimeVaccine1 = dateTimeVaccine;

                db.Update(aVaccination);
                db.SaveChanges();

                Citizen citizen1 = db.Citizens.FirstOrDefault(c => c.IdCitizen.Equals(idCitizen));

                citizen1.Waiting = false;

                db.Update(citizen1);
                db.SaveChanges();

                frmSideEffect window = new frmSideEffect(aVaccination);
                window.ShowDialog();

                showWaitingList();
            }
            else if (aVaccination.DateTimeVaccine1 != null && aVaccination.DateTimeVaccine2 == null)
            {
                MessageBox.Show("El ciudadano ha recibido la segunda dosis", "Vacunación Covid",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                aVaccination.DateTimeVaccine2 = dateTimeVaccine;

                db.Update(aVaccination);
                db.SaveChanges();

                Citizen citizen2 = db.Citizens.FirstOrDefault(c => c.IdCitizen.Equals(idCitizen));

                citizen2.Waiting = false;

                db.Update(citizen2);
                db.SaveChanges();

                frmSideEffect window = new frmSideEffect(aVaccination);
                window.ShowDialog();

                showWaitingList();
            }
            else if (aVaccination.DateTimeVaccine1 != null && aVaccination.DateTimeVaccine2 != null)
            {
                MessageBox.Show("El ciudadano ya ha recibido sus dos dosis, no es posible vacunarlo", "Vacunación Covid",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                Citizen citizen3 = db.Citizens.FirstOrDefault(c => c.IdCitizen.Equals(idCitizen));

                citizen3.Waiting = false;

                db.Update(citizen3);
                db.SaveChanges();

                showWaitingList();
            }           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage1");
        }
    }
}
