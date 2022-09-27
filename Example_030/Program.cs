// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
Random  random = new Random();

fillArray(array);
PrintArray(array);

void fillArray(int[] num)
{
    for (int i=0;i<num.Length;i++)
    {
        array[i] = random.Next(0,2);
    }
}

void PrintArray(int[] array)
{
    for (int i=0;i<n;i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();

}
