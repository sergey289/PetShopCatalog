using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetShop.Models;

namespace PetShop.Data
{
    public class PetShopContext:DbContext
    {


        public PetShopContext(DbContextOptions<PetShopContext> options) : base(options)
        {


        }

       
        public DbSet<Animals> Animals { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Comments> Comments { get; set; }


        protected override   void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().HasData(

            new { CategoryID = 1, Name = "Amphibians" },
            new { CategoryID = 2, Name = "Birds" },
            new { CategoryID = 3, Name = "Fish" },
            new { CategoryID = 4, Name = "Mammals" },
            new { CategoryID = 5, Name = "Reptiles" }

            );

            modelBuilder.Entity<Animals>().HasData(
            new { AnimalID = 1, Name = "Salamander", Age = "1", PictureName = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b1/Fire_salamander_Germany_10_2014.jpg/1200px-Fire_salamander_Germany_10_2014.jpg", Description = "The designation salamander covers almost all tailed amphibians with a weak need to stay in water.\n Most of them go into the water only in order to plant their larvae there. Several species of them even completely broke away from the water element;\n their representatives give birth to cubs fully adapted to life. Since mating and mating also take place on land, the aquatic part of the cage can be small.", CategoryID = 1 },
            new { AnimalID = 2, Name = "Alexandrian parrot", Age = "2", PictureName = "https://zoogalereya.ru/img/work/article/a_134_319.jpg", Description = "The Alexandrian parrot, a unique and endangered species. This is the largest of the necklace parrots. The main problem of the extinction of the species is poaching for sale.\n Natural habitat Pakistan, India.", CategoryID = 2 },
            new { AnimalID = 3, Name = "Blackbird", Age = "1", PictureName = "https://zoo-dom.com.ua/upload/breed/ru/0_09147800_1492159114_foto.jpg", Description = "The blackbird is one of two species chosen for captivity due to its incredibly beautiful singing.This species is widespread in our country; it can be found both in the forest and in gardens and parks.They love dense thickets in which they settle in pairs.", CategoryID = 2 }

           );

            modelBuilder.Entity<Comments>().HasData(

            new { CommentID = 1, AnimalID = 1, Comment = "cool coloring in this animal" },
            new { CommentID = 2, AnimalID = 2, Comment = "interesting he can speak" },
            new { CommentID = 3, AnimalID = 2, Comment = "I heard that there is another type of salamander called fire!" },

            new { CommentID = 4, AnimalID = 3, Comment = "interesting he can speak" },
            new { CommentID = 5, AnimalID = 3, Comment = "interesting he can speak" },
            new { CommentID = 6, AnimalID = 3, Comment = "interesting he can speak" });


        }



    }
}
