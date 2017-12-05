//Anthony Piccirilli
//Final Project
//December 5, 2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoppingCart.Controller;

namespace ShoppingCart.Model
{
    public class BuildProducts
    {
        List<Product> prod = new List<Product>();
        
        public BuildProducts()
        {
            prod.Add(new Product("Book", 101, "Big Data: A Revolution That Will Transform How We Live, Work, and Think", 50.55));
            prod.Add(new Product("Book", 102, "Disruptive Possibilities: How Big Data Changes Everything", 65.67));
            prod.Add(new Product("Book", 103, "Data Smart: Using Data Science to Transform Information into Insight", 32.78));
            prod.Add(new Product("Book", 104, "Big Data: Principles and best practices of scalable realtime data systems", 90.65));
            prod.Add(new Product("Book", 105, "Big Data Science & Analytics: A Hands-On Approach", 15.25));
            prod.Add(new Product("DVD", 201, "The Grand Tour Season 1", 10.00));
            prod.Add(new Product("DVD", 202, "Spectre", 11.99));
            prod.Add(new Product("DVD", 203, "Goliath Season 1", 12.99));
            prod.Add(new Product("DVD", 204, "The Hunger Games: Mockingjay Part 2", 10.99));
            prod.Add(new Product("DVD", 205, "Good Girls Revolt", 11.99));


            HttpContext.Current.Session["AllProducts"] = prod;
        }


        
    }
}