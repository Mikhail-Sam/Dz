//1
// using System;
// class Dz
// {
//     static void Main()
//     {
//          //с точностью до 10 
//         Console.WriteLine(Math.E.ToString("f1"));
//     }
// }


//2
// using System;
//
// class Dz
// {
//      static void Main()
//     {
//        Console.WriteLine(50);
//        Console.WriteLine(10);
//     }
// }


// Задание 3 
 // using System;

 // class Dz 
 // {
 //     static void Main()
 //     {
 //         //генерация рандом чисел
 //         Random chislo = new Random();
 //
 //         Console.WriteLine(chislo.Next());
 //         Console.WriteLine(chislo.Next());
 //         Console.WriteLine(chislo.Next());
 //         Console.WriteLine(chislo.Next());
 //     }
 // }


//Задание 4
// using System;

// class Dz
// {
//     static void Main()
//     {
//         int chislo = int.Parse(Console.ReadLine());
//         int rez = chislo + 10;
//         Console.WriteLine(rez);
//     }
// }


//Задание 5 
// using System;
//
// class Dz
// {
//     static void Main()
//     {
//         double x = double.Parse(Console.ReadLine());
//         double y = Math.Cos(x);
//         Console.WriteLine(y);
//     }
// }

//Задание 7
// using System;
// class Dz
// {
//     static void Main()
//     {
//         Console.WriteLine("Мир Труд Май");
//         Console.WriteLine("Затем так:");
//         Console.WriteLine("Мир");
//         Console.WriteLine("    Труд");
//         Console.WriteLine("        Май");
//     }
// }


//Задание 8
// using System;
//
// class Dz
// {
//     static void Main()
//     {
//         // Ввод первого числа
//         Console.WriteLine("Введите первое число:");
//         double a = double.Parse(Console.ReadLine());
//         
//         // Ввод второго числа
//         Console.WriteLine("Введите второе число:");
//         double b = double.Parse(Console.ReadLine());
//     
//         // Вывод до обмена
//         Console.WriteLine(a + ", " + b);
//         
//         // Обмен местами 
//         double c = a;  
//         a = b;            
//         b = c;         
//         
//         // Вывод после обмена
//         Console.WriteLine(a + ", " + b);
//     }
// }


//Задание 9
// using System;
//
// class Dz
// {
//     static void Main()
//     {
//         double chislo = double.Parse(Console.ReadLine());
//         Console.WriteLine("Вы ввели число: " + chislo);
//     }
// }


//Задание 11
// using System;
//
// class Dz
// {
//     static void Main()
//     {
//         int a = int.Parse(Console.ReadLine());
//         int b = int.Parse(Console.ReadLine());
//         double srarif = (a + b) / 2;
//         Console.WriteLine("Среднее арифметическое: " + srarif);
//         double srgeo = Math.Sqrt(a * b);
//         Console.WriteLine("Cреднее геометрическое: " + srgeo);
//         
//     }
// }


//Задание 12
// using System;
//
// class Dz
// {
//     static void Main()
//     {
//         // первая точка
//         Console.WriteLine("Введите координату x1 первой точки:");
//         double x1 = double.Parse(Console.ReadLine());
//         
//         Console.WriteLine("Введите координату y1 первой точки:");
//         double y1 = double.Parse(Console.ReadLine());
//         
//         // вторая точка
//         Console.WriteLine("Введите координату x2 второй точки:");
//         double x2 = double.Parse(Console.ReadLine());
//         
//         Console.WriteLine("Введите координату y2 второй точки:");
//         double y2 = double.Parse(Console.ReadLine());
//         
//         // Вычисление расстояния по формуле
//         double rast = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
//
//         Console.WriteLine("Расстояние между точками: " + rast);
//     }
// }

//Задание 13
// using System;
//
// class Dz
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите a:");
//         double a = double.Parse(Console.ReadLine());
//         
//         Console.WriteLine("Введите b:");
//         double b = double.Parse(Console.ReadLine());
//         
//         Console.WriteLine("Введите c:");
//         double c = double.Parse(Console.ReadLine());
//         
//         Console.WriteLine("До:");
//         Console.WriteLine("a = " + a);
//         Console.WriteLine("b = " + b);
//         Console.WriteLine("c = " + c);
//         
//         double A = a;  
//         double B = b;  
//         double C = c; 
//         
//         b = C; 
//         a = B;  
//         c = A;  
//         
//         Console.WriteLine("После: ");
//         Console.WriteLine("a = " + a);
//         Console.WriteLine("b = " + b);
//         Console.WriteLine("c = " + c);
//     }
// }


//Задание 14 
// using System;
//
// class Dz
// {
//     static void Main()
//     {
//         // ввод секунд
//         Console.WriteLine("Введите секунды ");
//         int x = int.Parse(Console.ReadLine());
//         
//         // сколько полных часов прошло 
//         int hour = x / 3600;
//         
//         // сколько полных минут 
//         int min = (x % 3600) / 60;
//         
//         // в) сколько секунд в этой минуте 
//         int sec = x % 60;
//         
//         Console.WriteLine("а) " + hour);
//         Console.WriteLine("б) " + min);
//         Console.WriteLine("в) " + sec);
//         
//     }
// }


//Задание 15 
// using System;
//
// class Dz
// {
//     static void Main()
//     {
//         int dlina = 543;
//         int shirina = 130;
//         int razmerkv= 130;
//         
//         //вычисляем сколько влезет квадратов по длине 
//         int skokdl = dlina / razmerkv;
//         //вычисляем сколько влезет квадаратов по ширине 
//         int skokshir = shirina / razmerkv;
//         //ищем кол-во квадратов 
//         int kolvo = skokshir * skokdl;
//
//         Console.WriteLine(kolvo);
//     }
// }


//Задание 16
// using System;
//
// class Dz
// {
//     static void Main()
//     {
//         int n = int.Parse(Console.ReadLine());
//         // достаем посл цифру
//         int posl = n % 10;
//         // удаляем посл цифру
//         int bezposl = n / 10;
//         // перемещаем посл цифру в начало
//         int rez = posl * 100 + bezposl;
//         Console.WriteLine(rez);
//     }
// }


//Задание 17
//  using System;
//
//  class Dz
//  {
//      static void Main()
//      {
//          int n = int.Parse(Console.ReadLine());
//          //находим сотни
//          int sto = (n / 100) % 10;
//          //находим тысячи
//          int tys = n / 1000;
//          Console.WriteLine(sto);
//          Console.WriteLine(tys);
//      }
// }


// Задание 18
// using System;
//
// class Dz
// {
//     static void Main()
//     {
//         string name = Console.ReadLine();
//         Console.WriteLine(name);
//         Console.WriteLine("Привет, " + name + "!");
//     }
// }


// Задание 19
 // using System;
 //
 // class Dz
 // {
 //     static void Main()
 //     {
 //         Console.WriteLine("Пользователь: Привет!");
 //         Console.WriteLine("Дневник: Как тебя зовут?");
 //         string name = Console.ReadLine();
 //         Console.WriteLine("Дневник: Привет, " + name + "!");
 //         Console.WriteLine("Пользователь: Ты знаешь что-то о тайной комнате?");
 //         Console.WriteLine("Дневник: Да");
 //         Console.WriteLine("Пользователь: Можешь рассказать?");
 //         Console.WriteLine("Дневник: Нет");
 //         
 //         // Пауза 5 сек
 //         Thread.Sleep(5000);
 //         Console.WriteLine("Дневник: но могу показать");
 //         
 //         // Генерация случ. цвета
 //         Random col = new Random();
 //         //создает массив, в который записываются все возможные цвета
 //         ConsoleColor[] colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
 //         // выбирает цвет 
 //         ConsoleColor randomColor = colors[col.Next(16)];
 //         
 //         // Установка случайного цвета, отвечает за то, какой будет цвет
 //         Console.ForegroundColor = randomColor;
 //         Console.WriteLine("        qwertyuiopp1345");
 //         
 //         // Сброс цвета
 //         Console.ResetColor();
 //     }
 // }