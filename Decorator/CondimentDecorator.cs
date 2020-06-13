namespace Decorator
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;
        public abstract override string GetDescription();
    }
}