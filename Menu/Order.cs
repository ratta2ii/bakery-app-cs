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

        public int PastryCosts()
        {
            if (PastryCount >= 3){
                threePastries = PastryCount / 3;
            }
            if (PastryCount % 3 != 0 || PastryCount < 3)
            {
                singlePastry = PastryCount % 3;
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

        public int BreadCosts()
        {
            if (BreadCount >= 3){
                threeBread = BreadCount / 3;
            }
            if (BreadCount % 3 != 0 || BreadCount < 3)
            {
                singleBread = BreadCount % 3;
            }
            int discountFees = threeBread * 10;
            int fullPriceFees = singleBread * 5;

            return discountFees + fullPriceFees;
        }

    }

    class Order {

        public string TotalCosts(int pastry, int bread)
        {
            int grandTotal = pastry + bread;

            return $"Your Grand Total: ${grandTotal}.00";
        }
    }

}







 





