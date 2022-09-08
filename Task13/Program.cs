Console.WriteLine("Введите число, соотвествующее дню недели (от 1 до 7)");
Double a = Convert.ToDouble(Console.ReadLine());
if (0 >= a | 7 < a) Console.WriteLine("Число не соответствует дню недели");
else
{
    if (a > 0 & a < 6)
    {
        Console.WriteLine("Число соответствует рабочему дню недели");
    }
    else
    {
        Console.WriteLine("Число соответствует выходному дню недели");
    }
}