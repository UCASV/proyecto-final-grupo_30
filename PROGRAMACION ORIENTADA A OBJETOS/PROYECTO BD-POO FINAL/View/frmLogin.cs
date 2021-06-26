using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using PROYECTO_BD_POO_FINAL.ProjectContext;
using PROYECTO_BD_POO_FINAL.View;

namespace PROYECTO_BD_POO_FINAL
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var db = new ProjectContext.PROJECTContext();
            var managerList = db.Employees
                .Where(m => m.IdType == 1)
                .ToList();

            var result = managerList.Where(
                u => u.EmployeeUsername.Equals(txtUser.Text) &&
                     u.EmployeePassword.Equals(txtPassword.Text) &&
                     u.IdType.Equals(1)
            ).ToList();

            if (result.Count == 0)
            {
                MessageBox.Show("The manager doesn't exist or username and password don't match", "Vacunación Covid",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUser.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Welcome", "Vacunación Covid",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmProcessType window = new frmProcessType();
                window.ShowDialog();
                txtUser.Text = "";
                txtPassword.Text = "";

                int idEmployee = result[0].IdEmployee;
                int idBooth = ((Booth) cmbBooth.SelectedItem).IdBooth;
                DateTime localDateTime = DateTime.Now;

                Management aManagement = new Management(idEmployee, idBooth, localDateTime);

                db.Add(aManagement);
                db.SaveChanges();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            var db = new ProjectContext.PROJECTContext();

            var boothList = db.Booths
                .ToList();

            cmbBooth.DataSource = boothList;
            cmbBooth.DisplayMember = "BoothAddress";
            cmbBooth.ValueMember = "IdBooth";
        }
    }
}
