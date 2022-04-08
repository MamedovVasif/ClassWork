using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem.Models
{
    class Order
    {
        public int ID { get; set; }
        public  List<ProductItem> ProductItem { get; set; }
        public double OrderPrice { get; set; }

    }
}
