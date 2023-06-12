using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Revision.Alghorithms.Search
{
    class LinearSearchAlghorithm
    {
        /*A simple search alghorithm that iterates trought the array and returns when the the element from the array mathes the target.
         * This has the complexity of O(n) where n is the array size.
         */

        public static int LinearSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i; 
                }
            }
            return -1; 
        }

    }
}
