// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.

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
//     for (int j = 1; j<matrix.GetLength(1); j++)
//     {
        
//        if(matrix[i,j-1]<matrix[i,j])
//        {
//         int h=matrix[i,j-1];
//         matrix[i,j-1]=matrix[i,j];
//         matrix[i,j]=h;
//         j=0;
//        }
       
//     }
// }
// Console.WriteLine("____________");
// for(int i = 0; i<matrix.GetLength(0); i++)
// {
//     for (int j = 0; j<matrix.GetLength(1); j++)
//     {
//        Console.Write(matrix[i,j]+" ");
//     }
//     Console.WriteLine();
// }



//Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


// int [,] matrix = new int[5,5];
// int [] massive = new int[matrix.GetLength(0)];
// int sa=0;
// int min = int.MaxValue;
// int mini=0;

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
//        sa=sa+matrix[i,j];
//     }
//     Console.WriteLine($"Сумма {i} строки: {sa}");
//     massive[i]=sa;
//     sa=0;
// }

// for (int i=0;i<massive.Length;i++)
// {
//     if (massive[i]>0 && massive[i]<min)
//     {
//         min=massive[i];
//         mini=i;
//     }
// }
//     Console.WriteLine($"Минимальная сумма {mini} строки равна: {min}");


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Console.WriteLine("Введите размерность первой матрицы:");
// Console.WriteLine("Строки:");
// int m1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Столбцы:");
// int n1 = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine("Введите размерность второй матрицы:");
// Console.WriteLine("Строки:");
// int m2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Столбцы:");
// int n2 = Convert.ToInt32(Console.ReadLine());

// int [,] matrix1 = new int[m1,n1];
// int [,] matrix2 = new int[m2,n2];
// int [,] matrix3 = new int[m1,n2];


// for(int i = 0; i<matrix1.GetLength(0); i++)
// {
//     for (int j = 0; j<matrix1.GetLength(1); j++)  // Заполнение 1 матрицы
//     {
//         matrix1[i,j]=new Random().Next(0,10);
//     }
//     Console.WriteLine();
// }

// for(int i = 0; i<matrix2.GetLength(0); i++)
// {
//     for (int j = 0; j<matrix2.GetLength(1); j++)  //Заполнение 2 матрицы
//     {
//         matrix2[i,j]=new Random().Next(0,10);
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Первая матрица: ");

// for(int i = 0; i<matrix1.GetLength(0); i++)
// {
//     for (int j = 0; j<matrix1.GetLength(1); j++)  //вывод 1 матрицы
//     {
//        Console.Write(matrix1[i,j]+" ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("_______________");
// Console.WriteLine("Вторая матрица: ");
// for(int i = 0; i<matrix2.GetLength(0); i++)
// {
//     for (int j = 0; j<matrix2.GetLength(1); j++) // вывод 2 матрицы
//     {
//        Console.Write(matrix2[i,j]+" ");
//     }
//     Console.WriteLine();
// }

// if (n1==m2)
// {
//     for (int k=0; k<matrix1.GetLength(0);k++)
//     {
//         for (int i=0; i<matrix2.GetLength(1); i++)
//         {
//             for (int j=0; j<matrix2.GetLength(0); j++)
//             {
//                 matrix3[k,i]+=matrix1[k,j]*matrix2[j,i];
//             }
//         }
//     }

// Console.WriteLine("Произведение матриц:");
// for(int i = 0; i<matrix3.GetLength(0); i++)
// {
//     for (int j = 0; j<matrix3.GetLength(1); j++) // вывод 3 матрицы
//     {
//        Console.Write(matrix3[i,j]+" ");
//     }
//     Console.WriteLine();


// }
// }
// else Console.WriteLine("Данные матрицы нельзя перемножить.");





//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
//добавляя индексы каждого элемента. Массив размером 2 x 2 x 2
// int [,,] array = new int[2,2,2];

// for (int a=0; a<array.GetLength(0);a++)
// {
//     for (int b=0; b<array.GetLength(1);b++)
//     {
//         for (int c=0; c<array.GetLength(2);c++)
//         {
//             array[a,b,c]=new Random().Next(10,100);
//         }
//     }
// }

// for (int a=0; a<array.GetLength(0);a++)
// {
//     for (int b=0; b<array.GetLength(1);b++)
//     {
//         for (int c=0; c<array.GetLength(2);c++)
//         {
//             Console.Write($"{array[a,b,c]}{(a,b,c)} :");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив: