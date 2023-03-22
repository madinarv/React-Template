using JuanTemplate.Models;

namespace JuanTemplate.ViewModels.HomeViemModels
{
    public class HomeVm
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Product> TopSellers { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        

    }
}
