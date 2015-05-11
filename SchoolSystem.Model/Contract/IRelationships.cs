namespace SchoolSystem.Model.Contract
{
    using System.Data.Entity;

    public interface IRelationships
    {
        void Configure(DbModelBuilder modelBuilder);
    }
}
