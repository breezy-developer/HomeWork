﻿//№27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число N: ");
int numN = int.Parse(Console.ReadLine());

int SumNumber(int numN)
{

    int counter = Convert.ToString(numN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = numN - numN % 10;
        result = result + (numN - advance);
        numN = numN / 10;
    }
    return result;
}

int sumNumber = SumNumber(numN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);