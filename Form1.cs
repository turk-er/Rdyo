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
    public partial class Radyo : Form
    {
        
        public Radyo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 yeni = new Form3();
            yeni.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 yabancı = new Form4();
            yabancı.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 spor = new Form5();
            spor.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Haber Haber = new Haber();
            Haber.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 trt = new Form7();
            trt.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 din = new Form8();
            din.Show();
            this.Hide();
        }
    }
}
