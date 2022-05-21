/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120

M = 4; N = 8. -> 30 */

int numStart = Input("Введите значение N ");
int numEnd = Input("Введите значение M ");
int result = RecurSum(numStart,numEnd);
Console.WriteLine(result + " ");

int RecurSum(int n,int m)
{

    if (n <= m)

        return n;

    return n + RecurSum(n - 1,m);

} 

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
