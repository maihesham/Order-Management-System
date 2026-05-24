using System;

namespace Order_Management_System
{
    public enum OrderAction
    {
        Create = 1,
        Update = 2
    }
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

            Console.WriteLine("Enter action:");
            Console.WriteLine("1 - Create Order");
            Console.WriteLine("2 - Update Order");

            int input = int.Parse(Console.ReadLine());

            OrderAction action = (OrderAction)input;
            if (action == OrderAction.Create)
            {
                orderService.CreateOrder(order);
            }
            else
            {
                orderService.UpdateOrder(order);
            }
        }
    }





  



    
}