namespace SchoolSystem.Model.ERegister
{
    using System;

    public abstract class Person
    {
        public string Id { get; private set; }

        public string FirstName { get; private set; }

        public string MiddleName { get; private set; }

        public string LastName { get; private set; }

        public Person(string firstName, string middleName, string lastName)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
        }

        public virtual string FullName
        {
            get
            {
                return String.Format("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName);
            }
        }
    }
}
