using System.ComponentModel.Design;

Console.Write("Введите число: ");
int count = Convert.ToInt32(Console.ReadLine());

if (count < 2)
{
    Console.WriteLine("Ошибка вхлдных данных");
}
else
{
    if (count % 2 == 0)
    {
        for(int i = 2; i < count; i += 2)
        {
            Console.WriteLine("{0}", i);
        }
        
    }
    else
    {
        for (int i = 2; i <= count - 1; i += 2)
        {
            Console.WriteLine("{0}", i);
        }
    }
}    
Console.ReadLine();