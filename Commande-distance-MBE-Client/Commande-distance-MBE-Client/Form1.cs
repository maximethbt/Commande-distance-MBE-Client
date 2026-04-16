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
        MBEClient Client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Client = new MBEClient("192.168.56.10", 9000);
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            if (!Client.SendMessage(textBox_Message.Text))
            {
                label_Status.Text = "Serveur deconnecte";
                return;
            }

            string reponse = Client.ReadResponse();
            if (reponse == null)
            {
                label_Status.Text = "Serveur deconnecte";
                return;
            }

            Label_Response.Text = reponse;
            textBox_Message.Clear();
        }


    }
}
