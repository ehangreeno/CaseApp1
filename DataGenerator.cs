using System;

namespace CaseApp1
{
    public static class DataGenerator
    {
        public static int[,] GetTwoDimensionalArray( int numberRows, int numberColumns)
        {
            Random random = new Random();
            int[,] array = new int[numberRows, numberColumns];
            for (int i = 0; i < numberRows; i++)
                for (int j = 0; j < numberColumns; j++)
                    array[i, j] = random.Next(1000);
            return array;
        }
                    
    }
}
