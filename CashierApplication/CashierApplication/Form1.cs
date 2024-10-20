using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class Form1 : Form
    {
        DiscountedItem item = new DiscountedItem();
        public class Item
        {
            public string ItemName { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }
        }
        public class DiscountedItem : Item
        {
            public double Discount { get; set; }
            public double GetTotalAmount()
            {
                double discountedPrice = Price * (1 - (Discount * 0.01));
                return discountedPrice * Quantity;
            }
        }        
        public Form1()//Dingson Oswell
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           try
            {
                item.Price = Convert.ToDouble(Pricetxtbox.Text);
                item.Discount = Convert.ToDouble(Discounttxtbox.Text);
                item.Quantity = Convert.ToInt32(Quantitytxtbox.Text);

                double totalAmount = item.GetTotalAmount();
                label6TotalAm.Text = "Total amount: " + totalAmount.ToString("F2");
            }
            catch(Exception) 
            {
                MessageBox.Show("ERROR!! Enter Valid Numbers for Price, Discount, and Quantity.");
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double totalAmount = Convert.ToDouble(label6TotalAm.Text.Split(':')[1]);
                double paymentReceived = Convert.ToDouble(Paymenttxtbox.Text);
                
                if (paymentReceived >= totalAmount)
                {
                    double change = paymentReceived - totalAmount;
                    label9Change.Text = "Change: " + change.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Payment received is less than the total amount.");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("ERROR!! calculate the total amount first and enter a valid payment.");
            }
        }
    }
}
