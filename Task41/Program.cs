Console.WriteLine ("Введите количество чисел");
int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
int pos = 0;                                            //Переменная для подсчёта положительных чисел
for (int i = 0; i < a; i++)
{
    Console.WriteLine ($"Введите число {i + 1}");       //Пишем так чтобы нумерация для пользователя шла с привычной единицы
    arr[i] = Convert.ToInt32(Console.ReadLine());       // Вводим числа сразу в массив каждое в свой индекс
    if (arr[i] > 0)                                     //Сравниваем с нулём
    {
        pos++;
    }
}
Console.WriteLine ($"Количество положительных чисел = {pos}");