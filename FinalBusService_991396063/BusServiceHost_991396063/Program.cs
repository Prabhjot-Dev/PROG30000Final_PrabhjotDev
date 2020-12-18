using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace BusServiceHost_991396063
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(FinalBusService_991396063.BusService_991396063)))
            {
                host.Open();
                Console.WriteLine("PROG30000 Final Exam by Prabhjot Dev, 991396063");
                Console.WriteLine("Host is running...started at: " + DateTime.Now);
                Console.ReadKey();
            }
        }
    }
}
