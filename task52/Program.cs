 int[,] matrix = new int[,]
        {
            { 8, 5, 7, 2 },
            { 5, 9, 6, 3 },
            { 3, 4, 9, 4 }
        };
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[] averages = new double[cols];
        for (int col = 0; col < cols; col++)
        {
            double sum = 0;
            for (int row = 0; row < rows; row++)
            {
                sum += matrix[row,
                              col];
            }
            averages[col] = sum / rows;
        }
        for (int col = 0; col < cols; col++)
        {
            Console.WriteLine("Среднее арифметическое столбца {0}: {1}", col + 1, averages[col]);
        }
        Console.ReadLine();