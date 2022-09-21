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
Console.WriteLine ("Введите количество строк");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов");
int stlb = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(str, stlb, 1, 99);
PrintArray(array2d);

