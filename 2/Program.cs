// //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Console.Write("Введите 3 значное число ");
// int num = Convert.ToInt32 (Console.ReadLine());
// if (num>100 && num<999)
// {
// int num2 = (num%100-num%10)/10;
// Console.WriteLine(num2);
// }
// else {
//     Console.WriteLine("Число должно быть 3 значным и желательно еще не отрицательным");
// }

// //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Console.WriteLine("Задача на вывод 3 цифры в числе, если таковая имеется");
// Console.Write("Введите число: ");
// int num = Convert.ToInt32 (Console.ReadLine());
// if (num>99){
// while (num>999)
// {
//     num = num/10;
    
// }
// int Third = num%10;
// Console.WriteLine(Third);
// }
// else {
//     Console.WriteLine("У числа нет 3 цифры либо оно отрицательное");
// }



//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Console.WriteLine("Введите порядковый номер дня недели");
// int num = Convert.ToInt32 (Console.ReadLine());
// if (num == 1){
//     Console.WriteLine("нет");
// }
// else if (num == 2){
//     Console.WriteLine("нет");
// }
// else if (num == 3){
//     Console.WriteLine("нет");
// }
// else if (num == 4){
//     Console.WriteLine("нет");
// }
// else if (num == 5){
//     Console.WriteLine("нет");
// }
// else if (num == 6){
//     Console.WriteLine("да");
// }
// else if (num == 7){
//     Console.WriteLine("да");
// }
// else{
//     Console.WriteLine("Подсказка: цифра должна быть от 1 до 7");
// }