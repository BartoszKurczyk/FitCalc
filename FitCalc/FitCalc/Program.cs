using FitCalcDb;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace FitCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new FitCalcDbContext())
            {
                /*db.Database.EnsureCreated();
                var pomidor = new Product { ProductName = "Pomidor" };
                var chleb = new Product { ProductName = "Chleb" };
                //db.Add(pomidor);
                //db.Add(chleb);
                var kanapkaZPomidorem = new Recipe { RecipeName = "Kanapka z pomidorem", RecipeDescription = "Pomidora pokrój i połóż na chlebie" };
                //db.Add(kanapkaZPomidorem);
                var listOfIngradients = new List<Ingradient>();
                listOfIngradients.Add(new Ingradient { Product = pomidor, Quantity = 50, TypeOfQuantity = TypeOfQuantity.g });
                listOfIngradients.Add(new Ingradient { Product = chleb, Quantity = 50, TypeOfQuantity = TypeOfQuantity.g });
                //listOfIngradients.ForEach(x => db.Add(x));

                db.Add(new RecipeWithIngradients { Recipe = kanapkaZPomidorem, Ingradients = listOfIngradients });
                db.SaveChanges();*/

                var recipe = db.RecipeWithIngradients.Include(x => x.Ingradients).ThenInclude(x=> x.Product).Include(x => x.Recipe).ToList().First();

                Console.WriteLine("Title: " + recipe.Recipe.RecipeName);
                Console.WriteLine("Description: " + recipe.Recipe.RecipeDescription);
                Console.WriteLine("Ingradients: ");
                recipe.Ingradients.ForEach(x => Console.WriteLine(x.Product.ProductName + " " + x.Quantity.ToString() + x.TypeOfQuantity.ToString()));

               


                        
            }
        }

        static public void DisplayDate(DateTime dateTime)
        {
            Console.WriteLine(dateTime.ToString());
        }
    }
}
