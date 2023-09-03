Console.WriteLine("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNum =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int thirdNum = Convert.ToInt32(Console.ReadLine());

int max = firstNum;
 if  (secondNum > max)
{
    max = secondNum;
}
 if (thirdNum > max)
{
    max = thirdNum;
}
Console.WriteLine("Максимальное число: {0}", max);
Console.ReadLine();