using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoherentSolutionsTask1
{
    public class Task3
    {
        public void RunTask3()
        {
            List<int> array = new List<int>();
            Console.WriteLine("Enter the how much numbers will you input: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Input "+(i+1)+" number: ");
                array.Add(int.Parse(Console.ReadLine()));
            }
            int MaxNumberPosition = Biggest(array);
            int MinNumberPosition = Smallest(array);
            Console.Write("The array: ");
            for (int i = 0; i < array.Count; i++)
            {

                Console.Write(array[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Sum of the array elements located between the smallest element in the array and the largest element: " + CountBiggestToSmallest(array,MaxNumberPosition,MinNumberPosition));
        }
        int Biggest(List<int> array)
        {
            int biggest = 0;
            int position =0;
            for (int i = 0; i < array.Count; i++)
            {
                if(array[i] >= biggest)
                {
                    biggest=array[i];
                    position = i;
                }
            }
            //Console.WriteLine("Biggest position " + position);
            return position;

        }

        int Smallest (List<int> array)
        {
            int smallest = 1;
            int position =0;
            for (int i = 0; i < array.Count; i++)
            {
                if(array[i] < smallest)
                {
                    smallest=array[i];
                    position = i;
                }
            }
            //Console.WriteLine("Smallest position " + position);
            return position;
        }

        int CountBiggestToSmallest(List<int> array, int biggestPosition, int smallestPosition)
        {
            int addition=0;
            if(biggestPosition > smallestPosition)
            {
                for(int i = smallestPosition; i <= biggestPosition;i++)
                {
                    addition=addition+array[i];
                }
            }
            else
            {
                for(int i = biggestPosition; i <= smallestPosition;i++)
                {
                    addition=addition+array[i];
                }
            }
            return addition;
        }
    }
}
