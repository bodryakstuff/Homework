Console.Clear();
Console.WriteLine();
double[,] CreateMatrixRndInt(int rows, int columns, int min, int max)              //метод для заполнения массива случайными числами
{
    double[,] matrix = new double[rows, columns];
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


void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] >= 10)                                         //условие для лишнего пробела перед числом если оно меньше 10 для красивого вывода
            {
                Console.Write($"{matrix[i, j]}   ");
            }
            else Console.Write($" {matrix[i, j]}   ");
        }
        Console.WriteLine("]");
    }
}

void AverageColumns(double[,] matrix)              //метод для подсчёта среднего арифметического
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double temp = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            temp += matrix[i, j];
        }
        temp = Math.Round(temp, 1, MidpointRounding.AwayFromZero);
        Console.Write($"{temp / matrix.GetLength(0)}  ");
    }


}



Console.WriteLine("Введите количество строк");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int stlb = Convert.ToInt32(Console.ReadLine());

double[,] array2d = CreateMatrixRndInt(str, stlb, 1, 9);
PrintArray(array2d);                                                    //поменял переменную в первом методе на дабл чтобы среднее арифметическое считалось с запятой
AverageColumns(array2d);
