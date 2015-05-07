namespace SchoolSystem.Data
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;

    using SchoolSystem.Model;

    public class SchoolSystemDbContext : IdentityDbContext<User>
    {
        public SchoolSystemDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static SchoolSystemDbContext Create()
        {
            return new SchoolSystemDbContext();
        }
    }
}
