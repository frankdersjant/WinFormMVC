using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormMVC.Controller;
using WinFormMVC.Controller.Interfaces;
using WinFormMVC.Model;
using WinFormMVC.Model.Interfaces;
using WinFormMVC.View;

namespace WinFormMVC
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            IMP3Player _MP3Player = new Mp3Player();
            IMP3Controller _MP3Controller = new MP3Controller(_MP3Player);

            Application.Run(new FrmMP3Display(_MP3Player, _MP3Controller));
        }
    }
}
