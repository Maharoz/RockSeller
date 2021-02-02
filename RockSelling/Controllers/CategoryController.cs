﻿using Microsoft.AspNetCore.Mvc;
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
    }
}
