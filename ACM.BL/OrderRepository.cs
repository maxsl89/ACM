using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        ///  Retrieve one order
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            // create the instanse of the order class
            // pass in the requested id
            Order order = new Order(orderId);
            
            // code that retrieves the defined order
            
            // temporary hard coded values to return 
            // a populated order
            if(orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2014, 07, 12, 06, 32, 00, new TimeSpan());
            }

            return order;
        }

        /// <summary>
        /// Code that saves the defined order
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //Code that saves the defined order
            return true;
        }
    }
}
