namespace HW2_Task1
{
    static class MatrixExtension
    {
        public static DiagonalMatrix AddTwoMatrixes(DiagonalMatrix matrixOne, DiagonalMatrix matrixTwo)
        {
            if (matrixOne == null && matrixTwo == null)
            {
                return null;
            }

            if (matrixOne == null)
            {
                return new DiagonalMatrix(matrixTwo.DiagonalElementsPublic);
            }
            else if(matrixTwo == null)
            {
                return new DiagonalMatrix(matrixOne.DiagonalElementsPublic);
            }

            int newMatrixSize = 0;


            if (matrixOne.SizePublic >= matrixTwo.SizePublic)
            {
                newMatrixSize = matrixOne.SizePublic;
            }
            else
            {
                newMatrixSize = matrixTwo.SizePublic;
            }

            int[] newMatrixElements = new int[newMatrixSize];

            for (int i = 0; i < newMatrixSize; i++)
            {
                newMatrixElements[i] = matrixOne[i,i] + matrixTwo[i,i];
            }

            return new DiagonalMatrix(newMatrixElements);
        }
    }
}
