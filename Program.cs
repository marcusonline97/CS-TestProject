using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeProject
{
    internal class Program // The Main Program
    {
        private static List<string> Name = new List<string>();
        private static List<double> Salary = new List<double>();

        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }


        private static bool MainMenu()
        {
            
            Console.WriteLine("1)Type 1 to provide employe information");
            Console.WriteLine("2)Type 2 to recieve and browse previous entries");
            Console.WriteLine("3)Type 3 exit the application");
            string result = Console.ReadLine();

            if (result == "1")
            {
                InputInfo();
                    return true;
            }
            else if (result == "2") 
            {
                ReadStoredInfo(); 

                return true;
              
            }
            else
            {
                return false;
            }
        }
        private static void InputInfo() //Metod som ber användare om input och information för att lagra i en lista.
        {
            Console.Clear();
            Console.Write("Please Insert Your Employes Information: \n");
            Console.Write("Your Employees name: ");
            string Named = Console.ReadLine();
            Name.Add(Named);

            Console.Write($" Apply {Named}'s salary \n "); //
            double salary;
            if(double.TryParse(Console.ReadLine(),out salary))
            {
                Salary.Add(salary);
                Console.Write("Information has been correctly applied!\nYou are now sent back to the registry menu.\n \n"); // Text som bekräftar lyckad inmatning
            }
            else 
            {
              Console.WriteLine("Incorrect input towards the salary, please try again");
            }

        }

        private static void ReadStoredInfo() //Vår metod som läser upp förvarade värden ifrån programmet
        {
            Console.Clear();
            if (Name.Count == 0 && Salary.Count == 0)
            {
                Console.WriteLine("No Information to broadcast! Please Register an employee first.");
                return;
            }

            for (int i = 0; i < Name.Count; i++)
            {
                Console.WriteLine($"EmployeName: {Name[i]} | Salary: {Salary[i]}|"); //Skriver ut användarens information
            }
        }
    }

}
