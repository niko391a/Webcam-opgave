using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Webcam_AForge_Edition
{
    public partial class Form2 : Form
    {
        int[] xData = new int[256];
        int[] yData = new int[256];
        
        
           
            

        public System.Drawing.Image Imagefromform1 { get; set; }

        public Form2(System.Drawing.Image im)
        {
            try
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
                pictureBoxOld.Image = (System.Drawing.Image)grayImage.Clone(); //clones the picture grayImage and displays it on the left
                //-----------------------------------------------------------------------------------------------------------------------------------

                // collect statistics
                ImageStatistics his = new ImageStatistics(grayImage);
                // get gray histogram (for grayscale image)
                Histogram histogram = his.Gray;

                // output some histogram's information
                System.Diagnostics.Debug.WriteLine("Mean = " + histogram.Mean);
                System.Diagnostics.Debug.WriteLine("Min = " + histogram.Min);
                System.Diagnostics.Debug.WriteLine("Max = " + histogram.Max);


                //-----------------------------------------------------------------------------------------------------------------------------------
                // series1
                //
                var series1 = new Series
                {
                    Name = "series1",
                    // Disse og mange andre kan bruges, hvis man vil sætte properties i runtime (altså under programkørslen)
                    //LegendText = "Series LegendText",
                    //IsVisibleInLegend = true,
                    //IsXValueIndexed = true,
                    Color = Color.Black,
                    ChartType = SeriesChartType.Column
                };

                // Add datapoints to Series
                for (int i = 0; i < histogram.Values.Count(); i++)
                {
                    series1.Points.AddXY(xData[i], histogram.Values[i]);
                }
                // Transfer series data to form chart series
                chart1.Series["Series1"] = series1;


                //// Add datapoints to Series
                //for (int i = 0; i < yData.Count(); i++)
                //{
                //    series1.Points.AddXY(histogram.Values, yData[i]);
                //}
                //// Transfer series data to form chart series
                //chart1.Series["Series1"] = series1;

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You need to capture a picture first");
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //Creation of greyscale filter so that the threshold is in correct format
            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            Bitmap bt = new Bitmap(pictureBoxOld.Image); //to prevent image from turning white a separate pictureBox was created to contain the original image

            //applying the filter
            Bitmap grayImage = filter.Apply(bt);

            // create thresholdfilter
            Threshold tfilter = new Threshold(trackBar1.Value); //sets the value of the trackbar as the threshold variable

            // apply the filter
            Bitmap thresh = tfilter.Apply(grayImage);
            pictureBoxForm2.Image = (System.Drawing.Image)thresh.Clone(); //clones the picture grayImage and displays it on the left

            label1.Text = Convert.ToString(trackBar1.Value); //visual feedback to user
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Closes Form2
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Closes Form2
            this.Close();
        }
    }
}

