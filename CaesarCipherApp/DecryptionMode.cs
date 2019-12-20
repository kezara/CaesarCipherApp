using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherApp
{
    public class DecryptionMode : ConsoleMenu
    {
        string fileName;
        string path; string decypher;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public string Decypher
        {
            get { return decypher; }
            set { decypher = value; }
        }

        public void ExceptionHandler()
        {
            ErrorMessage();
            MainMenu main = new MainMenu();
            main.DisplayMenu();
        }

        public override void DisplayMenu()
        {
            StreamReader sr = null;
            string file, line;
            int counter = 0;
            int key = 0;

            Console.WriteLine("Welcome to decryption mode");
            while(String.IsNullOrEmpty(Path))
            {
                Console.WriteLine("Enter path to file:");
                Path = Console.ReadLine();
            }

            while (String.IsNullOrEmpty(FileName))
            {
                Console.WriteLine("Enter the file name:");
                FileName = Console.ReadLine();
            }

            file = @Path + FileName;
            Console.WriteLine(file);

            try
            {
                sr = new StreamReader(file);
                while ((line = sr.ReadLine()) != null)
                {
                    key = int.Parse(line[0].ToString());
                    Decypher = CaesarCipher.Decrypt(line.Split('+')[1].ToString(), key);
                    Console.WriteLine($"The Cipher is: {Decypher}");

                    counter++;
                }
            }
            catch (Exception)
            {
                Path = string.Empty;
                FileName = string.Empty;
                ExceptionHandler();
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                    WriteToFile(Decypher, key);
                    Console.ReadLine();
                }
            }
        }
    }
}
