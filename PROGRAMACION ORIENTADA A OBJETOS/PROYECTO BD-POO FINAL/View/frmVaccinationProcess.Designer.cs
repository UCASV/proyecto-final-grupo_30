
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppointments)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1024, 629);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabStop = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1016, 593);
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
            this.btnClear.Location = new System.Drawing.Point(7, 535);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(189, 53);
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
            this.btnBrowse.Location = new System.Drawing.Point(749, 85);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(131, 35);
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
            this.btnProceedToStep2.Location = new System.Drawing.Point(880, 535);
            this.btnProceedToStep2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProceedToStep2.Name = "btnProceedToStep2";
            this.btnProceedToStep2.Size = new System.Drawing.Size(131, 53);
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
            this.lblCitizenDUI.Location = new System.Drawing.Point(152, 83);
            this.lblCitizenDUI.Name = "lblCitizenDUI";
            this.lblCitizenDUI.Size = new System.Drawing.Size(280, 35);
            this.lblCitizenDUI.TabIndex = 34;
            this.lblCitizenDUI.Text = "Ingrese el DUI del Ciudadano:";
            // 
            // lblFollowUpAppointment
            // 
            this.lblFollowUpAppointment.AutoSize = true;
            this.lblFollowUpAppointment.BackColor = System.Drawing.Color.Transparent;
            this.lblFollowUpAppointment.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFollowUpAppointment.ForeColor = System.Drawing.Color.White;
            this.lblFollowUpAppointment.Location = new System.Drawing.Point(336, 27);
            this.lblFollowUpAppointment.Name = "lblFollowUpAppointment";
            this.lblFollowUpAppointment.Size = new System.Drawing.Size(317, 41);
            this.lblFollowUpAppointment.TabIndex = 33;
            this.lblFollowUpAppointment.Text = "Seguimiento de Citas";
            // 
            // dataGridAppointments
            // 
            this.dataGridAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dataGridAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAppointments.Location = new System.Drawing.Point(7, 145);
            this.dataGridAppointments.Name = "dataGridAppointments";
            this.dataGridAppointments.ReadOnly = true;
            this.dataGridAppointments.RowHeadersWidth = 51;
            this.dataGridAppointments.RowTemplate.Height = 29;
            this.dataGridAppointments.Size = new System.Drawing.Size(1005, 383);
            this.dataGridAppointments.TabIndex = 32;
            // 
            // txtDUI
            // 
            this.txtDUI.BackColor = System.Drawing.Color.White;
            this.txtDUI.ForeColor = System.Drawing.Color.Black;
            this.txtDUI.Location = new System.Drawing.Point(439, 85);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(302, 27);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1016, 593);
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
            this.btnAddWaitingInfo.Location = new System.Drawing.Point(329, 448);
            this.btnAddWaitingInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddWaitingInfo.Name = "btnAddWaitingInfo";
            this.btnAddWaitingInfo.Size = new System.Drawing.Size(355, 65);
            this.btnAddWaitingInfo.TabIndex = 20;
            this.btnAddWaitingInfo.Text = "Agregar a lista de espera";
            this.btnAddWaitingInfo.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(424, 164);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(261, 28);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "xxxxxxx";
            // 
            // lblDUI
            // 
            this.lblDUI.BackColor = System.Drawing.Color.Transparent;
            this.lblDUI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDUI.Location = new System.Drawing.Point(385, 216);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(299, 28);
            this.lblDUI.TabIndex = 18;
            this.lblDUI.Text = "xxxxxxx";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(329, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 28);
            this.label13.TabIndex = 17;
            this.label13.Text = "DUI:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(329, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 28);
            this.label12.TabIndex = 16;
            this.label12.Text = "Nombre:";
            // 
            // lblPriorityGroupData
            // 
            this.lblPriorityGroupData.BackColor = System.Drawing.Color.Transparent;
            this.lblPriorityGroupData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPriorityGroupData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPriorityGroupData.Location = new System.Drawing.Point(518, 269);
            this.lblPriorityGroupData.Name = "lblPriorityGroupData";
            this.lblPriorityGroupData.Size = new System.Drawing.Size(167, 40);
            this.lblPriorityGroupData.TabIndex = 10;
            this.lblPriorityGroupData.Text = "xxxxxxxx";
            // 
            // lblDateData
            // 
            this.lblDateData.BackColor = System.Drawing.Color.Transparent;
            this.lblDateData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateData.Location = new System.Drawing.Point(394, 327);
            this.lblDateData.Name = "lblDateData";
            this.lblDateData.Size = new System.Drawing.Size(290, 40);
            this.lblDateData.TabIndex = 11;
            this.lblDateData.Text = "DD/MM/YY";
            // 
            // lblHourData
            // 
            this.lblHourData.BackColor = System.Drawing.Color.Transparent;
            this.lblHourData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHourData.Location = new System.Drawing.Point(394, 384);
            this.lblHourData.Name = "lblHourData";
            this.lblHourData.Size = new System.Drawing.Size(290, 40);
            this.lblHourData.TabIndex = 12;
            this.lblHourData.Text = "HH/MM";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.BackColor = System.Drawing.Color.Transparent;
            this.lblHour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHour.Location = new System.Drawing.Point(329, 384);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(63, 28);
            this.lblHour.TabIndex = 13;
            this.lblHour.Text = "Hora:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(329, 327);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(71, 28);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Fecha:";
            // 
            // lblPriorityGroup
            // 
            this.lblPriorityGroup.AutoSize = true;
            this.lblPriorityGroup.BackColor = System.Drawing.Color.Transparent;
            this.lblPriorityGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPriorityGroup.Location = new System.Drawing.Point(329, 269);
            this.lblPriorityGroup.Name = "lblPriorityGroup";
            this.lblPriorityGroup.Size = new System.Drawing.Size(197, 28);
            this.lblPriorityGroup.TabIndex = 15;
            this.lblPriorityGroup.Text = "Grupo de prioridad:";
            // 
            // lblWaitingProcess
            // 
            this.lblWaitingProcess.AutoSize = true;
            this.lblWaitingProcess.BackColor = System.Drawing.Color.Transparent;
            this.lblWaitingProcess.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWaitingProcess.Location = new System.Drawing.Point(385, 51);
            this.lblWaitingProcess.Name = "lblWaitingProcess";
            this.lblWaitingProcess.Size = new System.Drawing.Size(221, 41);
            this.lblWaitingProcess.TabIndex = 9;
            this.lblWaitingProcess.Text = "Lista de espera";
            // 
            // frmVaccinationProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 661);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmVaccinationProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proceso de Vacunación - Vacunación Covid";
            this.Shown += new System.EventHandler(this.frmVaccinationProcess_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppointments)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
    }
}