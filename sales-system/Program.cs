using System;

namespace sales_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Listica listica = new Listica(); // instancia, asignacion

            Seller s1 = new Seller();
            s1.Name = "Martha";
            s1.Age = 25;
            s1.Gender = 1; //F
            listica.AddSellers(s1);

            Seller s2 = new Seller();
            s2.Name = "Tiffany";
            s2.Age = 30;
            s2.Gender = 1; //M
            listica.AddSellers(s2);

            Seller s3 = new Seller();
            s3.Name = "Hugo";
            s3.Age = 42;
            s3.Gender = 0; //M
            listica.AddSellers(s3);




            Product pro1 = new Product();
            pro1.Name = "Rings";
            pro1.Price = 100;
            pro1.Category = "Jewelry";
            listica.AddProducts(pro1);

            Product pro2 = new Product();
            pro2.Name = "Tshirts";
            pro2.Price = 200;
            pro2.Category = "Clothes";
            listica.AddProducts(pro2);

            Product pro3 = new Product();
            pro3.Name = "Computer";
            pro3.Price = 1000;
            pro3.Category = "Technology";
            listica.AddProducts(pro3);

            Product pro4 = new Product();
            pro4.Name = "Meat";
            pro4.Price = 8;
            pro4.Category = "Food";
            listica.AddProducts(pro4);

            Product pro5 = new Product();
            pro5.Name = "Banana";
            pro5.Price = 10;
            pro5.Category = "Fruits";
            listica.AddProducts(pro5);


            Sale sa1 = new Sale();
            sa1.comments = "Sales Made";
            sa1.Venticas = 20;
            listica.AddSales(sa1);

            Sale sa2 = new Sale();
            sa2.comments = "Sales Made";
            sa2.Venticas = 10;
            listica.AddSales(sa2);

            Sale sa3 = new Sale();
            sa3.comments = "Sales Made";
            sa3.Venticas = 30;
            listica.AddSales(sa3);

            Sale sa4 = new Sale();
            sa4.comments = "Sales Made";
            sa4.Venticas = 40;
            listica.AddSales(sa4);

            Sale sa5 = new Sale();
            sa5.comments = "Sales Made";
            sa5.Venticas = 50;
            listica.AddSales(sa5);




            listica.AverageProducts();
            listica.CheapestProduct();
            listica.ExpensiveProduct();
            listica.soldProducts();










        }
    }
}
