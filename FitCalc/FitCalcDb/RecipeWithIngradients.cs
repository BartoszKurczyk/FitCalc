using System;
using System.Collections.Generic;
using System.Text;

namespace FitCalcDb
{
    public class RecipeWithIngradients
    {
        public int RecipeWithIngradientsId { get; set; }
        public Recipe Recipe { get; set; }
        public List<Ingradient> Ingradients { get; set; }
    }
}
