void max(int[,] ma)
{
    for(int i = 0; i < ma.GetLength(0); i++)
    {
        for(int j = 0; j< ma.GetLength(1); j++)
        {
            ma[i,j] = new Random().Next(1,10);
            Console.Write($"{ma[i,j]} \t");
        }
        Console.WriteLine();
    }
}




Console.Clear();
Console.WriteLine("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
max(matrix);
for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
    }
    Console.Write($"Среднее арифмитическое: { sum / matrix.GetLength(0)} \t");
}