using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default
{
    public class _StaticPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2 = c.Testimonials.Count();
            return View();
        }
    }
}
