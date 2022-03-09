using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_app.Controllers
{
    public class FuncionarioController : Controller
    {
        public ActionResult Index()
        {
            return View(Repository.Funcionario.getAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.Funcionario funcionario)
        {
            Repository.Funcionario.save(funcionario);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Repository.Funcionario.deleteById(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(Repository.Funcionario.getById(id));
        }

        [HttpPost]
        public ActionResult Edit(Models.Funcionario funcionario)
        {
            Repository.Funcionario.update(funcionario);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            return View(Repository.Funcionario.getById(id));
        }
    }
}