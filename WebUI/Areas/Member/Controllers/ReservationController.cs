using Business.Concrete;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebUI.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        ReservationManager reservationManager = new ReservationManager(new EfReservationDal());
        
        public IActionResult MyCurrentReservation()
        {
            return View();
        }
        public IActionResult MyOldReservation()
        {
            return View();
        }
        [HttpGet]
        public IActionResult NewReservation()
        {
            GetListFromDestinationMethod();
            return View();
        }

        

        [HttpPost]
        public IActionResult NewReservation(Reservation p)
        {
            p.AppUserId = 1;
            p.Status = "Bekleniyor";
            reservationManager.TAdd(p);
            return RedirectToAction("MyCurrentReservation");
        }
        private void GetListFromDestinationMethod()
        {
            List<SelectListItem> values = (from x in destinationManager.TGetAll()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.ID.ToString()
                                           }).ToList();
            ViewBag.v = values;
        }
    }
}
