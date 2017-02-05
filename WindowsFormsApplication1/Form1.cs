using System;
using System.Drawing;
using System.Windows.Forms;

using Microsoft.Kinect;
using Coding4Fun.Kinect.WinForm;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private KinectSensor Ksensor;
        private byte[] pixelData;

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
                    
                    Ksensor.SkeletonStream.Enable();
                    Ksensor.SkeletonFrameReady += Ksensor_SkeletonFrameReady; ;
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

        private void Ksensor_SkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs e)
        {
            using (var sk_frame = e.OpenSkeletonFrame())
                if (sk_frame != null)
                    DetectSkeleton(sk_frame);
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

        private void DetectSkeleton(SkeletonFrame frame)
        {
            Skeleton[] skData;
            skData = new Skeleton[frame.SkeletonArrayLength];
            frame.CopySkeletonDataTo(skData);

            foreach (Skeleton sk in skData)
            {
                //test if he skeleton it's trackable
                if (sk.TrackingState == SkeletonTrackingState.Tracked)
                {
                    Joint head = sk.Joints[JointType.Head];
                    SkeletonPoint head_pos = head.Position;
                    position.Text = string.Format("Head is in x: {0}, y: {1}, z: {2}", head_pos.X, head_pos.Y, head_pos.Z);
                }
            }
        }

        private Bitmap CreateBimapFromsensor(ColorImageFrame Frame)
        {
            pixelData = new byte[Frame.PixelDataLength];
            Frame.CopyPixelDataTo(pixelData);

           return pixelData.ToBitmap(Frame.Width, Frame.Height);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
