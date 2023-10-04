Console.Clear();

int Promt(string massage)
{
    Console.Write(massage);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int NaturalNumber(int n, int m)
{
    if (n == m) return n;
    else Console.Write($"{NaturalNumber(n, m + 1)} , ");
    return m;
}

int n = Promt("Input N: ");
if (n < 1)
{
    Console.WriteLine("Ввдите положительное число!");
    return;
}
Console.WriteLine(NaturalNumber(n, 1));