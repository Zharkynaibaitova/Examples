// Задача №53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

// int[,] CreateMassive()
// {
//     int m = new Random().Next(1, 10);
//     int n = new Random().Next(1, 10);
//     int[,] array = new int[m, n];
//     Console.WriteLine($"{m} and {n}");
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }

// int[,] ChangePlace(int[,] array)
// {
//     int m = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         (array[0, i], array[array.GetLength(0) - 1, i]) = (array[array.GetLength(0) - 1, i]);

//     }
//     return array;
// }

// void PrintMassive(int[,] array)
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

// int[,] array = CreateMassive();
// Console.WriteLine();
// int[,] massive = ChangePlace(array);
// PrintMassive(array);

// Поменять строки на столбцы

int ClientWriteNumber(string msg)
{
    Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] ArrayIntCreate(int arrayLenght0, int arrayLenght1)
{
    int[,] array = new int[arrayLenght0, arrayLenght1];
    for (int i = 0; i < arrayLenght0; i++)
    {
        for (int j = 0; j < arrayLenght1; j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    return array;
}

int[,] ArrayIntPrint(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    return array;
}