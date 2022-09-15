// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]  ");
}

int Summa(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) result = result + array[i];
    }
    return result;
}

Console.WriteLine("Введите размер массива: ");
int razm = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArrayRndInt(razm, 1, 10);
PrintArray(arr);
int res = Summa (arr);
Console.WriteLine ($"Сумма элементов на нечётных позициях = {res}");