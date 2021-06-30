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

                VaccinationxSideEffect aVaccinationxSideEffect =
                    new VaccinationxSideEffect(sideEffect[0].IdSideEffect, aVaccination.IdVaccination, Convert.ToInt32(minutes));

                db.Add(aVaccinationxSideEffect);
                db.SaveChanges();
            }

            if (cbFatigue.Checked)
            {
                var sideEffect = db.SideEffects
                    .Where(s => s.IdSideEffect.Equals(2))
                    .ToList();

                var minutes = nudFatigue.Value;

                VaccinationxSideEffect aVaccinationxSideEffect =
                    new VaccinationxSideEffect(sideEffect[0].IdSideEffect, aVaccination.IdVaccination, Convert.ToInt32(minutes));

                db.Add(aVaccinationxSideEffect);
                db.SaveChanges();
            }

            if (cbHeadache.Checked)
            {
                var sideEffect = db.SideEffects
                    .Where(s => s.IdSideEffect.Equals(3))
                    .ToList();

                var minutes = nudHeadache.Value;

                VaccinationxSideEffect aVaccinationxSideEffect =
                    new VaccinationxSideEffect(sideEffect[0].IdSideEffect, aVaccination.IdVaccination, Convert.ToInt32(minutes));

                db.Add(aVaccinationxSideEffect);
                db.SaveChanges();
            }

            if (cbFever.Checked)
            {
                var sideEffect = db.SideEffects
                    .Where(s => s.IdSideEffect.Equals(4))
                    .ToList();

                var minutes = nudFever.Value;

                VaccinationxSideEffect aVaccinationxSideEffect =
                    new VaccinationxSideEffect(sideEffect[0].IdSideEffect, aVaccination.IdVaccination, Convert.ToInt32(minutes));

                db.Add(aVaccinationxSideEffect);
                db.SaveChanges();
            }

            if (cbMialgia.Checked)
            {
                var sideEffect = db.SideEffects
                    .Where(s => s.IdSideEffect.Equals(5))
                    .ToList();

                var minutes = nudMialgia.Value;

                VaccinationxSideEffect aVaccinationxSideEffect =
                    new VaccinationxSideEffect(sideEffect[0].IdSideEffect, aVaccination.IdVaccination, Convert.ToInt32(minutes));

                db.Add(aVaccinationxSideEffect);
                db.SaveChanges();
            }

            if (cbArtralgia.Checked)
            {
                var sideEffect = db.SideEffects
                    .Where(s => s.IdSideEffect.Equals(6))
                    .ToList();

                var minutes = nudAltralgia.Value;

                VaccinationxSideEffect aVaccinationxSideEffect =
                    new VaccinationxSideEffect(sideEffect[0].IdSideEffect, aVaccination.IdVaccination, Convert.ToInt32(minutes));

                db.Add(aVaccinationxSideEffect);
                db.SaveChanges();
            }

            if (cbAnafilaxia.Checked)
            {
                var sideEffect = db.SideEffects
                    .Where(s => s.IdSideEffect.Equals(7))
                    .ToList();

                var minutes = nudAnafilaxia.Value;

                VaccinationxSideEffect aVaccinationxSideEffect =
                    new VaccinationxSideEffect(sideEffect[0].IdSideEffect, aVaccination.IdVaccination, Convert.ToInt32(minutes));

                db.Add(aVaccinationxSideEffect);
                db.SaveChanges();
            }
            this.Close();
        }
    }
}
