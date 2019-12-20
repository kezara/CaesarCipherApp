using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherApp
{
    class CaesarCipher
    {
        public static char[] Encrypt(string plainText, int key)
        {
            char[] cipherText = new char[plainText.Length];
            for (int i = 0, n = plainText.Length; i < n; i++)
            {
                if (plainText[i] >= 65 && plainText[i] <= 90)
                {
                    cipherText[i] = (char)((plainText[i] - 65) % 26 + 65 + key);
                }
                else if (plainText[i] >= 97 && plainText[i] <= 122)
                {
                    cipherText[i] = (char)((plainText[i] - 97) % 26 + 97 + key);
                }
                else
                {
                    cipherText[i] = (char)plainText[i];
                }
            }
            return cipherText;
        }

        public static string Decrypt(string cipherText, int key)
        {
            char[] plainText = new char[cipherText.Length];
            for (int i = 0, n = cipherText.Length; i < n; i++)
            {
                if (cipherText[i] >= 65 && cipherText[i] <= 90)
                {
                    plainText[i] = (char)((cipherText[i] - 65) % 26 + 65 - key);
                }
                else if (cipherText[i] >= 97 && cipherText[i] <= 122)
                {
                    plainText[i] = (char)((cipherText[i] - 97) % 26 + 97 - key);
                }
                else
                {
                    plainText[i] = (char)cipherText[i];
                }
            }
            string plainTextString = new String(plainText);
            return plainTextString;
        }
    }
}
