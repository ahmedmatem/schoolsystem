namespace SchoolSystem.Web.Controllers
{
    using System.Web.Mvc;
    using System.Data.Entity;

    using SchoolSystem.Data;

    public class BaseController : Controller
    {
        protected DbContext context;

        public BaseController()
        {
            this.context = new SchoolSystemDbContext();
        }
    }
}