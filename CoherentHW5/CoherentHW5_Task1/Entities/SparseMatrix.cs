using System.Collections;
using System.Text;

namespace CoherentHW5_Task1.Entities
{
    internal class SparseMatrix : IEnumerable<int>
    {

        private readonly SortedDictionary<(int, int), int> _matrixElements = new();
        public SparseMatrix(int columnsNumber, int rowNumber)
        {
            if (columnsNumber > 0 && rowNumber > 0)
            {
                ColumnsNumber = columnsNumber;
                RowNumber = rowNumber;
            }
            else
            {
                throw new ArgumentException("Number of rows or columns is zero");
            }
        }

        public int ColumnsNumber { get; init; }
        public int RowNumber { get; init; }

        public int this[int column, int row]
        {
            get
            {
                if (row > 0 || column > 0 || row < RowNumber || column < ColumnsNumber)
                {
                    if (!_matrixElements.ContainsKey((column, row)))
                    {
                        return 0;
                    }
                    else
                    {
                        _matrixElements.TryGetValue((column, row), out var elementValue);
                        return elementValue;
                    }
                }
                else
                {
                    throw new IndexOutOfRangeException($"Index out of range");
                }
            }
            set
            {
                if (row > 0 || column > 0 || row < RowNumber || column < ColumnsNumber)
                {
                    if (value != 0)
                    {
                        _matrixElements.Add((column, row), value);
                    }
                }
                else
                {
                    throw new IndexOutOfRangeException($"Index out of range");
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public int Count(int elementValue)
        {
            if (elementValue == 0)
            {
                return ColumnsNumber * RowNumber - _matrixElements.Count;
            }
            else
            {
                return _matrixElements.Count(element => element.Value == elementValue);
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int column = 0; column < ColumnsNumber; column++)
            {
                for (int row = 0; row < RowNumber; row++)
                {
                    yield return this[column, row];
                }
            }
        }

        public IEnumerable<(int, int, int)> NoZeroOutput()
        {
            foreach (KeyValuePair<(int, int), int> element in _matrixElements)
            {
                yield return (element.Key.Item1, element.Key.Item2, element.Value);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new ("Sparse matrix elements:\n");
            for (int column = 0; column < ColumnsNumber; column++)
            {
                for (int row = 0; row < RowNumber; row++)
                {
                    sb.Append(this[column, row] + "\t");
                }

                sb.Append('\n');
            }

            return sb.ToString();
        }

    }
}
