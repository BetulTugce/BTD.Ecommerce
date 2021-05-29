using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTD.Ecommerce.Core.Model.Entity
{
    public class Category : EntityBase
    {
        public int ParentID { get; set; } = 0;//Default değeri 0 çünkü eğer bir şeyin üst idsi 0sa ana kategoridir. Mesela 1 se 1in alt kategorisi demektir.
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
