//Anthony Piccirilli
//Final Project
//December 5, 2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ShoppingCart.Controller
{
    public class Product
    {
        public string ProductType { get; set; }
        public int ProductID { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        public Product(string _producttype, int _productid, string _title, double _price)
        {
            ProductType = _producttype;
            ProductID = _productid;
            Title = _title;
            Price = _price;
        }

        public double discountPercentage(int quantity)
        {
            
            if (quantity < 2 )
            {
                return 0;
            }
            else if(quantity > 5)
            {
                return .05;
            }
            else
            {
                return .02;
            }

            
        }
       
    }   
}
