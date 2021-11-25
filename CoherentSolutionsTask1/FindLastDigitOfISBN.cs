using System;

namespace CoherentSolutionsTask1
{
    public class FindLastDigitOfISBN
    {
        public void CreateLastDigitOfISBN()
        {
            Console.WriteLine("Input a 9 numbers in one line: ");
            string inputNumber =  Console.ReadLine();
            char[] arrayOfChars = inputNumber.ToCharArray();
            int ISBN = 0;
            for (int index = 0; index < arrayOfChars.Length; index++)
            {
                ISBN = ISBN + (10-index)*(arrayOfChars[index]-48);
            }
            int lastDigit = FindDigit(ISBN);
            {
                Console.WriteLine(inputNumber+lastDigit);
            }
        }

        int FindDigit(int isbn)
        {
            int remainderOfISBN = isbn % 11;
            int divisionOfISBN = isbn / 11;
            if(divisionOfISBN == 10)
            {
                return 10;
            }
            else if(divisionOfISBN > 10)
            {
                return 11 - remainderOfISBN;
            }
            else
            {
                return divisionOfISBN;
            }
        }
    }
}
