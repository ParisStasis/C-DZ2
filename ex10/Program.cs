// Задача 10
Console.WriteLine( "Введите трехзначное число" );
int a = Convert.ToInt32(Console.ReadLine());
int x = a/10%10;
Console.WriteLine( "Вторая цифра числа" + "" + a + "" + "=" + x );