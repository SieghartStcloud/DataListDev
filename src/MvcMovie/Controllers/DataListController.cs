using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.WindowsAzure.MobileServices;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class DataListController : Controller
    {
        // GET: /DataList/
        public IActionResult Index()
        {
            return View();
        }
    }
}
