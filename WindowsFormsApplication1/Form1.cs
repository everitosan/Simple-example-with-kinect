using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Kinect;
using Coding4Fun.Kinect.WinForm;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private KinectSensor Ksensor;

        public Form1()
        {
            InitializeComponent();
        }

        private void TriggerBtn_Click(object sender, EventArgs e)
        {
            if (TriggerBtn.Text == "Stream")
            {
                if (KinectSensor.KinectSensors.Count > 0)
                {
                    Ksensor = KinectSensor.KinectSensors[0];
                    KinectSensor.KinectSensors.StatusChanged += KinnectSensor_statusChanged;
                    TriggerBtn.Text = "Stop";
                    Ksensor.Start();
                    connectionText.Text = Ksensor.DeviceConnectionId;

                    Ksensor.ColorStream.Enable(ColorImageFormat.RgbResolution640x480Fps30);
                    Ksensor.ColorFrameReady += Ksensor_ColorFrameReady;
                }
            }
            else {
                TriggerBtn.Text = "Stream";
                if (Ksensor != null)
                {
                    Ksensor.Stop();
                }
            }

        }

        private void Ksensor_ColorFrameReady(object sender, ColorImageFrameReadyEventArgs e)
        {
            using (var frame = e.OpenColorImageFrame())
            {
                if (frame != null)
                {
                    streamBox.Image = CreateBimapFromsensor(frame);
                }
            }

        }

        private void KinnectSensor_statusChanged(object sender, StatusChangedEventArgs e)
        {
            statusText.Text = Ksensor.Status.ToString();
        }

        private Bitmap CreateBimapFromsensor(ColorImageFrame Frame)
        {
            var pixelData = new byte[Frame.PixelDataLength];
            Frame.CopyPixelDataTo(pixelData);

            return pixelData.ToBitmap(Frame.Width, Frame.Height);

           /* var stride = Frame.Width * Frame.BytesPerPixel;
            var bmpFrame = new Bitmap(Frame.Width, Frame.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb );
            var bpmData = bmpFrame.LockBits( new Rectangle(0,0,streamBox.Width, streamBox.Height), System.Drawing.Imaging.ImageLockMode.WriteOnly, bmpFrame.PixelFormat);

            System.Runtime.InteropServices.Marshal.Copy(pixelData, 0, bpmData.Scan0, Frame.PixelDataLength);

            bmpFrame.UnlockBits(bpmData);

            return bmpFrame;*/

        }
    }
}
