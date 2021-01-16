using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCCloud.Controllers
{
    public class DeleteStudentController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
      
    }
}
