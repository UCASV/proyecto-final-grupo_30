using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using PROYECTO_BD_POO_FINAL.Controller;
using PROYECTO_BD_POO_FINAL.ProjectContext;

namespace PROYECTO_BD_POO_FINAL.View
{
    public partial class frmCreateAppointment : Form
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

        private Management aManagement { get; set; }
        public frmCreateAppointment(Management aManagement)
        {
            InitializeComponent();
            this.aManagement = aManagement;
        }

        private void frmDateFollowUp_Load(object sender, EventArgs e)
        {
            var db = new ProjectContext.PROJECTContext();

            var institutionList = db.Institutions
                .ToList();

            // Loading Institution Data in Combo Box
            cmbInstitution.DataSource = institutionList;
            cmbInstitution.DisplayMember = "Institution1";
            cmbInstitution.ValueMember = "IdInstitution";

            tabControl1.ItemSize = new Size(0, 1);
        }

        private void btnEnterData_Click(object sender, EventArgs e)
        {
            bool verify = txtDUI.Text != null &&
                          txtFullName.Text != null &&
                          txtAddress.Text != null &&
                          txtCellphoneNumber.Text != null;
            if (verify)
            {
                this.dui = txtDUI.Text;
                this.fullName = txtFullName.Text;
                this.address = txtAddress.Text;
                this.cellphoneNumber = txtCellphoneNumber.Text;
                this.email = txtEmail.Text;
                Institution refInstitution = (Institution) cmbInstitution.SelectedItem;
                bool disability = false;

                if (rbYes.Checked)
                    disability = true;
                if (rbNo.Checked)
                    disability = false;

                var db = new ProjectContext.PROJECTContext();

                Institution idb = db.Set<Institution>()
                    .SingleOrDefault(i => i.IdInstitution == refInstitution.IdInstitution);

                var registerCitizen = RegisterCitizen.Save(dui, fullName, address, cellphoneNumber, email, refInstitution, disability);

                var citizenList = db.Citizens
                    .Where(c => c.Dui == dui)
                    .ToList();

                aCitizen = citizenList[0];

                var groupList = db.Institutions
                    .Where(i => i.IdInstitution.Equals(aCitizen.IdInstitution))
                    .ToList();

                displayFullName = aCitizen.CitizenName;

                if (registerCitizen)
                {
                    MessageBox.Show("Ciudadano Registrado Exitosamente", "Vacuna COVID-19",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Generating a Vaccination Place for an Appointment
                    var vaccinationPlaceList = db.VaccinationPlaces
                        .ToList();

                    var count = vaccinationPlaceList.Count();

                    var aRandom = new Random();

                    var randomVaccinationPlace = aRandom.Next(1, count);

                    // Generating a DateTime for an Appointment
                    dateTime = DateTime.Now;

                    // Generating Random hour an minute
                    var randomHour = aRandom.Next(7, 16);
                    var randomMinute = aRandom.Next(0, 59);

                    var ts = new TimeSpan(randomHour, randomMinute, 0);

                    dateTime = dateTime.AddDays(7);
                    dateTime = dateTime.Date + ts;

                    var anAppointment = new Appointment(dateTime, aManagement.IdEmployee, randomVaccinationPlace,
                        aCitizen.IdCitizen);

                    db.Add(anAppointment);
                    db.SaveChanges();

                    CheckBox[] checkBoxes = new CheckBox[] { cbLungs, cbHeart, cbDiabetes, cbObesity, cbSID, cbLiver };

                    for (int i = 1; i <= checkBoxes.Length; i++)
                    {
                        if (checkBoxes[i - 1].Checked)
                            RegisterDisease.Add(aCitizen.IdCitizen, i);
                    }

                    var resultVaccionation = vaccinationPlaceList
                        .Where(v => v.IdVaccinationPlace == randomVaccinationPlace)
                        .ToList();

                    displayGroup = groupList[0].Institution1;
                    displayDate = dateTime.ToShortDateString();
                    displayTime = dateTime.ToString("HH:mm:ss tt");
                    displayPlace = resultVaccionation[0].VaccinationPlace1;
                    displayAddress = resultVaccionation[0].VaccinationPlaceAddress;
                    
                }
                else
                {
                    MessageBox.Show("Ya existe un ciudadano registrado con ese DUI o número de teléfono.", "Vacuna COVID-19",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    var appointmentList = db.Appointments
                        .Where(c => c.IdCitizen == aCitizen.IdCitizen)
                        .ToList();

                    var vaccinationPlaces = db.VaccinationPlaces
                        .Where(p => p.IdVaccinationPlace == appointmentList[0].IdVaccinationPlace)
                        .ToList();

                    if (appointmentList[0].DateTimeAppointment2 is null)
                    {
                        displayDate = (Convert.ToDateTime((appointmentList[0].DateTimeAppointment1).ToString())).ToShortDateString();
                        displayTime = (Convert.ToDateTime((appointmentList[0].DateTimeAppointment1).ToString())).ToString("HH:mm:ss tt");

                    }
                    else
                    {
                        displayDate = (Convert.ToDateTime((appointmentList[0].DateTimeAppointment2).ToString())).ToShortDateString();
                        displayTime = (Convert.ToDateTime((appointmentList[0].DateTimeAppointment2).ToString())).ToString("HH:mm:ss tt");

                    }

                    displayGroup = groupList[0].Institution1;
                    displayFullName = aCitizen.CitizenName;
                    displayPlace = vaccinationPlaces[0].VaccinationPlace1;
                    displayAddress = vaccinationPlaces[0].VaccinationPlaceAddress;

                }

                lblPriorityGroupData.Text = displayGroup;
                lblName.Text = aCitizen.CitizenName;
                lblDUI.Text = aCitizen.Dui;
                lblDateData.Text = displayDate;
                lblHourData.Text = displayTime;
                lblPlaceData.Text = displayPlace;
                lblAddressData.Text = displayAddress;

                tabControl1.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("Los campos requeridos no han sido llenados", "Vacuna COVID-19",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            CreatePdf.Save("1", this.fullName, this.dui, this.displayPlace, this.displayDate, this.displayTime, this.displayAddress);
            MessageBox.Show("PDF Exportado con Éxito", "Vacuna COVID-19",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
