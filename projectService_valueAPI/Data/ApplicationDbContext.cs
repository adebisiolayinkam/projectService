using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using projectService_valueAPI.Models;

namespace projectService_valueAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<LocalUser> LocalUsers { get; set; }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Lagos state ikorodu, lagos Nigeria",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa3.jpg",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                   new Villa()
                   {
                       Id = 2,
                       Name = "Premium Pool Villa",
                       Details = "Ikorodu, lagos Nigeria",
                       ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa1.jpg",
                       Occupancy = 4,
                       Rate = 2500,
                       Sqft = 5000,
                       Amenity = "",
                       CreatedDate = DateTime.Now
                   },
                      new Villa()
                      {
                          Id = 3,
                          Name = "Luxury Pool Villa",
                          Details = "First gate, lagos Nigeria",
                          ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa4.jpg",
                          Occupancy = 6,
                          Rate = 300,
                          Sqft = 560,
                          Amenity = "",
                          CreatedDate = DateTime.Now
                      },
                        new Villa()
                        {
                            Id = 4,
                            Name = "Diamond Villa",
                            Details = "First gate, lagos Nigeria",
                            ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa5.jpg",
                            Occupancy = 4,
                            Rate = 600,
                            Sqft = 1100,
                            Amenity = "",
                            CreatedDate = DateTime.Now
                        },
                         new Villa()
                         {
                             Id = 5,
                             Name = "Diamond Pool Villa",
                             Details = "First gate, lagos Nigeria",
                             ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa2.jpg",
                             Occupancy = 4,
                             Rate = 600,
                             Sqft = 1100,
                             Amenity = "",
                             CreatedDate = DateTime.Now
                         });
        }
    }
}
