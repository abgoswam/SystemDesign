using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizza
{
    public sealed class ClassiPizza : Pizza
    {
        public decimal Price => 20;

        public string Ingredients => "Basic Ingridients";
    }
}