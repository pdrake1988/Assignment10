using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    public class Order
    {
        public int Id { get; set; }
        public string Buyer { get; set; }
        public Product Product { get; set; }
    }
}
