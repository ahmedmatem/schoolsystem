namespace SchoolSystem.Web.App_Start
{
    using SchoolSystem.Model;
    using SchoolSystem.Web.Areas.Admin.ViewModels;

    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            AutoMapper.Mapper.CreateMap<School, SchoolViewModel>().ReverseMap();
        }
    }
}
