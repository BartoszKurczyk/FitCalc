using System;
using System.Collections.Generic;
using System.Text;

namespace FitCalcDb
{
    public enum TypeOfQuantity
    {
        szt,
        g,
        ml
    }
    public class Ingradient
    {
        public int IngradientId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public TypeOfQuantity TypeOfQuantity { get; set; }
    }
}
