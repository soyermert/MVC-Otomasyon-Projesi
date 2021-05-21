using Otomasyon.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Otomasyon.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        Context c = new Context();
        public ActionResult Index()
        {
            var categories = c.Kategoris.ToList();
            return View(categories);
        }

        //public ActionResult KategoriEkle(int? KategoriID)
        //{
        //    if (KategoriID != 0)
        //    {
        //        var category = c.Kategoris.Where(m => m.KategoriID == KategoriID).SingleOrDefault();
        //        if (category != null)
        //        {
        //            return View(category);
        //        }

        //    }
        //    return View();
        //}

        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }


        [HttpPost]

        public ActionResult KategoriEkle(Kategori k)
        {
            c.Kategoris.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");

        }


        public ActionResult KategoriSil(int id)
        {
            var ktg = c.Kategoris.Find(id);
            c.Kategoris.Remove(ktg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult KategoriGetir(int id)
        {
            var kategori = c.Kategoris.Find(id);
            return View("KategoriGetir",kategori);
        }

        public ActionResult KategoriGuncelle(Kategori k)
        {
            var ktg = c.Kategoris.Find(k);
            c.SaveChanges();
            return RedirectToAction("Index");

        }



    }
}





