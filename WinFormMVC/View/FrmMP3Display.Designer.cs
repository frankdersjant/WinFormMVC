
namespace WinFormMVC.View
{
    partial class FrmMP3Display
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
            this.btnPlayMe = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnVolumeUp = new System.Windows.Forms.Button();
            this.btnVolumeDown = new System.Windows.Forms.Button();
            this.lblSong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlayMe
            // 
            this.btnPlayMe.Location = new System.Drawing.Point(126, 178);
            this.btnPlayMe.Name = "btnPlayMe";
            this.btnPlayMe.Size = new System.Drawing.Size(195, 34);
            this.btnPlayMe.TabIndex = 0;
            this.btnPlayMe.Text = "Play Me";
            this.btnPlayMe.UseVisualStyleBackColor = true;
            this.btnPlayMe.Click += new System.EventHandler(this.btnPlayMe_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(327, 184);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnVolumeUp
            // 
            this.btnVolumeUp.Location = new System.Drawing.Point(199, 126);
            this.btnVolumeUp.Name = "btnVolumeUp";
            this.btnVolumeUp.Size = new System.Drawing.Size(75, 23);
            this.btnVolumeUp.TabIndex = 2;
            this.btnVolumeUp.Text = "Volume Up";
            this.btnVolumeUp.UseVisualStyleBackColor = true;
            this.btnVolumeUp.Click += new System.EventHandler(this.btnVolumeUp_Click);
            // 
            // btnVolumeDown
            // 
            this.btnVolumeDown.Location = new System.Drawing.Point(182, 229);
            this.btnVolumeDown.Name = "btnVolumeDown";
            this.btnVolumeDown.Size = new System.Drawing.Size(92, 23);
            this.btnVolumeDown.TabIndex = 3;
            this.btnVolumeDown.Text = "Volume Down";
            this.btnVolumeDown.UseVisualStyleBackColor = true;
            // 
            // lblSong
            // 
            this.lblSong.AutoSize = true;
            this.lblSong.Location = new System.Drawing.Point(126, 50);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(83, 15);
            this.lblSong.TabIndex = 4;
            this.lblSong.Text = "Current Song: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 5;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(126, 86);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(47, 15);
            this.lblVolume.TabIndex = 6;
            this.lblVolume.Text = "Volume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 7;
            // 
            // FrmMP3Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 355);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSong);
            this.Controls.Add(this.btnVolumeDown);
            this.Controls.Add(this.btnVolumeUp);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPlayMe);
            this.Name = "FrmMP3Display";
            this.Text = "MP3 Display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayMe;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnVolumeUp;
        private System.Windows.Forms.Button btnVolumeDown;
        private System.Windows.Forms.Label lblSong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label label4;
    }
}