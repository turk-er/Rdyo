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
    public partial class Haber : Form
    {
        public Haber()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radyo.duhnet.tv/cnnturk";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://ntvrdwmp.radyotvonline.com/";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://icecast-ruvr.cdnvideo.ru/rian.voicestm";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://mn-nl.mncdn.com/bloomberghtradyo/bloomberghtradyo/playlist.m3u8";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://anadolu.liderhost.com.tr:10876/;";
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
