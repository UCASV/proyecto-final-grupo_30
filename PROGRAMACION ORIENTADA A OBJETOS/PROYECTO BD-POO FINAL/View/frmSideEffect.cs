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
        private string dui;
        private string fullName;
        private string address;
        private string cellphoneNumber;
        private string email;
        private string displayDate;
        private string displayTime;
        private string displayPlace;
        private string displayAddress;
        private DateTime dateTime;
        private string displayFullName;
        private string displayGroup;
        private Citizen aCitizen;


        private Vaccination aVaccination { get; set; }
        public frmSideEffect(Vaccination aVaccination)
        {
            InitializeComponent();
            this.aVaccination = aVaccination;
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
                var sideEffect = db.SideEffects
                    .Where(s => s.IdSideEffect.Equals(1))
                    .ToList();

                var minutes = nudBlush.Value;

                Reaction reaction = 
                    new Reaction(sideEffect[0].IdSideEffect, aVaccination.IdVaccination, Convert.ToInt32(minutes));

                db.Add(reaction);
                db.SaveChanges();
            }

            if (cbFatigue.Checked)
            {
                var sideEffect = db.SideEffects
                    .Where(s => s.IdSideEffect.Equals(2))
                    .ToList();

                var minutes = nudFatigue.Value;

                Reaction reaction =
                    new Reaction(sideEffect[0].IdSideEffect, aVaccination.IdVaccination, Convert.ToInt32(minutes));

                db.Add(reaction);
                db.SaveChanges();
            }

            if (cbHeadache.Checked)
            {
                var sideEffect = db.SideEffects
                    .Where(s => s.IdSideEffect.Equals(3))
                    .ToList();

                var minutes = nudHeadache.Value;

                Reaction reaction =
                    new Reaction(sideEffect[0].IdSideEffect, aVaccination.IdVaccination, Convert.ToInt32(minutes));

                db.Add(reaction);
                db.SaveChanges();
            }

            if (cbFever.Checked)
            {
                var sideEffect = db.SideEffects
                    .Where(s => s.IdSideEffect.Equals(4))
                    .ToList();

                var minutes = nudFever.Value;

                Reaction reaction =
                    new Reaction(sideEffect[0].IdSideEffect, aVaccination.IdVaccination, Convert.ToInt32(minutes));

                db.Add(reaction);
                db.SaveChanges();
            }

            if (cbMialgia.Checked)
            {
                var sideEffect = db.SideEffects
                    .Where(s => s.IdSideEffect.Equals(5))
                    .ToList();

                var minutes = nudMialgia.Value;

                Reaction reaction =
                    new Reaction(sideEffect[0].IdSideEffect, aVaccination.IdVaccination, Convert.ToInt32(minutes));

                db.Add(reaction);
                db.SaveChanges();
            }

            if (cbArtralgia.Checked)
            {
                var sideEffect = db.SideEffects
                    .Where(s => s.IdSideEffect.Equals(6))
                    .ToList();

                var minutes = nudAltralgia.Value;

                Reaction reaction =
                    new Reaction(sideEffect[0].IdSideEffect, aVaccination.IdVaccination, Convert.ToInt32(minutes));

                db.Add(reaction);
                db.SaveChanges();
            }

            if (cbAnafilaxia.Checked)
            {
                var sideEffect = db.SideEffects
                    .Where(s => s.IdSideEffect.Equals(7))
                    .ToList();

                var minutes = nudAnafilaxia.Value;

                Reaction reaction =
                    new Reaction(sideEffect[0].IdSideEffect, aVaccination.IdVaccination, Convert.ToInt32(minutes));

                db.Add(reaction);
                db.SaveChanges();
            }

            var citizenList = db.Citizens
                .Where(c => c.IdCitizen.Equals(aVaccination.IdCitizen))
                .ToList();

            var result = db.Appointments
                .Where(a => a.IdCitizen.Equals(citizenList[0].IdCitizen))
                .ToList();

            Appointment appointment = db.Appointments.FirstOrDefault(a => a.IdCitizen.Equals(citizenList[0].IdCitizen));
            aCitizen = citizenList[0];

            var aRandom = new Random();

            var randomHour = aRandom.Next(7, 16);
            var randomMinute = aRandom.Next(0, 59);

            var ts = new TimeSpan(randomHour, randomMinute, 0);

            DateTime dateTime = Convert.ToDateTime(appointment.DateTimeAppointment1);

            dateTime = dateTime.AddDays(56);
            dateTime = dateTime.Date + ts;

            appointment.DateTimeAppointment2 = dateTime;

            var groupList = db.Institutions
            .Where(i => i.IdInstitution.Equals(aCitizen.IdInstitution))
            .ToList();

            db.Update(appointment);
            db.SaveChanges();

            var vaccinationPlaces = db.VaccinationPlaces
            .Where(p => p.IdVaccinationPlace == result[0].IdVaccinationPlace)
            .ToList();

            displayDate = (Convert.ToDateTime((result[0].DateTimeAppointment2).ToString())).ToShortDateString();
            displayTime = (Convert.ToDateTime((result[0].DateTimeAppointment2).ToString())).ToString("HH:mm:ss tt");
            displayGroup = groupList[0].Institution1;
            displayFullName = aCitizen.CitizenName;
            displayPlace = vaccinationPlaces[0].VaccinationPlace1;
            displayAddress = vaccinationPlaces[0].VaccinationPlaceAddress;
            tabControl1.SelectedIndex = 1;

            lblPriorityGroupData.Text = displayGroup;
            lblName.Text = aCitizen.CitizenName;
            lblDUI.Text = aCitizen.Dui;
            lblDateData.Text = displayDate;
            lblHourData.Text = displayTime;
            lblPlaceData.Text = displayPlace;
            lblAddressData.Text = displayAddress;
            
        }

        private void frmSideEffect_Load(object sender, EventArgs e)
        {
            tabControl1.ItemSize = new Size(0, 1);
        }
    }
}
