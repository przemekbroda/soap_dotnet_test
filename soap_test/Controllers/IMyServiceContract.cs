using soap_test.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace soap_test.Controllers
{

    [ServiceContract]
    public interface IMyServiceContract : IService2
    {
        [OperationContract(Action = "http://test.com/test")]
        Task<string> Test(string message);

        [OperationContract]
        Task<CustomModel> ModelTest(int id);


    }
}
