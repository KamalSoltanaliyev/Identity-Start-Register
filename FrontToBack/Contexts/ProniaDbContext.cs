using Microsoft.EntityFrameworkCore;
using FrontToBack.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FrontToBack.Contexts
{
    public class ProniaDbContext : IdentityDbContext<AppUser>
    {
        public ProniaDbContext(DbContextOptions<ProniaDbContext> options) : base(options)
        {
        }

        public DbSet<Slider>? Sliders { get; set; }
        public DbSet<Shipping>? Shippings { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }
    }
}