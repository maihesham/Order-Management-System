using System;

namespace Order_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1,
                CustomerName = "Mai",
                CustomerEmail = "mai@test.com",
                TotalPrice = 6000
            };

            OrderService orderService = new OrderService();

            orderService.CreateOrder(order);

            Console.ReadLine();
        }
    }





  



    
}