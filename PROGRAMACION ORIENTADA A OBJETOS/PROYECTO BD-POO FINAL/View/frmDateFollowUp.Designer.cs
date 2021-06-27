
namespace PROYECTO_BD_POO_FINAL.View
{
    partial class frmDateFollowUp
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
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosis1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosis2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LugarVacunacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDUI
            // 
            this.txtDUI.BackColor = System.Drawing.Color.White;
            this.txtDUI.ForeColor = System.Drawing.Color.White;
            this.txtDUI.Location = new System.Drawing.Point(333, 64);
            this.txtDUI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(265, 23);
            this.txtDUI.TabIndex = 23;
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DUI,
            this.Nombre,
            this.Dosis1,
            this.Dosis2,
            this.LugarVacunacion});
            this.dgvAppointments.Location = new System.Drawing.Point(12, 108);
            this.dgvAppointments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.RowHeadersWidth = 51;
            this.dgvAppointments.RowTemplate.Height = 29;
            this.dgvAppointments.Size = new System.Drawing.Size(660, 245);
            this.dgvAppointments.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "Seguimiento de Citas";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 26);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ingrese el DUI del Ciudadano:";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // DUI
            // 
            this.DUI.HeaderText = "DUI";
            this.DUI.Name = "DUI";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Dosis1
            // 
            this.Dosis1.HeaderText = "Dosis 1";
            this.Dosis1.Name = "Dosis1";
            // 
            // Dosis2
            // 
            this.Dosis2.HeaderText = "Dosis 2";
            this.Dosis2.Name = "Dosis2";
            // 
            // LugarVacunacion
            // 
            this.LugarVacunacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LugarVacunacion.HeaderText = "Lugar de Vacunación";
            this.LugarVacunacion.Name = "LugarVacunacion";
            // 
            // frmDateFollowUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::PROYECTO_BD_POO_FINAL.Properties.Resources.vaccine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 367);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.txtDUI);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDateFollowUp";
            this.Text = "frmDateFollowUpcs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosis1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosis2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LugarVacunacion;
    }
}