// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int digitSum(int num)
{
    int temp = num;
    int sum = 0;

    while(temp>0)
    {
        sum += temp%10;
        temp = temp/10;
    }
    return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма цифр в числе "+number+ " равна "+digitSum(Math.Abs(number)));

