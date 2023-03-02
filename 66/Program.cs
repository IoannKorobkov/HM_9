// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int Sum(int a, int b)
{
    int result = a;
    if (a >= b)
    {
        return result;
    }
    else
    {
        return result = result + Sum(a + 1, b);
    }
}
Console.WriteLine(Sum(a, b));
