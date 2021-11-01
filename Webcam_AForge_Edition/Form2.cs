using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Webcam_AForge_Edition
{
    public partial class Form2 : Form
    {

        public Image Imagefromform1 { get; set; }

        //public Bitmap Imagefromform1 { get; set; }

        Stack<Bitmap> imageStack; //stack of bitmap pictures (pictures from webcam is bitmap) is initialized
        internal GlobalVars gv;  // Instantiate Global Var
        public Form2()
        {
            InitializeComponent();
            
    }
        private FilterInfoCollection CaptureDevices;
        private VideoCaptureDevice videosource;

        public void OldPicture()
        {
            
        }

        public void chart1_Click(object sender, EventArgs e)
        {
            

        }

        public void pictureBoxform2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            pictureBoxform2.Image = Imagefromform1;

            //gv.VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice); //gives all video devices and put them in a list
            //foreach (FilterInfo VideoCaptureDevice in gv.VideoCaptureDevices) //filtering of list
            //{
            //    comboBoxCameraList.Items.Add(VideoCaptureDevice.Name);
            //}
            //comboBox1.SelectedIndex = 0;
            //videosource = new VideoCaptureDevice;

        }
    }
}
