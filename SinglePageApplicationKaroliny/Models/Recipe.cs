using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SinglePageApplicationKaroliny.Models
{
    public class Recipe
    {
        public int ID { get; set; }
        [Display(Name = "Category", ResourceType = typeof(SinglePageApplicationKaroliny.Resources.Strings))]
        public RecipeCategory Category { get; set; }
        [StringLength(MinimumLength = 2)]
        [Display(Name = "Title_Edit", ResourceType = typeof(SinglePageApplicationKaroliny.Resources.Strings))]
        public string Title { get; set; }
        [Display(Name = "Description", ResourceType = typeof(SinglePageApplicationKaroliny.Resources.Strings))]
        public string Description { get; set; }
        public IList<string> IngredientsList {get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Description", ResourceType = typeof(SinglePageApplicationKaroliny.Resources.Strings))]
        public DateTime AddDate {get; set;}
        [Display(Name = "PictureURL", ResourceType = typeof(SinglePageApplicationKaroliny.Resources.Strings))]
        public string PictureURL { get; set; }
    }

    public enum RecipeCategory
    {
        Dinner,
        Sweet,
        Drink,
        Snack
    }
}