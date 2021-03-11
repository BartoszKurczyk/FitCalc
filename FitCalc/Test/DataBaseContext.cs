using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class DataBaseContext:DbContext
    {
        public DbSet<Item1> Items1 { get; set; }
        public DbSet<Item2> Items2 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost;Database=Test;User Id=sa;Password=Admin123;");
    }

    public class Item1
    {
        public int Item1Id { get; set; }
        public string Description { get; set; }

        public List<Item2> listOfItems2 { get; } = new List<Item2>();
    }
    public class Item2
    {
        public int Item2Id { get; set; }
        public string Content { get; set; }
    }
}
