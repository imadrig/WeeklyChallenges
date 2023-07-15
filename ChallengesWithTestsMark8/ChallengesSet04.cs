using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
           int result = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                   result += number;
                }
                else
                {
                    result -= number;
                }
               
            }
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] strings = new string[] { str1, str2, str3, str4 };
            int shortestString = strings.Min(str => str.Length);
            
            return shortestString;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] numbers = new int[] { number1, number2, number3, number4 };
            int smallestNumber = numbers.Min();

            return smallestNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            if (string.IsNullOrWhiteSpace(biz.Name))
            {
                biz.Name = "TrueCoders";
            }
            else
            {
                biz.Name = biz.Name.Replace(biz.Name, "TrueCoders");
            }
            
            
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            bool formsTriangle = (sideLength1 + sideLength2 > sideLength3) &&
                                 (sideLength2 + sideLength3 > sideLength1) &&
                                 (sideLength3 + sideLength1 > sideLength2);

            return formsTriangle;

            
        }

        public bool IsStringANumber(string input)
        {
            bool isNumber = double.TryParse(input, out double number);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if (!objs.Any(obj => obj== null))
            {
                return false;
            }
            else
            {
                int nullCount = 0;

                for (int i = 0; i < objs.Length; i++)
                {
                    if (objs[i] == null)
                    {
                        nullCount++;
                    }
                }
                return nullCount > objs.Length / 2;
            }

            
        }

        public double AverageEvens(int[] numbers)
        {
            double averageOfEvens;
            bool allNumbersAreOdd = numbers?.All(number => number % 2 != 0) ?? true;
            
           if (numbers != null && numbers.Length > 0 && !allNumbersAreOdd)
            {
                averageOfEvens = numbers.Where(number => number % 2 == 0).Average();
            }
            else
            {
                averageOfEvens = 0;
            }

            return averageOfEvens;
        }

        public int Factorial(int number)
        {
            if (number < 0) 
            {
                throw new ArgumentOutOfRangeException();
            }

            int factorial = 1;

            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;

        }
    }
}
