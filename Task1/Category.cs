using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Category
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string Icon { get; set; }
        public List<Product> Products { get; set; }
    }
}
