using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECore_class2
{
    internal class Blog
    {
       public int Id { get; set; }
        public string blogTitle { get; set; }
        public string blogDescription { get; set; }

    }
}
