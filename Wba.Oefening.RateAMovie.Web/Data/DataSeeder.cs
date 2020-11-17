using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wba.Oefening.RateAMovie.Domain.Entities;


namespace Wba.Oefening.RateAMovie.Web.Data
{
    public static class DataSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            //Company aanmaken
            var company = new Company{Id=1,Name="Warner Bros"};
            //movie aanmaken
            var movie = new Movie
            { Id = 1, Title = "Deadpool",CompanyId=1};
        }
    }
}
