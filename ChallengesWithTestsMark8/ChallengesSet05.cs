using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Linq.Expressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (startNumber == 0)
            {
                startNumber = 1;
            }

            for (int i = startNumber + 1; ; i++)
            {
                if (i % n == 0)
                {
                    return i;
                }


            }
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {


            foreach (var business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            var ascendingOrder = numbers.OrderBy(number => number).ToArray();
            bool trueAscendingOrder = numbers.SequenceEqual(ascendingOrder);

            return trueAscendingOrder;

        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;

            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (i + 1 < numbers.Length)
                    {
                        sum += numbers[i + 1];
                    }

                }

            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {

            if (words == null || words.Length == 0)
            {
                return "";
            }

            var justWords = words.Where(word => !string.IsNullOrWhiteSpace(word)).Select(word => word.Trim());
            string sentence = string.Join(" ", justWords).Trim();

            if (!string.IsNullOrEmpty(sentence) && !char.IsPunctuation(sentence[sentence.Length - 1]))
            {
                sentence += ".";
            }

            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {

            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }
            
            List<double> every4th = new List<double>();

            foreach (var item in elements)
            {
                if (item % 4 == 0)
                {
                    every4th.Add(item);
                }
            }
            return every4th.ToArray();
        }


        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length == 0 || nums.Length == 1) 
            {
                return false; 
            
            }
            
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        } 
    }
}
