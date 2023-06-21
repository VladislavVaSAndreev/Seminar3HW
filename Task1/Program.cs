int ReadInt(string message)
{
    Console.Write($"{message} > ");
    int value = int.Parse(Console.ReadLine());
    return value;
}

bool Validate5sign(int number)
{
    if (number > 9999 && number <= 99999)
    {
        return true;
    }
    System.Console.WriteLine("Это число не пятизначное");
    return false;
}
int number = ReadInt("Введите число >");
if (Validate5sign(number))
{
    int firstDigit = number/10000;
    int secondDigit =number/1000%10;
    int fourthDigit = number%100/10;
    int fifthDigit = number%10;
if (firstDigit==fifthDigit && secondDigit==fourthDigit)    
System.Console.WriteLine($"Это полиндром");
else 
{System.Console.WriteLine($"Это не полиндром");}
}
