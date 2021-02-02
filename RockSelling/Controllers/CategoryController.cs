using Microsoft.AspNetCore.Mvc;
using RockSelling.Data;
using RockSelling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockSelling.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDBContext _db;

        public CategoryController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objList = _db.Category;
            return View(objList);
        }


        //Get-Create
        public IActionResult Create()
        {
            return View();
        }

       

        //Post-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Category.Add(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(obj);
           
        }


        //Get-Edit
        public IActionResult Edit(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Category.Find(id);

            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }


        //Post-Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Category.Update(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(obj);

        }


        //Get-Edit
        public IActionResult Delete(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Category.Find(id);

            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }


        //Post-Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Category.Find(id);
            

            if(obj == null)
            {
                return NotFound();
            }
                _db.Category.Remove(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
           

        }
    }
}
