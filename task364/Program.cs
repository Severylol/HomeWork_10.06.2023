int n = 5; 
int m = 12; 
int[,] A = new int[n, m];
    for (int i = 0; i < n; i++)
        {
        for (int j = 0; j < m; j++)
            {
                A[i, j] = i * m + j + 1;
            }
        }
        for (int i = 0; i < n; i++)
        {
        for (int j = 0; j < m; j++)
            {
Console.Write(A[i, j] + " ");
            }
Console.WriteLine();
        }