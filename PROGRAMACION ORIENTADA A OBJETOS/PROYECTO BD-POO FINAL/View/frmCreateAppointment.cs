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

            cmbInstitution.DataSource = institutionList;
            cmbInstitution.DisplayMember = "Institution1";
            cmbInstitution.ValueMember = "IdInstitution";
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

                if (cbLungs.Checked)
                {
                    ChronicDisease cdDB = db.Set<ChronicDisease>()
                        .SingleOrDefault(c => c.IdChronicDisease == 1);

                    Citizen dbCitizen = db.Set<Citizen>()
                        .SingleOrDefault(c => c.IdCitizen == citizenList[0].IdCitizen);

                    CitizenxChronicDisease acCitizenxChronicDisease = new CitizenxChronicDisease(cdDB.IdChronicDisease, dbCitizen.IdCitizen);

                    db.Add(acCitizenxChronicDisease);
                    db.SaveChanges();
                }

                if (cbHeart.Checked)
                {
                    ChronicDisease cdDB = db.Set<ChronicDisease>()
                        .SingleOrDefault(c => c.IdChronicDisease == 2);

                    Citizen dbCitizen = db.Set<Citizen>()
                        .SingleOrDefault(c => c.IdCitizen == citizenList[0].IdCitizen);

                    CitizenxChronicDisease acCitizenxChronicDisease = new CitizenxChronicDisease(cdDB.IdChronicDisease, dbCitizen.IdCitizen);

                    db.Add(acCitizenxChronicDisease);
                    db.SaveChanges();
                }

                if (cbDiabetes.Checked)
                {
                    ChronicDisease cdDB = db.Set<ChronicDisease>()
                        .SingleOrDefault(c => c.IdChronicDisease == 3);

                    Citizen dbCitizen = db.Set<Citizen>()
                        .SingleOrDefault(c => c.IdCitizen == citizenList[0].IdCitizen);

                    CitizenxChronicDisease acCitizenxChronicDisease = new CitizenxChronicDisease(cdDB.IdChronicDisease, dbCitizen.IdCitizen);

                    db.Add(acCitizenxChronicDisease);
                    db.SaveChanges();
                }

                if (cbObesity.Checked)
                {
                    ChronicDisease cdDB = db.Set<ChronicDisease>()
                        .SingleOrDefault(c => c.IdChronicDisease == 4);

                    Citizen dbCitizen = db.Set<Citizen>()
                        .SingleOrDefault(c => c.IdCitizen == citizenList[0].IdCitizen);

                    CitizenxChronicDisease acCitizenxChronicDisease = new CitizenxChronicDisease(cdDB.IdChronicDisease, dbCitizen.IdCitizen);

                    db.Add(acCitizenxChronicDisease);
                    db.SaveChanges();
                }

                if (cbSID.Checked)
                {
                    ChronicDisease cdDB = db.Set<ChronicDisease>()
                        .SingleOrDefault(c => c.IdChronicDisease == 5);

                    Citizen dbCitizen = db.Set<Citizen>()
                        .SingleOrDefault(c => c.IdCitizen == citizenList[0].IdCitizen);

                    CitizenxChronicDisease acCitizenxChronicDisease = new CitizenxChronicDisease(cdDB.IdChronicDisease, dbCitizen.IdCitizen);

                    db.Add(acCitizenxChronicDisease);
                    db.SaveChanges();
                }

                if (cbLiver.Checked)
                {
                    ChronicDisease cdDB = db.Set<ChronicDisease>()
                        .SingleOrDefault(c => c.IdChronicDisease == 6);

                    Citizen dbCitizen = db.Set<Citizen>()
                        .SingleOrDefault(c => c.IdCitizen == citizenList[0].IdCitizen);

                    CitizenxChronicDisease acCitizenxChronicDisease = new CitizenxChronicDisease(cdDB.IdChronicDisease, dbCitizen.IdCitizen);

                    db.Add(acCitizenxChronicDisease);
                    db.SaveChanges();
                }
            }
        }
    }
}
