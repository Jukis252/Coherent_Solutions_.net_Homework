using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoherentHW3_Task2.Interfaces
{
    // Did some testing and found out that without struct restriction you can't work with char type variables
    interface IStack<T> where T : struct
    {
        int Size { get; }
        bool IsEmpty();
        T Pop();
        void Push(T element);
        T Peek();
    }
}
