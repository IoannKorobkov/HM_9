// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
void Nature(int n, int a)
{
    if (1 <= n)
    {
        Nature(n, a + 1);
        Console.Write($"{n},");

    }
    else
    {
        Console.Write($"{n},");
    }
}
Nature(n);