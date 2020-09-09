using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationDemo.API.Models
{
    [Serializable]
    public class Adress
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Detail { get; set; }

    }
}
