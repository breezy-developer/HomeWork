

{
    Console.Write("Введите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ведите второе число: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int min;
    int max;

    if (a > b)
    {
        max = a;
        min = b;

    }
    else
    {
        max = b; min = a;

    }

    Console.WriteLine("Максимальное число: {0}, Минимальное число:{1}", max, min);
    Console.ReadLine();

}

