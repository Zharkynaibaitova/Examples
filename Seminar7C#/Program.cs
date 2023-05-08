// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] Creatematrix(int Length, int minValue, int maxValue)
// {
//     int[] matr = new int[Length];  // объявляем массив
//     Random random = new Random();
//     for (int i = 0; i < Length; i++)
//     {
//         matr[i] = random.Next(minValue, maxValue + 1);
//         Console.WriteLine($"{matr[i] }");
//     }
//     Console.WriteLine();
//     return matr;
// }

// int EventNumber(int[] matr) // Колчиество чисел в массиве
// {
//     int count = 0;
//     for (int i = 0; i < matr.Length; i++)
//     {
//         if (matr[i] % 2 == 0) count++;
//     }
//     return count;
// }
// int res = EventNumber(Creatematrix(4, 100, 999));
// Console.WriteLine($"Количество четных чисел в массиве {res}");
// ----------------------------------------------------------------------------------

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] ->

// int[] Creatematrix(int Length, int minValue, int maxValue)
// {
//     int[] matr = new int[Length];  // объявляем массив
//     Random random = new Random();
//     for (int i = 0; i < Length; i++)
//     {
//         matr[i] = random.Next(minValue, maxValue + 1);
//         Console.WriteLine($"{matr[i]}");
//     }
//     Console.WriteLine();
//     return matr;
// }

// int SumOddPosition(int[] matr)
// {
//     int sum = 0;
//     for (int i = 0; i < matr.Length; i++)       // for (int i = 0; i < matr.Length; i += 2)
//     {
//         if (i % 2 == 0) sum = sum + matr[i];   //sum = sum + matr[i]
//     }
//     return sum;
// }

// int res = SumOddPosition(Creatematrix(4, -50, 50));
// Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях {res}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//  Массив вещкственных чисел
// NextDouble() - генерирует дробное число от 0 до 1

// double [] Creatematrix(int Length)
// {
//     double[] matr = new double[Length];  // объявляем массив
//     Random random = new Random();
//     for (int i = 0; i < Length; i++)
//     {
//         matr[i] = Math.Round(random.Next(1, 100) + random.NextDouble(),2);
//         Console.WriteLine($"{matr[i] }");
//     }
//     return matr;
// }

// // Разница между максимальным и минимальным элементом массива
// double DiffMinMax(double[] matr)
// {
//     double min = matr[0];
//     double max = matr[0];
//     for (int i = 0; i < matr.Length; i++)
//     {
//         if(matr[i] < min) min = matr[i];
//         if(matr[i] > max) max = matr[i];
//     }
//     double diff = max-min;
//     return diff;
// }

// double res = DiffMinMax(Creatematrix(5));
// Console.WriteLine();
// Console.WriteLine($"Разницу между максимальным и минимальным элементов массива {res}");


// Задача 46: Задайте двумерный массив размером nxm, заполненный случайными числами  
// m = 3, n = 4

// Console.WriteLine("Введите количество строк");
// int m1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n1 = Convert.ToInt32(Console.ReadLine());

// double[,] matr = new double m1, n1];
// FiilmatrixRandomNumbers(matr);
// Printmatrix(matr);



// void FiilmatrixRandomNumbers(double[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(0); j++)
//         {
//             matr[i, j] = Convert.ToDouble(new Random().Next(0, 10));
//         }
//     }
// }

// void Printmatrix(double[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(0); j++)
//         {
//             Console.Write(matr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// ------------------------------------------------------------------------------------------
// Задача 48. Задайте двумерный массив размером nxm. Каждый элемент в массиве равен сумме его индексов
// введите полученный ммасив на экрран


// Console.WriteLine("Введите количество строк");
// int m1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n1 = Convert.ToInt32(Console.ReadLine());

// double[,] matr = new double m1, n1];
// FiilmatrixRandomNumbers(matr); 
// Printmatrix(matr);



// void FiilmatrixRandomNumbers(double[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = i+j;
//         }
//     }
// }

// void Printmatrix(double[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write(matr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// -------------------------------------------------------------------------------------
// Задача 49: Задайте думерный массив. найдите элементы, у которых оба инлекса четные, изамените на их кватраты.
// 1 4 7 2
// 4 9 2 3
// 8 4 2 4

// Console.WriteLine("Введите количество строк");
// int m1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n1 = Convert.ToInt32(Console.ReadLine());

// double[,] matr = new double m1, n1];
// FiilmatrixRandomNumbers(matr);
// Printmatrix(matr);
// Console.WriteLine();
// Evenmatrix (matr);



// void FiilmatrixRandomNumbers(double[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = Convert.ToDouble(new Random().Next(0, 10));
//         }
//     }
// }

// void Printmatrix(double[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write(matr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }


// void Evenmatrix(double[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 ==0) matr[i, j]= matr[i, j]*matr[i, j];
//             Console.Write(matr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 51. Задайте двумерный массив. Найдите сумму элементов на главной диагонали.

// Console.WriteLine("Введите количество строк");
// int m1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n1 = Convert.ToInt32(Console.ReadLine());
// double sum = 0;
// double[,] matr = new double m1, n1];
// FiilmatrixRandomNumbers(matr);
// Printmatrix(matr);
// Console.WriteLine();
// DiagonaSumlmatrix(matr);

// void FiilmatrixRandomNumbers(double[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = Convert.ToDouble(new Random().Next(0, 10));
//         }
//     }
// }

// void Printmatrix(double[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write(matr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void DiagonaSumlmatrix(double[,] matr)
// {    
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (i == j) sum = sum + matr[i, j];          
//         }
//     }
//     Console.WriteLine($"Сумма чисел по диагонали {sum}");
// }
// -------------------------------------------------------------------------------------------------
// Задача 51. Второй вариант решения. Задайте двумерный массив. Найдите сумму элементов на главной диагонали.

// int[,] CreateMatrix (int m, int n) // метод создания матрицы
// {int[,] matr = new int [m, n];
//  for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(0, 10);
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// return matr;
// }


// int SummDiagomal (int[,] matrix) // метод подсчета диагонали
// {int sum = 0;
//  for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j) sum = sum + matrix[i, j];          
//         }
//     }
//     return sum;

// }

// Console.WriteLine("Введите количество строк");
// int m1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n1 = Convert.ToInt32(Console.ReadLine());

// int[,] matr = CreateMatrix(m1, n1);
// int sum1 = SummDiagomal(matr);
// Console.WriteLine($"Сумма чисел по диагонали {sum1}");



// Console.WriteLine("Введите количество строк");
// int m2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int n2 = Convert.ToInt32(Console.ReadLine());

// int[,] matr2 = CreateMatrix(m2, n2);
// int sum2 = SummDiagomal(matr);
// Console.WriteLine($"Сумма чисел по диагонали {sum2}");
