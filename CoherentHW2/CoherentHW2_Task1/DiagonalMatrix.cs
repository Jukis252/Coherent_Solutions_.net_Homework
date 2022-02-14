using System.Text;

namespace HW2_Task1
{
    internal class DiagonalMatrix
    {
        private readonly int[]? _diagonalElements;
        private readonly int _size;

        public DiagonalMatrix(params int[]? diagonalInputElements)
        {
            _diagonalElements = diagonalInputElements;
            if (diagonalInputElements.Length != null)
            {
                _size = _diagonalElements.Length;
            }
            else
            {
                _size = 0;
            }
        }

        public int[]? DiagonalElementsPublic => _diagonalElements;
        public int SizePublic => _size;

        public int this[int i, int j]
        {
            get
            {
                if (i != j || i<0 || j<0 || i>=SizePublic || j>=SizePublic)
                {
                    return 0;
                }
                else
                {
                    return DiagonalElementsPublic[i];
                }
            }
        }

        public int Track()
        {
            return DiagonalElementsPublic.Sum();
        }

        public override bool Equals(object? obj)
        {
            var other = obj as DiagonalMatrix;
            if (SizePublic != other.SizePublic)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < SizePublic; i++)
                {
                    if (DiagonalElementsPublic[i] != other.DiagonalElementsPublic[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override string ToString()
        {
            if (SizePublic == 0)
            {
                return "The Matrix is empty, size = 0";
            }

            StringBuilder sb;
            sb = new StringBuilder($"The output of Matrix({string.Join(", ",DiagonalElementsPublic)}):\n");

            for (int i = 0; i < SizePublic; i++)
            {
                for (int j = 0; j < SizePublic; j++)
                {
                    if (i == j)
                    {
                        sb.Append($"{DiagonalElementsPublic[i]} ");
                    }
                    else
                    {
                        sb.Append($"0 ");
                    }
                }

                sb.Append('\n');
            }

            return sb.ToString();
        }

    }
}
