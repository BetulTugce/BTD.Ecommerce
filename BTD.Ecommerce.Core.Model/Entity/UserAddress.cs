using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTD.Ecommerce.Core.Model.Entity
{
    public class UserAddress : EntityBase
    {
        public int UserID { get; set; } //Kimin adresi olacağını belirtecek
        public User User { get; set; } //Usera bağladım. Yani tipi User ve Userın idsi. Yukarıdakiyle ikisi birbirini keylemiş oldu.
        public string Title { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
    }
}
