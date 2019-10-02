using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConvertor
{    
    class SystemConverter
    {
        private static string getLetters(int input)
        {
            string[] letters = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            return letters[input];
        }

        protected static string fromDecimal(int number, int basis)
        {
            
            string result = "";
            int modulo;

            while (number > 0)
            {
                if (number % basis == 0)
                {
                    modulo = 0;
                }
                else
                {
                    modulo = number % basis;
                    number -= modulo;
                }
                result = getLetters(modulo) + result;
                number /= basis;
            }

            return result;
        }

        
    }
}