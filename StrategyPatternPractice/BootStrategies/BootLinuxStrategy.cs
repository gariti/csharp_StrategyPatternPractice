namespace StrategyPatternPractice
{
    internal class BootUbuntuStrategy : IBootStrategy
    {
        public void Boot()
        {
            System.Console.WriteLine("Starting Linux Kernal...");
            System.Console.WriteLine("Starting Ubuntu..");
            System.Console.WriteLine("You are now using Ubuntu...");
        }
    }
}