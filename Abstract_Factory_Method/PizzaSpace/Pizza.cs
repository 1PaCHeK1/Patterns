using Abstract_Factory_Method.Ingridients;
using System;

namespace Abstract_Factory_Method.PizzaSpace
{
    public abstract class Pizza
    {
        protected string Name;

        protected Dough dough;
        protected Sause sause;
        protected Cheese cheese;
        protected Clam clam;

        protected IPizzaIngridientFactory IngridientFactory;

        public void Bake()
        {
            Console.WriteLine($"Пицца {Name} готовиться 25 минут при температуре 350 градусов");
        }

        public void Slice()
        {
            Console.WriteLine($"Режем пиццу {Name}");
        }

        public void InBox()
        {
            Console.WriteLine($"Упаковываем вашу пиццу {Name}!");
        }

        public void ToString()
        {
            Console.WriteLine($"В пиице содержится: \n1) {dough.Name}\n2) {sause.Name}\n3) {cheese.Name}\n4) {(clam != null ? clam.Name : "Без маллюсков")}");
        }

        public abstract void Prepare();
    }
}