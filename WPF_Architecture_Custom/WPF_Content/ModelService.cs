using System.Linq;

namespace WPF_Architecture_Custom.WPF_Content
{
    public class ModelService
    {
        public Model GetModel() => new Model {FirstName = "Max", LastName = "Mustermann"};
        public Model GetTestModel() => new Model { FirstName = "Test", LastName = "Service" };
        public Model[] GetModels() => Enumerable.Repeat(GetModel(), 10).ToArray();
    }
}
