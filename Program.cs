// // Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// using System;
// class Program
// {
//     static void Main()
//     {
//         while (true) 
//         {
//             Console.Write("Введите число или 'q' для выхода: ");
//             string input = Console.ReadLine(); 
            
//             if (input == "q") 
//             {
//                 break;
//             }

//             int number;
//             if (int.TryParse(input, out number)) 
//             {
//                 int sum = 0;
//                 while (number > 0) 
//                 {
//                     sum += number % 10; 
//                     number /= 10; 
//                 }
                
//                 if (sum % 2 == 0) 
//                 {
//                     Console.WriteLine("[STOP]");
//                     break;
//                 }
//             }
//             else 
//             {
//                 Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое числоили 'q'.");
//             }
//         }
//     }
// }

// // Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

using System;
class Program
{
    static void Main()
    {
        int[] numbers = new int[10]; 
        Random random = new Random(); 
        int evenCount = 0; 

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(100, 1000); 
            Console.Write(numbers[i] + " "); 
            
            if (numbers[i] % 2 == 0)
            {
                evenCount++;
            }
        }
        
        Console.WriteLine($"\nКоличество четных чисел в массиве: {evenCount}");
    }
}