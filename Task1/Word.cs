﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Word
    {
        public Guid Id { get; set; }
        public string Header { get; set; }
        public string KeyWords {  get; set; }
        public List<KeyParams> PrpductLink { get; set; }
    }
}