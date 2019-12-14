using System;


namespace Menu.Order {
    class Program {
        static void Main()
        {
            Console.WriteLine("Welcome to Pierre's, the #1 Bakery in the County.");


            Console.WriteLine("How many pastries would you like to order?");
            int numberOfPastries = int.Parse(Console.ReadLine());
            Pastry pastryOrder = new Pastry(numberOfPastries);
            int pastryTotal = pastryOrder.PastryCosts();


            Console.WriteLine("How many pieces of loaves of bread would you like to order?");
            int numberOfBread = int.Parse(Console.ReadLine());
            Bread breadOrder = new Bread(numberOfBread);
            int breadTotal = breadOrder.BreadCosts();

            
            Console.WriteLine($"It looks like you chose {numberOfPastries} from pastries, and {numberOfBread} from bread.");


            Order finalOrder = new Order();
            string grandTotal = finalOrder.TotalCosts(pastryTotal, breadTotal);
            Console.WriteLine(grandTotal);
        }
    }
}