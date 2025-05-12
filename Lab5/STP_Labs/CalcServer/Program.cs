using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace CalcServer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CalcService)))
            {
                host.Open();
                Console.WriteLine("Server was started");
                Console.WriteLine("Press <Enter> to close!!!");
                Console.ReadLine();
            }
        }
    }
}
