using System;

class project_3
{
    static void Main()
{
        // ЗАДАЧА 1
        Console.WriteLine("     ЗАДАЧА 1: Типы данных. "); 
        
        // Выводим информацию о типах данных
        // byte -число от 0 до 255
        Console.WriteLine("byte: max = " + byte.MaxValue + ", min = " + byte.MinValue);
        
        // int - целое число
        Console.WriteLine("int: max = " + int.MaxValue + ", min = " + int.MinValue);
        
        // double - дробное число
        Console.WriteLine("double: max = " + double.MaxValue + ", min = " + double.MinValue);
        
        // char - один символ
        Console.WriteLine("char: max = " + char.MaxValue + ", min = " + char.MinValue);
    

        // ЗАДАЧА 2 
        Console.WriteLine("     ЗАДАЧА 2: Данные пользователя "); 
        
        Console.WriteLine("Введите имя: ");  
        string name = Console.ReadLine();  
        
        Console.WriteLine("Введите город: "); 
        string city = Console.ReadLine(); 
        
        Console.WriteLine("Введите возраст: "); 
        int age = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите PIN-код: ");
        int pin = int.Parse(Console.ReadLine());
        
        // Выводим все данные обратно
        Console.WriteLine("Ваши данные:"); 
        Console.WriteLine($"name + {name}");
        Console.WriteLine($"Город + {city}");
        Console.WriteLine($"Возраст:  + {age}");
        Console.WriteLine($"PIN:  + {pin}");

        //       ЗАДАЧА 3 
        Console.WriteLine("    ЗАДАЧА 3: Смена регистра букв ");
        
        Console.Write("Введите строку: ");  
        string input = Console.ReadLine();
        
        string result = "";  // Создаем пустую строку для результата
        
        // Проходим по каждому символу в строке
        for (int i = 0; i < input.Length; i++)  // Цикл от 0 до длины строки
        {
            char c = input[i];  // Берем текущий символ
            
            // Если буква маленькая - делаем большой
            if (char.IsLower(c))  // Проверяем, маленькая ли буква
            {
                result += char.ToUpper(c);  // Добавляем большую букву
            }
            // Если буква большая - делаем маленькой
            else if (char.IsUpper(c))  // Проверяем, большая ли буква
            {
                result += char.ToLower(c);  // Добавляем маленькую букву
            }
            // Если не буква - оставляем как есть
            else
            {
                result += c;  // Добавляем символ без изменений
            }
        }
        
        Console.WriteLine("Результат: " + result);  // Результат

        //                                 ЗАДАЧА 4 
        Console.WriteLine("     ЗАДАЧА 4: Поиск подстроки  "); 
        
        Console.Write("Введите строку: ");  
        string text = Console.ReadLine();
        
        Console.Write("Введите подстроку: "); 
        string substring = Console.ReadLine(); 
        
        int count = 0;  // Счетчик вхождений, начинаем с 0
        int index = 0;  // Позиция для поиска (начинаем с начала)
        
        // Ищем все вхождения подстроки
        while (index != -1)  // Пока не дойдем до конца
        {
            index = text.IndexOf(substring, index);  // Ищем подстроку
            
            if (index != -1)  // Если нашли
            {
                count++;  // Увеличиваем счетчик
                index += substring.Length;  // Переходим дальше
            }
        }
        
        Console.WriteLine("Количество вхождений: " + count); 
    

        //                       ЗАДАЧА 5
        Console.WriteLine("     ЗАДАЧА 5: Виски для отпуска ");  
        
        Console.Write("Цена бутылки (фунт): ");  
        double Price = double.Parse(Console.ReadLine());
        
        Console.Write("Скидка в Duty Free (%): ");  
        double discount = double.Parse(Console.ReadLine()); 
        
        Console.Write("Стоимость отпуска (фунт): "); 
        double holidayPrice = double.Parse(Console.ReadLine());
        
        // Считаем экономию с одной бутылки
        double savingPerBottle = Price * discount / 100;  // Формула экономии
        
        // Считаем сколько бутылок нужно купить
        double bottles = holidayPrice / savingPerBottle;  // Делим стоимость на экономию
        
        // Округляем до целого в меньшую сторону
        int rez = (int)Math.Floor(bottles);  // Округляем вниз
        
        Console.WriteLine("Нужно бутылок: " + rez); 
    

        //                        ЗАДАЧА 6    
        Console.WriteLine("     ЗАДАЧА 6: Структура студентов"); 
        
        Student[] students = new Student[5];  // Массив из 5 студентов
        
        students[0].LastName = "Иванов";  // Фамилия
        students[0].FirstName = "Иван";  // Имя
        students[0].Id = 1;  // ID
        students[0].BirthDate = "01.01.2000";  // Дата рождения
        students[0].AlcoholCategory = 'b';  // Категория (b - любит выпить)
        students[0].DrinkVolume = 5.0;  // Объем выпитого (литры)
        students[0].DrinkName = "Пиво";  // Название напитка
        students[0].AlcoholPercent = 5.0;  // Процент спирта
        
        // Заполняем остальных студентов (аналогично)
        students[1].LastName = "Петров";
        students[1].FirstName = "Петр";
        students[1].Id = 2;
        students[1].BirthDate = "15.05.1999";
        students[1].AlcoholCategory = 'c';
        students[1].DrinkVolume = 2.0;
        students[1].DrinkName = "Вино";
        students[1].AlcoholPercent = 12.0;
        
        students[2].LastName = "Сидоров";
        students[2].FirstName = "Сидор";
        students[2].Id = 3;
        students[2].BirthDate = "20.08.2001";
        students[2].AlcoholCategory = 'd';
        students[2].DrinkVolume = 0.0;
        students[2].DrinkName = "Вода";
        students[2].AlcoholPercent = 0.0;
        
        students[3].LastName = "Козлов";
        students[3].FirstName = "Козел";
        students[3].Id = 4;
        students[3].BirthDate = "10.12.1998";
        students[3].AlcoholCategory = 'a';
        students[3].DrinkVolume = 10.0;
        students[3].DrinkName = "Водка";
        students[3].AlcoholPercent = 40.0;
        
        students[4].LastName = "Новиков";
        students[4].FirstName = "Новик";
        students[4].Id = 5;
        students[4].BirthDate = "05.03.2000";
        students[4].AlcoholCategory = 'b';
        students[4].DrinkVolume = 3.0;
        students[4].DrinkName = "Пиво";
        students[4].AlcoholPercent = 4.5;
        
        // Считаем общую статистику
        double totalVolume = 0;  // Общий объем выпитого
        double totalAlcohol = 0;  // Общий объем чистого спирта
        
        // Проходим по всем студентам
        for (int i = 0; i < 5; i++)  // Цикл от 0 до 4
        {
            Console.WriteLine("Студент " + (i+1) + ":");  // Номер студента
            Console.WriteLine("ФИО: " + students[i].LastName + " " + students[i].FirstName);
            Console.WriteLine("ID: " + students[i].Id);
            Console.WriteLine("Дата рождения: " + students[i].BirthDate);
            Console.WriteLine("Напиток: " + students[i].DrinkName);
            Console.WriteLine("Объем: " + students[i].DrinkVolume + " л");
            Console.WriteLine("Спирт: " + students[i].AlcoholPercent + "%");
            
            // общий объем
            totalVolume += students[i].DrinkVolume;  // Добавляем объем
            
            // Считаем объем чистого спирта (объем * процент / 100)
            double alcoholVolume = students[i].DrinkVolume * students[i].AlcoholPercent / 100;
            totalAlcohol += alcoholVolume;  // Добавляем к общему
        }
        
        
        Console.WriteLine("      ОБЩАЯ СТАТИСТИКА     ");
        Console.WriteLine("Общий объем выпитого: " + totalVolume + " литров");
        Console.WriteLine("Общий объем чистого спирта: " + totalAlcohol + " литров");
        
        // Считаем процент от общего количества
        double alcoholPercent = (totalAlcohol / totalVolume) * 100;
        Console.WriteLine("Процент спирта от общего объема: " + alcoholPercent + "%");
    }
}

// Создаем структуру Студент
struct Student  // Объявляем структуру
{
    public string LastName;  // Фамилия
    public string FirstName;  // Имя 
    public int Id;  // айди
    public string BirthDate;  // Дата рождения 
    public char AlcoholCategory;  // Категория
    public double DrinkVolume;  // Объем выпитого 
    public string DrinkName;  // Название напитка 
    public double AlcoholPercent;  // Процент спирт
}