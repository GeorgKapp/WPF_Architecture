using AutoMapper;

namespace WPF_Architecture_Custom.WPF_Content
{
    public class ViewController
    {
        private ModelService _service;
        private static readonly IMapper Mapper = new MapperConfiguration(p => { p.AddProfile<MappingProfile>(); }).CreateMapper();
        public ViewController()
        {
            _service = new ModelService();
        }

        public ViewModel GetModel()
        {
            var model = _service.GetModel();
            return Mapper.Map<ViewModel>(model);
        }

        public void UpdateModel(ViewModel viewModel)
        {
            viewModel.LastName = "Last name";
        }

        public ViewModel GetTestModel()
        {
            var model = _service.GetTestModel();
            return Mapper.Map<ViewModel>(model);
        }
    }
}
