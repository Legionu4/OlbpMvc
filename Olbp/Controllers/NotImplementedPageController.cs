using System.Web.Mvc;

namespace Olbp.Controllers
{
    public class NotImplementedPageController : Controller
    {
        // GET: NotImplementedPage
        public ActionResult NotImplementedPage()
        {
            ViewBag.Message = "Sorry this page is not yet implemented ;(";

            return View();
        }
    }
}