using ConsumingRESTServiceCRUD_Client.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace ConsumingRESTServiceCRUD_Client.Models
{
    
    public class EmployeeServiceClient
    {
        String BASE_URL = "http://localhost:52524/EmployeeService.svc/rest/";
        //ServiceReference2.EmployeeServiceClient client = new ServiceReference2.EmployeeServiceClient();
        
        //public List<Employee> GetAllEmployee()
        //{
        //    var list = client.GetEmployeeList().ToList();
        //    var rt = new List<Employee>();
        //    list.ForEach(b=>rt.Add(new Employee{
        //        EmployeeId = b.EmployeeId,
        //        Name = b.Name,
        //        Salary = b.Salary,
        //        Department = b.Department
        //    }));
        //    return rt;
        //}

        public List<Employee> getAllEmployee()
        {
            var syncClient = new WebClient();
            var content = syncClient.DownloadString(BASE_URL + "Employees/");
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<List<Employee>>(content);
        }
    }
}