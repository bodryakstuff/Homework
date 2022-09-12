Console.WriteLine ("Введите число:");
int c = Convert.ToInt32(Console.ReadLine());
int a = c;
int i = 0;
for (i = 0; a > 0; a = a / 10)
    {
        i = i + (a % 10);
    }
Console.WriteLine ($"Сумма цифр числа {c} = {i}");

