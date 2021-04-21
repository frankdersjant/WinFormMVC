
namespace WinFormMVC.View
{
    partial class FrmVolumeDisplay
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
            this.progressBarVolume = new System.Windows.Forms.ProgressBar();
            this.labelVolume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBarVolume
            // 
            this.progressBarVolume.Location = new System.Drawing.Point(31, 43);
            this.progressBarVolume.Name = "progressBarVolume";
            this.progressBarVolume.Size = new System.Drawing.Size(232, 23);
            this.progressBarVolume.TabIndex = 0;
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(113, 43);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(38, 15);
            this.labelVolume.TabIndex = 1;
            this.labelVolume.Text = "label1";
            // 
            // FrmVolumeDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 124);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.progressBarVolume);
            this.Name = "FrmVolumeDisplay";
            this.Text = "Volume Display";
            this.Load += new System.EventHandler(this.FrmVolumeDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarVolume;
        private System.Windows.Forms.Label labelVolume;
    }
}