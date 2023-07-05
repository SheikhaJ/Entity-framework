using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDataBase.Model
{
    internal class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
       
        public blog blog { get; set; }
        public ICollection<tag> tag { get; set; }


    }
}
