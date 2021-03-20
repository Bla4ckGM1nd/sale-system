using System;
using System.Collections.Generic;
using System.Text;

namespace sales_system
{
    public class Listica
    {
        int count = 0;

        Seller[] Sellers = new Seller[10]; //Sellers nombre de lista limitado a 10
        int countSeller = 0;

        Product[] Products = new Product[10];
        int countProduct = 0;

        List<Sale> Sales = new List<Sale>();
        int countSale = 0;

        //se empieza a guardar info a las listas
        public void AddSellers(Seller seller)
        {
            Sellers[countSeller] = seller;
            countSeller++;
        }

        public void AddProducts(Product product)
        {
            Products[countProduct] = product;
            countProduct++;
        }

        
        public void AddSales(Sale sale)
        {
            if (count < countSeller)
            {
                Sales.Add(new Sale()
                {
                    Seller = Sellers[count],
                    Product = Products[countSale],
                    Venticas = sale.Venticas,
                    comments = sale.comments,
                });
                countSale++;
                count++;
            }
            else
            {
                count = 0;
                Sales.Add(new Sale()
                {
                    Seller = Sellers[count],
                    Product = Products[countSale],
                    Venticas = sale.Venticas,
                    comments = sale.comments,
                });
                countSale++;
                count++;
            }
        }

        public void CheapestProduct()
        {
            string nameSeller = "";
            string nameProduct = "";
            double priceProduct = 0;
            string categoryProduct = "";
            double value = 0;

            for (int i = 0; i < Sales.Count; i++)
            {
                double price = Sales[i].Product.Price;

                if (value == 0)
                {
                    nameSeller = Sales[i].Seller.Name;
                    nameProduct = Sales[i].Product.Name;
                    priceProduct = Sales[i].Product.Price;
                    categoryProduct = Sales[i].Product.Category;
                    value = priceProduct;
                }
                else if (price < value)
                {
                    nameSeller = Sales[i].Seller.Name;
                    nameProduct = Sales[i].Product.Name;
                    priceProduct = Sales[i].Product.Price;
                    categoryProduct = Sales[i].Product.Category;
                    value = priceProduct;
                }
            }

            Console.WriteLine("Who's the seller with the cheapest product?");
            Console.WriteLine("Name: " + nameSeller);
            Console.WriteLine("Product: " + nameProduct);
            Console.WriteLine("Price: " + priceProduct);
            Console.WriteLine("Category: " + categoryProduct);
        }

        public void AverageProducts()
        {
            double priceProducts = 0;
            double productPrice = 0;
            double averagePriceProducts = 0;

            for (int i = 0; i < countProduct; i++)
            {
                productPrice = Products[i].Price;
                priceProducts = priceProducts + productPrice;
            }

            averagePriceProducts = priceProducts / countProduct;
            Console.WriteLine("The average of the products is: " + averagePriceProducts);


        }

        public void soldProducts()
        {
            string nameProduct = "";
            double quantity = 0;


            for (int i = 0; i < Sales.Count; i++)
            {

                nameProduct = Sales[i].Product.Name;
                quantity = Sales[i].Venticas;

                Console.WriteLine("The units sold of each product was: ");
                Console.WriteLine("Name: " + nameProduct);
                Console.WriteLine("Cantidad: " + quantity);

            }


        }

        public void ExpensiveProduct()
        {
            string nameProduct = "";
            double priceProduct = 0;
            double value = 0;

            for (int i = 0; i < Sales.Count; i++)
            {
                double price = Sales[i].Product.Price;

                if (value == 0)
                {
                    nameProduct = Sales[i].Product.Name;
                    priceProduct = Sales[i].Product.Price;
                    value = priceProduct;
                }
                else if (price > value)
                {
                    nameProduct = Sales[i].Product.Name;
                    priceProduct = Sales[i].Product.Price;
                    value = priceProduct;
                }
            }

            Console.WriteLine("The expensive product was: ");
            Console.WriteLine("Name: " + nameProduct);
            Console.WriteLine("Price: " + priceProduct);

        }
    }
}
