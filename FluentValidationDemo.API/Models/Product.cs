using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationDemo.API.Models
{
    [Serializable]
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Adress PlaceOfOrigin { get; set; }
        public string ProductType { get; set; }
        public double Price { get; set; }
    }
}
