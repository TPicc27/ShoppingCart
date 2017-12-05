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


namespace ShoppingCart.WebForms
{
    public partial class Checkout : System.Web.UI.Page
    {
        List<CartObject> cartObj = new List<CartObject>();
        double itemPrice;
        protected void Page_Load(object sender, EventArgs e)
        {
            cartObj = (List<CartObject>)Session["cart"];
            
            foreach(CartObject c in cartObj)
            {
                if(!IsPostBack)
                {
                    itemPrice = c.obj.Price * c.quantity;
                    CartListBox.Items.Add(c.obj.Title + " - " + itemPrice.ToString("c"));
                    QuantityTextBox.Enabled = false;
                }
            }
        }

        protected void CartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuantityTextBox.Enabled = true;

            cartObj = (List<CartObject>)Session["cart"];

            CartObject selectedProduct = cartObj[CartListBox.SelectedIndex];

            QuantityTextBox.Text = selectedProduct.quantity.ToString();
        }

        protected void AcceptBtn_Click(object sender, EventArgs e)
        {
            cartObj = (List<CartObject>)Session["cart"];
            CartObject selectedProduct = cartObj[CartListBox.SelectedIndex];

            if(Convert.ToInt16(QuantityTextBox.Text) == 0)
            {
                cartObj.Remove(selectedProduct);
                CartListBox.Items.Remove(CartListBox.SelectedItem);
                Session["cart"] = cartObj;
            }
            else 
            {
                cartObj[CartListBox.SelectedIndex] = new CartObject(Convert.ToInt16(QuantityTextBox.Text), selectedProduct.obj);
                Session["cart"] = cartObj;
            }
        }

        protected void PayBtn_Click(object sender, EventArgs e)
        {
            cartObj = (List<CartObject>)Session["cart"];
            double totalPrice = 0;
            double totalDiscount = 0;

            foreach(CartObject c in cartObj)
            {
                double productPrice = c.obj.Price;
                int quantity = c.quantity;
                double price = quantity * productPrice;
                double discount = c.obj.discountPercentage(quantity);
                totalPrice += price;
                totalDiscount += (price * discount);
            }

            TotalLabel.Text = "Total amount to pay is " + (totalPrice - totalDiscount).ToString("c") + ". You got a discount of: " + totalDiscount.ToString("c");
        }

        protected void ExitBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ExitPage.aspx");
        }
    }
}