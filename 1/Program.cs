//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.WriteLine("Программа для сравнения 2 чисел");
// Console.WriteLine("Введите 2 числа");
// int num1 = Convert.ToInt32 (Console.ReadLine());
// int num2 = Convert.ToInt32 (Console.ReadLine());
// if (num1>num2)
// {
//     Console.WriteLine(num1);
// }
// else {
//     Console.WriteLine(num2);
// }



//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Console.WriteLine("Программа для нахождения максимума среди 3 чисел");
// Console.WriteLine("Введите 3 числа");
// int num1 = Convert.ToInt32 (Console.ReadLine());
// int num2 = Convert.ToInt32 (Console.ReadLine());
// int num3 = Convert.ToInt32 (Console.ReadLine());
// if (num1>num2 && num1>num3){
//     Console.WriteLine(num1);
// }
// else if (num2>num1 && num2>num3) {
//     Console.WriteLine(num2);
// }
// else {
//     Console.WriteLine(num3);
// }




//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Console.WriteLine("Программа для определения четности числа");
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32 (Console.ReadLine());
// if (num%2==0){
//     Console.WriteLine("Число четное");
// }
// else{
//     Console.WriteLine("Число нечетное");
// }




//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Программа, которая показывает все четные числа до введенного");
Console.WriteLine("Введите число");
int num = Convert.ToInt32 (Console.ReadLine());
int i = 0;
while (i<=num){
    if (i%2==0){
        Console.WriteLine(i);
        i++;
    }
    else {
        i++;
    }
}