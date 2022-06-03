using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System
{
    internal class Product
    {
        string productName = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());
        double DelivarPrice = double.Parse(Console.ReadLine());
        double PercentageMarkup = double.Parse(Console.ReadLine());
        double FinalPrice = double.Parse(Console.ReadLine());

        /*if (productName == null)
        {
            Console.WriteLine("Product name must not be null or empty!");
        }
        if (quantity != null)
        {
            Console.WriteLine("Quantity cannot be less or equal to 0!");
        }
        if (DelivarPrice == null)
        {
            Console.WriteLine("Deliver price cannot be less or equal to 0!");
        }
        if (PercentageMarkup != null)
        {
            Console.WriteLine("Percentage markup cannot be less or equal to 0!");
        }
        if (FinalPrice != null)
        {

        }*/


        public Product(string name, int quantity, double deliverPrice, double percentageMarkup)
        {
            this.productName = name;
            this.quantity = quantity;
            this.DelivarPrice = deliverPrice;
            this.PercentageMarkup = percentageMarkup;
        }
    }
}
