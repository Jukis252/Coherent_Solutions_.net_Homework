namespace CoherentHW4.Entities
{
    internal class LastChangedMatrixElementEventArgs<T> : EventArgs
    {
        public LastChangedMatrixElementEventArgs(int rowId, int columnId, T firstValue, T newValue)
        {
            RowId = rowId;
            ColumnId = columnId;
            FirstValue = firstValue;
            NewValue = newValue;
        }

        public int RowId { get; }
        public int ColumnId { get;  }
        public T FirstValue { get; }
        public T NewValue { get; }
    }
}