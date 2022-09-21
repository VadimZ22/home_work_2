Console.Clear();
Console.WriteLine("Введите любое число");
int number = int.Parse((Console.ReadLine()));

int bit = 0;

for (int x = number; x >= 1; bit++) //проверка разрядности числа с отсечением нулей в старших разрядах
{
    x = x / 10;
}


if (bit < 3)
    Console.WriteLine("В числе нет третьей цифры нет!");
else
{
    int thirdDigit = (number % (int)Math.Pow(10, (bit-2)) - (number % (int)Math.Pow(10, (bit-3)))) 
                    / (int)Math.Pow(10, (bit-3));

    Console.WriteLine(thirdDigit);
}



