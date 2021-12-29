using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_5
{
    interface IBall
    {
        void Print();
    }

    public interface IGym<T>
    {
        void Add(T item);
        void Delete(int index);
        void Show();
        public void Add(T item, int count);
    }
}
