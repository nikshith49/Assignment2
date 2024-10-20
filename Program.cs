

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            //int[] nums1 = { 1, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            //int[] nums4 = { 1, 2, 3};
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            //int decimalNumber = 10;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            //int[] nums5 = { 4, 5, 6, 7, 0, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            //int palindromeNumber = 122;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            //int n = 30;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);

            Console.ReadKey();
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                IList<int> al = new List<int>();
                // Add all elements in the nums array to hashset, below line does that
                var hs = new HashSet<int>(nums);
                for (int i = 1; i <= nums.Length; i++)
                {
                    // check if set contains the element
                    if (!hs.Contains(i))
                    {
                        // if set doesnot contain the element, add it to return list
                        al.Add(i);
                    }
                }
                // Write your code here
                // return array
                return al;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                // Even Array
                IList<int> e = new List<int>();
                // Odd Array
                IList<int> o = new List<int>();
                foreach (int i in nums)
                {
                    // check if even
                    if (i % 2 == 0)
                    {
                        // push all even elements to e array
                        e.Add(i);
                    }
                    else
                    {
                        // push all odd elements to odd array
                        o.Add(i);
                    }
                }
                // just append all odd elements to even list and return
                foreach (int item in o)
                {
                    e.Add(item);
                }
                // Write your code here
                // return array
                return e.ToArray(); // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                Dictionary<int, int> hm = new Dictionary<int, int>();
                int n = nums.Length;

                // Add element and its respective index to the dictionary
                for (int i = 0; i < n; i++)
                {
                    hm[nums[i]] = i;
                }

                for (int i = 0; i < n; i++)
                {
                    // Calculate the value needed to reach the target
                    int val = target - nums[i];
                    // Check if the val exists in the dict and make sure it's not the same element we are currently checking
                    if (hm.ContainsKey(val) && hm[val] != i)
                    {
                        // If found, return the current index and the index of the val
                        return new int[] { i, hm[val] };
                    }
                }
                // Write your code here
                // return {-1, -1} if no such pair exist
                return new int[] { -1, -1 }; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                int n = nums.Length;
                // Sort the array
                Array.Sort(nums);
                // if array size is less than 3 we cannot calculate product of max 3 elements, so return -1
                if (n < 3) return -1;
                // Write your code here
                // Calculate product for max 3 elements and return
                return nums[n - 3] * nums[n - 2] * nums[n - 1]; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                // Write your code here
                // The below line converts decimal to binary and returns the binary string
                return Convert.ToString(decimalNumber, 2); ; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                int l = 0;
                int r = nums.Length - 1;

                // If the array is already sorted in ascending order, return the first element
                if (nums[l] <= nums[r])
                    return nums[l];

                while (l < r)
                {
                    // Calculate the middle index
                    int m = l + (r - l) / 2;

                    // If the middle element is greater than the rightmost element,
                    // the minimum must be in the right half of the array
                    if (nums[m] > nums[r])
                    {
                        l = m + 1;
                    }
                    else
                    {
                        // Otherwise, the minimum is either the middle element or in the left half
                        r = m;
                    }
                }
                // Write your code here
                return nums[l];
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                // Write your code here
                string str = x.ToString();
                int n = str.Length;
                // Add pointer to the first index and last index
                int i = 0, j = n - 1;
                while (i < j)
                {
                    // Compare characters at the start and end
                    if (str[i] != str[j])
                    {
                        // If characters don't match, it's not a palindrome
                        return false;
                    }
                    // Move the start pointer forward
                    i++;
                    // Move the end pointer backward
                    j--;
                }
                // if we made it throught loop, it is a palindrome
                return true; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                // if n=0, return 0
                if (n == 0) return 0;
                // if n=1, return 1
                if (n == 1) return 1;
                // Write your code here
                // Recursive case: Return the sum of the n-1 and n-2 Fibonacci numbers
                return Fibonacci(n - 1) + Fibonacci(n - 2); // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
