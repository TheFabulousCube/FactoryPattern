namespace FactoryPattern
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza;
            switch (type)
            {
                case "cheese":
                    {
                        pizza = new CheesePizza(new ThickCrust(), new RedSauce(), new SixCheese());
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
                        pizza = new CheesePizza(new ThickCrust(), new RedSauce(), new SixCheese());
                        break;
                    }

            }
            return pizza;
        }
    }
}