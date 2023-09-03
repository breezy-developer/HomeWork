Console.Write("Введите число: ");
int numOddOrEven = Convert.ToInt32(Console.ReadLine());
if  (numOddOrEven % 2 == 0)
{
    Console.WriteLine("Число {0} чётное", numOddOrEven);
}
else
{
    Console.WriteLine("Число {0} нечетное", numOddOrEven);
}
Console.ReadLine();