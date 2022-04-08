using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem.Models
{
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(int id,string name,double price)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
        }
        
    }
}
