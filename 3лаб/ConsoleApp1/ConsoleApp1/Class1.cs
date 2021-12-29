using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba4Var8
{
    static class Class1
    {
        public static char LastNumb(this Set<string> list)
        {
            char numb = '\0';
            foreach (var elem in list)
            {
                var strArr = elem.ToString();
                if (numb == '\0')
                {
                    for (int i = 0; i < strArr.Length; i++)
                    {
                        if (numb == '\0')
                        {
                            if (strArr[i] >= '0' && strArr[i] <= '9') numb = strArr[i];

                        }
                    }
                }
            }
            return numb;
        }

        public static void DelNumb(this Set<int> A)
        {

            var arr = A._items.ToArray() as int[];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    A.Remove(arr[i]);
                }
            }

        }

    }
}
