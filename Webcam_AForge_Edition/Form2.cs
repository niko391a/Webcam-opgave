using AForge.Imaging.Filters;
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

            pictureBoxForm2.Image = Imagefromform1; //Displays the picture in the picturebox

            //Creation of greyscale filter
            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap bt = new Bitmap(pictureBoxForm2.Image);

            //applying the filter
            Bitmap grayImage = filter.Apply(bt);
            pictureBoxForm2.Image = (System.Drawing.Image)grayImage.Clone(); //clones the picture grayImage and displays it on the left

            
            



        }



    }
}
