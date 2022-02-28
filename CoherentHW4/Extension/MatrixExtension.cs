using CoherentHW4.Entities;

namespace CoherentHW4.Extension
{
    internal static class DiagonalMatrixExtension
    {

        private static DiagonalMatrix<T> MatrixAddition<T>(DiagonalMatrix<T> biggerMatrix, DiagonalMatrix<T> smallerMatrix, Func<T, T, T> addition)
        {
            var additionMatrix = new DiagonalMatrix<T>(biggerMatrix.Size);
            
            for (int i = 0; i < smallerMatrix.Size; i++)
            {
                additionMatrix[i, i] = addition(biggerMatrix[i, i], smallerMatrix[i, i]);
            }

            for (int i = smallerMatrix.Size; i < biggerMatrix.Size; i++)
            {
                additionMatrix[i, i] = addition(biggerMatrix[i, i], default(T) ?? throw new("Default is null"));
            }

            return additionMatrix;
        }
        
        public static DiagonalMatrix<T>? DiagonalMatrixAddition<T>(this DiagonalMatrix<T>? firstMatrix, DiagonalMatrix<T>? secondMatrix, Func<T, T, T> performAddition)
        {
            if (firstMatrix is null && secondMatrix is null)
            {
                return null;
            }

            if (firstMatrix is null)
            {
                return secondMatrix?.DeepClone();
            }
            else if (secondMatrix is null)
            {
                return firstMatrix.DeepClone();
            }


            if (firstMatrix.Size < secondMatrix.Size)
            {
                return MatrixAddition(secondMatrix, firstMatrix, performAddition);
            }
            else
            {
                return MatrixAddition(firstMatrix, secondMatrix, performAddition);
            }
        }
    }
}