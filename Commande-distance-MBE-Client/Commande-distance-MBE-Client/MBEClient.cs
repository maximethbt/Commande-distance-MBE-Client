using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace Commande_distance_MBE_Client
{
    internal class MBEClient
    {
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

            Console.WriteLine("Connected");
        }
    }
}
