using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = AlphabetEncryption.userMessage();

            int shift = AlphabetEncryption.userShift();

            List<char[]> bothAlphabets = AlphabetEncryption.AlphabetCreationAndEncrypt(message,shift);

            string encryptedMessage = AlphabetEncryption.SplitAndEncrypt(message, bothAlphabets);

            AlphabetEncryption.displayResults(encryptedMessage);

            //char[] alphabet = AlphabetEncryption.alphabet;
        }
    }
}
