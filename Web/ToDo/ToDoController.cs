using Redux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToDo
{
    [Reducer(Reducer = "" )]
    public class ToDoController : Controller
    {
        // GET: ToDo
        [Action(Type = Constants.CREATE_TASK_SUCCESS)]
        public ActionResult Index()
        {
            var todo = new ToDo();
            return View(todo);
        }

        [Action(Type = Constants.CREATE_TASK_SUCCESS)]
        public PartialViewResult _Index()
        {
            var todo = new ToDo();
            return PartialView(todo);
        }

        // GET: ToDo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ToDo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ToDo/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ToDo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ToDo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ToDo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ToDo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
