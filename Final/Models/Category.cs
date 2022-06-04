using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public IEnumerable<Product> Products { get; set; }
     
        public IEnumerable<Blog> Blogs { get; set; }

    }
}
