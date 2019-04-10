using System.ComponentModel.DataAnnotations;
using System;

namespace CRUDelicious.Models
{
    public class Dishes
    {
        [Key]
        public int DishId {get; set;}

        [Display(Name="Name of Dish")]
        [Required(ErrorMessage="Dish Name is required")]
        public string Name {get; set;}

        [Display(Name="Chef's Name")]
        [Required(ErrorMessage="Chef's Name is required")]
        public string Chef {get; set;}

        [Display(Name="Tastiness")]
        [Required(ErrorMessage="Tastiness is required")]
        public int Tastiness {get; set;}

        [Display(Name="# of Calories")]
        [Required(ErrorMessage="Calories is required")]
        public int Calories {get; set;}

        [Display(Name="Description")]
        [Required(ErrorMessage="Description is required")]
        public string Description {get; set;}
        public DateTime CreatedAt {get; set;}
        public DateTime UpdatedAt {get; set;}
    }
}