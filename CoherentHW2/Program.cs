namespace HW2_Task1
{
    internal class Program
    {
        static void Main()
        {
            var firstMatrix = new DiagonalMatrix(1, 3, 5);
            var secondMatrix = new DiagonalMatrix(2, 4, 6, 8);
            var thirdMatrix = new DiagonalMatrix(9, 5, 1);

            void TestIndex()
            {
                Console.WriteLine("Testing Indexes");
                Console.WriteLine(firstMatrix[0,0]);
                Console.WriteLine(firstMatrix[5, 5]);
                Console.WriteLine();
            }

            void TestTrack()
            {
                Console.WriteLine("Testing Track(addition)");
                Console.WriteLine(firstMatrix.Track());
                Console.WriteLine();
            }

            void TestEquals()
            {
                Console.WriteLine("Test Equals");
                Console.WriteLine(firstMatrix.Equals(secondMatrix));
                Console.WriteLine(firstMatrix.Equals(thirdMatrix));
                Console.WriteLine();
            }

            void TestToString()
            {
                Console.WriteLine("Testing ToString");
                Console.WriteLine(firstMatrix.ToString());
                Console.WriteLine();
            }

            void TestExstension()
            {
                Console.WriteLine("Testing Extension");
                var fourthMatrix = MatrixExtension.AddTwoMatrixes(firstMatrix, secondMatrix);
                Console.WriteLine(fourthMatrix.ToString());
                Console.WriteLine();
            }

            TestIndex();
            TestTrack();
            TestEquals();
            TestToString();
            TestExstension();
        }
    }
}

