Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

string Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть";
    if (xc < 0 && yc > 0) return "Вторая четверть";
    if (xc < 0 && yc < 0) return "Третья четверть";
    if (xc > 0 && yc < 0) return "Четвёртая четверть";
    return "Введены некорректные координаты";
}

string result = Quarter(x, y);
Console.WriteLine(result);



Console.Clear();
Console.Write("Пользователь, введите координаты первой точки: ");
Console.Write("Х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Пользователь, введите координаты второй точки: ");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double ABDistance(int xc1, int yc1, int xc2, int yc2)
{
    double d = (xc2 - xc1) * (xc2 - xc1) + (yc2 - yc1) * (yc2 - yc1);
    return Math.Round(Math.Sqrt(d), 2, MidpointRounding.ToZero);
}


Console.WriteLine(ABDistance(x1, y1, x2, y2));




Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i<=num){
    Console.Write($"{i} ");
    int quad = i*i;
    Console.WriteLine(quad);
    i++;
}







Console.WriteLine("Введите 'x' координату первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 'y' координату первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 'x' координату второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 'x' координату второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Dlin(int xa, int ya, int xb, int yb)
{
    double minusx = xb - xa;
    double minusy = yb - ya;
    minusx *= minusx;
    minusy *= minusy;
    double res = minusx + minusy;
    return Math.Sqrt(res);
}
double result = Dlin(x1, y1, x2, y2);
Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero));


for (int i = 0; i < length; i++)
{
    
}








