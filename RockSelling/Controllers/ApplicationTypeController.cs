using Microsoft.AspNetCore.Mvc;
using RockSelling.Data;
using RockSelling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockSelling.Controllers
{
    public class ApplicationTypeController : Controller
    {

        private readonly ApplicationDBContext _db;

        public ApplicationTypeController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<ApplicationType> objList = _db.ApplicationType;
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
        public IActionResult Create(ApplicationType obj)
        {
            _db.ApplicationType.Add(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
