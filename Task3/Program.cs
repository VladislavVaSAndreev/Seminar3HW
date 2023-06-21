int ReadInt(string message)
{
    Console.Write($"{message} > ");
    int value = int.Parse(Console.ReadLine());
    return value;
}

int number = ReadInt("Введите целое положительное число>");

int x = 1;
while (x <= number)
{
    int result = x * x * x;
    Console.Write($" {result} ");
    x++;
}