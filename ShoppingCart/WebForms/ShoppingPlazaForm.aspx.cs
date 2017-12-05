//Anthony Piccirilli
//Final Project
//December 5, 2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoppingCart.Controller;
using ShoppingCart.Model;
using System.Globalization;

namespace ShoppingCart.WebForms
{
    public partial class ShoppingPlazaFormaspx : System.Web.UI.Page
    {
        List<CartObject> cart = new List<CartObject>();
        List<Product> allProducts = new List<Product>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Cart"] == null)
            {
                Session.Add("Cart", cart);
            }

            BuildProducts buildProd = new BuildProducts();
            allProducts = (List<Product>)Session["AllProducts"];

            if (!IsPostBack)
            {
                foreach (Product i in allProducts)
                {
                    if (i.ProductType == "Book")
                    {
                        BooksDropDownList.Items.Add(i.Title);
                    }
                }

                foreach (Product i in allProducts)
                {
                    if (i.ProductType == "DVD")
                    {
                        DVDDropDownList.Items.Add(i.Title);
                    }

                }

                var bookList = allProducts.Where(b => b.ProductType == "Book").ToList();
                var dvdList = allProducts.Where(i => i.ProductType == "DVD").ToList();

                BooksDropDownList.SelectedIndex = 0;
                DVDDropDownList.SelectedIndex = 0;



                BookPriceValLbl.Text = bookList[BooksDropDownList.SelectedIndex].Price.ToString("c");
                DVDPriceValLbl.Text = dvdList[DVDDropDownList.SelectedIndex].Price.ToString("c");
            }
            
              
        }

        protected void BooksDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bookList = allProducts.Where(b => b.ProductType == "Book").ToList();
            BookPriceValLbl.Text = bookList[BooksDropDownList.SelectedIndex].Price.ToString("c");
        }

        protected void DVDDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dvdList = allProducts.Where(i => i.ProductType == "DVD").ToList();
            DVDPriceValLbl.Text = dvdList[DVDDropDownList.SelectedIndex].Price.ToString("c");
        }

        public bool checkForDuplicate(Product product, List<CartObject> cart)
        {
            bool result = false;
            foreach (CartObject c in cart)
            {
                if (product.ProductID == c.obj.ProductID)
                {
                    result = true;
                }
            }
            return result;
        }


        protected void AddItemBtn_Click(object sender, EventArgs e)
        {
            if (Session["Cart"] != null)
            {
                cart = (List<CartObject>)Session["Cart"];
                int dvd;
                int book;
                if (int.TryParse(BookQuantityTextBox.Text, out book) | int.TryParse(DVDQuantityTextbox.Text, out dvd))
                {
                    if (book > 0)
                    {
                        var bookList = allProducts.Where(b => b.ProductType == "Book").ToList();
                        Product selectedBook = bookList[BooksDropDownList.SelectedIndex];
                        CartObject cobj = new CartObject(book, selectedBook);
                        if (!checkForDuplicate(selectedBook, cart))
                        {
                            cart.Add(cobj);
                            MessageLbl.Text = "Item added: " + selectedBook.Title.ToString() + ", Quantity: " + book.ToString();
                        }
                        else
                        {
                            MessageLbl.Text = "The item " + selectedBook.Title.ToString() + " has already been added to the cart. Please select a different item.";
                        }
                    }
                    if (dvd > 0)
                    {
                        var dvdList = allProducts.Where(i => i.ProductType == "DVD").ToList();
                        Product selectedDvd = dvdList[DVDDropDownList.SelectedIndex];
                        CartObject cobj = new CartObject(dvd, selectedDvd);
                        if (!checkForDuplicate(selectedDvd, cart))
                        {
                            cart.Add(cobj);
                            MessageLbl1.Text = "Item added: " + selectedDvd.Title.ToString() + ", Quantity: " + dvd.ToString();
                        }
                        else
                        {
                            MessageLbl1.Text = "The item " + selectedDvd.Title.ToString() + " has already been added to the cart. Please select a different item.";
                        }
                    }
                    Session["Cart"] = cart;
                }
                else
                {
                    MessageLbl.Text = "One of the quantities must be more than 0. Otherwise, Please Click Exit";
                }
            }
           
        }

        protected void CheckoutBtn_Click(object sender, EventArgs e)
        {
            cart = (List<CartObject>)Session["Cart"];
            if (cart.Count != 0)
            {
                Response.Redirect("Checkout.aspx");
            }
            else
            {
                MessageLbl1.Text = "You must have at least one item in your cart to proceed to the checkout screen.";
            }

        }

        protected void ExitBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ExitPage.aspx");
        }
    }

    
    }