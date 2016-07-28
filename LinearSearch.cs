using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgoCode
{
    class LinearSearch
    {
        public int PerformLinearSearch(int[] inputArray, int key)
        {
            if (inputArray.Length == 0) return -1;
            for(int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == key)
                    return i;
            }
            return -1;
        }
    }
}
