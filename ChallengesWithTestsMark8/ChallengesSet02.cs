using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (Char.IsLetter(c)) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0) 
            {
                return true;
            }
                else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers != null && numbers.Any())
            {
                double sumMinMax = numbers.Min() + numbers.Max();
                return sumMinMax;
            } 
            else 
            {
                return 0f;
            }
            
          
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers != null && numbers.Any())
            {
              return numbers.Sum();  
            }
            else
            {
                return 0;
            }
            
        }

        public int SumEvens(int[] numbers)

        {
            List<int> evenNumbers = new List<int>();

            if (numbers !=null && numbers.Any())
            {
                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {

                        evenNumbers.Add(number);


                    }

                }
                return evenNumbers.Sum();
            }
            else
            { 
                return 0; 
            }

            

        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers != null && numbers.Sum() % 2 != 0)
            {
                return true;
            }
            return false;

           

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            List<long> positiveOdds = new List<long>(); 

            long countToNumber = 0;
            if (number > 0)
            {
                    for (long i = 1; i < number; i += 2)
                    {
                        positiveOdds.Add(i);
                    }
            }
            return positiveOdds.Count;

        }
    }
}
