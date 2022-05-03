﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    public class Blog
    {
        public int ID { get; set; }
        public string URL { get; set; }
        public List<Post> Posts { get; set; } = new();
    }
}
