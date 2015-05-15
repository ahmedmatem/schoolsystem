namespace SchoolSystem.Web.Controllers
{
    using System.Web.Mvc;
    using System.Data.Entity;

    using SchoolSystem.Data;

    public class BaseController : Controller
    {
        protected SchoolSystemDbContext dbContext;

        public BaseController()
        {
            this.dbContext = new SchoolSystemDbContext();
        }
    }
}