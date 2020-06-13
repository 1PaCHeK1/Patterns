using Abstract_Factory_Method.Ingridients;

namespace Abstract_Factory_Method
{
    public interface IPizzaIngridientFactory
    {
        public Sause AddSause();

        public Dough AddDough();

        public Clam AddClam();

        public Cheese AddCheese();
    }
}