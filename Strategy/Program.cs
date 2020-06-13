namespace Strategy
{
    class Program
    {
        /// <summary>
        /// Здесь мы используем паттерн Стратегия
        /// </summary>
        private static void Main()
        {
            Duck duck1 = new MallarDuck();

            duck1 = new SecondDuck();

            duck1.PerformFly();
            
        }
    }
}