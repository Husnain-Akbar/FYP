using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AutomotiveSols.BLL.Models
{
   public class ShoppingCart
    {
        public ShoppingCart()
        {
            Count = 1;
        }
        
        public int Id { get; set; }

        public string ApplicationUserId { get; set; }
       // [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }

        public int AutoPartId { get; set; }
       // [ForeignKey("AutoPartId")]
        public AutoPart AutoPart { get; set; }

        [Range(1, 1000, ErrorMessage = "Please enter a value between 1 and 1000")]
        public int Count { get; set; }


        
        [NotMapped]
        public double Price { get; set; }

    }
}
