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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.7.103:8040/;";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.3.246/stream/105/";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://trkvz-radyolar.ercdn.net/asporradyo/playlist.m3u8";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.close();
            this.Close();
            Radyo spor = new Radyo();
            spor.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://ssldyg.radyotvonline.com/smil/smil:ntvspor.smil/playlist.m3u8";
        }
    }
}
