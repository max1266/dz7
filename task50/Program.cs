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
Console.WriteLine("введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x =>int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
max(matrix);
Console.WriteLine("введите номер строки: ");
int pos1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца: ");
int pos2 = Convert.ToInt32(Console.ReadLine());
if(pos1 < 0 || pos1 > matrix.GetLength(0) && pos2 < 0 || pos2 > matrix.GetLength(1))
{
    Console.WriteLine("Такого значения нет");
}
else
Console.WriteLine(matrix[pos1, pos2]);