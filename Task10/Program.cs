Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 99 && a < 1000)
{
    int b = a / 10 % 10;
    Console.WriteLine(b);
}
else Console.WriteLine ("Введено не трёхзначное число");