using System;
using System.Collections.Generic;

namespace FactoryPattern
{
    public abstract class Pizza
    {
        public Crust crust;
        public Sauce sauce;
        public Cheese cheese;
        public List<Topping> toppings;
        public abstract void Prepare();
        public abstract void Bake();
        public abstract void Cut();
        public abstract void Box();
    }

    public class CheesePizza : Pizza
    {
        public CheesePizza(Crust crust, Sauce sauce, Cheese cheese)
        {
            this.crust = crust;
            this.sauce = sauce;
            this.cheese = cheese;
        }
        public override void Prepare()
        {
            throw new NotImplementedException();
        }
        public override void Bake()
        {
            throw new NotImplementedException();
        }

        public override void Cut()
        {
            throw new NotImplementedException();
        }
        public override void Box()
        {
            throw new NotImplementedException();
        }
    }
    public class PepperoniPizza : Pizza
    {
        public override void Prepare()
        {
            throw new NotImplementedException();
        }
        public override void Bake()
        {
            throw new NotImplementedException();
        }

        public override void Cut()
        {
            throw new NotImplementedException();
        }
        public override void Box()
        {
            throw new NotImplementedException();
        }
    }
    public class VeggiePizza : Pizza
    {
        public VeggiePizza()
        {
            this.crust = new ThickCrust();
            this.sauce = new RedSauce();
            this.cheese = new ThreeCheese();
            this.toppings.Add(Topping.Onions);
            this.toppings.Add(Topping.GreenPeppers);
            this.toppings.Add(Topping.Mushrooms);
        }
        public override void Prepare()
        {
            throw new NotImplementedException();
        }
        public override void Bake()
        {
            throw new NotImplementedException();
        }

        public override void Cut()
        {
            throw new NotImplementedException();
        }
        public override void Box()
        {
            throw new NotImplementedException();
        }
    }
    public class SupremePizza : Pizza
    {
        public SupremePizza()
        {
            this.crust = new ThinCrust();
            this.sauce = new WhiteSauce();
            this.cheese = new SixCheese();
            this.toppings.Add(Topping.Spinach);
            this.toppings.Add(Topping.Tomatoes);
        }
        public override void Prepare()
        {
            throw new NotImplementedException();
        }
        public override void Bake()
        {
            throw new NotImplementedException();
        }

        public override void Cut()
        {
            throw new NotImplementedException();
        }
        public override void Box()
        {
            throw new NotImplementedException();
        }
    }
}