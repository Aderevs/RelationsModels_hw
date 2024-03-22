using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Cart
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public required Guid UserId { get; set; }
        public Product Product { get; set; }
        public required Guid ProductId { get; set; }
    }
}
