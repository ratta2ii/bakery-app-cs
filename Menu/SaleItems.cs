using System;
using System.Collections.Generic;

namespace Menu.SaleItems {
   
    class Order {

        public int PastryCount { get; set; }
        public int BreadCount { get; set; }

        public Order(int pastryCount, int breadCount)
        {
            PastryCount = pastryCount;
            BreadCount = breadCount;
        }

        // static int TotalCharges(int pastryCount, int breadCount)
        // {

        // }
    }
}