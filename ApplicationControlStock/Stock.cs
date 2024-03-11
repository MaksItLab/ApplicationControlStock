using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationControlStock
{
    public partial class Stock : Form
    {
        public List<Product> products = new List<Product>();
        public int countAllProducts = 314;
        public double PriceAllProducts = 8321.67;

        public Stock()
        {
            products.Add(new Product() {Name = "Pen", Price = 3.25, Count = 5});
            products.Add(new Product() {Name = "Book", Price = 10, Count = 49});
            products.Add(new Product() {Name = "Phone", Price = 699, Count = 113});
            products.Add(new Product() {Name = "Computer", Price = 1299, Count =73});

            

            InitializeComponent();
        } 

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = $"Общее количество товара: {countAllProducts}";
            label2.Text = $"Общая сумма: {PriceAllProducts}";
        }
    }
}
