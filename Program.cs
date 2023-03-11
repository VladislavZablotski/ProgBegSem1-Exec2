Console.WriteLine("Введите число 1:");
int number1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int number2 =Convert.ToInt32(Console.ReadLine());
if (number1>number2)
{
    Console.Write("max= ");
    Console.WriteLine(number1);
    Console.Write("min= ");
    Console.WriteLine(number2);
}
else if (number2>number1)
{
    Console.Write("max= ");
    Console.WriteLine(number2);
    Console.Write("min= ");
    Console.WriteLine(number1);
}
else
{
     Console.Write("Numbers are equal!");
}