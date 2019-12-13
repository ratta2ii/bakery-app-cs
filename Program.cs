using System;
using System.Collections.Generic;

namespace Menu.SaleItems {
    class Program {
        static void Main()
        {
           Console.WriteLine("Welcome to May's, the #1 Bakery in the County.");
           Console.WriteLine("Please Choose the total number of pastries you would like to order, followed by the best Bread ever. ");

           Console.WriteLine("How many pastries would you like to order?");
           int numberOfPastries = int.Parse(Console.ReadLine());

           Console.WriteLine($"Looks like you chose {numberOfPastries}, great. Now how many pieces fo bread would you like with that?");

           int numberOfBread = int.Parse(Console.ReadLine());
           Console.WriteLine($"Great, looks like you chose {numberOfBread}. Let me get your total for you.");
        }
    }
}