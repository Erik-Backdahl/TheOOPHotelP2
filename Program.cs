using System;

namespace LabbTheOOPHotelP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            var Person = new Person("john", "qwer");
            bool isRunning = true;
            while (isRunning)
            {
                string[] menuHeader =
                [
                    "  Welcome to the OOP Hotel 2: Electric Hoteldoo!\n",
                    "\t\t\t       (press Q to quit)\n",
                    "   What would you like to do today?\n",                    
                ];

                string[] menuOptions =
                [
                    "Menu option 1",
                    "Menu option 2",
                    "Menu option 3",
                ];

                int menuSelection = Menu.Render(menuHeader, menuOptions);


                switch (menuSelection)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                }
            }
        }
    }
}
