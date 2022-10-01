// : Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
System.Console.Write("введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
GetNumbersToN();


void GetNumbersToN()
{
    int count = 1;
    if (N >= count)
    {
        System.Console.WriteLine(N);
        N = N - 1;
        GetNumbersToN();
    }
}
