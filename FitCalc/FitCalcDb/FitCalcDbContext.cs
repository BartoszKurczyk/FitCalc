using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitCalcDb
{
    public class FitCalcDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingradient> Ingradients { get; set; }
        public DbSet<RecipeWithIngradients> RecipeWithIngradients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost;Database=FitCalc;User Id=sa;Password=Admin123;");
    }
}
