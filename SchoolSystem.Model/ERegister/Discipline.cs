namespace SchoolSystem.Model.ERegister
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Discipline
    {
        public Discipline() 
        {
            this.Groups = new HashSet<Group>();
            this.Teachers = new HashSet<Teacher>();
        }

        [Key]
        public string Id { get; set; }

        public string Name { get; private set; }

        public string ShortName { get; private set; }

        public virtual ICollection<Group> Groups { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
