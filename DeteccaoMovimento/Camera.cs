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
    public partial class Camera : Form
    {
        public Camera()
        {
            InitializeComponent();
        }
       
        VideoCaptureDevice fontedeVideo;

        //variaveis para detecção
        MotionDetector deteccao;
        float nivelDedeteccao;
        FilterInfoCollection dispt;
        private void Camera_Load(object sender, EventArgs e)
        {
           

            // carregar os dispositivos no combox
            deteccao = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionBorderHighlighting());
            nivelDedeteccao = 0;
            dispt = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo x in dispt)
            {

                gerenciarCamera.Items.Add(x.Name);
            }
            gerenciarCamera.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Form1 addcamera = new Form1(fontedeVideo);

            fontedeVideo = new VideoCaptureDevice(dispt[gerenciarCamera.SelectedIndex].MonikerString);
           // videoSourcePlayer1.VideoSource = fontedeVideo;
           
            Close();
        }
    }
}
