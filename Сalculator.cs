using System;

namespace CaseApp1
{
    public static class Сalculator
    {
        public static int SumTwoDimensionalArray(int[,] array)
        {
            int sum = 0;
            try
            {
                for (int i = 0; i < array.GetLength(0); i++)
                    for (int j = 0; j < array.GetLength(1); j++)
                        checked
                        {
                            sum += array[i, j];
                        }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return sum;
        }
    }
}
