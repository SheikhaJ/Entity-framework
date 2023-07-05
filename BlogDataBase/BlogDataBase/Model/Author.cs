using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDataBase.Model
{
    internal class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Feild { get; set; }
        public int Age { get; set; }
        public blog blog { get; set; }
    }
}
