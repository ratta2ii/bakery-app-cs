using System;


namespace Menu.Order {
    class Program {
        static void Main()
        {
            Console.WriteLine("Welcome to Pierre's, the #1 Bakery in the County.");
            Console.WriteLine("How many pastries would you like to order?");
            int numberOfPastries = int.Parse(Console.ReadLine());
            Console.WriteLine("How many pieces of loaves of bread would you like to order?");
            int numberOfBread = int.Parse(Console.ReadLine());
            
            Console.WriteLine("--------------------");
            Console.WriteLine($"It looks like you chose {numberOfPastries} from pastries, and {numberOfBread} from bread.");

            // Order customerOrder = new Order(numberOfPastries, numberOfBread);

            Pastry pastryOrder = new Pastry(numberOfPastries);
            Bread breadOrder = new Bread(numberOfBread);

            Console.WriteLine("--------------------");
            Console.WriteLine(Order.TotalCosts(2, 5));
        }
    }
}