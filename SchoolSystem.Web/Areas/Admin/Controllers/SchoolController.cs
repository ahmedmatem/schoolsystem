namespace SchoolSystem.Web.Areas.Admin.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using AutoMapper.QueryableExtensions;

    using SchoolSystem.Web.Areas.Admin.ViewModels;
    using SchoolSystem.Model.ERegister;
    using SchoolSystem.Model;
    using SchoolSystem.Common;

    public class SchoolController : AdminController
    {
        // GET: Admin/School
        public ActionResult Details(string id)
        {
            //SchoolViewModel model = new SchoolViewModel();
            //model = this.dbContext.Schooles
            //        .Where(s => s.Id == id)
            //        .Project()
            //        .To<SchoolViewModel>()
            //        .FirstOrDefault();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SchoolViewModel model)
        {
            // generate random key
            model.Id = RandomKey.Generate();
            School school = AutoMapper.Mapper.Map<School>(model);

            this.dbContext.Schooles.Add(school);
            this.dbContext.SaveChanges();

            return RedirectToAction("Details");
        }
    }
}