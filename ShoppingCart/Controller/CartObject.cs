using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.Controller
{
    public class CartObject
    {
        public int quantity { get; set; }

        public Product obj { get; set; }

        public CartObject(int _quantity, Product _obj)
        {
            quantity = _quantity;
            obj = _obj;
        }

    }
}