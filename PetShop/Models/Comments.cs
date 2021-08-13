using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Comments
    {
        [Key]
        public int CommentID { get; set; }

        public int AnimalID { get; set; }

        public string Comment { get; set; }

        public virtual Animals Animal { get; set; }

        

    }
    
}
