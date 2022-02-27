using System.Text;

namespace CoherentHW4.Entities
{
    internal class DiagonalMatrix<T>
    {
        private readonly T[] _diagonalElements;

        public DiagonalMatrix(int size)
        {
            if (size >= 0)
            {
                _diagonalElements = new T[size];
                Size = _diagonalElements.Length;
            }
            else
            {
                throw new ArgumentException("Matrix size can't be less than zero 0");
            }
        }
        public int Size { get; }

        public T this[int i, int j]
        {
            get
            {
                if (i < 0 || j < 0 || i >= Size || j >= Size)
                {
                    throw new IndexOutOfRangeException($"Given index is out of range. It should fit in matrix size, which is {Size}");
                }
                else if (i != j)
                {
                    return default(T) ?? throw new InvalidOperationException("Default can't be null");
                }

                return _diagonalElements[i];
            }
            set
            {
                if (i < 0 || j < 0 || i >= Size || j >= Size)
                {
                    throw new IndexOutOfRangeException($"Given index is out of range. It should fit in matrix size, which is {Size}");
                }
                else if(i == j && !EqualityComparer<T>.Default.Equals(_diagonalElements[i], value))
                {
                    T oldElementValue = _diagonalElements[i];
                    _diagonalElements[i] = value;
                    LastChangedMatrixElementEvent?.Invoke(this, new(i, j, oldElementValue, _diagonalElements[i]));
                }
            }
        }

        public DiagonalMatrix<T> DeepClone()
        {
            var clone = new DiagonalMatrix<T>(this.Size);
            for (int i = 0; i < _diagonalElements.Length; i++)
            {
                clone[i, i] = _diagonalElements[i];
            }

            return clone;
        }

        public override string ToString()
        {
            if (Size == 0)
            {
                return "Empty matrix (size = 0)";
            }

            StringBuilder matrixOutput = new("Diagonal matrix elements :\n");

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    matrixOutput.Append($"{this[i, j]}\t");
                }
                matrixOutput.Append('\n');
            }
            return matrixOutput.ToString();
        }

        public event EventHandler<LastChangedMatrixElementEventArgs<T>>? LastChangedMatrixElementEvent;
    }
}