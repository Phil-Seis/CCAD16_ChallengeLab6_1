/*Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
 * Example 1:
    * Input: nums = [2,2,1]
    * Output: 1

 * Example 2:
    * Input: nums = [4,1,2,1,2]
    * Output: 4

 * Example 3:
    * Input: nums = [1]
    * Output: 1


//parse original array in dictionary, count occurences and add to the value of that key
//do a search of the unique key*/

using System;
using System.Collections.Generic;

namespace CCAD16_ChallengeLab6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare the array
            int[] nums = { 4, 1, 2, 1, 2 };
            Console.WriteLine($"Your array is: [{string.Join(", ", nums)}]");

            // Create a dictionary to count occurrences
            Dictionary<int, int> numCounts = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                try
                {
                    // increment the count for the key
                    numCounts[num]++;
                }
                catch (KeyNotFoundException)
                {
                    // If key doesn't exist, add it with a count of 1
                    numCounts[num] = 1;
                }
            }

            // Search the dictionary for the unique element
            int uniqueNumber = -1; // Default value in case no unique number is found
            foreach (KeyValuePair<int, int> pair in numCounts)
            {
                if (pair.Value == 1)
                {
                    uniqueNumber = pair.Key;
                    break;
                }
            }

            // Output the result
            Console.WriteLine($"The single number is: {uniqueNumber}");
        }
    }
}
