// // 5! = 1 * 2 * 3 * 4 * 5 
// int Fact(int num)
//   if (num == 1) return 1;
//    return num * Fact(num - 1);
//    Console.WriteLine("введите число");
//    int n = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine(Fact(5));
//    1) Fact(5) -> 5 * Fact(5-1)
//              Fact(4) - > 4 * Fact(4 -1)
//                            Fact(3) - > 3 * Fact(3 -1)
//                                                  Fact(2) - > 2 * Fact(2 -1)
//                                                                              Fact(1) - > 1
// --------------------------------------------------------------------------------------------------------

// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// void PrintNumbers(int n)
// {
//     if (n == 1) Console.WriteLine(1);
//     else 
//     {
//         PrintNumbers(n-1);
//         Console.WriteLine(n);
//     }
// }

// Console.Write("введите число:  ");
// int numb = Convert.ToInt32(Console.ReadLine());
// PrintNumbers(numb);
// --------------------------------------------------------------------------------------------------------------


// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// void PrintNumbers(int m, int n)
// {
//     if (n == m) Console.WriteLine(m);
//     else 
//     {
//         PrintNumbers(m, n-1);
//         Console.WriteLine(n);
//     }
// }

// Console.Write("введите число:  ");
// int numb1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите число:  ");
// int numb2 = Convert.ToInt32(Console.ReadLine());
// PrintNumbers(numb1, numb2);

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int PrintNumbers(int n)
// {
    
//     if (n == 0) return 0;
//     return PrintNumbers(n / 10) + (n % 10);
// }

// Console.Write("введите число:  ");
// int numb1 = Convert.ToInt32(Console.ReadLine());
// Console.Write(PrintNumbers(numb1));


// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int PrintNumbers(int A, int B)
// {
//     if (B == 0) return 1;
//     return PrintNumbers(A, B-1) * A;
// }


// Console.Write("введите число:  ");
// int numbA = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите число:  ");
// int numbB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(PrintNumbers(numbA, numbB));
