﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDataBase.Model
{
    internal class blog
    {
        public int blogId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public List<Post> Posts { get; set; }

        public int AuthorID { get; set; }
        public Author authour { get; set; }

    }
}
