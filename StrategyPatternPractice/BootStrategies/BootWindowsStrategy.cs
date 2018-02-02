using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternPractice
{
    public class BootWindowsStrategy : IBootStrategy
    {
        public void Boot()
        {
            Console.WriteLine("Booting DOS...");
            Console.WriteLine("Booting Windows....");
            Console.WriteLine("Booting more Microsoft stuff....");
            Console.WriteLine("Starting Windows...");
            Console.WriteLine("You are now using Windows!");
        }
    }
}
