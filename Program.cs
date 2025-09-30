using System;
using System.Net;

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
                    "Calculate Average Salary",
                    "Calculate Average Age",
                    "- QUIT"
                ];

                int menuSelection = Menu.Render(menuHeader, menuOptions);


                switch (menuSelection)
                {
                    case 0:
                        PersonMenu();
                        break;
                    case 1:
                        Console.WriteLine(hotelList.Average(p => p.Salary));
                        break;
                    case 2:
                        Console.WriteLine(hotelList.Average(p => p.Age));
                        break;
                    case 3:
                        Console.WriteLine("\n\t\tHave a nice day!");
                        Environment.Exit(0);
                        break;
                }
         
                Console.WriteLine("\n\nPlease press any key . . .\n");
                Console.ReadKey();
            }
        }

        public void PersonMenu()
        {
            bool isRunning = true;

            while (isRunning)
            {
                string[] menuHeader =
                [
                    "  Who are you adding?",
                ];

                string[] menuOptions =
                [
                    "Employee",
                    "Manager",
                    "Consultant",
                    "Housekeeper",
                ];

                int menuSelection = Menu.Render(menuHeader, menuOptions);


                switch (menuSelection)
                {
                    case 0:
                        EndPoint.AddPerson();
                        break;
                    case 1:
                        EndPoint.AddManager();
                        break;
                    case 2:
                        EndPoint.AddConsultant();
                        break;
                    case 3:
                        EndPoint.AddHouseKeeper();
                        break;
                }




                }


        public void Statistics()
        {
            //Console.WriteLine($"The average age is: {averageAge}");
            //Console.WriteLine($"The total salary is: {totalSalary}");
        }
    }
}
