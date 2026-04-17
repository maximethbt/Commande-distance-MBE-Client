using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace Commande_distance_MBE_Client
{
    internal class MBEClient
    {
        private NetworkStream stream;
        private TcpClient client;
        private byte[] buffer = new byte[1024];
        public bool IsConnected { get; private set; }
        public MBEClient(string IP, int Port)
        {
            client = new TcpClient();

            try
            {
                client.Connect(IP, Port);
                stream = client.GetStream();
                IsConnected = true;
            }
            catch (Exception ex)
            {
                IsConnected = false;
            }
            
        }

        public bool SendMessage(string Message)
        {
            byte[] messageBytes = Encoding.UTF8.GetBytes(Message);
            try
            {
                stream.Write(messageBytes, 0, messageBytes.Length);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Image RequestImage()
        {
            try
            {
                stream.WriteByte(0x01);
                byte[] sizeBytes = new byte[4];
                stream.Read(sizeBytes, 0, 4);
                int size = BitConverter.ToInt32(sizeBytes, 0);

                // Lire l'image
                byte[] imageBytes = new byte[size];
                int total = 0;
                while (total < size)
                {
                    int n = stream.Read(imageBytes, total, size - total);
                    if (n == 0) break;
                    total += n;
                }

                // Afficher
                MemoryStream ms = new MemoryStream(imageBytes);
                Image img = Image.FromStream(ms);
                return img;
            }
            catch
            {
                return null;
            }
            
        }

        public string ReadResponse()
        {
            try
            {
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                if (bytesRead == 0) return null;
                return Encoding.UTF8.GetString(buffer, 0, bytesRead);
            }
            catch
            {
                return null;
            }
        }


        public void Close()
        {
            if (stream != null) stream.Close();
            if (client != null) client.Close();
        }

    }
}
