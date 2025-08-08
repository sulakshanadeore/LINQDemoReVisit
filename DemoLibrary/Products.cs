using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Products
    {

        public int Prodid { get; set; }
        public string Name { get; set; }
    }

    public class Categories
    {

        public string CategoryName { get; set; }
        public List<Products> ProductsList { get; set; }
    }
}
