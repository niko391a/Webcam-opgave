
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;
using AForge.Imaging;

namespace Webcam_AForge_Edition
{
    public partial class Form1 : Form
    {
        //variable declaration
        Stack<Bitmap> imageStack; //stack of bitmap pictures (pictures from webcam is bitmap) is initialized
        internal GlobalVars gv;  // Instantiate Global Var
        int p = 1;

        public Form1()
        {
            InitializeComponent();
            buttonCamStart.Enabled = false; //doesn't enable webcam on startup
            gv = new GlobalVars(); // Initialize variable 
            previousPicture.Visible = false;
        }

        /**************************************************************************************/
        //
        /**************************************************************************************/
        private void Form1_Load(object sender, EventArgs e)
        {
            imageStack = new Stack<Bitmap>(); //instance of bitmap is created

            gv.VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice); //gives all video devices and put them in a list
            foreach (FilterInfo VideoCaptureDevice in gv.VideoCaptureDevices) //filtering of list
            {
                comboBoxCameraList.Items.Add(VideoCaptureDevice.Name);
            }
            if (comboBoxCameraList.Items.Count > 0)
            {
                comboBoxCameraList.SelectedIndex = 0;
                buttonCamStart.Enabled = true;
            }
            buttonStop.Enabled = false; //unable to click stop before start is clicked
            panel1.Visible = false;
        }

        /**************************************************************************************/
        //
        /**************************************************************************************/
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) //do you want to close?
        {
            DialogResult dr = MessageBox.Show("Sure you want to close?", "Are you sure?", MessageBoxButtons.YesNo);
            if (DialogResult.No == dr)
            {
                e.Cancel = true;
            }
            else
            {
                if (gv.FinalVideo != null)
                {
                    gv.FinalVideo.Stop(); //stops the webcam so the program can run correctly again
                    gv.FinalVideo.WaitForStop();
                }
                gv.FinalVideo = null;
            }
        }

        /**************************************************************************************/
        //
        /**************************************************************************************/
        void FinalVideo_NewFrame(object sender, NewFrameEventArgs eventArgs) //takes the picture in webcam and displays it to the screen
        {
            Bitmap video = (Bitmap)eventArgs.Frame.Clone();
            imgVideo.Image = video;

        }

        /**************************************************************************************/
        //
        /**************************************************************************************/
        private void buttonCapture_Click(object sender, EventArgs e)
        {
            try
            {
                imgCapture.Image = (System.Drawing.Image)imgVideo.Image.Clone(); //clones the picture on the left and displays it on the right as a still frame
                p = 1; //switch case variable
                buttonToggleTimer.Enabled = true;
                buttonGray.Enabled = true;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You need to choose a webcan and wait for the webcam to start");
            }
        }

        /**************************************************************************************/
        //
        /**************************************************************************************/
        private void buttonCamStart_Click(object sender, EventArgs e)
        {
            gv.FinalVideo = new VideoCaptureDevice(gv.VideoCaptureDevices[comboBoxCameraList.SelectedIndex].MonikerString); //the selected video feed is the one our combo box uses

            CameraSettings cs = new CameraSettings(gv);
            DialogResult dr = cs.ShowDialog(); //shows available presets for webcam such as resolution and bitcount

            if (DialogResult.OK == dr)
            {
                // Get vidoresolution possibilities
                VideoCapabilities[] vc = gv.FinalVideo.VideoCapabilities;
                // Get selected resolution
                int resolutionSelection = int.Parse(cs.tabControl1.SelectedTab.Text) - 1;  // Minus 1 due to 0 offset
                // Set camera resolution
                gv.FinalVideo.VideoResolution = vc[resolutionSelection];
                // Enable eventhandler
                gv.FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame); //eventhandler is started and we being to stream the video feed, finalvideo will be called when a new picture is created (fps)
                gv.FinalVideo.Start();
            }
        }


        /**************************************************************************************/
        //
        /**************************************************************************************/
        /// <summary>
        /// Convert captured picture to Grayscale.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void buttonGrayscale_Click(object sender, EventArgs e)
        {
            try
            {
                // 
                imageStack.Push(new Bitmap(imgCapture.Image)); //pushes captured image to stack
                //  undoToolStripMenuItem.Enabled = true;
                Bitmap bt = new Bitmap(imgCapture.Image); //copy the pushed image to varible bt
                for (int y = 0; y < bt.Height; y++)
                {
                    for (int x = 0; x < bt.Width; x++)
                    {
                        Color c = bt.GetPixel(x, y); //give me the color of a pixel

                        int avg = (c.R + c.G + c.B) / 3; //calculate average of pixel
                        bt.SetPixel(x, y, Color.FromArgb(avg, avg, avg)); //changes the pixel color to average (greyscale)
                    }
                }
                imgCapture.Image = bt; //the picture gets displayed on the right
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You need to capture a picture first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /**************************************************************************************/
        //
        /**************************************************************************************/
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Only if there is still something left on ehe stack
            if (imageStack.Count > 0) //checks if there is a picture in the stack (error handling)
            {
                imgCapture.Image = imageStack.Pop(); //pop the picture and put it back in the image capture
            }
            else
            {
                MessageBox.Show("You need to capture a picture first");
            }
        }

        /**************************************************************************************/
        //
        /**************************************************************************************/
        private void resolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gv.FinalVideo.SignalToStop();

            gv.FinalVideo.Stop(); //stops the video so we can make changes
            gv.FinalVideo.WaitForStop();
            gv.FinalVideo.NewFrame -= new NewFrameEventHandler(FinalVideo_NewFrame); //stops the processing of new images

            CameraSettings cs = new CameraSettings(gv); //displays settings again
            DialogResult dr = cs.ShowDialog();

            if (DialogResult.OK == dr) //starts the event and video feed again
            {
                VideoCapabilities[] vc = gv.FinalVideo.VideoCapabilities;
                int resolutionSelection = int.Parse(cs.tabControl1.SelectedTab.Text) - 1;  // Minus 1 due to 0 offset

                gv.FinalVideo.VideoResolution = vc[resolutionSelection];

                gv.FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
                gv.FinalVideo.Start();

                buttonCamStart.Enabled = false;
                buttonStop.Enabled = true;
                buttonCamStart.Enabled = false;
            }
        }

        /**************************************************************************************/
        //
        /**************************************************************************************/
        private void buttonStop_Click(object sender, EventArgs e) //stops the video feed
        {
            if (gv.FinalVideo != null) //if the video feed is running
            {
                gv.FinalVideo.Stop();
                gv.FinalVideo.WaitForStop();
            }
            gv.FinalVideo = null;
            buttonStop.Enabled = false;
            buttonCamStart.Enabled = true;
            buttonCapture.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
        }

        private void Rbutton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (p)
                {
                    case 1:
                        imageStack.Push(new Bitmap(imgCapture.Image)); //pushes captured image to stack
                                                                       //undoToolStripMenuItem.Enabled = true;
                        Bitmap bt = new Bitmap(imgCapture.Image); //copy the pushed image to varible bt
                        for (int y = 0; y < bt.Height; y++)
                        {
                            for (int x = 0; x < bt.Width; x++)
                            {
                                Color c = bt.GetPixel(x, y); //give me the color of a pixel

                                int avg = (c.R + c.G + c.B) / 3; //calculate average of pixel
                                bt.SetPixel(x, y, Color.FromArgb(255, avg, 0)); //changes the pixel colors so that it is red-scaled
                            }
                        }
                        imgCapture.Image = bt; //the picture gets displayed on the right
                        previousPicture.Image = bt; //the picture gets saved for later
                        p = 2;
                        label2.Text = Convert.ToString(p);
                        break;
                    case 2:                                                             //undoToolStripMenuItem.Enabled = true;
                        Bitmap bt2 = new Bitmap(previousPicture.Image); //copy the pushed image to varible bt
                        for (int y = 0; y < bt2.Height; y++)
                        {
                            for (int x = 0; x < bt2.Width; x++)
                            {
                                Color c = bt2.GetPixel(x, y); //give me the color of a pixel

                                int avg = (c.R + c.G + c.B) / 3; //calculate average of pixel
                                bt2.SetPixel(x, y, Color.FromArgb(255, avg, 0)); //changes the pixel colors so that it is red-scaled
                            }
                        }
                        imgCapture.Image = bt2; //the picture gets displayed on the right
                        label2.Text = Convert.ToString(p);
                        break;
                    default:
                        break;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You need to capture a picture first");
            }
        }

        private void Gbutton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (p)
                {
                    case 1:
                        imageStack.Push(new Bitmap(imgCapture.Image)); //pushes captured image to stack
                                                                       //undoToolStripMenuItem.Enabled = true;
                        Bitmap bt = new Bitmap(imgCapture.Image); //copy the pushed image to varible bt
                        for (int y = 0; y < bt.Height; y++)
                        {
                            for (int x = 0; x < bt.Width; x++)
                            {
                                Color c = bt.GetPixel(x, y); //give me the color of a pixel

                                int avg = (c.R + c.G + c.B) / 3; //calculate average of pixel

                                // The green attributes is set to 200 instead of 255 for a clearer picture after scale
                                bt.SetPixel(x, y, Color.FromArgb(avg, 200, 0)); //changes the pixel colors so that it is green-scaled
                            }
                        }
                        imgCapture.Image = bt; //the picture gets displayed on the right
                        previousPicture.Image = bt; //the picture gets saved for later
                        p = 2;
                        label2.Text = Convert.ToString(p);
                        break;
                    case 2:                                                             //undoToolStripMenuItem.Enabled = true;
                        Bitmap bt2 = new Bitmap(previousPicture.Image); //copy the pushed image to varible bt
                        for (int y = 0; y < bt2.Height; y++)
                        {
                            for (int x = 0; x < bt2.Width; x++)
                            {
                                Color c = bt2.GetPixel(x, y); //give me the color of a pixel

                                int avg = (c.R + c.G + c.B) / 3; //calculate average of pixel
                                bt2.SetPixel(x, y, Color.FromArgb(avg, 200, 0)); //changes the pixel colors so that it is green-scaled
                            }
                        }
                        imgCapture.Image = bt2; //the picture gets displayed on the right
                        label2.Text = Convert.ToString(p);
                        break;
                    default:
                        break;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You need to capture a picture first");
            }
        }

        private void Bbutton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (p)
                {
                    case 1:
                        imageStack.Push(new Bitmap(imgCapture.Image)); //pushes captured image to stack
                                                                       //undoToolStripMenuItem.Enabled = true;
                        Bitmap bt = new Bitmap(imgCapture.Image); //copy the pushed image to varible bt
                        for (int y = 0; y < bt.Height; y++)
                        {
                            for (int x = 0; x < bt.Width; x++)
                            {
                                Color c = bt.GetPixel(x, y); //give me the color of a pixel

                                int avg = (c.R + c.G + c.B) / 3; //calculate average of pixel
                                bt.SetPixel(x, y, Color.FromArgb(0, avg, 255)); //changes the pixel colors so that it is red-scaled
                            }
                        }
                        imgCapture.Image = bt; //the picture gets displayed on the right
                        previousPicture.Image = bt; //the picture gets saved for later
                        p = 2;
                        label2.Text = Convert.ToString(p);
                        break;
                    case 2:                                                             //undoToolStripMenuItem.Enabled = true;
                        Bitmap bt2 = new Bitmap(previousPicture.Image); //copy the pushed image to varible bt
                        for (int y = 0; y < bt2.Height; y++)
                        {
                            for (int x = 0; x < bt2.Width; x++)
                            {
                                Color c = bt2.GetPixel(x, y); //give me the color of a pixel

                                int avg = (c.R + c.G + c.B) / 3; //calculate average of pixel
                                bt2.SetPixel(x, y, Color.FromArgb(0, avg, 255)); //changes the pixel colors so that it is red-scaled
                            }
                        }
                        imgCapture.Image = bt2; //the picture gets displayed on the right
                        label2.Text = Convert.ToString(p);
                        break;
                    default:
                        break;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You need to capture a picture first");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            imgCapture.Image = (System.Drawing.Image)imgVideo.Image.Clone(); //clones the picture on the left and displays it on the right as a still frame
            p = 1; //switch case variable
        }

        private void buttonToggleTimer_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (timer1.Enabled == true)
                {
                    timer1.Enabled = false; //disables the timer so that it can't run the code in the specified interval
                }
                else
                {
                    timer1.Enabled = true; //enables the timer so that it can run the code in the specified interval
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You need to capture a picture first");
            }
        }

        private void timer2_Tick(object sender, EventArgs e) //a faster greyscale using aforge instead of couting each pixel
        {
            try
            {
                imgCapture.Image = (System.Drawing.Image)imgVideo.Image.Clone(); //clones the picture on the left and displays it on the right as a still frame

                //Push old image onto stack
                imageStack.Push(new Bitmap(imgCapture.Image));
                undoToolStripMenuItem.Enabled = true;

                //Creation of greyscale filter
                Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
                Bitmap bt = new Bitmap(imgCapture.Image);

                //applying the filter
                Bitmap grayImage = filter.Apply(bt);
                imgCapture.Image = (System.Drawing.Image)grayImage.Clone(); //clones the picture grayImage and displays it on the left
                p = 1; //switch case variable
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You need to capture a picture first");
            }
        }
        private void fastGray_Click_1(object sender, EventArgs e)
        {
            if (timer2.Enabled == true)
            {
                timer2.Enabled = false; //disables the timer so that it can't run the code in the specified interval
            }
            else
            {
                timer2.Enabled = true; //enables the timer so that it can run the code in the specified interval
            }
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 NewForm = new Form2(imgCapture.Image);
            NewForm.Show();
        }
    }
}
