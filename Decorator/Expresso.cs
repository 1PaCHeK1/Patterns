namespace Decorator
{
    public class Expresso : Beverage
    {
        public Expresso() => Description = "Экспрессо";

        public override double Cost() => 100;
    }
}