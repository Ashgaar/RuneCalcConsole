namespace RuneCalcConsole
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            bool menu = true;
            Graphic graphic = new Graphic();

            graphic.Introduction();

            while (menu)
            {
                graphic.MainMenu();





                Console.Write("Input: ");
                string choice = Console.ReadLine();

            }
        }
    }
}