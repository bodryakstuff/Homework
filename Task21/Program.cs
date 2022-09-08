Console.Clear();
Console.Write("Пользователь, введите координаты первой точки: ");
Console.Write("Х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Пользователь, введите координаты второй точки: ");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double ABDistance(int xc1, int yc1, int zc1, int xc2, int yc2, int zc2)
{
    double d = (xc2 - xc1) * (xc2 - xc1) + (yc2 - yc1) * (yc2 - yc1) + (zc2-zc1)*(zc2-zc1);
    return Math.Round(Math.Sqrt(d), 2, MidpointRounding.ToZero);
}


Console.WriteLine(ABDistance(x1, y1, z1, x2, y2, z2));