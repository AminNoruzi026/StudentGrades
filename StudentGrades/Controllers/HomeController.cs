using StudentGrades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentGrades.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(Repository.people);
        }

        public ActionResult Detail(int id)
        {
            //Person person = new Person()
            //{
            //    FirstName = "Amin",
            //    LastName = "Noruzi",
            //    NationalCode = 26,
            //};

            Person p = Repository.people.Single(person => person.Id == id);

            return View(p);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Person person)
        {
            person.Id = Repository.people.Max(p => p.Id) + 1;

            Repository.people.Add(person);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Person person = Repository.people.SingleOrDefault(p => p.Id == id);

            if (person == null)
            {
                return HttpNotFound();
            }

            return View(person);
        }

        [HttpPost]
        public ActionResult Edit(Person person)
        {
            int index = Repository.people.FindIndex(p => p.Id == person.Id);

            Repository.people[index] = person;
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            int index = Repository.people.FindIndex(p => p.Id == id);
            Repository.people.RemoveAt(index);
            return RedirectToAction("Index");
        }

    }
}