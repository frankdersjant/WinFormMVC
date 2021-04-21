using WinFormMVC.View.Interfaces;

namespace WinFormMVC.Model.Interfaces
{
    public interface IMP3Player
    {
        void Play();
        void Stop();
        void Next();
        void SetVolume(int volumeLevel);

        Song CurrentSong { get; }
        bool isPlaying { get; }
        int VolumeLevel { get; }

        void AddObserver(ISongObserver songObserver);
        void AddObserver(IVolumeObserver volumeObserver);
    }
}
