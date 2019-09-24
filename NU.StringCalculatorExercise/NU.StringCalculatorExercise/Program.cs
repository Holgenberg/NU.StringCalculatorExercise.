using System;

namespace NU.StringCalculatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = Add("1, 2, 3");
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        static int Add(string numbers)
        {
            var sum = 0;

            var deliminator = SetDeliminator(numbers);

            var numbersStringArray = numbers.Split(deliminator);

            foreach (var numberString in numbersStringArray)
            {
                if (numberString.Contains("\n"))
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

        static string SetDeliminator(string numbers)
        {
            var deliminator = ",";

            if (numbers.StartsWith("//") && numbers.Contains("\n"))
            {
                var startIndexOfDelim = 2;
                var endIndexOfDelim = numbers.IndexOf("\n");

                deliminator = numbers.Substring(startIndexOfDelim, endIndexOfDelim - startIndexOfDelim);
            }

            return deliminator;
        }

        static int AddMultipleNumbersFromString(string multipleNumberString)
        {
            var numberStringSumAdditive = 0;

            var multipleNumberStringArray = multipleNumberString.Split("\n");

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
