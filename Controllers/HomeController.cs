using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Backend_SweetAlert.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string mesaj)
        {
            ViewBag.SweetAlertShowMessage = SweetAlertHelper.ShowMessage("Success", "Username or Password Wrong"+ mesaj, SweetAlertMessageType.success);
            //ViewBag.SweetAlertShowMessage = SweetAlertHelper.ShowMessage("Error", "Username or Password Wrong", SweetAlertMessageType.error);

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IndexError(string mesaj)
        {
            //ViewBag.SweetAlertShowMessage = SweetAlertHelper.ShowMessage("Success", "Username or Password Wrong" + mesaj, SweetAlertMessageType.success);
            ViewBag.SweetAlertShowMessage = SweetAlertHelper.ShowMessage("Error", "Username or Password Wrong"+ mesaj, SweetAlertMessageType.error);
            return View("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IndexWarning(string mesaj)
        {
            //ViewBag.SweetAlertShowMessage = SweetAlertHelper.ShowMessage("Success", "Username or Password Wrong" + mesaj, SweetAlertMessageType.success);
            ViewBag.SweetAlertShowMessage = SweetAlertHelper.ShowMessage("Warning", "Username or Password Wrong" + mesaj, SweetAlertMessageType.warning);
            return View("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IndexInfo(string mesaj)
        {
            //ViewBag.SweetAlertShowMessage = SweetAlertHelper.ShowMessage("Success", "Username or Password Wrong" + mesaj, SweetAlertMessageType.success);
            ViewBag.SweetAlertShowMessage = SweetAlertHelper.ShowMessage("Info", "Username or Password Wrong" + mesaj, SweetAlertMessageType.info);
            return View("Index");
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
    }
}