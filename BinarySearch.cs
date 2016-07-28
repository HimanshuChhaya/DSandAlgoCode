using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgoCode
{
    class BinarySearch
    {
        public int PerformBinarySearch(int[] inputArray, int key)
        {
            if (inputArray.Length == 0) return -1;
            if(inputArray.Length == 1) 
            {
                if (key == inputArray[0])
                    return 0;
                else
                    return -1;
            }

            int left = 0;
            int right = inputArray.Length - 1;
            int mid;

            while(left <= right)
            {
                mid = (left + right) / 2;
                if (key == inputArray[mid])
                    return mid;
                if (key < inputArray[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            return -1;
        }

    }
}
