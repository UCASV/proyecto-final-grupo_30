
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
            this.btnAddWaitingInfo = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDUI = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPriorityGroupData = new System.Windows.Forms.Label();
            this.lblDateData = new System.Windows.Forms.Label();
            this.lblHourData = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPriorityGroup = new System.Windows.Forms.Label();
            this.lblWaitingProcess = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnVaccinate = new System.Windows.Forms.Button();
            this.lblVaccinationProcess = new System.Windows.Forms.Label();
            this.dgvPersonsReadyForVaccine = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppointments)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonsReadyForVaccine)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, -11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(914, 505);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
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
            this.tabPage1.Size = new System.Drawing.Size(906, 474);
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
            this.btnClear.Location = new System.Drawing.Point(6, 428);
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
            this.btnProceedToStep2.Location = new System.Drawing.Point(785, 428);
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
            this.dataGridAppointments.GridColor = System.Drawing.Color.Black;
            this.dataGridAppointments.Location = new System.Drawing.Point(6, 109);
            this.dataGridAppointments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridAppointments.Name = "dataGridAppointments";
            this.dataGridAppointments.ReadOnly = true;
            this.dataGridAppointments.RowHeadersWidth = 51;
            this.dataGridAppointments.RowTemplate.Height = 29;
            this.dataGridAppointments.Size = new System.Drawing.Size(894, 314);
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
            this.tabPage2.BackgroundImage = global::PROYECTO_BD_POO_FINAL.Properties.Resources.syringevaccinationg931114934_1435242_860x566;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.btnAddWaitingInfo);
            this.tabPage2.Controls.Add(this.lblName);
            this.tabPage2.Controls.Add(this.lblDUI);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.lblPriorityGroupData);
            this.tabPage2.Controls.Add(this.lblDateData);
            this.tabPage2.Controls.Add(this.lblHourData);
            this.tabPage2.Controls.Add(this.lblHour);
            this.tabPage2.Controls.Add(this.lblDate);
            this.tabPage2.Controls.Add(this.lblPriorityGroup);
            this.tabPage2.Controls.Add(this.lblWaitingProcess);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(906, 474);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddWaitingInfo
            // 
            this.btnAddWaitingInfo.BackColor = System.Drawing.Color.Black;
            this.btnAddWaitingInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWaitingInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddWaitingInfo.ForeColor = System.Drawing.Color.White;
            this.btnAddWaitingInfo.Location = new System.Drawing.Point(288, 336);
            this.btnAddWaitingInfo.Name = "btnAddWaitingInfo";
            this.btnAddWaitingInfo.Size = new System.Drawing.Size(311, 49);
            this.btnAddWaitingInfo.TabIndex = 20;
            this.btnAddWaitingInfo.Text = "Agregar a lista de espera";
            this.btnAddWaitingInfo.UseVisualStyleBackColor = false;
            this.btnAddWaitingInfo.Click += new System.EventHandler(this.btnAddWaitingInfo_Click);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(371, 123);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(228, 21);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "xxxxxxx";
            // 
            // lblDUI
            // 
            this.lblDUI.BackColor = System.Drawing.Color.Transparent;
            this.lblDUI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDUI.Location = new System.Drawing.Point(337, 162);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(262, 21);
            this.lblDUI.TabIndex = 18;
            this.lblDUI.Text = "xxxxxxx";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(288, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 21);
            this.label13.TabIndex = 17;
            this.label13.Text = "DUI:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(288, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 21);
            this.label12.TabIndex = 16;
            this.label12.Text = "Nombre:";
            // 
            // lblPriorityGroupData
            // 
            this.lblPriorityGroupData.BackColor = System.Drawing.Color.Transparent;
            this.lblPriorityGroupData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPriorityGroupData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPriorityGroupData.Location = new System.Drawing.Point(453, 202);
            this.lblPriorityGroupData.Name = "lblPriorityGroupData";
            this.lblPriorityGroupData.Size = new System.Drawing.Size(146, 30);
            this.lblPriorityGroupData.TabIndex = 10;
            this.lblPriorityGroupData.Text = "xxxxxxxx";
            // 
            // lblDateData
            // 
            this.lblDateData.BackColor = System.Drawing.Color.Transparent;
            this.lblDateData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateData.Location = new System.Drawing.Point(345, 245);
            this.lblDateData.Name = "lblDateData";
            this.lblDateData.Size = new System.Drawing.Size(254, 30);
            this.lblDateData.TabIndex = 11;
            this.lblDateData.Text = "DD/MM/YY";
            // 
            // lblHourData
            // 
            this.lblHourData.BackColor = System.Drawing.Color.Transparent;
            this.lblHourData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHourData.Location = new System.Drawing.Point(345, 288);
            this.lblHourData.Name = "lblHourData";
            this.lblHourData.Size = new System.Drawing.Size(254, 30);
            this.lblHourData.TabIndex = 12;
            this.lblHourData.Text = "HH/MM";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.BackColor = System.Drawing.Color.Transparent;
            this.lblHour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHour.Location = new System.Drawing.Point(288, 288);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(51, 21);
            this.lblHour.TabIndex = 13;
            this.lblHour.Text = "Hora:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(288, 245);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 21);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Fecha:";
            // 
            // lblPriorityGroup
            // 
            this.lblPriorityGroup.AutoSize = true;
            this.lblPriorityGroup.BackColor = System.Drawing.Color.Transparent;
            this.lblPriorityGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPriorityGroup.Location = new System.Drawing.Point(288, 202);
            this.lblPriorityGroup.Name = "lblPriorityGroup";
            this.lblPriorityGroup.Size = new System.Drawing.Size(159, 21);
            this.lblPriorityGroup.TabIndex = 15;
            this.lblPriorityGroup.Text = "Grupo de prioridad:";
            // 
            // lblWaitingProcess
            // 
            this.lblWaitingProcess.AutoSize = true;
            this.lblWaitingProcess.BackColor = System.Drawing.Color.Transparent;
            this.lblWaitingProcess.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWaitingProcess.Location = new System.Drawing.Point(337, 38);
            this.lblWaitingProcess.Name = "lblWaitingProcess";
            this.lblWaitingProcess.Size = new System.Drawing.Size(177, 32);
            this.lblWaitingProcess.TabIndex = 9;
            this.lblWaitingProcess.Text = "Lista de espera";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::PROYECTO_BD_POO_FINAL.Properties.Resources.syringevaccinationg931114934_1435242_860x566;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.btnVaccinate);
            this.tabPage3.Controls.Add(this.lblVaccinationProcess);
            this.tabPage3.Controls.Add(this.dgvPersonsReadyForVaccine);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(906, 474);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnVaccinate
            // 
            this.btnVaccinate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVaccinate.Location = new System.Drawing.Point(769, 413);
            this.btnVaccinate.Name = "btnVaccinate";
            this.btnVaccinate.Size = new System.Drawing.Size(131, 45);
            this.btnVaccinate.TabIndex = 2;
            this.btnVaccinate.Text = "Vacunar";
            this.btnVaccinate.UseVisualStyleBackColor = true;
            // 
            // lblVaccinationProcess
            // 
            this.lblVaccinationProcess.AutoSize = true;
            this.lblVaccinationProcess.BackColor = System.Drawing.Color.Transparent;
            this.lblVaccinationProcess.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVaccinationProcess.Location = new System.Drawing.Point(314, 45);
            this.lblVaccinationProcess.Name = "lblVaccinationProcess";
            this.lblVaccinationProcess.Size = new System.Drawing.Size(259, 32);
            this.lblVaccinationProcess.TabIndex = 1;
            this.lblVaccinationProcess.Text = "Personas para vacunar";
            // 
            // dgvPersonsReadyForVaccine
            // 
            this.dgvPersonsReadyForVaccine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonsReadyForVaccine.BackgroundColor = System.Drawing.Color.White;
            this.dgvPersonsReadyForVaccine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonsReadyForVaccine.GridColor = System.Drawing.Color.Black;
            this.dgvPersonsReadyForVaccine.Location = new System.Drawing.Point(10, 106);
            this.dgvPersonsReadyForVaccine.Name = "dgvPersonsReadyForVaccine";
            this.dgvPersonsReadyForVaccine.RowTemplate.Height = 25;
            this.dgvPersonsReadyForVaccine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonsReadyForVaccine.Size = new System.Drawing.Size(890, 301);
            this.dgvPersonsReadyForVaccine.TabIndex = 3;
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonsReadyForVaccine)).EndInit();
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
        private System.Windows.Forms.Button btnAddWaitingInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDUI;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPriorityGroupData;
        private System.Windows.Forms.Label lblDateData;
        private System.Windows.Forms.Label lblHourData;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPriorityGroup;
        private System.Windows.Forms.Label lblWaitingProcess;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblVaccinationProcess;
        private System.Windows.Forms.DataGridView dgvPersonsReadyForVaccine;
        private System.Windows.Forms.Button btnVaccinate;
    }
}