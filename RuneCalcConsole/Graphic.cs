using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuneCalcConsole
{
    public class Graphic
    {
        public void Introduction() {
            Console.WriteLine("/////////////////////////////////");
            Console.WriteLine("/                               /");
            Console.WriteLine("/      Welcome to runecalc      /");
            Console.WriteLine("/                               /");
            Console.WriteLine("/////////////////////////////////");
        }

        public void MainMenu()
        {
            Console.WriteLine("1. Show XP table");
        }

        public void XPTable()
        {
            Console.WriteLine("Lvl | XP | Diff");
            Console.WriteLine("1\t0\t0");
            Console.WriteLine("2\t83\t83");
            Console.WriteLine("3\t174\t91");
            Console.WriteLine("1 0 0");
            Console.WriteLine("1 0 0");
            Console.WriteLine("1 0 0");
            Console.WriteLine("1 0 0");
            Console.WriteLine("1 0 0");
        }
    }
}
