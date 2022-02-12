using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Instanciar a webcam
using AForge.Video.DirectShow;
using AForge.Video;
//Detecção de movimento
using AForge.Vision.Motion;

namespace DeteccaoMovimento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Camera camera = new Camera();
        private void câmeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            camera.Show();
        }

       
    }
}
