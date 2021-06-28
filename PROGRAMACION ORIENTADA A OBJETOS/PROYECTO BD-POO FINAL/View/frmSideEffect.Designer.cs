
namespace PROYECTO_BD_POO_FINAL.View
{
    partial class frmSideEffect
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbNone = new System.Windows.Forms.CheckBox();
            this.cbArtralgia = new System.Windows.Forms.CheckBox();
            this.cbMialgia = new System.Windows.Forms.CheckBox();
            this.cbFever = new System.Windows.Forms.CheckBox();
            this.cbHeadache = new System.Windows.Forms.CheckBox();
            this.cbFatigue = new System.Windows.Forms.CheckBox();
            this.cbBlush = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAnafilaxia = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnterObervation = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Observación";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cbAnafilaxia, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbNone, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbArtralgia, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbMialgia, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbFever, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbHeadache, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbFatigue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbBlush, 0, 0);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(135, 89);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(424, 212);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cbNone
            // 
            this.cbNone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNone.AutoSize = true;
            this.cbNone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbNone.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbNone.Location = new System.Drawing.Point(216, 162);
            this.cbNone.Name = "cbNone";
            this.cbNone.Size = new System.Drawing.Size(202, 44);
            this.cbNone.TabIndex = 6;
            this.cbNone.Text = "Ninguna";
            this.cbNone.UseVisualStyleBackColor = true;
            // 
            // cbArtralgia
            // 
            this.cbArtralgia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbArtralgia.AutoSize = true;
            this.cbArtralgia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbArtralgia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbArtralgia.Location = new System.Drawing.Point(216, 106);
            this.cbArtralgia.Name = "cbArtralgia";
            this.cbArtralgia.Size = new System.Drawing.Size(202, 47);
            this.cbArtralgia.TabIndex = 5;
            this.cbArtralgia.Text = "Artralgia";
            this.cbArtralgia.UseVisualStyleBackColor = true;
            // 
            // cbMialgia
            // 
            this.cbMialgia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMialgia.AutoSize = true;
            this.cbMialgia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbMialgia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbMialgia.Location = new System.Drawing.Point(6, 106);
            this.cbMialgia.Name = "cbMialgia";
            this.cbMialgia.Size = new System.Drawing.Size(201, 47);
            this.cbMialgia.TabIndex = 4;
            this.cbMialgia.Text = "Mialgia";
            this.cbMialgia.UseVisualStyleBackColor = true;
            // 
            // cbFever
            // 
            this.cbFever.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFever.AutoSize = true;
            this.cbFever.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbFever.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbFever.Location = new System.Drawing.Point(216, 56);
            this.cbFever.Name = "cbFever";
            this.cbFever.Size = new System.Drawing.Size(202, 41);
            this.cbFever.TabIndex = 3;
            this.cbFever.Text = "Fever";
            this.cbFever.UseVisualStyleBackColor = true;
            // 
            // cbHeadache
            // 
            this.cbHeadache.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbHeadache.AutoSize = true;
            this.cbHeadache.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbHeadache.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbHeadache.Location = new System.Drawing.Point(6, 56);
            this.cbHeadache.Name = "cbHeadache";
            this.cbHeadache.Size = new System.Drawing.Size(201, 41);
            this.cbHeadache.TabIndex = 2;
            this.cbHeadache.Text = "Dolor de cabeza";
            this.cbHeadache.UseVisualStyleBackColor = true;
            // 
            // cbFatigue
            // 
            this.cbFatigue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFatigue.AutoSize = true;
            this.cbFatigue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbFatigue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbFatigue.Location = new System.Drawing.Point(216, 6);
            this.cbFatigue.Name = "cbFatigue";
            this.cbFatigue.Size = new System.Drawing.Size(202, 41);
            this.cbFatigue.TabIndex = 1;
            this.cbFatigue.Text = "Fatiga";
            this.cbFatigue.UseVisualStyleBackColor = true;
            // 
            // cbBlush
            // 
            this.cbBlush.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBlush.AutoSize = true;
            this.cbBlush.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbBlush.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbBlush.Location = new System.Drawing.Point(6, 6);
            this.cbBlush.Name = "cbBlush";
            this.cbBlush.Size = new System.Drawing.Size(201, 41);
            this.cbBlush.TabIndex = 0;
            this.cbBlush.Text = "Enrojecimiento";
            this.cbBlush.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Efectos secundarios:";
            // 
            // cbAnafilaxia
            // 
            this.cbAnafilaxia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAnafilaxia.AutoSize = true;
            this.cbAnafilaxia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbAnafilaxia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbAnafilaxia.Location = new System.Drawing.Point(6, 162);
            this.cbAnafilaxia.Name = "cbAnafilaxia";
            this.cbAnafilaxia.Size = new System.Drawing.Size(201, 44);
            this.cbAnafilaxia.TabIndex = 7;
            this.cbAnafilaxia.Text = "Anafilaxia";
            this.cbAnafilaxia.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.DimGray;
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.Window;
            this.numericUpDown1.Location = new System.Drawing.Point(351, 313);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(208, 34);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Minutos transcurridos:";
            // 
            // btnEnterObervation
            // 
            this.btnEnterObervation.BackColor = System.Drawing.Color.Black;
            this.btnEnterObervation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterObervation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnterObervation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnterObervation.Location = new System.Drawing.Point(135, 407);
            this.btnEnterObervation.Name = "btnEnterObervation";
            this.btnEnterObervation.Size = new System.Drawing.Size(424, 43);
            this.btnEnterObervation.TabIndex = 60;
            this.btnEnterObervation.Text = "Ingresar datos";
            this.btnEnterObervation.UseVisualStyleBackColor = false;
            this.btnEnterObervation.Click += new System.EventHandler(this.btnEnterObervation_Click);
            // 
            // frmSideEffect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTO_BD_POO_FINAL.Properties.Resources.sideeffects;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 462);
            this.Controls.Add(this.btnEnterObervation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "frmSideEffect";
            this.Text = "frmSideEffect";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox cbNone;
        private System.Windows.Forms.CheckBox cbArtralgia;
        private System.Windows.Forms.CheckBox cbMialgia;
        private System.Windows.Forms.CheckBox cbFever;
        private System.Windows.Forms.CheckBox cbHeadache;
        private System.Windows.Forms.CheckBox cbFatigue;
        private System.Windows.Forms.CheckBox cbBlush;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbAnafilaxia;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnterObervation;
    }
}