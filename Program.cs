using System;
using System.Collections.Generic;

namespace Menu.SaleItems {
    class Program {
        static void Main()
        {
           Console.WriteLine("Welcome to May's, the #1 Bakery in the County.");
        
           Console.WriteLine("---------------------------------------------");

           Console.WriteLine("How many pastries would you like to order?");
           int numberOfPastries = int.Parse(Console.ReadLine());
           Console.WriteLine("How many pieces of bread would you like to order?");

           int numberOfBread = int.Parse(Console.ReadLine());
           Console.WriteLine($"Great, it looks like you chose {numberOfPastries} from pastries, and {numberOfBread} bread.");

           Order customerOrder = new Order(numberOfPastries, numberOfBread);

           Console.WriteLine($"I am pastry property: {customerOrder.PastryCount} ");
           Console.WriteLine($"I am bread property: {customerOrder.BreadCount} ");

           Console.WriteLine("---------------------------------------------");

           Console.WriteLine(customerOrder.pastryCosts(customerOrder.PastryCount));

        }
    }
}