namespace SchoolSystem.Model.ERegister
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Student : Person
    {
        public Student(string firstName, string middleName, string lastName)
            : base(firstName, middleName, lastName)
        {
            this.Notes = new HashSet<Note>();
        }

        public string GroupId { get; set; }

        public virtual Group Group { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
    }
}
