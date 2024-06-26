﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class User
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string Login {  get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public List<Cart> Cart {  get; set; }
    }
}
