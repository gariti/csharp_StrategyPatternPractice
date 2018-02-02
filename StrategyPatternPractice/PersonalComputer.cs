namespace StrategyPatternPractice
{
    class PersonalComputer
    {
        private IBootStrategy bootStrategy;
        private IGraphicsDriversStrategy graphicsDriversStrategy;

        public PersonalComputer(IBootStrategy bootStrategy, IGraphicsDriversStrategy graphicsDriversStrategy)
        {
            this.bootStrategy = bootStrategy;
            this.graphicsDriversStrategy = graphicsDriversStrategy;
        }

        public void Boot()
        {
            LoadGraphicsDrivers();

            bootStrategy.Boot();
        }

        public void LoadGraphicsDrivers()
        {
            graphicsDriversStrategy.Load();
        }
    }
}
