using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQDemoReVisit
{
    public partial class SelectManyExample : Form
    {
        public SelectManyExample()
        {
            InitializeComponent();
        }

        List<Categories> categoryList = new List<Categories> {
            new Categories
            {
                CategoryName="Electronics",
                ProductsList=new List<Products>
                {
                    new Products {Prodid=1,Name="Laptop" },
                    new Products{ Prodid=2,Name="SmartPhones" }
                }

            },
            new Categories{
            CategoryName="Groceries",
            ProductsList=new List<Products>{
            new Products{ Prodid=3,Name="Bananas"},
            new Products{ Prodid=4,Name="Oranges"},
            new Products{ Prodid=5,Name="Mangoes"}


            }

            }



        };
        private void SelectManyExample_Load(object sender, EventArgs e)
        {

            var result = categoryList.SelectMany(c => c.ProductsList);
            foreach (var item in result)
            {
               MessageBox.Show(item.Prodid.ToString());
                MessageBox.Show(item.Name);
                
            }
        }
    }
}
