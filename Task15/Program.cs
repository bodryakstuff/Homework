Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100)
      {
        Console.WriteLine("Третьего числа нету");
      }    
 else
 {
    int b = 0;
    do
    {
        b = a / 10;
    }
    while (b > 1000);
    int c = b % 10;
    Console.WriteLine($"Третее число {c}");
 }