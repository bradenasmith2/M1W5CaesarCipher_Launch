using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CaesarCipher
{
    public class AlphabetEncryption
    {
        //public char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public AlphabetEncryption()
        {

        }

        public static string userMessage()
        {
            Console.Write("Enter a message to Encrypt: ");
            var message = Console.ReadLine();//input

            return message;
        }

        public static int userShift()
        {
            Console.Write("Enter a shift value (1 - 26): ");
            int shift = Convert.ToInt32(Console.ReadLine());//shift input + conversion

            return shift;
        }

        public static List<char[]> AlphabetCreationAndEncrypt(string message, int shift)
        {
            //method 2 return ciphered alphabet
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            //char[] alphabet = this.alphabet;

            char[] cipherAlphabet = new char[26];
            Array.Copy(alphabet, shift, cipherAlphabet, 0, 26 - shift);//source array, source index, destination array, destination index, length
            Array.Copy(alphabet, 0, cipherAlphabet, 26 - shift, shift);

            List<char[]> bothAlphabets = new List<char[]>{alphabet, cipherAlphabet };

            return bothAlphabets;
            
        }

        public static string SplitAndEncrypt(string message, List<char[]> bothAlphabets)
        {
            char[] alphabet = bothAlphabets[0];
            char[] cipherAlphabet = bothAlphabets[1];

            char[] splitMessage = message.ToCharArray();

            string encrypted = "";

            foreach (var letter in splitMessage)
            {
                if (alphabet.Contains(letter))
                {
                    int indexOfLetter = Array.IndexOf(alphabet, letter);
                    char encryptedLetter = cipherAlphabet[indexOfLetter];
                    encrypted += encryptedLetter;
                }
                else
                {
                    encrypted += letter;
                }
            }

            return encrypted;
        }

        public static void displayResults(string result)
        {
            Console.WriteLine(result);
        }
    }
}
