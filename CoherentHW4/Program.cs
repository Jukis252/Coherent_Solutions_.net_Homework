using CoherentHW4.Entities;
using CoherentHW4.Extension;


namespace CoherentHW4
{
    class Program
    {
        static void Main()
        {
            var firstDiagonalMatrix = new DiagonalMatrix<int>(5);
            var value = 1;
            for (int i = 0; i < firstDiagonalMatrix.Size; i++)
            {
                firstDiagonalMatrix[i,i] = value++;
            }

            /*firstDiagonalMatrix[0,0] = 1;
            firstDiagonalMatrix[1,1] = 2;
            firstDiagonalMatrix[2,2] = 3;
            firstDiagonalMatrix[3,3] = 4;
            firstDiagonalMatrix[4,4] = 5;*/

            var secondDiagonalMatrix = new DiagonalMatrix<int>(3);
            for (int i = 0; i < secondDiagonalMatrix.Size; i++)
            {
                secondDiagonalMatrix[i,i] = 5*i;
            }

            var thirdDiagonalMatrix = new DiagonalMatrix<double>(3);
            for (int i = 0; i < thirdDiagonalMatrix.Size; i++)
            {
                thirdDiagonalMatrix[i,i] =i*0.8;
            }
            
            var fourthDiagonalMatrix = new DiagonalMatrix<double>(3);
            fourthDiagonalMatrix[0, 0] = 1.50;
            fourthDiagonalMatrix[1, 1] = 2.50;
            fourthDiagonalMatrix[2, 2] = 3.50;

            DiagonalMatrix<int>? fifthDiagonalMatrix = firstDiagonalMatrix.DiagonalMatrixAddition(secondDiagonalMatrix, PerformElementAddition);
            DiagonalMatrix<double>? sixthDiagonalMatrix = thirdDiagonalMatrix.DiagonalMatrixAddition(fourthDiagonalMatrix, PerformElementAddition);

            Console.WriteLine(firstDiagonalMatrix.ToString());
            Console.WriteLine(secondDiagonalMatrix.ToString());
            Console.WriteLine(thirdDiagonalMatrix.ToString());
            Console.WriteLine(fourthDiagonalMatrix.ToString());
            Console.WriteLine(fifthDiagonalMatrix?.ToString());
            Console.WriteLine(sixthDiagonalMatrix?.ToString());

            var trackFirstDiagonalMatrix = new MatrixTracker<int>(firstDiagonalMatrix);
            firstDiagonalMatrix[1, 1] = 50;

            trackFirstDiagonalMatrix.Undo();
            Console.WriteLine(firstDiagonalMatrix[1, 1]);
        }

        private static T PerformElementAddition<T>(T? firstDiagonalMatrixElement, T? secondDiagonalMatrixElement)
        {
            dynamic? firstElement = firstDiagonalMatrixElement;
            dynamic? secondElement = secondDiagonalMatrixElement;

            return firstElement + secondElement;
        }
    }
}