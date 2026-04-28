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
        Image img;
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
            textBox_IP.Text = "192.168.56.10";
            textBox_Port.Text = "9000";
            
        }

        private void button_Screenshot_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() =>
            {
                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                while (true)
                {
                    sw.Reset();
                    sw.Start();
                    Image frame = Client.RequestImage();
                    sw.Stop();
                    long networkMs = sw.ElapsedMilliseconds;
                    if (frame == null) break;

                    sw.Reset();
                    sw.Start();
                    this.Invoke(new Action(() =>
                    {
                        if (pictureBox_Screenshot.Image != null)
                            pictureBox_Screenshot.Image.Dispose();
                        pictureBox_Screenshot.Image = frame;
                    }));
                    sw.Stop();
                    long uiMs = sw.ElapsedMilliseconds;

                    System.Diagnostics.Debug.WriteLine(
                        "Network: " + networkMs + "ms | UI: " + uiMs + "ms");

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
            catch(Exception ex)
            {
                label_Status.Text = "Connection attempt failed";
            }
            if (Client.IsConnected)
                label_Status.Text = "Connected";
           
        }

    }
}
