namespace SchoolSystem.Web.Areas.Admin.ViewModels
{
    using SchoolSystem.Common;

    public class SchoolViewModel
    {
        public SchoolViewModel() 
        {
            
        }

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

        public string WebSiteUrl { get; set; }
    }
}
