using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeDataAccess.Models
{
    public class IngredientsModel
    {
        [Column("Name")]
        public string Name { get; set; }
        [Column("Quantity")]
        public int Quantity { get; set; }
        [Column("QuantityType")]
        public string QuantityType { get; set; }
    }
}
