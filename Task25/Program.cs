Console.WriteLine ("Введите число для возведения в степень");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число степени");
int b = Convert.ToInt32(Console.ReadLine());
int d = 1;
for (int c = 1; c <= b; c++)
{
    d = d*a;
}
Console.WriteLine ($"Число1 {a} ^ Число2 {b} = {d}");


