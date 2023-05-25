// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int n = InputInt("Введите положительное число");
// int m = 1;
// if (n < 1)
// {
//     Console.WriteLine("Ввели не положительное число");
// }
// Console.WriteLine(NaturalNumber(n, m));

// int NaturalNumber(int n, int m)
// {
//     if (n == m)
//         return n;
//     else
//         Console.Write($"{NaturalNumber(n, m + 1)}, ");
//     return m;
// }

// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

// -----------------------------------------------------------------------------

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int m = InputInt("Введите M:");
// int n = InputInt("Введите N:");
// Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");

// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

// int CountNaturalSum(int m, int n)
// {
//     if (m == n)
//         return n;
//     return n + CountNaturalSum(m, n - 1);
// }



