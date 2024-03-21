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
        public required Product Product { get; set; }
        public required Guid ProductId { get; set; }
        public required Word KeyWords { get; set; }
        public required Guid KeyWordsId { get; set; }
    }
}
