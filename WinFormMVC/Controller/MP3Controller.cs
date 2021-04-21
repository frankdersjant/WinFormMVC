using WinFormMVC.Controller.Interfaces;
using WinFormMVC.Model.Interfaces;

namespace WinFormMVC.Controller
{
    public class MP3Controller : IMP3Controller
    {
        private IMP3Player _MP3Player;

        public MP3Controller(IMP3Player MP3Player)
        {
            _MP3Player = MP3Player;
        }

        public void Next()
        {
            _MP3Player.Next();
        }

        public void Play()
        {
            _MP3Player.Play();
        }

        public void Stop()
        {
            _MP3Player.Stop();
        }

        public void VolumeDown()
        {
            int vol = _MP3Player.VolumeLevel;
            _MP3Player.SetVolume(--vol);
        }

        public void VolumeUp()
        {
            int vol = _MP3Player.VolumeLevel;
            _MP3Player.SetVolume(++vol);
        }
    }
}
