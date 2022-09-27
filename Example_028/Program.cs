// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

if (A>0)
{
    int prod = 1;
    for (int i=2;i<=A;i++)
    {
        prod *= i;
        Console.Write($"{i} ");
    }
    Console.WriteLine("Произведение = " + prod);
}
else
{
    Console.WriteLine("Ошибка ввода");
}


