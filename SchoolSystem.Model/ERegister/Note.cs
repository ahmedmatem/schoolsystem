namespace SchoolSystem.Model.ERegister
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Note
    {
        public Note() { }

        [Key]
        public string Id { get; set; }

        public string StudentId { get; set; }

        public string DisciplineId { get; set; }

        public NoteType Type { get; set; }

        public DateTime CreatedOn { get; set; }

        [ForeignKey("DisciplineId")]
        public virtual Discipline Discipline { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
    }
}
