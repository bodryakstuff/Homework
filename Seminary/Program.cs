// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    int sum = default;

    for (int i = 1; i <= num; i++)
    {
        //sum = sum + i;
        sum += i;
    }
    return sum;
}

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");






// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int CountDigits(int num)
{
    if (num != 0)
    {
        if (num < 0) num = -num;
        int count = default;
        while (num > 0)
        {
            num = num / 10;
            count++;
        }
        return count;
    }
    return 1;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = CountDigits(number);
Console.WriteLine(result);




// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// Console.Clear();

int[] arr = new int[8];

void FillArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        if (i == count - 1) Console.Write($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
    }
}

FillArray(arr);
PrintArray(arr);



// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// Console.Clear();

int[] arr = new int[8];

void FillArray(int[] array)
{
    int count = array.Length;
    Random rnd = new Random();
    for (int i = 0; i < count; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        if (i == 0) Console.Write("[");
        if (i == count - 1) Console.Write($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
    }
}

FillArray(arr);
PrintArray(arr);


//Семинар 13 сентября


Console.Clear();
Console.WriteLine();
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.LongLength; i++)
    {
        if (i < array.LongLength - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int[] Gett


int [] arr = CreateArrayRndInt(12,-9, 9);
PrintArray(arr);

// Метод создания массива

int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}


void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}


int[] GetSumPosNegElem(int[] array)
{
    int sumNeg = 0;
    int sumPos = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sumNeg += array[i];
        else sumPos += array[i];
    }

    return new int[]{sumNeg, sumPos};
}


int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
Console.WriteLine();
int[] result = GetSumPosNegElem(arr);
Console.WriteLine($"Сумма отрицательных чисел = {result[0]}");
Console.WriteLine($"Сумма положительных чисел = {result[1]}");

// pflfxf32

Console.Clear();
Console.WriteLine();

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
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
    Console.Write("]");
}
int[] Inverse(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
    return array;
}
int[] arr = CreateArrayRndInt(10, -100, 100);
PrintArray(arr);
Console.WriteLine();
int[] result = Inverse(arr);
PrintArray(result);
Console.WriteLine();


// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();
Console.WriteLine();

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
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
    Console.Write("]");
}
bool ArraySearch(int[] array, int search1)
{
    bool exist = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == search1)
        {
            exist = true;
            break;
        }

    }
    return exist;
}
int[] arr = CreateArrayRndInt(16, -100, 100);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("Введите число для поиска в массиве: ");
int search = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
bool result = ArraySearch(arr, search);
Console.WriteLine($"{result}");







Console.Clear();
Console.WriteLine();

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
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
    Console.Write("]");
}
int[] ProductPairsDigit(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 != 0) size += 1;
    int[] newArray = new int[size];



    for (int i = 0; i < array.Length / 2; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }

    if (newArray.Length % 2 != 0) newArray[newArray.Length - 1] = array[array.Length / 2];
    return newArray;
}
Console.WriteLine();
int[] arr = CreateArrayRndInt(9, 1, 5);
PrintArray(arr);
int[] result = ProductPairsDigit(arr);
Consol




double[] CreateArrayRndDouble (int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble()*100;
    }
    return array;
}





