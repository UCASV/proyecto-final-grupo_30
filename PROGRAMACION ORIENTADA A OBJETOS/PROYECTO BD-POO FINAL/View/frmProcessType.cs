﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_BD_POO_FINAL.View
{
    public partial class frmProcessType : Form
    {
        

        public frmProcessType()
        {
            InitializeComponent();
        }

        private void btnAppointmentTracking_Click(object sender, EventArgs e)
        {
            frmLoading loadingScreen = new frmLoading(2000, "Abriendo seguimiento de citas");
            loadingScreen.ShowDialog();
        }

    }
}
