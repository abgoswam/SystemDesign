using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizza
{
    public abstract class PizzaDecorator : Pizza
    {
        public Pizza _decoratorPizza;
        public PizzaDecorator(Pizza pizza)
        {
            _decoratorPizza = pizza;
        }

        public virtual decimal Price => _decoratorPizza.Price;

        public virtual string Ingredients => _decoratorPizza.Ingredients;
    }
}