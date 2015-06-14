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
        public RecipeCategory Category { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IList<string> IngredientsList {get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime AddDate {get; set;}
        public string PictureURL { get; set; }
    }

    public enum RecipeCategory
    {
        Dinner,
        Sweet,
        Drink
    }
}