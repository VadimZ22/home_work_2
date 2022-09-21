Console.Clear();
Console.WriteLine("Введите номер дня недели");
int number = int.Parse(Console.ReadLine());

if (number > 7 || number < 1)
    Console.WriteLine("нет такого дня недели!");
else if (number == 6 || number == 7)
    Console.WriteLine("Урааа! Выходной!");
else
    Console.WriteLine("На работу(((");

