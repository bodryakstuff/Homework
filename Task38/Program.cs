// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble() * 100;
        Math.Round(array[i], 3, MidpointRounding.AwayFromZero);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]  ");
}

double BolsheMenshe(double[] array)
{
    double max = 0;
    double min = array[0];
    double result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];

    }
    result = max - min;
    Math.Round(result, 2, MidpointRounding.AwayFromZero);
    return result;
}

Console.WriteLine("Введите размер массива: ");
int razm = Convert.ToInt32(Console.ReadLine());
double[] arr = CreateArrayRndDouble(razm, 1, 10);
PrintArray(arr);
double res = BolsheMenshe (arr);
Console.WriteLine ($"Сумма элементов на нечётных позициях = {res}");