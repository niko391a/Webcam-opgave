namespace Webcam_AForge_Edition
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imgVideo = new System.Windows.Forms.PictureBox();
            this.buttonCapture = new System.Windows.Forms.Button();
            this.comboBoxCameraList = new System.Windows.Forms.ComboBox();
            this.buttonCamStart = new System.Windows.Forms.Button();
            this.imgCapture = new System.Windows.Forms.PictureBox();
            this.buttonGray = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonStop = new System.Windows.Forms.Button();
            this.Rbutton = new System.Windows.Forms.Button();
            this.Bbutton = new System.Windows.Forms.Button();
            this.Gbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.previousPicture = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonToggleTimer = new System.Windows.Forms.Button();
            this.fastGray = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.buttonBlobDetection = new System.Windows.Forms.Button();
            this.horizontalTracking = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previousPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalTracking)).BeginInit();
            this.SuspendLayout();
            // 
            // imgVideo
            // 
            this.imgVideo.Location = new System.Drawing.Point(9, 32);
            this.imgVideo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgVideo.Name = "imgVideo";
            this.imgVideo.Size = new System.Drawing.Size(362, 243);
            this.imgVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgVideo.TabIndex = 0;
            this.imgVideo.TabStop = false;
            // 
            // buttonCapture
            // 
            this.buttonCapture.BackColor = System.Drawing.Color.Red;
            this.buttonCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCapture.ForeColor = System.Drawing.Color.White;
            this.buttonCapture.Location = new System.Drawing.Point(13, 321);
            this.buttonCapture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCapture.Name = "buttonCapture";
            this.buttonCapture.Size = new System.Drawing.Size(358, 45);
            this.buttonCapture.TabIndex = 1;
            this.buttonCapture.Text = "Capture";
            this.buttonCapture.UseVisualStyleBackColor = false;
            this.buttonCapture.Click += new System.EventHandler(this.buttonCapture_Click);
            // 
            // comboBoxCameraList
            // 
            this.comboBoxCameraList.FormattingEnabled = true;
            this.comboBoxCameraList.Location = new System.Drawing.Point(11, 436);
            this.comboBoxCameraList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCameraList.Name = "comboBoxCameraList";
            this.comboBoxCameraList.Size = new System.Drawing.Size(92, 21);
            this.comboBoxCameraList.TabIndex = 2;
            // 
            // buttonCamStart
            // 
            this.buttonCamStart.Location = new System.Drawing.Point(108, 435);
            this.buttonCamStart.Name = "buttonCamStart";
            this.buttonCamStart.Size = new System.Drawing.Size(75, 23);
            this.buttonCamStart.TabIndex = 3;
            this.buttonCamStart.Text = "Start";
            this.buttonCamStart.UseVisualStyleBackColor = true;
            this.buttonCamStart.Click += new System.EventHandler(this.buttonCamStart_Click);
            // 
            // imgCapture
            // 
            this.imgCapture.Location = new System.Drawing.Point(375, 32);
            this.imgCapture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgCapture.Name = "imgCapture";
            this.imgCapture.Size = new System.Drawing.Size(358, 243);
            this.imgCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCapture.TabIndex = 4;
            this.imgCapture.TabStop = false;
            // 
            // buttonGray
            // 
            this.buttonGray.Location = new System.Drawing.Point(268, 435);
            this.buttonGray.Name = "buttonGray";
            this.buttonGray.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonGray.Size = new System.Drawing.Size(75, 23);
            this.buttonGray.TabIndex = 8;
            this.buttonGray.Text = "Gray scale";
            this.buttonGray.UseVisualStyleBackColor = true;
            this.buttonGray.Click += new System.EventHandler(this.buttonGrayscale_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.resolutionToolStripMenuItem,
            this.displayToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // resolutionToolStripMenuItem
            // 
            this.resolutionToolStripMenuItem.Name = "resolutionToolStripMenuItem";
            this.resolutionToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.resolutionToolStripMenuItem.Text = "&Resolution";
            this.resolutionToolStripMenuItem.Click += new System.EventHandler(this.resolutionToolStripMenuItem_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(57, 22);
            this.displayToolStripMenuItem.Text = "Display";
            this.displayToolStripMenuItem.Click += new System.EventHandler(this.displayToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseFileToolStripMenuItem,
            this.saveFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // chooseFileToolStripMenuItem
            // 
            this.chooseFileToolStripMenuItem.Name = "chooseFileToolStripMenuItem";
            this.chooseFileToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.chooseFileToolStripMenuItem.Text = "Choose File";
            this.chooseFileToolStripMenuItem.Click += new System.EventHandler(this.chooseFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(187, 435);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 11;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // Rbutton
            // 
            this.Rbutton.BackColor = System.Drawing.Color.Brown;
            this.Rbutton.Dock = System.Windows.Forms.DockStyle.Left;
            this.Rbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbutton.ForeColor = System.Drawing.Color.White;
            this.Rbutton.Location = new System.Drawing.Point(0, 0);
            this.Rbutton.Name = "Rbutton";
            this.Rbutton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Rbutton.Size = new System.Drawing.Size(119, 43);
            this.Rbutton.TabIndex = 12;
            this.Rbutton.Text = "R-channel";
            this.Rbutton.UseVisualStyleBackColor = false;
            this.Rbutton.Click += new System.EventHandler(this.Rbutton_Click);
            // 
            // Bbutton
            // 
            this.Bbutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.Bbutton.Dock = System.Windows.Forms.DockStyle.Right;
            this.Bbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bbutton.ForeColor = System.Drawing.Color.White;
            this.Bbutton.Location = new System.Drawing.Point(239, 0);
            this.Bbutton.Name = "Bbutton";
            this.Bbutton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Bbutton.Size = new System.Drawing.Size(119, 43);
            this.Bbutton.TabIndex = 13;
            this.Bbutton.Text = "B-channel";
            this.Bbutton.UseVisualStyleBackColor = false;
            this.Bbutton.Click += new System.EventHandler(this.Bbutton_Click);
            // 
            // Gbutton
            // 
            this.Gbutton.BackColor = System.Drawing.Color.ForestGreen;
            this.Gbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbutton.ForeColor = System.Drawing.Color.White;
            this.Gbutton.Location = new System.Drawing.Point(120, 0);
            this.Gbutton.Name = "Gbutton";
            this.Gbutton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Gbutton.Size = new System.Drawing.Size(119, 43);
            this.Gbutton.TabIndex = 14;
            this.Gbutton.Text = "G-channel";
            this.Gbutton.UseVisualStyleBackColor = false;
            this.Gbutton.Click += new System.EventHandler(this.Gbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 291);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(375, 321);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(358, 45);
            this.button1.TabIndex = 16;
            this.button1.Text = "RGB-Channels";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Rbutton);
            this.panel1.Controls.Add(this.Bbutton);
            this.panel1.Controls.Add(this.Gbutton);
            this.panel1.Location = new System.Drawing.Point(375, 367);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 43);
            this.panel1.TabIndex = 17;
            // 
            // previousPicture
            // 
            this.previousPicture.Location = new System.Drawing.Point(564, 2);
            this.previousPicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.previousPicture.Name = "previousPicture";
            this.previousPicture.Size = new System.Drawing.Size(50, 26);
            this.previousPicture.TabIndex = 19;
            this.previousPicture.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonToggleTimer
            // 
            this.buttonToggleTimer.BackColor = System.Drawing.Color.Red;
            this.buttonToggleTimer.Location = new System.Drawing.Point(349, 437);
            this.buttonToggleTimer.Name = "buttonToggleTimer";
            this.buttonToggleTimer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonToggleTimer.Size = new System.Drawing.Size(116, 23);
            this.buttonToggleTimer.TabIndex = 21;
            this.buttonToggleTimer.Text = "Toggle Auto Capture";
            this.buttonToggleTimer.UseVisualStyleBackColor = false;
            this.buttonToggleTimer.Click += new System.EventHandler(this.buttonToggleTimer_Click_1);
            // 
            // fastGray
            // 
            this.fastGray.BackColor = System.Drawing.Color.Red;
            this.fastGray.Location = new System.Drawing.Point(470, 435);
            this.fastGray.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fastGray.Name = "fastGray";
            this.fastGray.Size = new System.Drawing.Size(125, 23);
            this.fastGray.TabIndex = 22;
            this.fastGray.Text = "Toggle Auto grayscale";
            this.fastGray.UseVisualStyleBackColor = false;
            this.fastGray.Click += new System.EventHandler(this.fastGray_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(470, 410);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(4, 4);
            this.button3.TabIndex = 23;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // buttonBlobDetection
            // 
            this.buttonBlobDetection.Location = new System.Drawing.Point(599, 435);
            this.buttonBlobDetection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBlobDetection.Name = "buttonBlobDetection";
            this.buttonBlobDetection.Size = new System.Drawing.Size(91, 21);
            this.buttonBlobDetection.TabIndex = 24;
            this.buttonBlobDetection.Text = "Blob detection";
            this.buttonBlobDetection.UseVisualStyleBackColor = true;
            this.buttonBlobDetection.Click += new System.EventHandler(this.buttonBlobDetection_Click);
            // 
            // horizontalTracking
            // 
            this.horizontalTracking.Location = new System.Drawing.Point(375, 279);
            this.horizontalTracking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.horizontalTracking.Name = "horizontalTracking";
            this.horizontalTracking.Size = new System.Drawing.Size(358, 26);
            this.horizontalTracking.TabIndex = 25;
            this.horizontalTracking.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(744, 469);
            this.Controls.Add(this.horizontalTracking);
            this.Controls.Add(this.buttonBlobDetection);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.fastGray);
            this.Controls.Add(this.buttonToggleTimer);
            this.Controls.Add(this.previousPicture);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonGray);
            this.Controls.Add(this.imgCapture);
            this.Controls.Add(this.buttonCamStart);
            this.Controls.Add(this.comboBoxCameraList);
            this.Controls.Add(this.buttonCapture);
            this.Controls.Add(this.imgVideo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "WebCam Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previousPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalTracking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgVideo;
        private System.Windows.Forms.Button buttonCapture;
        private System.Windows.Forms.ComboBox comboBoxCameraList;
        private System.Windows.Forms.Button buttonCamStart;
        private System.Windows.Forms.PictureBox imgCapture;
        private System.Windows.Forms.Button buttonGray;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resolutionToolStripMenuItem;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button Rbutton;
        private System.Windows.Forms.Button Bbutton;
        private System.Windows.Forms.Button Gbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox previousPicture;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonToggleTimer;
        private System.Windows.Forms.Button fastGray;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button buttonBlobDetection;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.PictureBox horizontalTracking;
    }
}

