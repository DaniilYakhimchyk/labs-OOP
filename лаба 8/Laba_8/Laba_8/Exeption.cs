using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_8
{
    class IndexException:Exception
    {
        public IndexException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
