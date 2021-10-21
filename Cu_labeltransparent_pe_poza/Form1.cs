using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cu_labeltransparent_pe_poza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            wmp.URL = "sabaton.mp3";
            wmp.Ctlcontrols.fastForward();
            wmp.Ctlcontrols.play();
        }
    }
}
