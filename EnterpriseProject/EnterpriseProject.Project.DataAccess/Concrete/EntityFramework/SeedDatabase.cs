using EnterpriseProject.Project.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterpriseProject.Project.DataAccess.Concrete.EntityFramework
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new MyContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    List<Category> categories = new List<Category> 
                    { 
                        new Category {Name="Teknoloji"},
                        new Category {Name="Beyaz Eşya"}
                    };
                    foreach (var item in categories)
                    {
                        context.Categories.Add(item);
                    }
                    context.SaveChanges();

                    List<Product> products = new List<Product>
                    {
                        new Product {Name="Samsung S5",CategoryId=1,Stock=5,UnitPrice=5000},
                        new Product{Name="Bosh",CategoryId=2,Stock=2,UnitPrice=1200}
                    };
                    foreach (var item in products)
                    {
                        context.Products.Add(item);
                    }
                    context.SaveChanges();
                };

            }
        }
    }
}
