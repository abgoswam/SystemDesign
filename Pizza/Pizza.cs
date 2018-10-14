using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizza
{
    public interface Pizza
    {
        /// <summary>
        /// cost of a pizza
        /// </summary>
        decimal Price { get; }
        /// <summary>
        /// list of toppings
        /// </summary>
        string Ingredients { get; }
    }
}