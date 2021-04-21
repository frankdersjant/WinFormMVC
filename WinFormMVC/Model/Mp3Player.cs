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

        private bool _IsPlaying;
        public bool isPlaying { get { return _IsPlaying; } }

        private int _VolumeLevel;
        public int VolumeLevel { get { return _VolumeLevel; } }


        private List<ISongObserver> songObservers;

        private List<IVolumeObserver> volumeObservers;

        public Mp3Player()
        {
            _currentSong = null;
            _IsPlaying = true;
            _VolumeLevel = 0;

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
