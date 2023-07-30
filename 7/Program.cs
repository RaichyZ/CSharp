// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Console.Write("Введите количество строк массива: ");
// int str= Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int stolb= Convert.ToInt32(Console.ReadLine());

// double [,] matrix = new double[str,stolb];

// for(int i = 0; i<matrix.GetLength(0); i++)
// {
//     for (int j = 0; j<matrix.GetLength(1); j++)
//     {
//         matrix[i,j]=new Random().NextDouble();
//     }
//     Console.WriteLine();
// }

// for(int i = 0; i<matrix.GetLength(0); i++)
// {
//     for (int j = 0; j<matrix.GetLength(1); j++)
//     {
//         Console.Write(matrix[i,j]+" ");
//     }
//     Console.WriteLine();
// }



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// int [,] matrix = new int[5,5];

// for(int i = 0; i<matrix.GetLength(0); i++)
// {
//     for (int j = 0; j<matrix.GetLength(1); j++)
//     {
//         matrix[i,j]=new Random().Next(0,10);
//     }
//     Console.WriteLine();
// }

// for(int i = 0; i<matrix.GetLength(0); i++)
// {
//     for (int j = 0; j<matrix.GetLength(1); j++)
//     {
//        Console.Write(matrix[i,j]+" ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Введите строку и столбец элемента, начиная нумерацию с 0: ");
// int n=Convert.ToInt32(Console.ReadLine());
// int m=Convert.ToInt32(Console.ReadLine());
// if (n>=matrix.GetLength(0) || m>=matrix.GetLength(1))
// {
//     Console.WriteLine("Элемент вне диапозона массива.");
// }
// else Console.WriteLine(matrix[n,m]);



//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
//в каждом столбце.

// int [,] matrix = new int[5,5];
// int sa=0;

// for(int i = 0; i<matrix.GetLength(0); i++)
// {
//     for (int j = 0; j<matrix.GetLength(1); j++)
//     {
//         matrix[i,j]=new Random().Next(0,10);
//     }
//     Console.WriteLine();
// }

// for(int i = 0; i<matrix.GetLength(0); i++)
// {
//     for (int j = 0; j<matrix.GetLength(1); j++)
//     {
//        Console.Write(matrix[i,j]+" ");
//     }
//     Console.WriteLine();
// }
// for(int i = 0; i<matrix.GetLength(0); i++)
// {
//     for (int j = 0; j<matrix.GetLength(1); j++)
//     {
//        sa=sa+matrix[j,i];
//     }
//     Console.WriteLine($"Сумма {i} столбца: {sa}");
//     sa=0;
// }