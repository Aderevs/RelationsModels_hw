using Microsoft.EntityFrameworkCore;

namespace Task1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using MyDatabase db = new MyDatabase();
            var orders = new List<Order>
            {
                new Order
                {
                    OrderId = Guid.NewGuid(),
                    Name = "Order 1",
                    Create = new DateTime(2023, 3, 1),
                    Update = new DateTime(2023, 3, 2),
                    Description = "This is the first order.",
                    OrderAlterId = 1
                },
                new Order
                {
                    OrderId = Guid.NewGuid(),
                    Name = "Order 2",
                    Create = new DateTime(2023, 3, 3),
                    Update = new DateTime(2023, 3, 4),
                    Description = "This is the second order.",
                    OrderAlterId = 2
                },
                new Order
                {
                    OrderId = Guid.NewGuid(),
                    Name = "Order 3",
                    Create = new DateTime(2023, 3, 5),
                    Update = new DateTime(2023, 3, 6),
                    Description = "This is the third order.",
                    OrderAlterId = 3
                },
                new Order
                {
                    OrderId = Guid.NewGuid(),
                    Name = "Order 4",
                    Create = new DateTime(2023, 3, 7),
                    Update = new DateTime(2023, 3, 8),
                    Description = "This is the fourth order.",
                    OrderAlterId = 4
                },
                new Order
                {
                    OrderId = Guid.NewGuid(),
                    Name = "Order 5",
                    Create = new DateTime(2023, 3, 9),
                    Update = new DateTime(2023, 3, 10),
                    Description = "This is the fifth order.",
                    OrderAlterId = 5
                },
                new Order
                {
                    OrderId = Guid.NewGuid(),
                    Name = "Order 6",
                    Create = new DateTime(2023, 3, 11),
                    Update = new DateTime(2023, 3, 12),
                    Description = "This is the sixth order.",
                    OrderAlterId = 6
                },
                new Order
                {
                    OrderId = Guid.NewGuid(),
                    Name = "Order 7",
                    Create = new DateTime(2023, 3, 13),
                    Update = new DateTime(2023, 3, 14),
                    Description = "This is the seventh order.",
                    OrderAlterId = 7
                },
                new Order
                {
                    OrderId = Guid.NewGuid(),
                    Name = "Order 8",
                    Create = new DateTime(2023, 3, 15),
                    Update = new DateTime(2023, 3, 16),
                    Description = "This is the eighth order.",
                    OrderAlterId = 8
                },
                new Order
                {
                    OrderId = Guid.NewGuid(),
                    Name = "Order 9",
                    Create = new DateTime(2023, 3, 17),
                    Update = new DateTime(2023, 3, 18),
                    Description = "This is the ninth order.",
                    OrderAlterId = 9
                },
                new Order
                {
                    OrderId = Guid.NewGuid(),
                    Name = "Order 10",
                    Create = new DateTime(2023, 3, 19),
                    Update = new DateTime(2023, 3, 20),
                    Description = "This is the tenth order.",
                    OrderAlterId = 10
                }
            };

            foreach (var order in orders)
            {
                db.Add(order);
            }
            await db.SaveChangesAsync();
            
            Console.WriteLine("Hello, World!");
        }
    }
}
