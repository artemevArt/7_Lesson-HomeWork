// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(double[,] array)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Math.Round(rnd.Next(1, 10) + rnd.NextDouble(),2);
//         }

//     }
// }
// double[,] matrix = new double[5, 5];

// PrintArray(matrix);
// Console.WriteLine("--------------------------");
// FillArray(matrix);
// PrintArray(matrix);


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }

    }
}
int[,] matrix = new int[5, 5];

Console.WriteLine("Номер строки: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Номер столбца: ");
int y = Convert.ToInt32(Console.ReadLine());

//PrintArray(matrix);
Console.WriteLine("--------------------------");
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("--------------------------");

if (x >= matrix.GetLength(0) || y >= matrix.GetLength(1)) Console.WriteLine("Такого числа нет");
else Console.WriteLine(matrix[x,y]);