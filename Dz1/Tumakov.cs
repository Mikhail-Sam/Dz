// Упражнение 2.1 
// using System;
//
//     class Tumakov
//     {
//         static void Main()
//         {
//             // переменная для имени
//             string name;
//             Console.WriteLine("Как тебя звать ?:");
//             
//             // запоминается имя и сохраняется в переменную name
//             name = Console.ReadLine();
//             Console.WriteLine("Привет, " + name + "!");
//             Console.ReadKey();
//         }
//     }

//Упражнение 2.2
// using System;
//
// class Tumakov
// {
//     static void Main()
//     {
//         int n1 = int.Parse(Console.ReadLine());
//         int n2 = int.Parse(Console.ReadLine());
//         int n3 = n1 / n2;
//         Console.WriteLine(n3);
//     }
// }

//Дом. Задание 2.2
// using System;
//
// class Tumakov
// {
//     static void Main()
//     {
//         // переменные для коэф уравнения
//             double a, b, c;
//             
//             // переменные для дискриминанта и корней
//             double d;
//             double x1, x2;
//             
//             // заголовок кода
//             Console.WriteLine("ax2 + bx + c = 0");
//             
//             
//             Console.Write("Коэффициент a: ");
//             a = double.Parse(Console.ReadLine());
//             Console.Write("Коэффициент b: ");
//             b = double.Parse(Console.ReadLine());
//             Console.Write("Коэффициент c: ");
//             c = double.Parse(Console.ReadLine());
//             
//             // является ли уравнение квадратным
//             if (a == 0)
//             {
//                 // а != 0, это не квадратное уравнение
//                 Console.WriteLine("Это не квадратное уравнение.");
//             }
//             else
//             {
//                 // формула дискриминант
//                 d = b * b - 4 * a * c;
//                 
//                 // вывод дискриминанта
//                 Console.WriteLine();
//                 Console.WriteLine($"Дискриминант D = {d}");
//                 
//                 // Анализ дискриминанта
//                 if (d > 0)
//                 {
//                     // Если D > 0, два различных корня
//                     Console.WriteLine("Уравнение имеет два корня:");
//                     
//                     // первый корень по формуле
//                     x1 = (-b + Math.Sqrt(d)) / (2 * a);
//                     
//                     // второй корень по формуле
//                     x2 = (-b - Math.Sqrt(d)) / (2 * a);
//                     
//                     // Вывод корни
//                     Console.WriteLine($"x1 = " + x1);
//                     Console.WriteLine($"x2 = " + x2);
//                 }
//                 else if (d == 0)
//                 {
//                     // если D = 0, уравнение имеет один корень
//                     Console.WriteLine("Уравнение имеет один корень:");
//                     
//                     // вычисляем корень по формуле
//                     x1 = -b / (2 * a);
//                     
//                     // Вывод корня
//                     Console.WriteLine($"x = " + x1);
//                 }
//                 else
//                 {
//                     // если D < 0, корней нет
//                     Console.WriteLine("Корней нет.");
//                 }
//             }
//             Console.ReadKey();
//     }
// }
