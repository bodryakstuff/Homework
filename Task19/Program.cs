﻿Console.Clear();
Console.Write("Пользователь, введите пятизначное число: ");
int i = Convert.ToInt32(Console.ReadLine());
int a = 1;
int b = 1;
int d = 1;
int e = 1;
if (i > 99999 || i <= 9999)
{
    Console.WriteLine("Ваше число не пятизначное");
}
else
{
    a = i % 10;
    b = i / 10 % 10;
    d = i / 10 / 10 / 10 % 10;
    e = i / 10 / 10 / 10 / 10 % 10;
    if (a == e && b == d)
    {
        Console.WriteLine("Число - палиндром");
    }
    else 
    {
        Console.WriteLine("Число - не палиндром");
    }
}
