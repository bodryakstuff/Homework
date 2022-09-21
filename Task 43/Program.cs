Console.WriteLine ("Две прямые задану уравнениями y = k1 * x + b1, y = k2 * x + b2 надо найти точку пересечения");
Console.WriteLine ("Введите k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Введите b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Введите k2");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Введите b2");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1 - k2 == 0)
{
    Console.WriteLine("Деление на ноль недопустимо");
}
else
{
double x = (b2 - b1)/(k1 - k2);
x = Math.Round(x, 2, MidpointRounding.ToZero);
double y = k1*x + b1;
y = Math.Round(y, 2, MidpointRounding.ToZero);
Console.WriteLine($"Точка пересечения прямых {x} {y}");
}
