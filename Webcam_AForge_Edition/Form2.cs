using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webcam_AForge_Edition
{
    public partial class Form2 : Form
    {

        public Image Imagefromform1 { get; set; }

        public Form2(Image im)
        {
            Imagefromform1 = im;
            InitializeComponent();
            pictureBoxForm2.Image = Imagefromform1;
        }



    }
}
