using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal abstract class Market
    {

        private Product[] _products;
        public Product[] Products  = new Product[0];
        private double _totalInCome;

        public int Productlimit { get; set; }
        public double TotalInCome { get => _totalInCome; }

      public void AddProduct(Product product)
        {
            if (Productlimit > Products.Length)
            {
                Array Resize (ref Product  , Product.Length+1) 
                Products[Products.Length - 1] = product;

            }
        }
        public void SellProduct (  int No)
        { int count = 0;
          
            
            for (int i=0;i<Products.Length;i++)
            if ( Products[i] == No && count != 0)
                {
                    count--;
                    _totalInCome++;
                }
        }




    }




}
