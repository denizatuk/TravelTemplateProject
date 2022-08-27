using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebUI.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        // GET: /<controller>/
        DestinationManager destinationManager
             = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = destinationManager.TGetAll();
            return View(values);
        }
    }
}

