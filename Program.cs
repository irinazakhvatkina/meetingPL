// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// void Che(int m, int n)
// {
//     if (m > n)
//     return;
    
//     if (m % 2 == 0)
//     {
//         Console.Write($"{m}, ");
//     }
//     Che(m+1,n);

// }
// Che(m,n);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int Akkerman(int m, int n)
// {
//     if (m == 0) return n + 1;
//     if (n == 0) return Akkerman((m - 1), 1);
//     return Akkerman((m - 1), Akkerman(m, (n - 1)));
// }

// Console.Write($"Функция Аккермана равно {Akkerman(m, n)} ");

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

class Program
{
   static void Main(string[] args)
   {
       int[] array = { 1, 2, 5, 0, 10, 34 };
       PrintArrayReversed(array, array.Length - 1);
   }

   static void PrintArrayReversed(int[] array, int index)
   {
       if (index >= 0)
       {
           Console.Write(array[index] + " ");
           PrintArrayReversed(array, index - 1);
       }
   }
}
