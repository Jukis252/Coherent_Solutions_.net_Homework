using CoherentHW5_Task1.Entities;

namespace CoherentHW5_Task1
{
    class Program
    {
        static void Main()
        {
            
            var sparseMatrix = new SparseMatrix(5, 5);
            sparseMatrix[0, 0] = 1;
            sparseMatrix[0, 1] = 5;
            sparseMatrix[1, 1] = 3;
            sparseMatrix[1, 2] = 4;
            sparseMatrix[2, 2] = 5;
            sparseMatrix[2, 3] = 6;
            sparseMatrix[3, 3] = 7;
            sparseMatrix[3, 4] = 5;
            sparseMatrix[4, 4] = 9;

            Console.WriteLine(sparseMatrix);
            foreach (var element in sparseMatrix)
            {
                Console.WriteLine(element);
            }

            foreach (var element in sparseMatrix.NoZeroOutput())
            {
                Console.WriteLine($"Value {element.Item3} in column " + $"{element.Item1 + 1} and row {element.Item2 + 1}");
            }

            Console.WriteLine();
            int occurrencesOfCount = sparseMatrix.Count(5);
            Console.WriteLine($"Occurrences of number 5 in matrix is: {occurrencesOfCount}");
        }
    }
}