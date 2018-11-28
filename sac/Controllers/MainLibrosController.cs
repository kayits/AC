using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using sac.Models;

namespace sac.Controllers
{
    public class MainLibrosController : Controller
    {
        dbModel db = new dbModel();
        // GET: MainLibros
        public ActionResult Index()
        {
            return View(db.tblLibros.ToList());
        }

        public ActionResult Create()
        {
            ViewBag.idotorgante = new SelectList(db.tblOtorgante, "idotorgante", "nombres");
            ViewBag.idfavorde = new SelectList(db.tblAfavorde, "idfavorde", "nombres");
            return View();
        }
        [HttpPost]
        public ActionResult Create(tblLibros libros)
        {
            if (ModelState.IsValid)
            {
                if (Request.Files.Count > 0)
                {
                    HttpPostedFileBase file = Request.Files[0];
                    if (file.ContentLength > 0)
                    {
                        var img = (file.FileName).ToLower();
                        libros.img = "/Content/Libros/" + img;
                        file.SaveAs(Server.MapPath("~/Content/Libros/") + img);

                    }
                    db.tblLibros.Add(libros);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return View(libros);
        }
        public ActionResult Edit(int id)
        {
            ViewBag.idotorgante = new SelectList(db.tblOtorgante, "idotorgante", "nombres");
            ViewBag.idfavorde = new SelectList(db.tblAfavorde, "idfavorde", "nombres");
            var datos = db.tblLibros.Find(id);
            return View(datos);
        }
        [HttpPost]
        public ActionResult Edit(tblLibros libros, int id)
        {
            db.Entry(libros).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var datos = db.tblLibros.Find(id);
            return View(datos);
        }
        public ActionResult Delete(int id)
        {
            var datos = db.tblLibros.Find(id);
            return View(datos);
        }
        [HttpPost]
        public ActionResult Delete(tblLibros libros, int id)
        {
            var datos = db.tblLibros.Where(a => a.idlibros.Equals(id)).FirstOrDefault();

            db.tblLibros.Remove(datos);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}