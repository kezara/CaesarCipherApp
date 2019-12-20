using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherApp
{
    public class EncryptionMode : ConsoleMenu
    {
        string message;
        char[] cipher;
        int key;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public char[] Cipher
        {
            get { return cipher; }
            set { cipher = value; }
        }

        public int Key
        {
            get { return key; }
            set { key = value; }
        }

        public override void DisplayMenu()
        {
            int keyMenu = 0;
            bool success = false;
            string cipherString;
            Console.WriteLine("Welcome to encryption mode");
            while (String.IsNullOrEmpty(Message))
            {
                Console.WriteLine("Enter message to encrypt:");
                Message = Console.ReadLine();
                if (String.IsNullOrEmpty(Message))
                {
                    ErrorMessage();
                }
            }

            while (!success)
            {
                Console.WriteLine("Enter the key:");
                success = int.TryParse(Console.ReadLine(), out keyMenu);
                if (!success)
                {
                    ErrorMessage();
                }
            }

            Key = keyMenu;
            Cipher = CaesarCipher.Encrypt(Message, Key);
            Console.WriteLine("The Cipher is: ");
            Console.WriteLine(Cipher);

            cipherString = new String(Cipher);

            WriteToFile(cipherString, Key);

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
