using sac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sac.Controllers
{
    public class MainAfavordeController : Controller
    {
        dbModel db = new dbModel();
        // GET: MainAfavorde
        public ActionResult Index()
        {
            return View(db.tblAfavorde.ToList());
        }
        public ActionResult Create()
        {
            List<SelectListItem> genero = new List<SelectListItem>();
            genero.Add(new SelectListItem() { Text = "Masculino", Value = "Masculino" });
            genero.Add(new SelectListItem() { Text = "Femenino", Value = "Femenino" });
            genero.Add(new SelectListItem() { Text = "Otros", Value = "Otros" });

            ViewBag.generos = genero;
            return View();
            ;
        }
        [HttpPost]
        public ActionResult Create(tblAfavorde afavorde)
        {
            db.tblAfavorde.Add(afavorde);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            List<SelectListItem> genero = new List<SelectListItem>();
            genero.Add(new SelectListItem() { Text = "Masculino", Value = "Masculino" });
            genero.Add(new SelectListItem() { Text = "Femenino", Value = "Femenino" });
            genero.Add(new SelectListItem() { Text = "Otros", Value = "Otros" });

            ViewBag.generos = genero;

            var datos = db.tblAfavorde.Find(id);
            return View(datos);
        }
        [HttpPost]
        public ActionResult Edit(tblAfavorde favorde, int id)
        {
            db.Entry(favorde).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var datos = db.tblAfavorde.Find(id);
            return View(datos);
        }
        public ActionResult Delete(int id)
        {
            var datos = db.tblAfavorde.Find(id);
            return View(datos);
        }
        [HttpPost]
        public ActionResult Delete(tblAfavorde favorde, int id)
        {
            var datos = db.tblAfavorde.Find(id);
            db.tblAfavorde.Remove(datos);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}