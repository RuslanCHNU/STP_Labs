﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using CustomerService;
[ServiceContract]
public interface IStudentService
{
    [OperationContract]
    [WebInvoke(Method = "GET",
               ResponseFormat = WebMessageFormat.Json,
               UriTemplate = "GetStudents")]
    List<Student> GetStudentList();
}
