using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veshi
{
    public class Things
    {
        private string Name_;
        private double price_;
        private int quantity_;
        private Vid_odezhdi Vid_;

        public Things(string veshiName, double veshiPrice,int quantity, Vid_odezhdi Vid)
        {
            Name_ = veshiName;
            price_ = veshiPrice;
            quantity_ = quantity;
            Vid_ = Vid;
        }

        public string GetName()
        {
            return Name_;
        }
        public double GetPrice()
        {
            return price_;
        }
        public int GetQuantity()
        {
            return quantity_;
        }
        public Vid_odezhdi GetVid()
        {
            return Vid_;
        }

    }
}
