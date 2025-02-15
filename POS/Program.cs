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
            }
            else
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
            Console.WriteLine("       Chicken                   Price\n");
            Console.WriteLine("[ A ]  Fried Chicken              100");
            Console.WriteLine("[ B ]  Inasal Chicken             120");
            Console.WriteLine("[ C ]  Double Fried Chicken       180");
            Console.WriteLine("[ D ]  Back");

            Console.Write("Enter Choice: ");
            string choice = Console.ReadLine();

            if (choice == "A" || choice == "a")
            {
                Console.WriteLine("Fried Chicken");
                Console.Write("Quantity  : ");
                int qty = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Total: " + qty * 100);
                Console.WriteLine("Add to Cart? [Y/N]");
                string add = Console.ReadLine();
                if (add == "Y" || add == "y")
                {
                    Console.WriteLine("Added to Cart");
                    MainMenu();
                }
                else
                {
                    Console.WriteLine("Not Added to Cart");
                    MainMenu();
                }
            }
            else if (choice == "B" || choice == "b")
            {
                Console.WriteLine("Inasal Chicken");
                Console.Write("Quantity  : ");
                int qty = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Total: " + qty * 120);
                Console.WriteLine("Add to Cart? [Y/N]");
                string add = Console.ReadLine();
                if (add == "Y" || add == "y")
                {
                    Console.WriteLine("Added to Cart");
                    MainMenu();
                }
                else
                {
                    Console.WriteLine("Not Added to Cart");
                    MainMenu();
                }
            }
            else if (choice == "C" || choice == "c")
            {
                Console.WriteLine("Double Fried Chicken");
                Console.Write("Quantity  : ");
                int qty = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Total: " + qty * 180);
                Console.WriteLine("Add to Cart? [Y/N]");
                string add = Console.ReadLine();
                if (add == "Y" || add == "y")
                {
                    Console.WriteLine("Added to Cart");
                    MainMenu();
                }
                else
                {
                    Console.WriteLine("Not Added to Cart");
                    MainMenu();
                }
            }
            else if (choice == "D" || choice == "d")
            {
                MenuOrder();
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Chicken();
            }
        }
        static void Drinks()
        {
            Console.WriteLine("       Drinks            Price\n");
            Console.WriteLine("[ A ]  Coke              49");
            Console.WriteLine("[ B ]  Royal             49");
            Console.WriteLine("[ C ]  Sprite            49");
            Console.WriteLine("[ D ]  Water             20");
            Console.WriteLine("[ E ]  Back");

            Console.Write("Enter Choice: ");
            string choice = Console.ReadLine();
            Console.WriteLine("");

            if (choice == "A" || choice == "a")
            {
                Console.WriteLine("Coke");
                Console.Write("Quantity  : ");
                int qty = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Total: " + qty * 49);
                Console.WriteLine("Add to Cart? [Y/N]");
                string add = Console.ReadLine();
                if (add == "Y" || add == "y")
                {
                    Console.WriteLine("Added to Cart");
                    MainMenu();
                }
                else
                {
                    Console.WriteLine("Not Added to Cart");
                    MainMenu();
                }
            }
            else if (choice == "B" || choice == "b")
            {
                Console.WriteLine("Royal");
                Console.Write("Quantity  : ");
                int qty = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Total: " + qty * 49);
                Console.WriteLine("Add to Cart? [Y/N]");
                string add = Console.ReadLine();
                if (add == "Y" || add == "y")
                {
                    Console.WriteLine("Added to Cart");
                    MainMenu();
                }
                else
                {
                    Console.WriteLine("Not Added to Cart");
                    MainMenu();
                }

            }
            else if (choice == "C" || choice == "c")
            {
                Console.WriteLine("Sprite");
                Console.Write("Quantity  : ");
                int qty = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Total: " + qty * 49);
                Console.WriteLine("Add to Cart? [Y/N]");
                string add = Console.ReadLine();
                if (add == "Y" || add == "y")
                {
                    Console.WriteLine("Added to Cart");
                    MainMenu();
                }
                else
                {
                    Console.WriteLine("Not Added to Cart");
                    MainMenu();
                }
            }
            else if (choice == "D" || choice == "d")
            {
                Console.WriteLine("Water");
                Console.Write("Quantity  : ");
                int qty = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Total: " + qty * 20);
                Console.WriteLine("Add to Cart? [Y/N]");
                string add = Console.ReadLine();
                if (add == "Y" || add == "y")
                {
                    Console.WriteLine("Added to Cart");
                    MainMenu();
                }
                else
                {
                    Console.WriteLine("Not Added to Cart");
                    MainMenu();
                }
            }
            else if (choice == "E" || choice == "e")
            {
                MenuOrder();
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Drinks();
            }
        }        
            static void SideDish()
            {
                Console.WriteLine("       Side-Dish            Price\n");
                Console.WriteLine("[ A ]   Coleslaw              59");
                Console.WriteLine("[ B ]   Fries                 59");

            Console.Write("Enter Choice: ");
            string choice = Console.ReadLine();
            Console.WriteLine("");

            if (choice == "A" || choice == "a")
            {
                Console.WriteLine("Coleslaw");
                Console.Write("Quantity  : ");
                int qty = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Total: " + qty * 59);
                Console.WriteLine("Add to Cart? [Y/N]");
                string add = Console.ReadLine();
                if (add == "Y" || add == "y")
                {
                    Console.WriteLine("Added to Cart");
                    MainMenu();
                }
                else
                {
                    Console.WriteLine("Not Added to Cart");
                    MainMenu();
                }
            }
            else if (choice == "B" || choice == "b")
            {
                Console.WriteLine("Fries");
                Console.Write("Quantity  : ");
                int qty = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Total: " + qty * 59);
                Console.WriteLine("Add to Cart? [Y/N]");
                string add = Console.ReadLine();
                if (add == "Y" || add == "y")
                {
                    Console.WriteLine("Added to Cart");
                    MainMenu();
                }
                else
                {
                    Console.WriteLine("Not Added to Cart");
                    MainMenu();
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
                SideDish();
            }
        }
            static void Cart()
            {
                
            }
            static void History()
            {
                Console.WriteLine("nkiuu");
            }

        }
    }