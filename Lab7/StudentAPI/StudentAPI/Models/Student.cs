﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentAPI.Models
{
    public class Student
    {
        public int StudentCardNumber { get; set; }
        public string FullName { get; set; }
        public int Course { get; set; }
    }
}