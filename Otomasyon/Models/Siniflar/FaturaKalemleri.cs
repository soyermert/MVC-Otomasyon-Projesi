using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Otomasyon.Models.Siniflar
{
    public class FaturaKalemleri
    {
        [Key]
        public int FaturaKalemID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Aciklama { get; set; }
        public int Miktar{ get; set; }
        public decimal  BirimFiyat{ get; set; }
        public decimal  Tutar{ get; set; }
       //Bir fatura kaleminin bir faturası vardır.
        public Faturalar Faturalar { get; set; }
    }
}