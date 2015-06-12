using System;
using System.Collections.Generic;
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