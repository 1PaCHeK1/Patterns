namespace Abstract_Factory_Method.PizzaSpace
{
    public class RussianCheesePizza : Pizza
    {
        public RussianCheesePizza(IPizzaIngridientFactory ingridientFactory) => IngridientFactory = ingridientFactory;

        public override void Prepare()
        {
            Name = "Русская";
            dough = IngridientFactory.AddDough();
            sause = IngridientFactory.AddSause();
            cheese = IngridientFactory.AddCheese();
            clam = IngridientFactory.AddClam();
        }
    }
}