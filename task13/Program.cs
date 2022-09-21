Console.Clear();
Console.WriteLine("Введите любое число");
int number = int.Parse((Console.ReadLine()));
string num = number.ToString();
int bit = num.Length;

if (bit < 3)
    Console.WriteLine("В числе нет третьей цифры нет!");
else
{
    int thirdDigit = (number % (int)Math.Pow(10, (bit-2)) - (number % (int)Math.Pow(10, (bit-3)))) 
                    / (int)Math.Pow(10, (bit-3));

    Console.WriteLine(thirdDigit);
}



