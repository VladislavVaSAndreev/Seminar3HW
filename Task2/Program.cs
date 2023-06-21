int ReadInt(string message)
{
Console.Write($"{message} > ");
int value = int.Parse(Console.ReadLine());
return value;
}

double Lenght (int x, int y, int z)
{
    double temp =(x*x)+(y*y)+(z*z);
    return Math.Sqrt(temp);
}
int x1=ReadInt("Введите координату x первой точки");
int y1=ReadInt("Введите координату y первой точки");
int z1=ReadInt("Введите координату z первой точки");
int x2=ReadInt("Введите координату x второй точки");
int y2=ReadInt("Введите координату y второй точки");
int z2=ReadInt("Введите координату z второй точки");

double Diagonale =Lenght(x1-x2, y1-y2, z1-z2);
Console.WriteLine($"расстояние между двумя точками равно {Diagonale} ");
