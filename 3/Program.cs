// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// int num;
// int sum=0;
// int r;
// int t;
// Console.WriteLine("Введите пятизначное число:");
// num = Convert.ToInt32(Console.ReadLine());
// if(num>9999 && num<100000)
// {
//     for(t=num;num!=0;num=num/10)
//     {
//     r=num % 10;
//     sum=sum*10+r;
//     }
//         if(t==sum)
//         {
//         Console.Write(t + " является палиндромом.");
//         }else
//         Console.Write(t + " не является палиндромом.");
// } else
// Console.Write("Нужно ввести только положительное пятизначное число! ");




//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
//ними в 3D пространстве.

// Console.WriteLine("ВВедите координату X первой точки: ");
// int X1=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("ВВедите координату Y первой точки: ");
// int Y1=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("ВВедите координату Z первой точки: ");
// int Z1=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("ВВедите координату X второй точки: ");
// int X2=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("ВВедите координату Y второй точки: ");
// int Y2=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("ВВедите координату Z второй точки: ");
// int Z2=Convert.ToInt32(Console.ReadLine());

// double result=Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2)+Math.Pow((Z2-Z1),2));
// Console.WriteLine(result);





Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int num=Convert.ToInt32(Console.ReadLine());

for (int i=1;i<=num;i++)
{
   Console.Write(Math.Pow(i,3)+" ");
}
