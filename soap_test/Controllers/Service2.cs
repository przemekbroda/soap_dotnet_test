using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace soap_test.Controllers
{
    public class Service2 : IService2
    {
        public int DoSomething(int msg)
        {
            return 1;
        }
    }
}
