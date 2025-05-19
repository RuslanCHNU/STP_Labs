using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CustomerService
{
    [DataContract(Namespace = "")]
    public class Customer
    {
        [DataMember] public int CustomerID { get; set; }
        [DataMember] public string FirstName { get; set; }
        [DataMember] public string LastName { get; set; }
        [DataMember] public string Address { get; set; }
    }
}