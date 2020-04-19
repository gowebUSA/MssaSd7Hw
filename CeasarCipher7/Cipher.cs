using System;

namespace CeasarCipher7
{
    public class CeasarCipher7
    {
        static string Alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static string Ring(int key)
        {
            key %= 26;
            string cipher = "";
            for (int i = 0; i < Alpha.Length; i++)
            {
                int offset = i + key;
                if (key > 0)
                {
                    cipher += Alpha[offset < 26 ? offset : offset - 26];
                }
                else
                    cipher += Alpha[offset < 0 ? offset + 26 : offset];
            }
                return cipher;
        }
        public static string CharShift(string message, int key)
        {
            string code = "";
            string cipher = Ring(key);
            foreach (char letter in message.ToUpper())
            {
                code += cipher.Contains(letter) ? cipher[Alpha.IndexOf(letter)] : letter;
            }
            return code;
        }
    }
    class Cipher
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CeasarCipher");
        }
    }
}
