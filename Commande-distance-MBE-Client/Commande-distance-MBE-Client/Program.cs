using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commande_distance_MBE_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MBEClient Client = new MBEClient("192.168.56.10", 9000);
        }
    }
}
