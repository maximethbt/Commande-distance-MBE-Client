using System;
using System.Collections.Generic;
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
        public MBEClient(string IP, int Port)
        {
            TcpClient client = new TcpClient();

            try
            {
                client.Connect(IP, Port);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Impossible to connect : " + ex.Message);
                Console.ReadKey();
                return;
            }
            stream = client.GetStream();
            Console.WriteLine("Connected");
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

        public string ReadResponse()
        {
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string reponse = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            return reponse;
        }

        public void Close()
        {
            stream.Close();
            client.Close();
        }

    }
}
