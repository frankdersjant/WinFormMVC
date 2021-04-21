using System.Windows.Forms;
using WinFormMVC.Controller;
using WinFormMVC.Model;
using WinFormMVC.Model.Interfaces;
using WinFormMVC.View.Interfaces;

namespace WinFormMVC.View
{
    public partial class FrmMP3Display : Form, ISongObserver, IVolumeObserver
    {
        private IMP3Player _MP3Player;
        private IMP3Controller _MP3Controller;

        public FrmMP3Display(IMP3Player mP3Player, IMP3Controller mP3Controller)
        {
            InitializeComponent();

            _MP3Player = mP3Player;
            _MP3Controller = mP3Controller;
        }

        public void Update(Song CurrentSong)
        {

            if (CurrentSong is null)
                label2.Text = "Not playing...";
            else
                label2.Text = string.Format("{0} ({1})", CurrentSong.Title, CurrentSong.Artists);
        }

        public void Update(int Currentvolume)
        {
            lblVolume.Text = Currentvolume.ToString();
        }

        private void btnPlayMe_Click(object sender, System.EventArgs e)
        {
            if (_MP3Player.isPlaying)
                _MP3Controller.Stop();
            else
                _MP3Controller.Play();
        }
    }
}
