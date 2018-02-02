namespace StrategyPatternPractice
{
    internal class RadeonGraphicsStrategy : IGraphicsDriversStrategy
    {
        public void Load()
        {
            System.Console.WriteLine("Loading Radeon graphics...");
        }
    }
}