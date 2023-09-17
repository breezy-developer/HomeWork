// №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Degree(int numA, int numB)
{
    int res = 1;
    for (int i = 1; i <= numB; i++) 
    {
        res = res * numA;
    }
    
    return res;
}
Console.WriteLine("Введите число A: ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numB = int.Parse(Console.ReadLine());

int degree = Degree(numA, numB);
Console.WriteLine("Ответ: " + degree);