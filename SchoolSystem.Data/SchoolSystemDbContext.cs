namespace SchoolSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Reflection;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration;

    using Microsoft.AspNet.Identity.EntityFramework;

    using SchoolSystem.Model;
    using SchoolSystem.Model.ERegister;
    using SchoolSystem.Data.Migrations;
    using SchoolSystem.Data.TablesRelationships;
    using SchoolSystem.Model.Contract;

    public class SchoolSystemDbContext : IdentityDbContext<User>
    {
        private IRelationships teachersRelationship;

        public SchoolSystemDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            this.teachersRelationship = new TeachersRelationships();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            this.teachersRelationship.Configure(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        public virtual IDbSet<Student> Students { get; set; }

        public virtual IDbSet<Teacher> Teachers { get; set; }

        public virtual IDbSet<Group> Groups { get; set; }

        public virtual IDbSet<Discipline> Disciplines { get; set; }

        public virtual IDbSet<Note> Notes { get; set; }

        public static SchoolSystemDbContext Create()
        {
            return new SchoolSystemDbContext();
        }
    }
}
