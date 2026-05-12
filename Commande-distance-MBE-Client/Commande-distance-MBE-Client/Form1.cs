using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Commande_distance_MBE_Client
{

    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetProcessDPIAware();
        MBEClient Client;
        public Form1()
        {
            SetProcessDPIAware();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox_IP.Text = "192.168.56.10";
            textBox_IP.Text = "169.254.27.80";

            textBox_Port.Text = "9000";

        }

        private void button_Screenshot_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() =>
            {
                while (true)
                {
                    Image img = Client.RequestImage();
                    if (img == null) break;
                    this.BeginInvoke(new Action(() =>
                    {
                        if (pictureBox_Screenshot.Image != null)
                            pictureBox_Screenshot.Image.Dispose();
                        pictureBox_Screenshot.Image = img;
                    }));
                }
            });
            t.IsBackground = true;
            t.Start();
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                Client = new MBEClient(textBox_IP.Text, Convert.ToInt32(textBox_Port.Text));
            }
            catch (Exception ex)
            {
                label_Status.Text = "Connection attempt failed";
            }
            if (Client.IsConnected)
                label_Status.Text = "Connected";

        }

        private void pictureBox_Screenshot_MouseMove(object sender, MouseEventArgs e)
        {
            int RealPosX = (e.X * 1680) / pictureBox_Screenshot.Width;
            int RealPosY = (e.Y * 1050) / pictureBox_Screenshot.Height;
            if (Client != null && Client.IsConnected)
                Client.SendMouseMove(RealPosX, RealPosY);
        }

        private void splitContainerMain_Panel2_SizeChanged(object sender, EventArgs e)
        {
            if(pictureBox_Screenshot.Image!=null)
            {
                float RatioImage = (float)pictureBox_Screenshot.Image.Width / pictureBox_Screenshot.Image.Height;
                float RatioPanel = (float)splitContainerMain.Width / splitContainerMain.Height;

                if (RatioImage >= RatioPanel)
                {
                    float Ratio = (float)splitContainerMain.Panel2.Width / pictureBox_Screenshot.Image.Width;
                    pictureBox_Screenshot.Width = (int)Math.Round(pictureBox_Screenshot.Image.Width * Ratio, 0);
                    pictureBox_Screenshot.Height = (int)Math.Round(pictureBox_Screenshot.Image.Height * Ratio, 0);
                }
                else
                {
                    float Ratio = (float)splitContainerMain.Panel2.Height / pictureBox_Screenshot.Image.Height;
                    pictureBox_Screenshot.Width = (int)Math.Round(pictureBox_Screenshot.Image.Width * Ratio, 0);
                    pictureBox_Screenshot.Height = (int)Math.Round(pictureBox_Screenshot.Image.Height * Ratio, 0);
                }
            }
            
        }
    }
}
