﻿using BookWebA.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookWebA.Controllers
{
    public class PublisherController : Controller
    {
        ApplicationDbContext dbContext;
        public PublisherController(ApplicationDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Publisher> publishers = dbContext.Publishers.ToList();
            return View(publishers);
        }
        public IActionResult Details(int id) 
        {
            Publisher publisher = dbContext.Publishers.Find(id);
            if (publisher == null)
            {
                return NotFound();
            }
            //return Content(publisher.Name);
            return View(publisher);
        }
    }
}
