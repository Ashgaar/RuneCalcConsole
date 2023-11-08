using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuneCalcConsole
{
    public class InputHandler
    {
        public int NumericalInput()
        {
            Console.Write("Input: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        public void ContinueInput()
        {
            Console.Write("Press any key to conitnue ...");
            Console.ReadLine();
        }
    }
}
