using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

[DataContract(Namespace = "")]
public class Student
{
    [DataMember] public int StudentCardNumber { get; set; }
    [DataMember] public string FullName { get; set; }
    [DataMember] public int Course { get; set; }
}
