

Console.Clear();
Console.WriteLine("Введите любое число");
string number = (Console.ReadLine());

int len =  number.Length;
if (len < 3)
    Console.WriteLine("В числе нет третьей цифры нет!");

else
{
    char thirdDigit = number[2];
    Console.WriteLine(thirdDigit);
}






