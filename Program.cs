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


// void PrintArray(int[,] array)
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

// void FillArray(int[,] array)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(1, 10);
//         }

//     }
// }
// int[,] matrix = new int[5, 5];

// Console.WriteLine("Номер строки: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Номер столбца: ");
// int y = Convert.ToInt32(Console.ReadLine());

// //PrintArray(matrix);
// Console.WriteLine("--------------------------");
// FillArray(matrix);
// PrintArray(matrix);
// Console.WriteLine("--------------------------");

// if (x >= matrix.GetLength(0) || y >= matrix.GetLength(1)) Console.WriteLine("Такого числа нет");
// else Console.WriteLine(matrix[x,y]);


int ReverseNumber(int num)
{
    int revers = 0;
    while (num > 0)
    {
        revers = (revers * 10) + (num % 10);
        num = num / 10;
    }
    return revers;
}

void FillArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(99, 999);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }

}

float PolindromResult(int[,] array, int count)
{
    int column = count;
    int sum = 0;
    int count2 = 0;
    float result = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i, column] == ReverseNumber(array[i, column]))
        {
            sum = sum + array[i, column];
            count2++;
        }

    }
    if (count2 >= 1)
    {
        result = (float)sum / count2;
    }
    else { result = 0; }


    return result;
}
void FillNewArrayOfPolindrom(float[] array, int[,] arraymatrix)
{
    int i = 0;
    int[,] matrix = arraymatrix;
    while (i < array.Length)
    {
        array[i] = PolindromResult(matrix, i);
        i++;
    }
}
void PrintArrayFromMatrix(float[] array)
{
    int i = 0;
    while (i < array.Length)
    {
        Console.Write(array[i] + " ");
        i++;
    }
}

int[,] matrix = new int[4, 4];
float[] arrayfrommatrix = new float[4];


FillArray(matrix);
PrintArray(matrix);
Console.WriteLine("-----------------------");

matrix[0, 0] = 353;// Для проверки
matrix[3, 0] = 454;// Для проверки
PrintArray(matrix);
Console.WriteLine("-----------------------");




FillNewArrayOfPolindrom(arrayfrommatrix, matrix);
PrintArrayFromMatrix(arrayfrommatrix);