using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetShop.Data;
using PetShop.Models;




namespace PetShop.Controllers
{
    public class UserController : Controller
    {
        private PetShopContext _DbpetShopContext;

        public UserController(PetShopContext DbpetShopContext)
        {
            _DbpetShopContext = DbpetShopContext;
        }

        public IActionResult Home()
        {


         var Animals = (from a in _DbpetShopContext.Animals
                                                from c in _DbpetShopContext.Comments
                                                where c.AnimalID == a.AnimalID
                                                group a by a.AnimalID into gr                                             
                                                select new
                                                {
                                                   animalID=gr.Key,
                                                   count=gr.Count()

                                                }).ToList();


            List<int> IDOfTop2dAnimals = Animals
                                    .OrderByDescending(a => a.count)
                                    .Take(2)
                                    .Select(a=>a.animalID)
                                    .ToList();
    
            IEnumerable<Animals> Top2animals = (from objAnimal in _DbpetShopContext.Animals
                                       where IDOfTop2dAnimals.Contains(objAnimal.AnimalID)
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

            return View(Top2animals);
        }

        public IActionResult Catalog()
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

        public IActionResult AnimalInfo(int id)
        {

            var IfExixtsComment = _DbpetShopContext.Comments.Where(c => c.AnimalID == id).ToList();

            if (IfExixtsComment == null)
            {
                ViewBag.Comment = "No Comments !";
            }

            List<Comments> comments = IfExixtsComment;
            ViewBag.Comment = comments;
            Animals ani = _DbpetShopContext.Animals.SingleOrDefault(a => a.AnimalID == id);
            ViewBag.AnimalID = id;
            Categories catego = _DbpetShopContext.Categories.SingleOrDefault(ca => ca.CategoryID == ani.CategoryID);
            ViewBag.categoryName = catego.Name;

            return View(ani);

        }

        public IActionResult AddComments (string comment, int id)
        {
           

            Comments newComment = new Comments();
            newComment.AnimalID = id;
            newComment.Comment = comment;
            _DbpetShopContext.Comments.Add(newComment);
            _DbpetShopContext.SaveChanges();
            return RedirectToAction("AnimalInfo", new { id = id });

        }

    }
}


