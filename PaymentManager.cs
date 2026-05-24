using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Management_System
{
    public class PaymentManager
    {
        public void Visa(Order order)
        {
            Console.WriteLine(
                $"Visa payment for {order.TotalPrice}"
            );
        }


        public void PayPal(Order order)
        {
            Console.WriteLine(
                $"Paypal payment for {order.TotalPrice}"
            );
        }


        public void Crypto(Order order)
        {
            Console.WriteLine(
                $"Crypto payment for {order.TotalPrice}"
            );
        }


       
    }
}
