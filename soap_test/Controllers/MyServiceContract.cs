using soap_test.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace soap_test.Controllers
{
    public class MyServiceContract : Service2, IMyServiceContract
    {
        public async Task<CustomModel> ModelTest(int id)
        {
            await Task.Delay(2000);

            var m = new CustomModel {
                Id = 1,
                Email = "test@test.com",
                Name = "test"
            };

            m.Contacts = new List<string> { "a", "b", "c" };

            return m;
        }

        public async Task<string> Test(string message)
        {
            return message;
        }
    }
}
