﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDataBase.Model
{
    internal class tag
    {
        public int id {  get; set; }
        public string name { get; set; }
        public ICollection<Post> posts { get; set; }
    }
}
