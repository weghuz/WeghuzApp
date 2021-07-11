using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Web;
using Microsoft.AspNetCore.Hosting.Server;
using System.IO;

namespace WebApplication1.Controllers
{
    public class HostingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/{controller}/Display/{id}")]
        public FileResult Display(string id)
        {
            switch(id)
            {
                case "space": return File("/Images/space.jpg", "image/jpeg");
            }
            return File("", "image/jpeg");
        }
    }
}
