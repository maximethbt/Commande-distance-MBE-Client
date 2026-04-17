using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            textBox_IP.Text = "192.168.56.10";
            textBox_Port.Text = "9000";
            
        }

        private void button_Screenshot_Click(object sender, EventArgs e)
        {
            Image img = Client.RequestImage();
            if (img == null)
            {
                label_Status.Text = "Erreur de reception";
                return;
            }
            pictureBox_Screenshot.Image = img;
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
