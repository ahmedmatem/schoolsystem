namespace SchoolSystem.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Schooles")]
    public class School
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public string City { get; set; }

        public string FirstAddresLine { get; set; }

        public string SecondAddressLine { get; set; }

        public string PostCode { get; set; }

        public string MobilePhoneNumber { get; set; }

        public string StationaryPhoneNumber { get; set; }

        public string Email { get; set; }

        private string WebSiteUrl { get; set; }
    }
}
