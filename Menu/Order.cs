using System;


namespace Menu.Order {
  
    class Pastry {

        int threePastries;
        int singlePastry;
        public int PastryCount { get; set; }
        public Pastry(int pastryCount)
        {
            PastryCount = pastryCount;
        }

        public int PastryCosts(int pastryCount)
        {
            if (pastryCount >= 3){
                threePastries = pastryCount / 3;
            }
            if (pastryCount % 3 != 0 || pastryCount < 3)
            {
                singlePastry = pastryCount % 3;
            }
            int discountFees = threePastries * 5;
            int fullPriceFees = singlePastry * 2;

            return discountFees + fullPriceFees;    
        }

    }

    class Bread {
        int singleBread;
        int threeBread;
        public int BreadCount { get; set; }

        public Bread(int breadCount)
        {
            BreadCount = breadCount;
        }

        public int BreadCosts(int breadCount)
        {
            if (breadCount >= 3){
                threeBread = breadCount / 3;
            }
            if (breadCount % 3 != 0 || breadCount < 3)
            {
                singleBread = breadCount % 3;
            }
            int discountFees = threeBread * 10;
            int fullPriceFees = singleBread * 5;

            return discountFees + fullPriceFees;
        }

    }

    // class Order {

    //     public string TotalCosts(int pastryCount, int breadCount)
    //     {
    //         int totalPastryCosts = Menu.Order.Pastry.PastryCosts(pastryCount);
    //         int totalBreadCosts = BreadCosts(breadCount);
    //         int grandTotal = totalPastryCosts + totalBreadCosts;

    //         return $"Your Grand Total: ${grandTotal}.00";
    //     }
    // }

}







 





