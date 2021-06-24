
namespace PROYECTO_BD_POO_FINAL.View
{
    partial class frmProcessType
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAppointmentTracking = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAppointmentTracking
            // 
            this.btnAppointmentTracking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btnAppointmentTracking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAppointmentTracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointmentTracking.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAppointmentTracking.Location = new System.Drawing.Point(52, 240);
            this.btnAppointmentTracking.Name = "btnAppointmentTracking";
            this.btnAppointmentTracking.Size = new System.Drawing.Size(269, 43);
            this.btnAppointmentTracking.TabIndex = 0;
            this.btnAppointmentTracking.Text = "Seguimiento de cita";
            this.btnAppointmentTracking.UseVisualStyleBackColor = false;
            this.btnAppointmentTracking.Click += new System.EventHandler(this.btnAppointmentTracking_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(34, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Proceso para agendar cita";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmProcessType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PROYECTO_BD_POO_FINAL.Properties.Resources.Background_Proceso;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(387, 641);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAppointmentTracking);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmProcessType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProcessType";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAppointmentTracking;
        private System.Windows.Forms.Button button1;
    }
}