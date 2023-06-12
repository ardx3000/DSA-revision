using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Revision.Alghorithms.Search
{
    class BinarySearchAlghorithm
    {
        public static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                {
                    return mid; // Return the index of the target element
                }
                else if (array[mid] < target)
                {
                    left = mid + 1; // Target is in the right half
                }
                else
                {
                    right = mid - 1; // Target is in the left half
                }
            }

            return -1; // Return -1 if the target element is not found
        }
}
