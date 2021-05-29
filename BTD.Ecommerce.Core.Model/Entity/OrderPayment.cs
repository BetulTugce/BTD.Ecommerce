using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTD.Ecommerce.Core.Model.Entity
{
    public class OrderPayment : EntityBase
    {
        public int OrderID { get; set; } //Hangi orderın paymentı(Dikkat sipariş detayına değil siparişe bağlı)
        public _OrderType OrderType { get; set; } //Ödeme tipi
        public decimal Price { get; set; }
        public string Bank { get; set; } //Hangi bankaya? Benim 5 10 tane hesabım olabilir
    }
    public enum _OrderType
    {
        Havale = 0,
        Kredikarti = 1
    }
}
