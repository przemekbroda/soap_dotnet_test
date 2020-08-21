using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace soap_test.Controllers
{
    [ServiceContract]
    public interface IService2
    {
        [OperationContract]
        int DoSomething(int msg);
    }
}
