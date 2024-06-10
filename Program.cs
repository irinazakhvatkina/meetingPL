// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// bool multiplicity (int x)
// {
//     if (x % 7 == 0 &&  x % 23 == 0)
//     {
//         return true;
//     }
//     return false;
// }

// void Result (int x)
// {
//     if (multiplicity (x))
//     {
//         Console.WriteLine ("да");
//     }
//     else
//     {
//         Console.WriteLine ($"Данное число не кратно 7 и 23, {x % 7 == 0 &&  x % 23 == 0}");
//     }

// }

// Console.WriteLine("Input first number:   ");
// int x = Convert.ToInt32(Console.ReadLine());
// Result (x);

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// void Result (int x, int y)
// {
//     if (x>0 && y>0)
//     {
//         Console.WriteLine ("I");
//     }else 
//     if(x<0 && y<0)
//     {
//         Console.WriteLine ("III");
//     }else 
//     if(x<0 && y>0)
//     {
//         Console.WriteLine ("IV");
//     }else 
//     if(x>0 && y<0)
//     {
//         Console.WriteLine ("II");
//     }else
//     {
//         Console.WriteLine ("Точка не лежит ни в одной из плоскастей.");
//     }
// }

// Console.WriteLine("Input X number:   ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input Y umber:  ");
// int y = Convert.ToInt32(Console.ReadLine());
// Result (x,y);

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.dotnet

Console.WriteLine("Введите целое число из отрезка [10, 99]:   ");
int n = Convert.ToInt32(Console.ReadLine());

void Result (int x)
{
    if (n>10 && n<99)
    {
         int max = 0;
         do max = Math.Max(max, n % 10);
         while ((n /= 10) != 0);
         Console.WriteLine(max);
    }else 
    {
        Console.WriteLine ("Число не принадлежит отрезку [10, 99].");
    }
}

Result (n);

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
