// Задача 29: Напишите программу, которая задаёт массив
// из 8 случайных целых чисел и выводит отсортированный
// по модулю массив.
// -2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
// 6, 1, -33 -> [1, 6, -33]

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
Random  random = new Random();

fillArray(array);
PrintArray(array);

sortArray(array);
PrintArray(array);

void fillArray(int[] arr)
{
    for (int i=0;i<arr.Length;i++)
    {
        arr[i] = random.Next(-35,36);
    }
}

void PrintArray(int[] array)
{
    for (int i=0;i<array.Length;i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
}

void sortArray(int[] A)
{
    int len = A.Length;
    int temp = 0;
    int min = 0;

    for (int i=0;i<len-1;i++)
    {
        min = i;
        for (int j=i+1; j<len;j++)
        {
            if (Math.Abs(A[j])< Math.Abs(A[min]))
            {
                min = j;
            }
        }
        temp = A[i];
        A[i] = A[min];
        A[min] = temp;
    }

}
