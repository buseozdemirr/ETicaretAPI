using ETicareAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicareAPI.Domain.Entities
{
    public class Product:BaseEntity
    {
        public int Stock { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
