using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace HLServer
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ourHl7Server = new OurSimpleMultiThreadedTcpServer();
            //starting the server
            ourHl7Server.StartOurTcpServer(1080);

            Console.WriteLine("Press any key to exit program...");
            Console.ReadLine();
        }
    }
}