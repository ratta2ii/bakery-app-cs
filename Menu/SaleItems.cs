using System;
using System.Collections.Generic;

namespace Menu.SaleItems {
    class Bread {
       
    }

    class Pastry {

        public string PastryName { get; set; }
        public int PastryCount { get; set; }

        public Pastry(string name, int pastryCount)
        {
            PastryName = name;
            PastryCount = pastryCount;
        }

    }
}