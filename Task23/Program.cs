Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i<=num)
{
    Console.Write($"{i} ");
    int cube = i*i*i;
    Console.WriteLine(cube);
    i++;
}