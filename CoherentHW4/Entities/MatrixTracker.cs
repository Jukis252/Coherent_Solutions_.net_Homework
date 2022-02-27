namespace CoherentHW4.Entities
{
    internal class MatrixTracker<T>
    {
        private readonly DiagonalMatrix<T>? _diagonalMatrix;
        private T? _lastChangedElementValue;
        private int _lastChangedElementRowIndex;
        private int _lastChangedElementColumnIndex;
        private void SaveLastElementChange(object? sender, LastChangedMatrixElementEventArgs<T> e)
        {
            Console.WriteLine($"Event trigerred. Element with position [{e.RowId}, {e.ColumnId}]" +
                              $" in Diagonal Matrix is being changed from previous value {e.FirstValue} to new value" +
                              $" {e.NewValue}. Saving details of old element value.");
            _lastChangedElementValue = e.FirstValue;
            _lastChangedElementRowIndex = e.RowId;
            _lastChangedElementColumnIndex = e.ColumnId;
        }

        public MatrixTracker(DiagonalMatrix<T>? diagonalMatrix)
        {
            _diagonalMatrix = diagonalMatrix;
            if (_diagonalMatrix != null) _diagonalMatrix.LastChangedMatrixElementEvent += SaveLastElementChange;
        }

        public void Undo()
        {
            if (_diagonalMatrix != null)
                if (_lastChangedElementValue != null)
                    _diagonalMatrix[_lastChangedElementRowIndex, _lastChangedElementColumnIndex] =
                        _lastChangedElementValue;
        }
    }
}