// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите начальное число M:");
int minNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное число M:");
int number = Convert.ToInt32(Console.ReadLine());

void SumToN (int minNumber, int number, int sum)
{
    if (number<minNumber) 
    {
        Console.WriteLine($"Сумма элементов в промежутке от M до N равна {sum}"); 
        return;
    }
    sum = sum + (minNumber++);
    SumToN(minNumber, number, sum);
}

SumToN(minNumber, number, 0);