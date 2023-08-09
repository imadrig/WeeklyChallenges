using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }

            if (ignoreCase == false && words.Contains(word))
            {
                return true;
            }
            else if (ignoreCase == true)
            {
                return words.Any(word2 => word2 != null && word2.Equals(word, StringComparison.OrdinalIgnoreCase));
               
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int divideBy = 2; divideBy < num; divideBy++)
            {
                if (num % divideBy == 0) 
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uniqueIndex;

            for (int i = 0; i < str.Length; i++)
            {
                uniqueIndex = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uniqueIndex = false;
                    }
                }

                if (uniqueIndex == true)
                {
                    index = i;
                }
            }

            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            int count = 1;
            int currentCount = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount > count)
                {
                    count = currentCount;
                }
            }

            return count;
            /*int count = 0;


            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                    currentCount++;
                }

                if (currentCount > count)
                {
                    count = currentCount;
                }
            }

            return count;*/
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> result = new List<double>();

            if (elements == null || n <= 0 || n > elements.Count)
            {
                return result.ToArray();
            }

            
            for (int i = n -1; i < elements.Count; i += n)
            {

                result.Add(elements[i]);
                
            }
            return result.ToArray();
        }
    }
}
