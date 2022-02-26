using System.Text;
using CoherentHW3_Task2.Interfaces;

namespace CoherentHW3_Task2.Entities
{
    class Stack<T> : IStack<T> where T : struct
    {

        private readonly T[] _stack;
        private int _elementCount;
        private readonly int _size;

        public Stack(int size)
        {
            if (size > 0)
            {
                _stack = new T[size];
                _elementCount = 0;
                _size = size;
            }
            else
            {
                throw new ArgumentException("Stack size is less than 0");
            }
        }
        public int Size => _size;

        public bool IsEmpty()
        {
            return _elementCount == 0;
        }

        public T Pop()
        {
            T lastElement;

            if (_elementCount >= 1)
            {
                lastElement = _stack[_elementCount - 1];
                _stack[_elementCount - 1] = default;
            }
            else
            {
                throw new InvalidOperationException("Nothing to pop, stack is empty");
            }

            _elementCount--;
            return lastElement;
        }

        public void Push(T element)
        {
            if (_elementCount < _stack.Length)
            {
                _stack[_elementCount] = element;
                _elementCount++;
            }
            else
            {
                throw new IndexOutOfRangeException("Maximum capacity reached");
            }
        }

        public T Peek()
        {
            if (!IsEmpty())
            {
                return _stack[_elementCount - 1];
            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var element in _stack)
            {
                sb.Append(element + " ");
            }

            return sb.ToString();
        }
    }
}
