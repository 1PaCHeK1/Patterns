using Abstract_Factory_Method.PizzaSpace;

namespace Abstract_Factory_Method.PizzaStoreSpace
{
    public class RussianPizzaStore : PizzaStore
    {
        public RussianPizzaStore() => ingridientFactory = new RussianIngridientFactory();

        protected override Pizza CreatePizza(object pizzaEnum)
        {
            Pizza pizza = (PizzaEnum)pizzaEnum switch
            {
                PizzaEnum.CheesePizza => new RussianCheesePizza(ingridientFactory),
                PizzaEnum.ClamPizza => new RussianCheesePizza(ingridientFactory),
                PizzaEnum.PepperonuPizza => new RussianCheesePizza(ingridientFactory),
                PizzaEnum.VeggiePizza => new RussianCheesePizza(ingridientFactory),
                _ => throw new System.ArgumentException("Введена неопознанная пицца")
            };
            return pizza;
        }
    }
}