using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTD.Ecommerce.Core.Model.Entity
{
    public class OrderProduct : EntityBase
    {
        public int OrderID { get; set; } //Hangi siparişe ait ürün listesi
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
