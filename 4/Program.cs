// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

// Console.WriteLine("Введите число: ");
// int num= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень: ");
// int step= Convert.ToInt32(Console.ReadLine());

// int Stepen()
// {
//     int otvet=1;
//     int count=1;
//     while(count<=step)
//     {
//         otvet=otvet*num;
//         count++;
//     }
//     return otvet;
// }

// if (num>0 && step>0)
// {
// int result =Stepen();
// Console.WriteLine(result);
// }
// else
// Console.WriteLine("Пока поработаем с натуральными числами:");


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int Summa()
// {
//     int a=0;
//     int sum=0;

//     for (int i=num;num>0;num=num/10)
//     {
//     a=i%10;
//     i=i/10;
//     sum=sum+a;
//     }
//     return sum;
// }

// if (num>0)
// {
//     int otvet = Summa();
//     Console.WriteLine(otvet);
// } else
// Console.WriteLine("Пока поработаем с положительными числами");


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// Console.WriteLine("Введите размер массива: ");
// int arraylength = Convert.ToInt32(Console.ReadLine());
// int[] array= new int[arraylength];
// GetArray();

// void GetArray()
// {
//     for (int i=0;i<array.Length;i++)
//     {
//         array[i]=Convert.ToInt32(Console.ReadLine());
//     }
//      for (int j=0;j<array.Length;j++)
//     {
//         Console.Write(array[j]+" ");
//     }
// }