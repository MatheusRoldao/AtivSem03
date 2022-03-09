using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_app.Controllers
{
    public class DepartamentoController : Controller
    {
        public ActionResult Index()
        {
            return View(Repository.Departamento.getAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.Departamento departamento)
        {
            Repository.Departamento.save(departamento);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Repository.Departamento.deleteById(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(Repository.Departamento.getById(id));
        }

        [HttpPost]
        public ActionResult Edit(Models.Departamento departamento)
        {
            Repository.Departamento.update(departamento);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            return View(Repository.Departamento.getById(id));
        }
    }
}