// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] CreateMatrix (int m, int n) // метод создания матрицы
// {double[,] matr = new double [m, n];
// Random rand = new Random();
//  for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int i = 0; i < matr.GetLength(1); i++)
//         {
//             matr[i, i] = Math.Round(rand.Next(1, 100) + rand.NextDouble(),2); // (double)rand.Next(0,10)/10;
//             Console.Write(matr[i, i] + "\t");
//         }
//         Console.WriteLine();
//     }
// return matr;
// }

// Console.WriteLine("Введите количество строк");
// int m1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n1 = Convert.ToInt32(Console.ReadLine());
// double[,] matr = CreateMatrix(m1, n1);

// -----------------------------------------------------------
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] CreateMatrix (int m, int n) // метод создания матрицы
// {int[,] matr = new int [m, n];
//  for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int i = 0; i < matr.GetLength(1); i++)
//         {
//             matr[i, i] = new Random().Next(0, 10);
//             Console.Write($"{matr[i, i]} ");
//         }
//         Console.WriteLine();
//     }
// return matr;
// }

// void FindElement (int[,] matrix, int usernumber) //  возвращает значение этого элемента
// {bool find = false;
//  for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int i = 0; i < matrix.GetLength(1); i++)
//         {
//             if (matrix[i, i] == usernumber) Console.Write("Ваше значение находится по кординатам " + i + " " + i);
//             find = true;
                                  
//         }
//         Console.WriteLine();  
//     }
//     if (!find) Console.Write("Такого значения в массиве нет ");
    
// }

// Console.WriteLine("Введите количество строк");
// int m1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n1 = Convert.ToInt32(Console.ReadLine());

// int[,] matr = CreateMatrix(m1, n1);

// Console.WriteLine("Введите значение ");
// int number = Convert.ToInt32(Console.ReadLine());
// FindElement (matr, number);
// -----------------------------------------------------------------------------------------------------

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


