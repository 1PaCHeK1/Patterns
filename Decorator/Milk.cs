namespace Decorator
{
    public class Milk : CondimentDecorator
    {
        public Milk(Beverage _beverage) => beverage = _beverage;

        public override double Cost() => beverage.Cost() + 10;

        public override string GetDescription() => beverage.GetDescription() + ", Молоко";
    }
}