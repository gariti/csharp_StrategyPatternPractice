using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            BootWindowsStrategy windows = new BootWindowsStrategy();
            RadeonGraphicsStrategy radeon = new RadeonGraphicsStrategy();
            PersonalComputer pc = new PersonalComputer(windows, radeon);
            pc.Boot();

            NvidiaGraphicsStrategy nvidia = new NvidiaGraphicsStrategy();
            BootUbuntuStrategy ubuntu = new BootUbuntuStrategy();
            PersonalComputer pc2 = new PersonalComputer(ubuntu, nvidia);
            pc2.Boot();

            Console.ReadKey();
        }
    }
}
