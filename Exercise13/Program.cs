Console.Write("Введите число");
int numbers = int.Parse(Console.ReadLine());
string numberText = Convert.ToString(numbers);
if (numberText.Length > 2)
{
    Console.WriteLine("третья цифра -> " + numberText[2]);
}
else
{
    Console.Write("нет третьего числа");
}