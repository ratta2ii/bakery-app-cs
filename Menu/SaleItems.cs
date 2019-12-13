using System;
using System.Collections.Generic;

namespace Menu.SaleItems {
   
    class Order {

        public int PastryCount { get; set; }
        public int BreadCount { get; set; }
        public int DiscountCount { get => DiscountCount1; set => DiscountCount1 = value; }
        public int DiscountCount1 { get => discountCount; set => discountCount = value; }

        public Order(int pastryCount, int breadCount)
        {
            PastryCount = pastryCount;
            BreadCount = breadCount;
        }

        int discountCount;
        int fullPriceCount;
        public int pastryCosts(int pastryCount)
        {
          
            if (pastryCount > 3){
                DiscountCount1 = pastryCount / 3;
            }
            if (pastryCount % 3 != 0)
            {
                fullPriceCount = pastryCount % 3;
            }
            int discountFees = DiscountCount1 * 5;
            int fullPriceFees = fullPriceCount * 2;
            return discountFees + fullPriceFees;
        }

    //    static int TotalCharges(int pastryCost, int breadCost)
    //    {

    //    }
    }
}


/*
Pastry: Buy 1 for \$2 or 3 for $5.
Bread: Buy 2, get 1 free. A single loaf costs $5.
 */