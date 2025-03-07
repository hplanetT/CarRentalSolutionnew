using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Rental
    {
        public int RentalID { get; set; }  // Primary Key
        public int CarID { get; set; }  // FK - Kiralanan Araç
        public int CustomerID { get; set; }  // FK - Kiralayan Müşteri
        public int UserID { get; set; }  // FK - İşlemi yapan personel
        public DateTime RentDate { get; set; }  // Kiralama Başlangıç Tarihi
        public DateTime? ReturnDate { get; set; }  // İade Tarihi (Opsiyonel)
        public decimal? TotalPrice { get; set; }  // Toplam Ücret
        public string Status { get; set; }  // "Aktif", "Tamamlandı", "İptal Edildi"
        
   
        public virtual Car Car { get; set; }

        public virtual Customer Customer { get; set; }

       
        public virtual Payment Payment { get; set; }
    }
}
