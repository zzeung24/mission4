using Microsoft.EntityFrameworkCore;
using System;

namespace WebApplication.Models
{
    public class WebApplicationContext : DbContext
    {
        //Constructor
        public WebApplicationContext(DbContextOptions<WebApplicationContext> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    ApplicationId = 1,
                    Category = "Action/Adventure",
                    Title = "Avengers, The",
                    Year = 2012,
                    Director = "Joss Whedon",
                    Rating = "PG-13",
                    Edited = false
                },
                new ApplicationResponse
                {
                    ApplicationId = 2,
                    Category = "Action/Adventure",
                    Title = "Batman",
                    Year = 1989,
                    Director = "Tim Burton",
                    Rating = "PG-13",
                    Edited = false
                },
                new ApplicationResponse
                {
                ApplicationId = 3,
                    Category = "Action/Adventure",
                    Title = "Batman & Robin",
                    Year = 1997,
                    Director = "Joel Schumacher",
                    Rating = "PG-13",
                    Edited = false
                }

            );
        }
    }
}
