using AutoMapper;

namespace WPF_Architecture_Custom.WPF_Content
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Model, ViewModel>();
            CreateMap<ViewModel, Model>();
        }
    }
}
