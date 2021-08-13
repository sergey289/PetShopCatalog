using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Animals
    {
        [Key]
        public int AnimalID { get; set; }
        [Display(Name ="Animal name")]
        public string Name { get; set; }
        
        public string Age { get; set; }

        public string PictureName { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public int CategoryID { get; set; }

        public int? CommentID { get; set; }

        public virtual Categories Category { get; set; }

        public virtual IEnumerable<Comments> Comments { get; set; }



    }
}
