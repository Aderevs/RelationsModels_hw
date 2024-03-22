using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class KeyParams
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public required Guid ProductId { get; set; }
        public Word KeyWords { get; set; }
        public required Guid KeyWordsId { get; set; }
    }
}
