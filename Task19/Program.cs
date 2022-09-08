Console.Clear();
Console.Write("Пользователь, введите пятизначное число: ");
int i = Convert.ToInt32(Console.ReadLine());
if (i > 99999 || i <= 9999)
{
    Console.WriteLine("Ваше число не пятизначное");
}
else
{
    int a = i % 10;
    int b = i % 10 % 10;
    int d = i % 10 % 10 % 10 % 10;
    int e = i % 10 % 10 % 10 % 10 % 10;
    if (a == e && b == d)
    {
        Console.WriteLine("Число - палиндром");
    }
    else 
    {
        Console.WriteLine("Число - не палиндром");
    }
}
Console.Write($"{b} ");