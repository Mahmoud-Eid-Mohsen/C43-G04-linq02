using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment.Data
{
    class Product : IComparer<Product>
    {
        public long ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        //public int CompareTo(Product? other)
        //{
        //    return this.Category.CompareTo(other?.Category);
        //}
      
       
        public override string ToString()
            => $"ProductID:{ProductID},ProductName:{ProductName},Category{Category},UnitPrice:{UnitPrice},UnitsInStock:{UnitsInStock}";

        int IComparer<Product>.Compare(Product? x, Product? y)
        {
            return string.Compare(x.Category, y.Category);
        }

        //int IComparable<Product>.CompareTo(Product? other)
        //{
        //    return this.Category.CompareTo(other?.Category);
        //}

    }
}
