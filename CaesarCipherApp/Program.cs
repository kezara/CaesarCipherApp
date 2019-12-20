using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleMenu opcija;
            DisplayMenuDelegate dmDelegate;
            MainMenu mainMenu = new MainMenu();
            string izbor;
            do
            {
                Console.WriteLine("Welcome to Caesar cipher app, please choose:\n");
                mainMenu.DisplayMenu();
                izbor = Console.ReadLine();
                if (izbor != "x")
                {
                    opcija = ConsoleMenu.GetMenuInfo(izbor);
                    if (opcija != null)
                    {
                        Console.Clear();
                        dmDelegate = opcija.DisplayMenu;
                        dmDelegate();
                        Console.Clear();
                    }
                }
            }
            while (izbor != "x");
        }
    }
}
