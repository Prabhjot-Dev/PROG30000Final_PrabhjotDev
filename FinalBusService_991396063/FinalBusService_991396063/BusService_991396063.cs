using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FinalBusService_991396063
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BusService_991396063" in both code and config file together.
    public class BusService_991396063 : AuthenticateUserService, DBOperationsService
    {
        ABCBusDB_991396063Entities context = new ABCBusDB_991396063Entities();

        public string AuthenticateUser(string Name, string Password)
        {
            var user = context.Users.SingleOrDefault(u => u.UserName == Name);
            var password = context.Users.SingleOrDefault(u => u.Password == Password);

            if (user != null && password !=null)
            {
                return "Login success!";
            }

            return "Login Failed!";
        }

        public void InsertABus(BusInfo bus)
        {
            try
            {
                context.BusInfoes.Add(bus);
                context.SaveChanges();
                Console.WriteLine("Record Inserted!");
            }
            catch
            {
                Console.WriteLine("Data insertion failed!");
            }
            
        }

        public List<BusInfo> RetrieveBusInfo()
        {
            return context.BusInfoes.ToList();
        }
    }
}
