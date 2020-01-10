using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class SigController : Controller
    {
        [Route("sd/sd")]
        public string nn()
        {
            return "NN String";
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}