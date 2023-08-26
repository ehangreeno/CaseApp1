
using System;

namespace CaseApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberRows = random.Next(1,12);
            int numberColumns = random.Next(1, 12);
            int[,] arrays = DataGenerator.GetTwoDimensionalArray(numberRows, numberColumns);
            
            if (numberRows <= 10 && numberColumns <= 10)
                Console.WriteLine($"Array sum : {Сalculator.SumTwoDimensionalArray(arrays)}");
            else Console.WriteLine($"* exceeded the number of columns({numberColumns}) or rows({numberRows}). " +
                $"The allowed value is no more than 10");
        }
    }
}
