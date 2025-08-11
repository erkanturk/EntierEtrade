using ETICARET.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETICARET.DataAccess.Concrete.EfCore
{
    public class SeedDatabase
    {
        public static void Seed()
        {

        }
        private static Category[] Categories =
        {
            new Category() {Name="Telefon"},//0
            new Category() {Name="Bilgisayar"},//1
            new Category() {Name="Elektronik"},//2
            new Category() {Name="Ev Gereçleri"}//3

        };

        private static Product[] Products = {
             new Product(){ Name = "Samsung Note 8" , Price = 15000, Images = { new Image() {ImageUrl = "samsung.jpg" },  new Image() {ImageUrl = "samsung2.jpg" }, new Image() {ImageUrl = "samsung3.jpg" }, new Image() {ImageUrl = "samsung4.jpg" } },Description ="<p>Güzel telefon</p>" },
             new Product(){ Name = "Samsung Note 8" , Price = 15000, Images = { new Image() {ImageUrl = "samsung.jpg" },  new Image() {ImageUrl = "samsung2.jpg" }, new Image() {ImageUrl = "samsung3.jpg" }, new Image() {ImageUrl = "samsung4.jpg" } },Description ="<p>Güzel telefon</p>" },
        };

        private static ProductCategory[] ProductCategories = {
            new ProductCategory(){Product=Products[0],Category=Categories[0]},//telefon
            new ProductCategory(){Product=Products[1],Category=Categories[3]},//Ev gereçleri
        };
    }
}
