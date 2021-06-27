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
                    RegisterDisease.Add(citizenList[0].IdCitizen, 1);
                }

                if (cbHeart.Checked)
                {
                    RegisterDisease.Add(citizenList[0].IdCitizen, 2);
                }

                if (cbDiabetes.Checked)
                {
                    RegisterDisease.Add(citizenList[0].IdCitizen, 3);
                }

                if (cbObesity.Checked)
                {
                    RegisterDisease.Add(citizenList[0].IdCitizen, 4);
                }

                if (cbSID.Checked)
                {
                    RegisterDisease.Add(citizenList[0].IdCitizen, 5);
                }

                if (cbLiver.Checked)
                {
                    RegisterDisease.Add(citizenList[0].IdCitizen, 6);
                }
            }
        }
    }
}
