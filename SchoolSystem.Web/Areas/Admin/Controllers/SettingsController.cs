namespace SchoolSystem.Web.Areas.Admin.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class SettingsController : AdminController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
