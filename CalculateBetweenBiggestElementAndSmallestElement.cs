using System;
using System.Collections.Generic;

namespace CoherentSolutionsTask1
{
    public class CalculateBetweenBiggestElementAndSmallestElement
    {
        public void SumOfBiggestElementAndSmallest()
        {
            List<int> array = new List<int>();
            Console.WriteLine("Enter the how much numbers will you input: ");
            int imputOfNumber = int.Parse(Console.ReadLine());
            for (int index = 0; index < imputOfNumber; index++)
            {
                Console.WriteLine("Input "+(index+1)+" number: ");
                array.Add(int.Parse(Console.ReadLine()));
            }
            int MaxNumberPosition = BiggestElementPosition(array);
            int MinNumberPosition = SmallestElementPosition(array);
            Console.Write("The array: ");
            for (int index = 0; index < array.Count; index++)
            {

                Console.Write(array[index]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Sum of the array elements located between the smallest element in the array and the largest element: " + SumBetweenBiggestAndSmallestElementsInArray(array,MaxNumberPosition,MinNumberPosition));
        }
        int BiggestElementPosition(List<int> array)
        {
            int currentBiggestElement = array[0];
            int currentPositionOfBiggestElement =0;
            for (int index = 0; index < array.Count; index++)
            {
                if(array[index] >= currentBiggestElement)
                {
                    currentBiggestElement=array[index];
                    currentPositionOfBiggestElement = index;
                }
            }
            return currentPositionOfBiggestElement;
        }

        int SmallestElementPosition (List<int> array)
        {
            int currentSmallestElement = array[0];
            int currentPositionOfSmallestElement =0;
            for (int index = 0; index < array.Count; index++)
            {
                if(array[index] < currentSmallestElement)
                {
                    currentSmallestElement=array[index];
                    currentPositionOfSmallestElement = index;
                }
            }
            return currentPositionOfSmallestElement;
        }

        int SumBetweenBiggestAndSmallestElementsInArray(List<int> array, int biggestPosition, int smallestPosition)
        {
            int Sum=0;
            if(biggestPosition > smallestPosition)
            {
                for(int index = smallestPosition; index <= biggestPosition;index++)
                {
                    Sum=Sum+array[index];
                }
            }
            else
            {
                for(int index = biggestPosition; index <= smallestPosition;index++)
                {
                    Sum=Sum+array[index];
                }
            }
            return Sum;
        }
    }
}
