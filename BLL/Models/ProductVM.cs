using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class ProductVM
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int Ctg_Id { get; set; }
    }
}
