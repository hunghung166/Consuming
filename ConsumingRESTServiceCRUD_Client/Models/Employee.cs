﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsumingRESTServiceCRUD_Client.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }
}