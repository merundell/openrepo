using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace PingService
{
    [ServiceContract()]
    public interface IPingResponder
    {
        [OperationContract]
        string Ping();

        [OperationContract]
        int RollDice(int sides, int count);
    }
}
