// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int count =1;

// string PrintNumber(int start, int end)
// {
//     if (start==end)
//     {
//         return start.ToString();
//     }
//     return (start+" "+PrintNumber(start-1, end));
// }

// Console.WriteLine(PrintNumber(num,count));


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// Console.WriteLine("Введите промежуток: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());


// int PrintNumber(int start, int end)
// {
//     if (start==end)
//     {
//         return start;
//     }
//     return (start+PrintNumber(start+1, end));
// }

// Console.WriteLine(PrintNumber(num1,num2));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// Console.WriteLine("Введите число m");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число n");
// int n = Convert.ToInt32(Console.ReadLine());

// int A(int n, int m)
// {
//   if (n == 0)
//     return m + 1;
//   else
//     if ((n != 0) && (m == 0))
//       return A(n - 1, 1);
//     else
//       return A(n - 1, A(n, m - 1));
// }

// Console.WriteLine(A(m,n));