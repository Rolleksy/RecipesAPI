using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeDataAccess.Models
{
    public class RecipeWithIngre
    {
        public RecipeModel recipe { get; set; }
        public List<IngredientsModel> ingreList { get; set; }
    }
}
