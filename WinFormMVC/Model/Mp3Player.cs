using System;
using System.Collections.Generic;
using System.Linq;
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


        private List<Song> _playList;

        private List<ISongObserver> songObservers;

        private List<IVolumeObserver> volumeObservers;

        public Mp3Player()
        {
            _playList = new List<Song>();

            CreatePlaylist();

            _currentSong = _playList.First();

            _IsPlaying = false;
            _VolumeLevel = 1;

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
            Song Currunt = _currentSong;

            _currentSong = _playList.SkipWhile(x => x.SongId != _currentSong.SongId).Skip(1).DefaultIfEmpty(_playList[0]).FirstOrDefault();

            NotifySongObservers();
        }

        public void Play()
        {
            NotifySongObservers();
        }

        public void SetVolume(int volume)
        {
            _VolumeLevel = volume;
            NotifyVolumeObservers();
        }

        public void Stop()
        {
            NotifySongObservers();
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

        private void CreatePlaylist()
        {
            Song newSoung1 = new Song(1, "TransMission", "Joy Division");
            Song newSoung2 = new Song(2, "Riverman", "Nick Drake");
            Song newSoung3 = new Song(3, "Overkill", "Motorhead");

            _playList.Add(newSoung1);
            _playList.Add(newSoung2);
            _playList.Add(newSoung3);
        }
    }
}
