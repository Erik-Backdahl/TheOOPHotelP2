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
                    "Add Employee",
                    "Add Manager",
                    "Add Consultant",
                    "Calculate Average Salary",
                    "Calculate Average Age",
                    "- QUIT"
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
                    case 3:
                        Console.WriteLine(hotelList.Average(p => p.Salary));
                        break;
                    case 4:
                        Console.WriteLine(hotelList.Average(p => p.Age));
                        break;
                    case 99: // Set this to whatever the final menu option number ends up being at the end.
                        Console.WriteLine("\n\t\tHave a nice day!");
                        Environment.Exit(0);
                        break;
                }
         
                Console.WriteLine("\n\nPlease press any key . . .\n");
                Console.ReadKey();
            }
        }

        public void Statistics()
        {
            //Console.WriteLine($"The average age is: {averageAge}");
            //Console.WriteLine($"The total salary is: {totalSalary}");
        }
    }
}
