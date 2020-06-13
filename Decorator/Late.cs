namespace Decorator
{
    public class Late : Beverage
    {
        public Late() => Description = "Латте";

        public override double Cost() => 50;
    }
}