using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherApp
{
    public delegate void DisplayMenuDelegate();

    public abstract class ConsoleMenu
    {

        public abstract void DisplayMenu();

        public static ConsoleMenu GetMenuInfo(string menu)
        {
            if (menu.Equals("e"))
            {
                return new EncryptionMode();
            }
            if (menu.Equals("d"))
            {
                return new DecryptionMode();
            }
            return null;
        }

        public void ErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Invalid input");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void WriteToFile(string message, int key)
        {
            string file = @"D:\Crypted-Decrypted.txt";
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine($"{key}+{message}");
            sw.Close();
        }
    }
}
