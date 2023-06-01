// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// Console.Write("введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 10000 && number <= 99999)
// {
//     Console.WriteLine("Пятизначное число");
//     int firtsDigit = number/10000;
//     int secondDigit = (number/1000) %10;
//     int fourtDigit = (number % 100) /10;
//     int fivesDigit = number %10;
//     if (firtsDigit ==fivesDigit && secondDigit ==fourtDigit)
//     {
//         Console.WriteLine(number + " -> палиндром");
//     }
//     else
//     {
//         Console.WriteLine(number + " -> не палиндром");
//     }
// }
// else 
// {
//     Console.WriteLine("НЕ пятизначное число");
// }

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите координату х1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату у1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату х2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату у2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());
// double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// Console.WriteLine($"Расстояние между точками А:({x1},{y1},{z1}) и В:({x2},{y2},{z2})  равно: {Math.Round(d,2)}"); 

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

 Console.Write("Ввведите число N: ");
 int N = Convert.ToInt32(Console.ReadLine());

 int i = 1;
 while (i <= N)
 {
    Console.Write(Math.Pow(i, 3) + "\t");
    i ++;
 }

//  for (int i = 1; i <= N; i++)
//  {
//     Console.Write(Math.Pow(i, 3) + "\t"); 
//  }