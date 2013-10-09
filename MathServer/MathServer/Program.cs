using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Thrift.Server;
using Thrift.Transport;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MathServer handler = new MathServer();
                MathService.Processor processor = new MathService.Processor(handler);
                TServerTransport serverTransport = new TServerSocket(9095);
                TServer server = new TSimpleServer(processor, serverTransport);
                Console.WriteLine("Starting the server...");
                server.Serve();
            }
            catch (Exception x)
            {
                Console.WriteLine(x.StackTrace);
            }
            Console.WriteLine("done.");
        }
    }
}
