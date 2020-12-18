using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FinalBusService_991396063
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBusService_991396063" in both code and config file together.
    [ServiceContract]
    public interface AuthenticateUserService
    {
        [OperationContract]
        string AuthenticateUser(string Name, string Password);
    }

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBusService_991396063" in both code and config file together.
    [ServiceContract]
    public interface DBOperationsService
    {
        [OperationContract]
        void InsertABus(BusInfo bus);

        [OperationContract]
        List<BusInfo> RetrieveBusInfo();
    }
}
