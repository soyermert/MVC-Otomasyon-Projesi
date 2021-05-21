using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Otomasyon.Models.Siniflar
{
    public class SatisHareket
    {
        [Key]
        public int SatisID { get; set; }
        //ÜRÜN
        //CARİ
        //PERSONEL
        
        public int Adet { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Fiyat { get; set; }
        public decimal ToplamTutar { get; set; }
        //Bir satış hareketinde birden çok ürün olabilir.
        public Urun Urun { get; set; }
        public Cariler Cariler { get; set; }
        public Personel Personel { get; set; }
    }
}