using System;
using System.Windows.Forms;
using WinFormMVC.Model.Interfaces;
using WinFormMVC.View.Interfaces;

namespace WinFormMVC.View
{
    public partial class FrmVolumeDisplay : Form, IVolumeObserver
    {
        private IMP3Player _IMP3Player;
        public FrmVolumeDisplay(IMP3Player IMP3Player)
        {
            InitializeComponent();

            _IMP3Player = IMP3Player;
            _IMP3Player.AddObserver(this);
        }

        public void Update(int Currentvolume)
        {
            progressBarVolume.Value = Currentvolume;
            labelVolume.Text = Currentvolume.ToString();
        }

        private void FrmVolumeDisplay_Load(object sender, EventArgs e)
        {
            progressBarVolume.Minimum = 0;
            progressBarVolume.Maximum = 100;
            progressBarVolume.Value = _IMP3Player.VolumeLevel;  
        }
    }
}
