using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class Program
    {
        static void Main(string[] args)
        {
            login();
        }
        static void login()
        {
            string User, Password;
            Console.WriteLine("Welcome");
            Console.Write("\nUser      :");
            User = Console.ReadLine();
            Console.Write("\nPassword  :");
            Password = Console.ReadLine();

            if (User == "admin" && Password == "admin")
            {
                MainMenu();   
            }else
            {
                Console.WriteLine("Please Try Again!");
                login();
            }
        }
        static void MainMenu()
        {
            Console.WriteLine("[ A ]  Menu");
            Console.WriteLine("[ B ]  Cart");
            Console.WriteLine("[ C ]  History");
            Console.WriteLine("[ D ]  Exit");

            string choice = Console.ReadLine();
            if (choice == "A" || choice == "a")
            {
                MenuOrder();
            }
            else if (choice == "B" || choice == "b")
            {
                Cart();
            }
            else if (choice == "C" || choice == "c")
            {
                History();
            }
            else if (choice == "D" || choice == "d")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid Input");
                MainMenu();
            }

        }
        static void MenuOrder()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("[ A ]  Chicken");
            Console.WriteLine("[ B ]  Drinks");
            Console.WriteLine("[ C ]  Side-Dish");
            Console.WriteLine("[ D ]  Back");
            string choice = Console.ReadLine();
            if (choice == "A" || choice == "a")
            {
                Chicken();
            }
            else if (choice == "B" || choice == "b")
            {
                Drinks();
            }
            else if (choice == "C" || choice == "c")
            {
                SideDish();
            }
            else if (choice == "D" || choice == "d")
            {
                MainMenu();
            }
            else
            {
                Console.WriteLine("Invalid Input");
                MenuOrder();
            }
        }
        static void Chicken()
        {
            Console.WriteLine();
                }
        static void Drinks()
        {
            Console.WriteLine();
        }
        static void SideDish()
        {
            Console.WriteLine();
        }
        static void Cart()
        {
            Console.WriteLine();
        }
        static void History()
        {
            Console.WriteLine("nkiuu");
        }

    }
}
