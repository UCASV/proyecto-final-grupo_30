
namespace PROYECTO_BD_POO_FINAL.View
{
    partial class frmVaccinationProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVaccinationProcess));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnProceedToStep2 = new System.Windows.Forms.Button();
            this.lblCitizenDUI = new System.Windows.Forms.Label();
            this.lblFollowUpAppointment = new System.Windows.Forms.Label();
            this.dataGridAppointments = new System.Windows.Forms.DataGridView();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 472);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::PROYECTO_BD_POO_FINAL.Properties.Resources.vaccine;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnBrowse);
            this.tabPage1.Controls.Add(this.btnProceedToStep2);
            this.tabPage1.Controls.Add(this.lblCitizenDUI);
            this.tabPage1.Controls.Add(this.lblFollowUpAppointment);
            this.tabPage1.Controls.Add(this.dataGridAppointments);
            this.tabPage1.Controls.Add(this.txtDUI);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(888, 441);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(6, 401);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(165, 40);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Limpiar Busqueda";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowse.Location = new System.Drawing.Point(655, 64);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(115, 26);
            this.btnBrowse.TabIndex = 36;
            this.btnBrowse.Text = "Buscar";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnProceedToStep2
            // 
            this.btnProceedToStep2.BackColor = System.Drawing.Color.Transparent;
            this.btnProceedToStep2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceedToStep2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProceedToStep2.ForeColor = System.Drawing.Color.White;
            this.btnProceedToStep2.Location = new System.Drawing.Point(770, 401);
            this.btnProceedToStep2.Name = "btnProceedToStep2";
            this.btnProceedToStep2.Size = new System.Drawing.Size(115, 40);
            this.btnProceedToStep2.TabIndex = 35;
            this.btnProceedToStep2.Text = "Continuar";
            this.btnProceedToStep2.UseVisualStyleBackColor = false;
            this.btnProceedToStep2.Click += new System.EventHandler(this.btnProceedToStep2_Click);
            // 
            // lblCitizenDUI
            // 
            this.lblCitizenDUI.BackColor = System.Drawing.Color.Transparent;
            this.lblCitizenDUI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCitizenDUI.ForeColor = System.Drawing.Color.White;
            this.lblCitizenDUI.Location = new System.Drawing.Point(133, 62);
            this.lblCitizenDUI.Name = "lblCitizenDUI";
            this.lblCitizenDUI.Size = new System.Drawing.Size(245, 26);
            this.lblCitizenDUI.TabIndex = 34;
            this.lblCitizenDUI.Text = "Ingrese el DUI del Ciudadano:";
            // 
            // lblFollowUpAppointment
            // 
            this.lblFollowUpAppointment.AutoSize = true;
            this.lblFollowUpAppointment.BackColor = System.Drawing.Color.Transparent;
            this.lblFollowUpAppointment.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFollowUpAppointment.ForeColor = System.Drawing.Color.White;
            this.lblFollowUpAppointment.Location = new System.Drawing.Point(294, 20);
            this.lblFollowUpAppointment.Name = "lblFollowUpAppointment";
            this.lblFollowUpAppointment.Size = new System.Drawing.Size(255, 32);
            this.lblFollowUpAppointment.TabIndex = 33;
            this.lblFollowUpAppointment.Text = "Seguimiento de Citas";
            // 
            // dataGridAppointments
            // 
            this.dataGridAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dataGridAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAppointments.Location = new System.Drawing.Point(6, 109);
            this.dataGridAppointments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridAppointments.Name = "dataGridAppointments";
            this.dataGridAppointments.RowHeadersWidth = 51;
            this.dataGridAppointments.RowTemplate.Height = 29;
            this.dataGridAppointments.Size = new System.Drawing.Size(879, 287);
            this.dataGridAppointments.TabIndex = 32;
            // 
            // txtDUI
            // 
            this.txtDUI.BackColor = System.Drawing.Color.White;
            this.txtDUI.ForeColor = System.Drawing.Color.Black;
            this.txtDUI.Location = new System.Drawing.Point(384, 64);
            this.txtDUI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(265, 23);
            this.txtDUI.TabIndex = 31;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(888, 441);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmVaccinationProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 496);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVaccinationProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proceso de Vacunación - Vacunación Covid";
            this.Load += new System.EventHandler(this.frmVaccinationProcess_Load);
            this.Shown += new System.EventHandler(this.frmVaccinationProcess_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppointments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnProceedToStep2;
        private System.Windows.Forms.Label lblCitizenDUI;
        private System.Windows.Forms.Label lblFollowUpAppointment;
        private System.Windows.Forms.DataGridView dataGridAppointments;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnClear;
    }
}