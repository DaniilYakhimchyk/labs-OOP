using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_5
{
    class Exeption2 : Exception
    {
        public int Top { get; set; }

        public Exeption2(string message, int TopUp) : base(message)
        {
            this.Top = TopUp;
        }
    }
}
