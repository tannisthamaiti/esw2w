using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double Price;
            double Priceofeachtopping;
            double Priceofcoke;

            Console.WriteLine("Number Of Orders: ");
            Console.WriteLine("----------------");
            double numberofOrders = double.Parse(Console.ReadLine());

            Console.WriteLine("Size of PIZZA 2:Large, 1:Medium, 0:Small: ");
            double sizeofPizza = double.Parse(Console.ReadLine());

            Console.WriteLine("Number of toppings: ");
            double toppings = double.Parse(Console.ReadLine());

            Console.WriteLine("You want a Coke (1:Yes, 0:No) : ");
            double Coke = double.Parse(Console.ReadLine());

            if (sizeofPizza == 2)
            {
                Price = 15.00;
            }
            if (sizeofPizza == 1)
            {
                Price = 10.00;
            }
            if (sizeofPizza == 0)
            {
                Price = 5.00;
            }

            if (toppings >= 1)
            {
                Priceofeachtopping = 0.50;
            }

            if (Coke == 1)
            {
                Priceofcoke = 2.00;
            }

            double totalprice = sizeofPizza + toppings + Coke;
            double deliveryPrice = 10;

            if (numberofOrders >= 2)
            {
                totalprice = totalprice * 2;
            }

            Console.WriteLine("Number of orders: " + numberofOrders);
            Console.WriteLine("Your Total Bill: " + totalprice);

            if (totalprice <= 25)
            {
                Console.WriteLine("A delivery fee of $10 is required");
                Console.WriteLine("Price After Delivery Charges: " + (totalprice + deliveryPrice));
            }
            else if (totalprice > 25)
            {
                Console.WriteLine("Congratulations you qualify for free delivery");
            }

        }
    }
}
