Console.Clear();
Console.WriteLine();
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)              //метод для заполнения массива случайными числами
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           if (matrix[i , j] >= 10)                                         //условие для лишнего пробела перед числом если оно меньше 10 для красивого вывода
           {
            Console.Write ($"{matrix[i , j]}   ");
           } 
           else Console.Write ($" {matrix[i , j]}   ");
        }
        Console.WriteLine("]");
    }
}
Console.WriteLine ("Введите нужную строку");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите нужный столбец");
int stlb = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 99);
PrintArray(array2d);
if (str > 3 || stlb > 4)
{
    Console.WriteLine ("Такого элемента не существует");
}
else Console.WriteLine ($"Значение этого элемента {array2d[str - 1,stlb - 1]}");     //так поступил чтобы пользователь не был вынужден считать от нуля