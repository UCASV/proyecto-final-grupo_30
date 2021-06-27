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
using PROYECTO_BD_POO_FINAL.Controller;
using PROYECTO_BD_POO_FINAL.ProjectContext;

namespace PROYECTO_BD_POO_FINAL.View
{
    public partial class frmCreateAppointment : Form
    {
        public frmCreateAppointment()
        {
            InitializeComponent();
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
            bool verify = txtDUI != null &&
                          txtFullName != null &&
                          txtAddress != null &&
                          txtCellphoneNumber != null;
            if (verify)
            {
                string dui = txtDUI.Text;
                string fullName = txtFullName.Text;
                string address = txtAddress.Text;
                string cellphoneNumber = txtCellphoneNumber.Text;
                string email = txtEmail.Text;
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

                int randomHour = aRandom.Next(7, 16);
                int randomMinute = aRandom.Next(0, 59);

                TimeSpan ts = new TimeSpan(randomHour, randomMinute, 0);

                dateTime = dateTime.AddDays(7);
                dateTime = dateTime.Date + ts;

                CheckBox[] checkBoxes = new CheckBox[]{ cbLungs, cbHeart, cbDiabetes, cbObesity, cbSID, cbLiver };

                for(int i = 1; i <= checkBoxes.Length; i++)
                {
                    if(checkBoxes[i-1].Checked)
                        RegisterDisease.Add(citizenList[0].IdCitizen, i);
                }
                tabControl1.SelectedIndex = 1;
            }
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
