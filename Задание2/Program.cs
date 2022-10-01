//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.Write("введите число M:   ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("введите число N:   ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
void FindSum()
{
   if ( M > N)
   {
    for (; M >= N; N ++)
    {
        sum = sum + N;
    }
    }
    else if (M < N)
    {
          for ( ; M <= N; M++ )
          {
            sum = sum + M;
          }
        

    }

    
   }
    

FindSum();
System.Console.WriteLine(sum);