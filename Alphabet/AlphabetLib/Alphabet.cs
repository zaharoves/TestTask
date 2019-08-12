using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetLib
{
    public class Alphabet
    {
        public static string AllLettersAfter(char letter)
        {
            string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (Alphabet.Contains(Char.ToUpper(letter)))
            {
                int indexOfLetter = Alphabet.IndexOf(Char.ToUpper(letter));
                if (indexOfLetter == Alphabet.Length - 1) return "Это последняя буква алфавита!";
                else
                    return (Alphabet.Substring(indexOfLetter + 1));
            }
            else return "Введите букву английского алфавита!";
        }
    }
}
