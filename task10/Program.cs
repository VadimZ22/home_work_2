Console.Clear();
Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());

if (number < 100 || number > 1000)
    Console.WriteLine("Число не является трехзначным!");
else
{
    int secondDigit = ((number % 100) - (number % 10)) / 10;
    Console.WriteLine(secondDigit);
}
    