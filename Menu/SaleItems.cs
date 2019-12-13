using System;


namespace Menu.Order {
    class Order {

        int threePastries;
        int singlePastry;
        int singleBread;
        int threeBread;

        public int PastryCount { get; set; }
        public int BreadCount { get; set; }

        public Order(int pastryCount, int breadCount)
        {
            PastryCount = pastryCount;
            BreadCount = breadCount;
        }

        private int PastryCosts(int pastryCount)
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

        private int BreadCosts(int breadCount)
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

        public string TotalCosts(int pastryCount, int breadCount)
        {
            int totalPastryCosts = PastryCosts(pastryCount);
            int totalBreadCosts = BreadCosts(breadCount);
            int grandTotal = totalPastryCosts + totalBreadCosts;

            return $"Your Grand Total: ${grandTotal}.00";
        }

    }
}



// Pastry: Buy 1 for \$2 or 3 for $5.
// Bread: Buy 2, get 1 free. A single loaf costs $5.




 





