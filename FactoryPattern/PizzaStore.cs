using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class PizzaStore
    {
        public Pizza orderPizza(string type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
        public abstract Pizza CreatePizza(string type);
    }

    public class NYStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza;
            switch (type)
            {
                case "cheese":
                    {
                        // pizza = new NYStyleCheesePizza();
                        pizza = new CheesePizza(new ThinCrust(), new RedSauce(), new ThreeCheese());
                        break;
                    }
                case "pepperoni":
                    {
                        pizza = new PepperoniPizza();
                        break;
                    }
                case "veggie":
                    {
                        pizza = new VeggiePizza();
                        break;
                    }
                case "supreme":
                    {
                        pizza = new SupremePizza();
                        break;
                    }
                default:
                    {
                        pizza = new CheesePizza(new ThinCrust(), new RedSauce(), new ThreeCheese());
                        break;
                    }

            }
            return pizza;
        }
    }
}
