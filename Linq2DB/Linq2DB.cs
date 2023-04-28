using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ16.Linq2DB
{
    internal class Linq2DB
    {
        public static void Demo()
        {
            var options = new DataOptions().UsePostgreSQL(Constants.ConnectionString);
            var db = new ShopDB(options);
            var Customers1 = db.Customers.Where(x => x.Age > 23).OrderBy(x => x.ID).Skip(1);
            var Customers2 = db.Customers.Where(x => x.FirstName == "Сергей").OrderBy(x => x.LastName).Skip(1);
            var Customers3 = db.Customers.Where(x => x.LastName == "Бравый").OrderBy(x => x.FirstName).Skip(1);

            var Orders1 = db.Orders.Where(x => x.Quantity > 5).OrderBy(x => x.ID).Skip(1);
            var Orders2 = db.Orders.Where(x => x.CustomerID == 4).OrderBy(x => x.ID).Skip(1);
            var Orders3 = db.Orders.Where(x => x.ProductID == 5).OrderBy(x => x.ID).Skip(1);

            var Products1 = db.Products.Where(x => x.StockQuantity > 500).OrderBy(x => x.Name).Skip(1);
            var Products2 = db.Products.Where(x => x.Price > 100).OrderBy(x => x.Name).Skip(1);
            var Products3 = db.Products.Where(x => x.Name == "%Молоко%").OrderBy(x => x.Name).Skip(1);



            var result = Customers1.ToList();
            foreach (var item in result) 
                Console.WriteLine(item.FirstName + " | "+item.Age);

            var result1 = Products2.ToList();
            foreach (var item in result1)
                Console.WriteLine(item.Name + " - " + item.Price);

        }
    }
}
