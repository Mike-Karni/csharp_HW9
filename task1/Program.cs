/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

N = 5 -> "5, 4, 3, 2, 1"

N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

int numberStart = Input("Введите значение M: ");
int numberEnd = 1;

Console.WriteLine(OutputFunction(numberStart, numberEnd));

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int OutputFunction(int numStart, int numEnd)
{
    if (numEnd == numStart)
    {
        return numEnd;
    }
    Console.Write(OutputFunction(numStart, numEnd + 1) + ", ");
    return numEnd;
}