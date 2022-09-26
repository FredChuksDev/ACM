using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if(orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now);
            }
            return order;
        }

        //Saves the current order
        public bool Save(Order order)
        {
            //Code that saves the passed in order
            return true;
        }


    }
}
