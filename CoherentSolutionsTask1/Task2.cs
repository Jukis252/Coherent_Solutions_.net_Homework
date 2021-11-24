using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoherentSolutionsTask1
{
    public class Task2
    {
        public void RunTask2()
        {
            bool answer;
            Console.WriteLine("Input a 9 numbers in one line: ");
            string number =  Console.ReadLine();
            char[] arrayOfChars = number.ToCharArray();
            int ISBN = 0;
            for (int i = 0; i < arrayOfChars.Length; i++)
            {
                ISBN = ISBN + (10-i)*(arrayOfChars[i]-48);
            }
            int digit = CheckDigit(ISBN);
            answer = Validation(digit,ISBN);
            if(answer == true)
            {
                Console.WriteLine(number+digit);
            }

            
        }
        int CheckDigit(int isbn)
        {
            int remainder = isbn % 11;
            int division = isbn / 11;
            if(division > 10)
            {
                return 11 - remainder;
            }
            else
            {
                return division;
            }
        }

        bool Validation(int digit, int isbn)
        {
            int newisbn = isbn+digit;
            int remainder = newisbn % 11;
            int division = newisbn / 11;
            if(remainder == 0)
            {
                Console.WriteLine("Valid ISBN");
                return true;
            }
            else
            {
                Console.WriteLine("ISBN not valid");
                return false;
            }

        }
    }
}
