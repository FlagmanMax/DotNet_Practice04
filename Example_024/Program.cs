// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

if (A>0)
{
    int sum = 0;
    for (int i=1;i<=A;i++)
    {
        sum += i;
        Console.Write($"{i} ");
    }
    Console.WriteLine("Сумма = " + sum);
}
else
{
    Console.WriteLine("Ошибка ввода");
}
