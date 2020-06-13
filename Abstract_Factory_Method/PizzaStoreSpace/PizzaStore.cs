using Abstract_Factory_Method.PizzaSpace;

namespace Abstract_Factory_Method.PizzaStoreSpace
{
    public abstract class PizzaStore
    {
        protected IPizzaIngridientFactory ingridientFactory;

        public Pizza Order(object pizzaEnum)
        {
            Pizza pizza = CreatePizza(pizzaEnum);

            pizza.Prepare();
            pizza.Bake();
            pizza.Slice();
            pizza.InBox();
            pizza.ToString();
            
            return pizza;
        }

        protected abstract Pizza CreatePizza(object pizzaEnum);
    }
}