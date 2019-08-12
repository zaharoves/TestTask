using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlphabetLib;

namespace Alphabet
{
    class Alphabet
    {

        public static void Main()
        {
            string inputString = Console.ReadLine();
            char inputChar;
            if (!char.TryParse(inputString, out inputChar)) Console.WriteLine("Необходимо ввести один символ!");
            else Console.WriteLine(AlphabetClass.AllLettersAfter(Char.ToUpper(inputChar))); //Переводим в верхний регистр букву, чтобы корректно выполнялся метод
            Console.ReadLine();
        }

        
    }
}
