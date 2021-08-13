using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetShop.Data;
using PetShop.Models;

namespace PetShop.Controllers
{
    public class AdministratorController : Controller
    {

        private PetShopContext _DbpetShopContext;

        public AdministratorController(PetShopContext DbpetShopContext)
        {
            _DbpetShopContext = DbpetShopContext;
        }

        public IActionResult Home()
        {

            IEnumerable<Animals> Allanimals = (from objAnimal in _DbpetShopContext.Animals

                                               select new Animals()
                                               {
                                                   AnimalID = objAnimal.AnimalID,
                                                   Name = objAnimal.Name,
                                                   Age = objAnimal.Age,
                                                   PictureName = objAnimal.PictureName,
                                                   Description = objAnimal.Description,
                                                   CategoryID = objAnimal.CategoryID,
                                                   CommentID = objAnimal.CommentID

                                               }).ToList();

            ViewBag.categories = _DbpetShopContext.Categories.ToList();

           




            return View(Allanimals);
        }

        public IActionResult ByCategories(int id)
        {
            IEnumerable<Animals> Animals = (from objAnimal in _DbpetShopContext.Animals
                                            where objAnimal.CategoryID == (int)id
                                            select new Animals()
                                            {
                                                AnimalID = objAnimal.AnimalID,
                                                Name = objAnimal.Name,
                                                Age = objAnimal.Age,
                                                PictureName = objAnimal.PictureName,
                                                Description = objAnimal.Description,
                                                CategoryID = objAnimal.CategoryID,
                                                CommentID = objAnimal.CommentID

                                            }).ToList();
            ViewBag.categories = _DbpetShopContext.Categories.ToList();
            return View(Animals);





        }

        public IActionResult Delete(int id)
        {

            var Animal = _DbpetShopContext.Animals.Where(a => a.AnimalID == id);
            Animals AnimarForRemovie = Animal.FirstOrDefault();
            _DbpetShopContext.Animals.Remove(AnimarForRemovie);
            _DbpetShopContext.SaveChanges();
             return RedirectToAction("Home");
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.categories = _DbpetShopContext.Categories.ToList();
            return View();

        }

        [HttpPost]
        public IActionResult Add(Animals animal)
        {

            Animals NewAnimal = new Animals
            {
                Name = animal.Name,
                Age = animal.Age,
                PictureName = animal.PictureName,
                Description = animal.Description,
                CategoryID = animal.CategoryID


            };


            _DbpetShopContext.Animals.Add(NewAnimal);
            _DbpetShopContext.SaveChanges();

            return RedirectToAction("Home");

        }
        
        public IActionResult Edit(int animalID)
        {
            var AnimalRec= (from item in _DbpetShopContext.Animals
                           where item.AnimalID==animalID
                           select item).First();

            TempData["imgPatch"] = AnimalRec.PictureName;
            ViewBag.categories = _DbpetShopContext.Categories.ToList();
            ViewBag.SpecificCategoryName = _DbpetShopContext.Categories.Where(c => c.CategoryID == AnimalRec.CategoryID).Select(c => c.Name).FirstOrDefault();
            ViewBag.SpecificCategoryID = _DbpetShopContext.Categories.Where(c => c.CategoryID == AnimalRec.CategoryID).Select(c => c.CategoryID).FirstOrDefault();
            return View("Edit",AnimalRec);



        }

        [HttpPost]
        public IActionResult Edit(Animals obj)
        {
            var AnimalRec = (from item in _DbpetShopContext.Animals
                             where item.AnimalID == obj.AnimalID
                             select item).First();

            AnimalRec.Name = obj.Name;
            AnimalRec.Age = obj.Age;
            AnimalRec.PictureName = TempData["imgPatch"].ToString();
            AnimalRec.Description = obj.Description;
            AnimalRec.CategoryID = obj.CategoryID;
           _DbpetShopContext.SaveChanges();


            return RedirectToAction("Home");

        }

    }
}
