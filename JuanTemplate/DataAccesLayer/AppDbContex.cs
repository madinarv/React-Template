using JuanTemplate.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace JuanTemplate.DataAccesLayer
{
    public class AppDbContex : DbContext
    {
        public AppDbContex( DbContextOptions <AppDbContex> options) : base(options) { }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

    }
}
