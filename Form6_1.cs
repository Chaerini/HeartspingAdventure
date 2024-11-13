using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_HeartspingAdventure
{
    public partial class Form6_1 : Form
    {
        public Form6_1()
        {
            InitializeComponent();
            //  axWindowsMediaPlayer1.PlayStateChange += AxWindowsMediaPlayer1_PlayStateChange1;
        }

        private void AxWindowsMediaPlayer1_PlayStateChange1(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            //// MediaEnded 상태일 때 폼을 닫음
            //if (e.newState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            //{
            //    this.Close(); // 영상 재생이 끝나면 폼을 닫음
            //}

        }

        public void startVideo(string videoPath)
        {
            axWindowsMediaPlayer1.URL = videoPath;
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

    }
}
