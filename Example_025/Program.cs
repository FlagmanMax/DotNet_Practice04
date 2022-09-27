// Задача 25: Используя определение степени числа,
// напишите цикл, который принимает на вход два
// натуральных числа (A и B) и возводит число A в степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int power(int value, int pow)
{
    int result = value;

    for (int i=1;i<pow;i++)
    {
        result *= value;
    }

    return result;
}

Console.WriteLine("Меню ввода условий задачи: ");
Console.WriteLine("\t[ 0 ] - ввод случайных значений");
Console.WriteLine("\t[ 1 ] - ввод вручную");
Console.Write("-> ");

int value = 0;
int pow = 0;

int menu = Convert.ToInt32(Console.ReadLine());
if (menu == 0)
{
    Random random = new Random();
    value = random.Next(1,11);
    pow = random.Next(1,11);
}
else if (menu == 1)
{
    Console.Write("Введите число: ");
    value = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите степень: ");
    pow = Convert.ToInt32(Console.ReadLine());
}
else
{
   Console.WriteLine("Ошибка ввода");
   return;
}

int result = power(value,pow);
Console.WriteLine($"Число {value} в степени {pow} равно {result}");