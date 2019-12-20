using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherApp
{
    public class MainMenu : ConsoleMenu
    {
        string[] mainMenuItems = {"(E) to encrypt",
                                  "(D) to decrypt",
                                  "(X) to exit"};

        public override void DisplayMenu()
        {
            for (int i = 0; i < mainMenuItems.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {mainMenuItems[i]}");
            }
        }
    }
}
