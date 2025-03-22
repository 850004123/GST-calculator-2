using System;

namespace GST_calculator_2
{
    class Program
    {
        static void Main(string[] args)
            // Written by Jordan.E
        {
            // Ask user to enter product name
            Console.WriteLine("Please enter product name: ");
            string product = Console.ReadLine();

            // Ask user to enter quantity
            Console.WriteLine("Please enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            // Ask user to enter product cost
            Console.WriteLine("Please enter product cost: ");
            double cost = Convert.ToDouble(Console.ReadLine());

            // Ask user if GST is included in the price
            Console.WriteLine(" Is GST included in the price? (y/n)");
            string gstchoice = Console.ReadLine();

            // Check user choice is GST included or not

            if (gstchoice == "y")
               

            {
              // Calculate amount excluding GST

                double amountExcludingGST = cost/ 1.15;

                // Display the total amount excluding GST

                Console.WriteLine("The total amount excluding GST is: " + amountExcludingGST);

            }
            else if (gstchoice == "n")
            {
                double total = cost * quantity;
                double gst = total * 0.15;
                double totalgst = total + gst;
                Console.WriteLine("Product: " + product);
                Console.WriteLine("Quantity: " + quantity);
                Console.WriteLine("Price: " + cost);
                Console.WriteLine("Total: " + total);
                Console.WriteLine("GST: " + gst);
                Console.WriteLine("Total with GST: " + totalgst);
            }
            else
            {   // Display error message if user enters invalid choice
                Console.WriteLine("Invalid choice");
            }














        }
    }
}