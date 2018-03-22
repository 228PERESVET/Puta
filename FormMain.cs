using Emgu.CV;
using Emgu.CV.CvEnum;
using System;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace PERESVET228
{
    public partial class FormMain : Form
    {
        VideoCapture cp;
        PeresvetNetwork pn;

        delegate void del(string str);
        delegate void delEn(bool b);

        public FormMain()
        {

            InitializeComponent();

            cp = new VideoCapture();
            cp.SetCaptureProperty(CapProp.FrameCount, 2);
            cp.SetCaptureProperty(CapProp.FrameWidth, 320);
            cp.SetCaptureProperty(CapProp.FrameHeight, 240);
            cp.FlipType = FlipType.Horizontal;
            cp.ImageGrabbed += ImageGrab;

            pn = new PeresvetNetwork();
        }

        void ImageGrab(object s, EventArgs e)
        {

            try
            {
                Mat img = new Mat();
                cp.Retrieve(img);
                pn.SendData(img.Clone());
                pb_main.Image = img.Bitmap;
            }
            catch(Exception err)
            {
                bt_start.Invoke(new delEn((e1) => lb_sizeImg.Enabled = e1), true);
                cp.Stop();
                pn.StopNet();
            }
            Thread.Sleep(1000 / 1);
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            if (cp != null)
            {
                if (pn.run)
                {
                    pn.StopNet();
                    cp.Stop();
                    bt_start.Text = "Start";
                }
                else
                {
                    if (pn.GetIpAdress(tb_ipport.Text))
                    {
                        pn.StartNet();
                        cp.Start();
                        bt_start.Text = "Stop";
                    }
                    
                }
                
            }
                
        }
    }
}