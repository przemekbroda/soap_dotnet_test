using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace soap_test.Model
{
    [DataContract]
    public class CustomModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember(IsRequired = true)]
        public string Email { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public List<string> Contacts { get; set; }
    }
}
