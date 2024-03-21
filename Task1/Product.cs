using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Product
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required double Price { get; set; }
        public double ActionPrice { get; set; }
        public string Description {  get; set; }
        public string DescriptionField1 {  get; set; }
        public string DescriptionField2 { get; set;}
        public string ImgUrl {  get; set; }
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
        public List<Cart> Cart { get; set; }
        public List<KeyParams> KeyWords { get; set; }

    }
}
