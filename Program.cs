using System;

namespace Menu.Order {
    class Program {
        static void Main()
        {
            Console.WriteLine("Welcome to May's, the #1 Bakery in the County.");
            Console.WriteLine("--------------------");

            Console.WriteLine("How many pastries would you like to order?");
            int numberOfPastries = int.Parse(Console.ReadLine());

            Console.WriteLine("How many pieces of bread would you like to order?");
            int numberOfBread = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------");

            Console.WriteLine($"It looks like you chose {numberOfPastries} from pastries, and {numberOfBread} from bread.");

            Order customerOrder = new Order(numberOfPastries, numberOfBread);

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(customerOrder.TotalCosts(customerOrder.PastryCount, customerOrder.BreadCount));
        }
    }
}