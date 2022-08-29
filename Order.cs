using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming_Concepts
{
    public class Order
    {
        public string OrderNo { get; set; }
        public string OrderValue { get; set; }
        public string OrderCountry { get; set; }

        public string CrateOrder()
        {
            validateOrderValue();
            validateOrderCountry();
            // Order Creation Logic 
            return "Order Created";
        }

        private bool validateOrderValue()
        {
            //Implementation go there
            return true;
        }

        private bool validateOrderCountry()
        {
            //Implementation go there
            return true;
        }
    }
}
