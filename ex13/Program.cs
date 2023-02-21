// Задача 13;

int number = new Random().Next(10,999);
Console.WriteLine(number);
int x = number/100;
int y = number%10;
if (x > 0)
{
    Console.WriteLine( y );
}
if (x == 0)
{
    Console.WriteLine( "третьей цифры нет" );
}