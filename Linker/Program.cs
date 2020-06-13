using System;
using System.Linq;

namespace Linker
{
    internal class Program
    {
        private static void Main()
        {
            IComponent RootComponent = new Composite("ROOT");
            IComponent component1 = new Composite("Component1");
            IComponent component2 = new Composite("Component2");
            IComponent component11 = new Composite("Component11");
            IComponent component21 = new Composite("Component21");

            IComponent leaf11 = new Leaf("Leaf11");
            IComponent leaf21 = new Leaf("Leaf21");

            IComponent leaf12 = new Leaf("Leaf12");
            IComponent leaf22 = new Leaf("Leaf22");

            IComponent component12 = new Composite("Component12");
            IComponent component22 = new Composite("Component22");

            IComponent leaf13 = new Leaf("Leaf13");
            IComponent leaf23 = new Leaf("Leaf23");

            component12.AddComponent(leaf13);
            component22.AddComponent(leaf23);

            component11.AddComponent(leaf12);
            component21.AddComponent(leaf22);

            component11.AddComponent(component12);
            component21.AddComponent(component22);

            component1.AddComponent(component11);
            component1.AddComponent(leaf11);

            component2.AddComponent(component21);
            component2.AddComponent(leaf21);

            RootComponent.AddComponent(component1);
            RootComponent.AddComponent(component2);

            foreach (var i in RootComponent
                                        .GetList()
                                        .OrderBy(e => e.Name))
                Console.WriteLine(i.Name);
        }
    }
}