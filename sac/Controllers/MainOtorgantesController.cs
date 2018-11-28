using sac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sac.Controllers
{
    public class MainOtorgantesController : Controller
    {
        dbModel db = new dbModel();
        // GET: MainOtorgantes
        public ActionResult Index()
        {
            return View(db.tblOtorgante.ToList());
        }
        public ActionResult Create()
        {
            List<SelectListItem> genero = new List<SelectListItem>();
            genero.Add(new SelectListItem() { Text = "Masculino", Value = "Masculino" });
            genero.Add(new SelectListItem() { Text = "Femenino", Value = "Femenino" });
            genero.Add(new SelectListItem() { Text = "Otros", Value = "Otros" });

            ViewBag.generos = genero;

            return View();
        }
        [HttpPost]
        public ActionResult Create(tblOtorgante otorgantes)
        {
            db.tblOtorgante.Add(otorgantes);
            db.SaveChanges();

            return RedirectToAction("index");
        }
        public ActionResult Edit(int id)
        {
            List<SelectListItem> genero = new List<SelectListItem>();
            genero.Add(new SelectListItem() { Text = "Masculino", Value = "Masculino" });
            genero.Add(new SelectListItem() { Text = "Femenino", Value = "Femenino" });
            genero.Add(new SelectListItem() { Text = "Otros", Value = "Otros" });

            ViewBag.generos = genero;

            var datos = db.tblOtorgante.Find(id);
            return View(datos);
        }
        [HttpPost]
        public ActionResult Edit(tblOtorgante otorgantes, int id)
        {
            db.Entry(otorgantes).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var datos = db.tblOtorgante.Find(id);
            return View(datos);
        }
        public ActionResult Delete(int id)
        {
            var datos = db.tblOtorgante.Find(id);
            return View(datos);
        }
        [HttpPost]
        public ActionResult Delete(tblOtorgante otorgante, int id)
        {
            var datos = db.tblOtorgante.Find(id);
            db.tblOtorgante.Remove(datos);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}