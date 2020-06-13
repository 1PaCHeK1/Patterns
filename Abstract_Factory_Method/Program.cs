using Abstract_Factory_Method.PizzaSpace;
using Abstract_Factory_Method.PizzaStoreSpace;

namespace Abstract_Factory_Method
{
    internal class Program
    {
        /// <summary>
        /// Здесь мы применим абстрактный метод в интерфейсе PizzaStore
        /// Также мы применим абстрактную фабрику в интерфейсе IPizzaIngridientFactory
        /// </summary>
        private static void Main()
        {
            PizzaStore russianPizzaStore = new RussianPizzaStore();

            Pizza pizza = russianPizzaStore.Order(PizzaEnum.CheesePizza);
        }
    }
}