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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://18463.live.streamtheworld.com/METRO_FM128AAC.aac";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://37.59.205.232:7796/;";
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.close();
            this.Close();
            Radyo ilk = new Radyo();
            ilk.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://powerfm.listenpowerapp.com/powerfm/mpeg/icecast.audio";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://17773.live.streamtheworld.com/JOY_FMAAC.aac";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://provisioning.streamtheworld.com/pls/SC010_SO1AAC.pls";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://n10101m.mediatriple.net/videoonlylive/mtkgeuihrlfwlive/u_stream_5c9e2f95dcb16_1/playlist.m3u8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://17753.live.streamtheworld.com/KISS_FM128AAC.aac";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://listen.radyofenomen.com/fenomen/128/icecast.audio";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://stream.radyoodtu.com.tr/canli;";
        }
    }
}
