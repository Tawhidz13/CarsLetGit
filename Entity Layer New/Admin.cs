using Cars;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cars.Models
{
 
    public class Admin:Entity
    {
        [Key]
        [Required]
     
        public string UserID { get; set; }
       
        [Required]
        public string UserName { get; set; }
       
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
     
        public bool IsDirector { get; set; }

       
    }
}