using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //First
            // var firstNumList = new List<int>();
            // firstNumList.Add(3);
            // firstNumList.Add(1);
            // firstNumList.Add(3);
            // firstNumList.Add(1);
            // firstNumList.Add(1);
            // firstNumList.Add(3);
            // var myArray = firstNumList.ToArray();
            // Console.WriteLine(countMults(myArray, 3));

            // //Second
            // Console.WriteLine(hasThreeNonAdjacentThrees(myArray));

            //Third
            char[] letters = new char[5];
            letters[0] = 'd';
            letters[1] = 'o';
            letters[2] = 'e';
            letters[3] = 'g';
            letters[4] = 'v';
            
            Console.WriteLine(containsString(letters, "doge"));
        }


        public static int countMults(int[] nums, int divisibility)
        {
            var divisibleCount = 0;

            foreach (var item in nums)
            {
                if (item % divisibility == 0)
                {
                    Console.WriteLine($"{item} is divisible by {divisibility}.");
                    divisibleCount++;
                }
            }
            return divisibleCount;
        }

        public static bool hasThreeNonAdjacentThrees(int[] nums)
        {
            var threeCount = 0;
            foreach (var item in nums)
            {
                if (item == 3)
                {
                    threeCount++;
                }
            }

            if (threeCount != 3)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] == 3 && nums[i + 1] == 3)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public static bool containsString(char[] letters, string word)
        {
            var letterCount = word.Where(l => letters.Contains(l)).Count();
            //letterCount = where l(current character in word) is equal to l(current character in Letters array) add to the count
            return letterCount == word.Length;
        }
    }
}
