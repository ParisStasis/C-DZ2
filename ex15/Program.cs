// Задача 15
Console.WriteLine("Введите номер дня недели");
int a = Convert.ToInt32(Console.ReadLine());
if (a==6)
{
    Console.WriteLine("Сегодня выходной, у вас похмелье");
}
if (a==7)
{
    Console.WriteLine("Сегодня выходной, но завтра на работу");
}
if (a<6)
{
    Console.WriteLine("Сегодня не выходной, иди работай!!!");
}