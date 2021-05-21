using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Otomasyon.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        //Kullanıcı adı'nın türü varchar olacak
        //Kullanıcı adı'nın uzunluğu 10 karakter olacak
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string KullaniciAdi { get; set; }
        
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string Sifre { get; set; }
        public string Yetki { get; set; }

    }
}