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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://mtisvwurbfcyslive.mediatriple.net/mtisvwurbfcyslive/broadcast_58e23cb112296.smil/playlist.m3u8";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://cdn3.akradyo.net/akracanli2/_definst_/livestream_aac/playlist.m3u8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://trkvz-radyolar.ercdn.net/radyovav/playlist.m3u8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://yayin1.canliyayin.org:8282/;stream.nsv";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://anadolu.liderhost.com.tr:10994/;";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://yayin.dostfm.com:8920/;";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://yayin1.canliyayin.org:8202/;stream.mp3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://37.247.98.8/stream/33/";
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
