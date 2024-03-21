using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Order
    {
        public Guid OrderId { get; set; }
        public string Name { get; set; }
        public DateTime Create { get; set; }
        public DateTime Update { get; set; }
        public string Description { get; set; }
        public int OrderAlterId { get; set; }
    }
    
}
