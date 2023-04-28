using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ16.Linq2DB
{
    internal class ShopDB : LinqToDB.Data.DataConnection
    {
        public ShopDB(DataOptions options) : base(options)
        { 

        }
        public ITable<Customer> Customers => this.GetTable<Customer>();

        public ITable<Order> Orders => this.GetTable<Order>();

        public ITable<Product> Products => this.GetTable<Product>();
    }
}
