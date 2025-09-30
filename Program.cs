using System;

namespace LabbTheOOPHotelP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            var hotelList = List.GetDefaultList();
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
                    "(1): Add Employee",
                    "(2): Add Manager",
                    "(3): Add Consultant",
                    "(4): calculate average salary"
                ];

                int menuSelection = Menu.Render(menuHeader, menuOptions);


                switch (menuSelection)
                {
                    case 1:
                        
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 9:
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
