using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rdyo
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radio-trtradyo1.live.trt.com.tr/master.m3u8";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radio-trtradyo3.live.trt.com.tr/master.m3u8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radio-trtvotworld.live.trt.com.tr/master.m3u8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radio-trtradyo6.live.trt.com.tr/master.m3u8";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radio-trtantalya.live.trt.com.tr/master.m3u8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radio-trtfm.live.trt.com.tr/master.m3u8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radio-trtnagme.live.trt.com.tr/master.m3u8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radio-trtturku.live.trt.com.tr/master.m3u8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radio-trtradyohaber.live.trt.com.tr/master.m3u8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radio-trtgap.live.trt.com.tr/master.m3u8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radio-trtcukurova.live.trt.com.tr/master.m3u8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radio-trterzurum.live.trt.com.tr/master.m3u8";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://eustr73.mediatriple.net/videoonlylive/mtikoimxnztxlive/broadcast_5e3c14192aa92.smil/playlist.m3u8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://eustr73.mediatriple.net/videoonlylive/mtikoimxnztxlive/broadcast_5e3c1171d7d2a.smil/playlist.m3u8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://eustr73.mediatriple.net/videoonlylive/mtikoimxnztxlive/broadcast_5e3c1520b2626.smil/playlist.m3u8";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.close();
            this.Close();
            Radyo ilk = new Radyo();
            ilk.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://trtcanlifm-lh.akamaihd.net/i/TRTVOTWORLD_1@182149/master.m3u8";
        }
    }
}
