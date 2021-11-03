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

        public Image Imagefromform1 { get; set; } //a public variable that makes it able to get pictures from Form1

        

 
       
        public Form2(Image im)
        { 
            Imagefromform1 =im;
            InitializeComponent();
            pictureBoxform2.Image = Imagefromform1;
        }
        
       
    }
}
