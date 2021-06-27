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

                RegisterCitizen.Save(dui, fullName, address, cellphoneNumber, email, refInstitution, disability);

                MessageBox.Show("Ciudadano Registrado Exitosamente", "Vacunacion Covid",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                var citizenList = db.Citizens
                    .Where(c => c.Dui == dui)
                    .ToList();

                // Generating a Vaccination Place for an Appointment
                var vaccinationPlaceList = db.VaccinationPlaces
                    .ToList();

                var count = vaccinationPlaceList.Count();

                Random aRandom = new Random();

                int randomVaccinationPlace = aRandom.Next(1, count);

                // Generating a DateTime for an Appointment
                DateTime dateTime = DateTime.Now;

                // Generating Random hour an minute
                int randomHour = aRandom.Next(7, 16);
                int randomMinute = aRandom.Next(0, 59);

                TimeSpan ts = new TimeSpan(randomHour, randomMinute, 0);

                dateTime = dateTime.AddDays(7);
                dateTime = dateTime.Date + ts;

                Appointment anAppointment = new Appointment(dateTime, aManagement.IdEmployee, randomVaccinationPlace,
                    citizenList[0].IdCitizen);

                db.Add(anAppointment);
                db.SaveChanges();

                CheckBox[] checkBoxes = new CheckBox[]{ cbLungs, cbHeart, cbDiabetes, cbObesity, cbSID, cbLiver };

                for(int i = 1; i <= checkBoxes.Length; i++)
                {
                    if(checkBoxes[i-1].Checked)
                        RegisterDisease.Add(citizenList[0].IdCitizen, i);
                }
                tabControl1.SelectedIndex = 1;

                var resultVaccionation = vaccinationPlaceList
                    .Where(v => v.IdVaccinationPlace == randomVaccinationPlace)
                    .ToList();

                
                lblPriorityGroupData.Text = refInstitution.Institution1;

                displayDate = dateTime.ToShortDateString();
                lblDateData.Text = displayDate;
                displayTime = dateTime.ToString("HH:mm:ss tt");
                lblHourData.Text = displayTime;
                displayPlace = resultVaccionation[0].VaccinationPlace1;
                lblPlaceData.Text = displayPlace;
                displayAddress = resultVaccionation[0].VaccinationPlaceAddress;
                lblAddressData.Text = displayAddress;
            }
            else
            {
                MessageBox.Show("Los campos requeridos no han sido llenados", "Vacunación Covid",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            CreatePdf.Save("1", this.fullName, this.dui, this.displayPlace, this.displayDate, this.displayTime, this.displayAddress);
            MessageBox.Show("PDF Exportado con Éxito", "Vacunación Covid",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
