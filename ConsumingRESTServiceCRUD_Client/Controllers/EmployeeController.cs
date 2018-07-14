using ConsumingRESTServiceCRUD_Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConsumingRESTServiceCRUD_Client.Controllers
{
    public class EmployeeController : Controller
    {
       
        public ActionResult Index()
        {
            EmployeeServiceClient bsc = new EmployeeServiceClient();
            ViewBag.listEmployees = bsc.getAllEmployee();
            return View();
        }

    }
}