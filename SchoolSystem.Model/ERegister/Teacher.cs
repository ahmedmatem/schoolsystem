namespace SchoolSystem.Model.ERegister
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Teacher : Person
    {
        public Teacher(string firstName, string middleName, string lastName)
            : base(firstName, middleName, lastName)
        {
            this.Disciplines = new HashSet<Discipline>();
        }

        public bool HasGroup { get; set; }

        public virtual Group Group { get; set; }

        public virtual ICollection<Discipline> Disciplines { get; set; }
    }
}
