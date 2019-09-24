using System;

namespace NU.StringCalculatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        int Add(string numbers)
        {
            var sum = 0;

            var numbersStringArray = numbers.Split(',');

            foreach (var numberString in numbersStringArray)
            {
                //if (numberString.Contains('\n'))
                //{
                //    sum += AddMultipleNumbersFromNumberString(numberString);
                //}

                //else
                //{
                //    sum += ParseNumberStringAndAddToSum(numberString);
                //}

                sum += ParseNumberStringAndAddToSum(numberString);
            }

            return sum;
        }

        //private int AddMultipleNumbersFromNumberString(string thisNumberString)
        //{
        //    var numberStringSumAdditive = 0;

        //    var thisNumbersStringArray = thisNumberString.Split('\n');

        //    foreach (var numberString in thisNumbersStringArray)
        //    {
        //        numberStringSumAdditive += ParseNumberStringAndAddToSum(numberString);
        //    }

        //    return numberStringSumAdditive;
        //}

        private int ParseNumberStringAndAddToSum(string numberString)
        {
            int.TryParse(numberString, out int additive);
            return additive;
        }
    }
}
