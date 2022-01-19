using System;

namespace CoherentSolutionsTask1
{
    public class DecimalToTenaryConvertion
    {
        public void  ConvertionDecimalToTenary()
        {
            int firstInput;
            int secondInput;
            Console.WriteLine("Input 2 numbers: ");
            Console.WriteLine("Number 1: ");
            firstInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Number 2: ");
            secondInput = int.Parse(Console.ReadLine());
            for (int index=firstInput; index <= secondInput; index++)
            {
                string tenaryNumber = ConvertDecimalToTernary(index);
                int countOfTwos = CountOfTwosInTenary(tenaryNumber);
                if (countOfTwos == 2)
                {
                    Console.Write("Tenary numbers that have exactly 2 twos are(in decimal form): " + index);
                    Console.WriteLine();
                }
            }
        }

        string ConvertDecimalToTernary(int number)
        {
            string tenaryNumber = "";
            while(number > 0)
            {
                int remainder = number % 3;
                tenaryNumber = remainder + tenaryNumber;
                number = number / 3;
            }

            return tenaryNumber;
        }

        int CountOfTwosInTenary(string str)
        {
            int CountOfTwos = 0;
            char[] array = str.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == '2')
                {
                    CountOfTwos++;
                }
            }
            return CountOfTwos;
        }



    }
}
