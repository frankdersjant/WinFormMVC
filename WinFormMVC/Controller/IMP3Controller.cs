using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormMVC.Controller
{
    public interface IMP3Controller
    {
        void Play();
        void Stop();
        void Next();
        void VolumeUp();
        void VolumeDown();
    }
}
