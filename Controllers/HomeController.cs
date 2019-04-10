using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private CRUDeliciousContext dbContext;

        public HomeController(CRUDeliciousContext context)
        {
            dbContext = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            List<Dishes> dishes = dbContext.dishes.OrderByDescending(d => d.CreatedAt).ToList();

            return View(dishes);
        }

        [HttpGet("new")]
        public IActionResult getDishAddForm()
        {
            return View("DishAddForm");
        }

        [HttpPost("AddDishes")]
        public IActionResult addDishes(Dishes dishes)
        {
            if(ModelState.IsValid)
            {
                dishes.CreatedAt = DateTime.Now;
                dbContext.Add(dishes);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("DishAddForm");
            }
        }

        [HttpGet("{id}")]
        public IActionResult getDishDetail(int id)
        {
            Dishes dish = dbContext.dishes.SingleOrDefault(d => d.DishId == id);
            return View("DishDetail", dish);
        }

        [HttpGet("edit/{id}")]
        public IActionResult getDishEditForm(int id)
        {
            Dishes dish = dbContext.dishes.SingleOrDefault(d => d.DishId == id);
            return View("DishUpdateForm", dish);
        }

        [HttpPost("edit/{id}")]
        public IActionResult getUpdateDish(int id, Dishes dishes)
        {
            if(ModelState.IsValid)
            {
                Dishes dish = dbContext.dishes.SingleOrDefault(d => d.DishId == id);
                dish.Name = dishes.Name;
                dish.Chef = dishes.Chef;
                dish.Tastiness = dishes.Tastiness;
                dish.Calories = dishes.Calories;
                dish.Description = dishes.Description;
                dish.UpdatedAt = DateTime.Now;                
                dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View("DishAddForm");
            }
        }

        [HttpGet("delete/{id}")]
        public IActionResult DeleteDish(int id)
        {
            System.Console.WriteLine(id);
            Dishes dish = dbContext.dishes.SingleOrDefault(d => d.DishId == id);
            dbContext.dishes.Remove(dish);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }        
    }
}
