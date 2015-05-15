namespace SchoolSystem.Web.Areas.Admin.Controllers
{
    using System.Data.Entity;
    using System.Web.Mvc;

    using SchoolSystem.Data;
    using SchoolSystem.Model.ERegister;
    using SchoolSystem.Common;
    using SchoolSystem.Web.Controllers;

    [Authorize(Roles=GlobalConstants.RoleAdmin)]
    public class AdminController : BaseController
    {
        public AdminController()
            : base()
        {
            
        }
    }
}
