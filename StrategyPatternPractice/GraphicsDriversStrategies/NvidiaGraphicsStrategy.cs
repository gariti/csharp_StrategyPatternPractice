namespace StrategyPatternPractice
{
    internal class NvidiaGraphicsStrategy : IGraphicsDriversStrategy
    {
        public void Load()
        {
            System.Console.WriteLine("Loading nvidia geforce drivers...");
        }
    }
}