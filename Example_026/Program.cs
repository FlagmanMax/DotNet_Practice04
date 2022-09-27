// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int temp = number;
// int count = 0;
// while(temp>0)
// {
//     temp = temp/10;
//     count++;
// }
// Console.WriteLine("В числе "+count+ " цифр");

Console.Write("Введите число: ");
string number = Console.ReadLine();

int len =  number.Length;
Console.WriteLine("В числе "+len+ " цифр");





