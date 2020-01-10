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
        [Route("list/s")]
        public List<String> ilst()
        {
            List<String> nn = new List<string>();
            nn.Add("Satya ");
            nn.Add("Reddy ");
            nn.Add("Kovvuri ");
            nn.Add("Aditya ");
            return nn;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}