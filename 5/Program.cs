// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int al = 10;
// int[] array = new int [al];
// int j=0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i]=new Random().Next(100,1000);
//     Console.Write(array[i]+" ");

//     if (array[i]%2==0)
//     {
//         j++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"Количество четных чисел в массиве: {j}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int al = 10;
// int[] array = new int [al];
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i]=new Random().Next(0,3);
//     Console.Write(array[i]+" ");
// }
// for (int j = 1; j < array.Length; j=j+2)
//     {
//         sum=sum+array[j];
//     }
// Console.WriteLine();
// Console.WriteLine(sum);


// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// int al = 10;
// double[] array = new double [al];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i]=new Random().NextDouble();
//     Console.Write(array[i]+" ");
// }
// Console.WriteLine();
// double m = array.Max();
// double min = array.Min();
// double difference = m-min;
// Console.WriteLine(difference);
