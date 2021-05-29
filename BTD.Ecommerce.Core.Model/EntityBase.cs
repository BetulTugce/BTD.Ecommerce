using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTD.Ecommerce.Core.Model
{
    public class EntityBase
    {
        [Key] //Tablomda bir tane key olmak zorunda
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//Tablodaki id alanı her seferinde kendi kendini arttırsın

        //Her tablomda olması gereken alanlar
        public int ID { get; set; }
        public DateTime CreateDate { get; set; } //Her kaydın kayıt tarihini tutmak zorundayım
        public int CreateUserID { get; set; } //Kaydı kimin oluşturduğunu tutmalıyım
        public int? UpdateUserID { get; set; } //Kaydı kimin güncellediğini tutmak zorundayım ama kayıt update edilene kadar boş olabilir. Zorunlu olmaması lazım.
        public DateTime? UpdateDate { get; set; } //Her kaydın update dateini tutmalıyım ama kayıt update edilene kadar boştur.Soru işareti boş bırakılabilir anlamına geliyor.
    }
}
