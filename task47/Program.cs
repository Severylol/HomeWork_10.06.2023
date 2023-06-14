internal class Program
{
    private static void Main(string[] args)
    {
        static void InputMatrix(double[,] matrix)
        {
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    double randomNumber = random.NextDouble() * 20 - 10;
                    matrix[i, j] = Math.Round(randomNumber, 2);
                }
            }
        }
        static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        {
            Console.Clear();
            Console.Write("Введите размеры массива: ");
            int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
            int m = size[0];
            int n = size[1];
            double[,] matrix = new double[m, n];
            InputMatrix(matrix);
            PrintMatrix(matrix);
        }
    }
}