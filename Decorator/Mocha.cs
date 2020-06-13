namespace Decorator
{
    class Mocha : CondimentDecorator
    {
        public Mocha(Beverage _beverage) => beverage = _beverage;

        public override double Cost() => beverage.Cost() + 20;

        public override string GetDescription() => beverage.GetDescription() + ", Шоколад";
    }
}
