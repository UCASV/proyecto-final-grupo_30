
namespace PROYECTO_BD_POO_FINAL.View
{
    partial class frmLoading
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
            this.picBoxLoadingGif = new System.Windows.Forms.PictureBox();
            this.lblLoadingText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLoadingGif)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxLoadingGif
            // 
            this.picBoxLoadingGif.Dock = System.Windows.Forms.DockStyle.Left;
            this.picBoxLoadingGif.Image = global::PROYECTO_BD_POO_FINAL.Properties.Resources.EXfY;
            this.picBoxLoadingGif.Location = new System.Drawing.Point(0, 0);
            this.picBoxLoadingGif.Name = "picBoxLoadingGif";
            this.picBoxLoadingGif.Size = new System.Drawing.Size(128, 128);
            this.picBoxLoadingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLoadingGif.TabIndex = 0;
            this.picBoxLoadingGif.TabStop = false;
            // 
            // lblLoadingText
            // 
            this.lblLoadingText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoadingText.Location = new System.Drawing.Point(143, 9);
            this.lblLoadingText.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblLoadingText.Name = "lblLoadingText";
            this.lblLoadingText.Size = new System.Drawing.Size(150, 110);
            this.lblLoadingText.TabIndex = 1;
            this.lblLoadingText.Text = "Procesando cita...";
            this.lblLoadingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLoading
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(308, 128);
            this.Controls.Add(this.lblLoadingText);
            this.Controls.Add(this.picBoxLoadingGif);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoading";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.frmLoading_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLoadingGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxLoadingGif;
        private System.Windows.Forms.Label lblLoadingText;
    }
}