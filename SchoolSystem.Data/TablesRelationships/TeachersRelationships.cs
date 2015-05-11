namespace SchoolSystem.Data.TablesRelationships
{
    using System.Data.Entity;

    using SchoolSystem.Model.ERegister;
    using SchoolSystem.Model.Contract;

    public class TeachersRelationships : IRelationships
    {
        public void Configure(DbModelBuilder modelBuilder)
        {
            // Configure Id as PK for Teacher
            modelBuilder.Entity<Teacher>()
                .HasKey(t => t.Id);

            modelBuilder.Entity<Group>()
                .HasRequired(t => t.Teacher)
                .WithOptional(e => e.Group);
        }
    }
}
