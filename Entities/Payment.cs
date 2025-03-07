using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Payment
    {
        public int PaymentID { get; set; }  // Primary Key
        public int RentalID { get; set; }  // FK - Kiralama İşlemi
        public DateTime PaymentDate { get; set; }  // Ödeme Tarihi
        public decimal Amount { get; set; }  // Ödeme Tutarı
        public string PaymentMethod { get; set; }  // "Nakit" veya "Kredi Kartı"

        public virtual Rental Rental { get; set; }
    }
}
