namespace RuneCalcConsole
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            bool menu = true;
            Graphic graphic = new Graphic();
            InputHandler inputHandler = new InputHandler();

            graphic.Introduction();

            while (menu)
            {
                graphic.MainMenu();
                int choice = inputHandler.NumericalInput();

                if (choice == 1)
                {
                    graphic.XPTable();
                    inputHandler.ContinueInput();
                }



                if(choice == 0)
                {
                    menu = false;
                }
            }
        }
    }
}