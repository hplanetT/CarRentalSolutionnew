using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Car
    {
        public int CarID { get; set; }  // Primary Key
        public string Brand { get; set; }  // Araç Markası (BMW, Mercedes, vb.)
        public string Model { get; set; }  // Araç Modeli
        public int Year { get; set; }  // Araç Model Yılı
        public string LicensePlate { get; set; }  // Plaka (Benzersiz olmalı)
        public string FuelType { get; set; }  // Yakıt Türü: "Benzin", "Dizel", "Elektrik"
        public string Transmission { get; set; }  // Vites Türü: "Manuel" veya "Otomatik"
        public decimal DailyPrice { get; set; }  // Günlük Kiralama Ücreti
        public bool Status { get; set; }  // **True** → Kiralanabilir, **False** → Kirada
    }
}
