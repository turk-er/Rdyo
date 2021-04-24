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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://37.247.100.104/stream/552/";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.7.125/listen.pls";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://18463.live.streamtheworld.com/JOY_TURKAAC.aac";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radyo.duhnet.tv/radyod";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.3.204:80/";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.3.201:80/";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://shoutcast.radyogrup.com:1010/;";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://listen.powerapp.com.tr/powerturk/abr/powerturk/128/playlist.m3u8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://yonradyo.radyolarburada.com:8020/;";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.3.229/;";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://listen.radyofenomen.com/fenomenturk/128/icecast.audio";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.7.100/stream/170/";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radyo.duhnet.tv/slowturk";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://17703.live.streamtheworld.com/SUPER_FM128AAC.aac";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://m.egm.gov.tr:8095/;";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://yayin.radyoseymen.com.tr:1070/;stream.mp3";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.close();
            this.Close();
            Radyo ilk = new Radyo();
            ilk.Show();
        }
    }
}
