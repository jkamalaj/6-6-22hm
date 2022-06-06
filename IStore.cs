using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal interface IStore

    {
        Product[] Products { get; }
        int Productlimit { get; set; }
        void AddProduct(Product product);
        void SellProduct(string No);
        double TotalInCome { get; }
        
      



    }
}
