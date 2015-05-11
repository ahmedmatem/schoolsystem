namespace SchoolSystem.Model.ERegister
{
    using System;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;

    public class Group
    {
        public Group()
        {
            this.Students = new HashSet<Student>();
            this.Disciplines = new HashSet<Discipline>();
        }

        [Key]
        public string Id { get; set; }

        public string Name { get; private set; }

        public string TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public virtual ICollection<Discipline> Disciplines { get; set; }
    }
}
