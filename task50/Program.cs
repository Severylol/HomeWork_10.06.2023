            int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
            
                Console.Clear();

                Console.WriteLine("Введите позиции элементa:");
                Console.Write("Строка: ");
                int row = int.Parse(Console.ReadLine()!);

                Console.Write("Столбец: ");
                int column = int.Parse(Console.ReadLine()!);

                int numRows = matrix.GetLength(0);
                int numColumns = matrix.GetLength(1);

                if (row < 0 || row >= numRows || column < 0 || column >= numColumns)
                {
                    Console.WriteLine("Элемент с указанными позициями отсутствует.");
                }
                else
                {
                    int element = matrix[row, column];
                    Console.WriteLine("Значение элемента: " + element);
                }