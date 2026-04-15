using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Commande_distance_MBE_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MBEClient Client = new MBEClient("192.168.56.10", 9000);

            while (true)
            {
                Console.Write("> ");
                string message = Console.ReadLine();

                if (message == null || message.ToLower() == "quit")
                    break;

                if(!Client.SendMessage(message))
                    break;

                string Response = Client.ReadResponse();
                Console.WriteLine("Response : " + Response);
            }
            Console.WriteLine("Disconnected");
            Console.ReadKey();
        }
    }
}
