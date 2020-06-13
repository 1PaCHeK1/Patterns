using Abstract_Factory_Method.Ingridients;

namespace Abstract_Factory_Method
{
    internal class RussianIngridientFactory : IPizzaIngridientFactory
    {
        public Cheese AddCheese() => new Cheese1();
        public Clam AddClam() => null;
        public Dough AddDough() => new Dough2();
        public Sause AddSause() => new Sause1();
    }
}