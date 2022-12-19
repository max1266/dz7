void ma(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-100, 100) + new Random().NextDouble();
        Console.Write("{0,6:F2}", matrix[i, j]);
    }
    Console.WriteLine();
}

}


Console.Clear();
Console.WriteLine("введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];
ma(matrix);

