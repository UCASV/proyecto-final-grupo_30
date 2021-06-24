using System;
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
    public partial class frmLoading : Form
    {
        private int time;
        private string text;

        public frmLoading(int time, string text)
        {
            InitializeComponent();
            this.time = time;
            this.text = text;
        }

        private void delay()
        {
            Thread.Sleep(time);
        }

        private async void showLoadingScreen()
        {
            lblLoadingText.Text = text;
            Task oTask = new Task(delay);
            oTask.Start();
            await oTask;
            Close();
        }

        private void frmLoading_Shown(object sender, EventArgs e)
        {
            showLoadingScreen();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
