using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoherentSolutionsTask1
{
    public class Task1
    {
        public void  RunTask1()
        {
            List<int> ArrayOfTenarys = new List<int>();
            int a;
            int b;
            string Tenary;
            int count=0;
            Console.WriteLine("Input 2 numbers: ");
            Console.WriteLine("Number 1: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Number 2: ");
            b = int.Parse(Console.ReadLine());
            for (int i=a; i <= b; i++)
            {
                Console.Write("Tenary number of " + i +" is: ");
                Tenary = convertToTernary(i);
                count = SplitStringCountTwos(Tenary);
                if(count == 2)
                {
                    Console.Write("Tenary numbers that have exactly 2 twos are(in decimal form): " + i);

                }
                else
                {

                }
                Console.WriteLine();
            }
        }

        string convertToTernary(int number)
        {
            string numberToBe = "";
            while(number > 0)
            {
                int x = number % 3;
                Convert.ToString(x);
                numberToBe = numberToBe + x;
                number = number / 3;
            }

            return numberToBe;
        }

        int SplitStringCountTwos(string str)
        {
            int count = 0;
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == '2')
                {
                    count++;
                }
            }
            return count;
        }



    }
}
