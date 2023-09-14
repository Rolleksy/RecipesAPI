using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeDataAccess.Models
{
    public class RecipeModel
    {
        public int recipeId { get; set; }
        public string? recipeName { get; set; }
        public string? category { get; set; }
        public string? description { get; set; }
        public int prepTime { get; set; }
        public int servings { get; set; }
    }
}
