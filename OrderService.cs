using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Management_System
{
    public class OrderService
    {
        public void CreateOrder(Order order)
        {
            Console.WriteLine("Creating order...");


            ApplyDiscount(order);

            SaveOrder(order);

            SendEmail(order);

            Log(order);

            ProcessPayment(order);
        }



        public void ApplyDiscount(Order order)
        {
            // duplicated logic begins

            if (order.TotalPrice > 1000)
            {
                Console.WriteLine("10% Discount Applied");
            }

            if (order.TotalPrice > 5000)
            {
                Console.WriteLine("20% Discount Applied");
            }
        }



        public void SaveOrder(Order order)
        {
            Console.WriteLine("Saving order to DB");

            // imagine DB save here
        }



        public void SendEmail(Order order)
        {

            Console.WriteLine(
                $"Email sent to {order.CustomerEmail}"
            );
        }



        public void Log(Order order)
        {
            Console.WriteLine(
                $"Order {order.Id} logged"
            );
        }



        public void ProcessPayment(Order order)
        {
            PaymentManager payment =
                    new PaymentManager();

            payment.Visa(order);

            
        }



        public void UpdateOrder(Order order)
        {

            if (order.TotalPrice > 1000)
            {
                Console.WriteLine("10% Discount Applied");
            }

            if (order.TotalPrice > 5000)
            {
                Console.WriteLine("20% Discount Applied");
            }

            Console.WriteLine(
                "Updating order..."
            );
        }
    }
}
