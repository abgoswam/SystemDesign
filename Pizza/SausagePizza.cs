using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizza
{
    public class SausagePizza : PizzaDecorator
    {
        public SausagePizza(Pizza pizza) : base(pizza)
        {
        }

        public override decimal Price => base.Price + 20;

        public override string Ingredients => base.Ingredients + ";sausage";

    }
}