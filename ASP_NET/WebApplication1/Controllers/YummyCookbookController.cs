using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text.Encodings.Web;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class YummyCookbookController : Controller
    {


        private static List<Recipe> cache = setupTestRecipies();


        public IActionResult View(int id)
        {

            Recipe result = cache.Find(x => x.Id == id);

            if (result == null)
            {
                ViewData["isCorrectId"] = false;
            }
            else
            {
                ViewData["isCorrectId"] = true;
            }

            return View(result);
        }

        [HttpGet]
        public IActionResult Index(int delete = -1)
        {

            if(delete != -1)
            {
                var found = cache.Find(x => x.Id == delete);
                if(found == null)
                {
                    ViewData["info"] = "Could not find recipe with this id to delete";
                }
                else
                {
                    cache.Remove(found);
                    ViewData["info"] = "Deleted recipe with id: " + delete;
                }
            }
            return View(cache);
        }

        [HttpPost]
        public IActionResult Index(Recipe recipe)
        {
            var found = cache.Find(x => x.Id == recipe.Id);
            if(found == null)
            {
                cache.Add(recipe);
                ViewData["info"] = "Recipe added";
            }
            else
            {
                cache.Remove(found);
                cache.Add(recipe);
                ViewData["info"] = "Recipe edited and saved";
            }

            return View(cache);
        }




        public IActionResult Create(int id = -1)
        {
            if(id != -1)
            {
                Recipe result = cache.Find(x => x.Id == id);

                if (result == null)
                {
                    ViewData["isCorrectId"] = false;
                }
                else
                {
                    ViewData["isCorrectId"] = true;
                }
                return View(result);
            }

            return View();
        }




        private static List<Recipe> setupTestRecipies()
        {
            Recipe recipe1 = new Recipe(1, "Carbonara", 20, 2, 712, "pasta, eggs, bacon, cheese", "cook carbonara", "do not overcook eggs");
            Recipe recipe2 = new Recipe(2, "Sandwich", 5, 0, 34, "bread, ham, lettuce, tomato", "make a sandwich", "do not use old ingredients");

            return new List<Recipe>() { recipe1, recipe2 };
        }
    }
}
