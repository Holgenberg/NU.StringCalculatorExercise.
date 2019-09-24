using System;

namespace NU.StringCalculatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sum = Add("1\n2,3");
            //Console.WriteLine(sum);
            //Console.ReadKey();
        }

        static int Add(string numbers)
        {
            var sum = 0;

            var numbersStringArray = numbers.Split(',');

            foreach (var numberString in numbersStringArray)
            {
                if (numberString.Contains('\n'))
                {
                    sum += AddMultipleNumbersFromString(numberString);
                }

                else
                {
                    sum += ParseNumberString(numberString);
                }
            }

            return sum;
        }

        static int AddMultipleNumbersFromString(string multipleNumberString)
        {
            var numberStringSumAdditive = 0;

            var multipleNumberStringArray = multipleNumberString.Split('\n');

            foreach (var numberString in multipleNumberStringArray)
            {
                numberStringSumAdditive += ParseNumberString(numberString);
            }

            return numberStringSumAdditive;
        }

        static int ParseNumberString(string numberString)
        {
            int.TryParse(numberString, out int additive);
            return additive;
        }
    }
}
