using System;
using System.Collections.Generic;
using WinFormMVC.Model.Interfaces;
using WinFormMVC.View.Interfaces;

namespace WinFormMVC.Model
{
    public class Mp3Player : IMP3Player
    {
        private Song _currentSong;
        public Song CurrentSong { get { return _currentSong; } }

        public bool isPlaying { get { return isPlaying; } }

        public int VolumeLevel { get { return VolumeLevel; } }


        private List<ISongObserver> songObservers;

        private List<IVolumeObserver> volumeObservers;

        public Mp3Player()
        {
            _currentSong = null;

            songObservers = new List<ISongObserver>();
            volumeObservers = new List<IVolumeObserver>();
        }

        public void AddObserver(IVolumeObserver volumeObserver)
        {
            volumeObservers.Add(volumeObserver);
        }

        public void AddObserver(ISongObserver songObserver)
        {
            songObservers.Add(songObserver);
        }

        public void Next()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public void SetVolume(int volume)
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        private void NotifySongObservers()
        {
            foreach (ISongObserver songObserver in songObservers)
            {
                songObserver.Update(_currentSong);
            }
        }

        private void NotifyVolumeObservers()
        {
            foreach (IVolumeObserver volumeObserver in volumeObservers)
            {
                volumeObserver.Update(VolumeLevel);
            }
        }
    }
}
