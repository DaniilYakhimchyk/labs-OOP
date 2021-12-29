using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_8
{//общественный интерфейс
     interface Iin<T>
    {
        public bool Remove(T data);
        public void Add(T data);
    }
}
