using SpeedyCouriers.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SpeedyCouriers.Controllers
{
    public class UserController : Controller
    {
        // GET: User

        SpeedyCouriersEntities db = new SpeedyCouriersEntities();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult CreateParcel()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateParcel(receiverInfo receiver)
        {
            return View();
        }

        public ActionResult OrderDetails()
        {

            List<OrderInfo> orderInfo = db.OrderInfoes.ToList();
            return View(orderInfo);
        }
    }


    
}