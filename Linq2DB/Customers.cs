using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ16.Linq2DB
{
    
    [Table("Customers")]
    internal class Customer
    {
        [PrimaryKey, Identity, Column("ID")]
        public int ID { get; set; }

        [Column("FirstName"), NotNull]
        public string FirstName { get; set; }


        [Column("LastName"), NotNull]
        public string LastName { get; set; }

        [Column("Age")]
        public int Age { get; set; }

        [Association(ThisKey = nameof(ID), OtherKey = nameof(Order.CustomerID))]
        public List<Order>? Orders { get; set; }
    }

    [Table("Orders")]
    class Order
    {
        [PrimaryKey, Identity, Column("ID")]
        public int ID { get; set; }


        [Column("CustomerID"), NotNull]
        public int CustomerID { get; set; }

        [Column("ProductID"), NotNull]
        public int ProductID { get; set; }

        [Column("Quantity")]
        public double Quantity { get; set; }

        //[Association(ThisKey = "user_id", OtherKey = "id")]
        //public virtual User User { get; set; }
    }

    [Table("Products")]
    class Product
    {
        [PrimaryKey, Identity, Column("ID")]
        public int ID { get; set; }


        [Column("Name"), NotNull]
        public string Name { get; set; }

        [Column("Description"), NotNull]
        public string Description { get; set; }

        [Column("StockQuantity")]
        public double StockQuantity { get; set; }

        [Column("Price")]
        public double Price { get; set; }

        //[Association(ThisKey = "user_id", OtherKey = "id")]
        //public virtual User User { get; set; }
    }
}
