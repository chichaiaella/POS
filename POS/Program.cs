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
            Console.WriteLine("AXAD");

        }
    }
}
