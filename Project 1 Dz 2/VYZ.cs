//
// using System; 
//
// class VYZ
// {
//     static void Main() 
//     {
//         Console.WriteLine("     Задание 0: ");
//         byte oxygenLevel = 250; 
//         byte extraOxygen = 10;  
//         
//         byte result = (byte)(oxygenLevel + extraOxygen);
//         // byte обрезает результат до диапазона 0-255, получаем 4 (260 % 256 = 4)
//         
//         Console.WriteLine("oxygenLevel: " + oxygenLevel); 
//         Console.WriteLine("extraOxygen: " + extraOxygen); 
//         Console.WriteLine("result: " + result);          
//         Console.WriteLine("Без приведения: " + (oxygenLevel + extraOxygen)); 
//         // Почему result = 4, а не 260?
//         // Тип byte хранит значения от 0 до 255 (2^8 = 256 значений)
//         // Когда мы приводим 260 к byte, происходит переполнение: 260 - 256 = 4
//         
//         
//         // Следующее задание 1
//         Console.WriteLine("     Задание 1: ");
//         var candidate= new 
//         {
//             Name = "",           // Имя кандидата (строка)
//             Age = 0,             // Возраст (целое число)
//             Height = 0.0,        // Рост в метрах (дробное число)
//             Weight = 0.0,        // Вес в килограммах (дробное число)
//             FavoriteFilm = ""   // Любимый фильм (строка)
//         };
//         
//         Console.WriteLine("   АНКЕТА КОСМОНАВТА   ");
//         
//         // Ввод имени
//         Console.WriteLine("Введите имя: "); 
//         string name = Console.ReadLine();
//         
//         Console.WriteLine("Введите возраст: ");
//         string ageT = Console.ReadLine(); 
//         int age = int.Parse(ageT); 
//         
//         Console.WriteLine("Введите рост в метрах: ");
//         string heightText = Console.ReadLine();
//         double height = double.Parse(heightText);
//         
//         Console.WriteLine("Введите вес в килограммах: ");
//         string weightT = Console.ReadLine();
//         double weight = double.Parse(weightT);
//         
//         
//         Console.WriteLine("Введите любимый фильм про космос: ");
//         string movie = Console.ReadLine();
//         
//         // Вывод анкеты в аккуратном виде
//         Console.WriteLine("    ИТОГОВАЯ АНКЕТА   "); 
//         Console.WriteLine($"Имя: {name}"); // Выводим имя
//         Console.WriteLine($"Возраст: {age} лет"); // Выводим возраст
//         Console.WriteLine($"Рост: {height} м"); // Выводим рост
//         Console.WriteLine($"Вес: {weight} кг"); // Выводим вес
//         Console.WriteLine($"Любимый фильм: {movie}"); // Выводим фильм
        
        
                     // Следующее задание 2
        
// using System; 
// enum CarType
// {
//     Platzkart,  
//     Kupe,       
//     SV,         
//     Lux         
// }
// class TrainTicket
// {
//     public string PassengerName { get; set; }      // ФИО пассажира 
//     public int TrainNumber { get; set; }           // Номер поезда 
//     public DateTime DepartureDate { get; set; }    // Дата отправления (спец тип DateTime)
//     public TimeSpan DepartureTime { get; set; }    // Время отправления (спец тип TimeSpan)
//     public CarType CarType { get; set; }           // Тип вагона (перечисление)
//     public double Price { get; set; }             // Цена билета 
//     
//     public void PrintTicket()
//     {
//         Console.WriteLine("         БИЛЕТ НА ПОЕЗД         ");
//         Console.WriteLine($"Пассажир: {PassengerName}");
//         Console.WriteLine($"Номер поезда: {TrainNumber}");
//         Console.WriteLine($"Дата отправления: {DepartureDate:dd.MM.yyyy}"); // Форматируем дату
//         Console.WriteLine($"Время отправления: {DepartureTime:hh:mm}");   // Форматируем время
//         Console.WriteLine($"Тип вагона: {CarType}");
//         Console.WriteLine($"Цена билета: {Price:F2} руб."); // F2 означает 2 знака после запятой
//         Console.WriteLine("=====================================");
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("     ПОКУПКА БИЛЕТА НА ПОЕЗД");
//         
//         Console.Write("ФИО пассажира: ");
//         string passengerName = Console.ReadLine();
//         Console.Write("Введите номер поезда: ");
//         int trainNumber = int.Parse(Console.ReadLine());
//         Console.Write("Дата отправления (ДД.ММ.ГГГГ): ");
//         string dateString = Console.ReadLine();
//         DateTime departureDate = DateTime.Parse(dateString);
//         Console.Write("Время отправления (ЧЧ:ММ): ");
//         string timeString = Console.ReadLine();
//         TimeSpan departureTime = TimeSpan.Parse(timeString); // TimeSpan представляет промежуток времени (часы:минуты)
//         
//         Console.WriteLine("Выберите тип вагона:");
//         Console.WriteLine("1 - Плацкарт");
//         Console.WriteLine("2 - Купе");
//         Console.WriteLine("3 - СВ");
//         Console.WriteLine("4 - Люкс");
//         Console.Write("Введите номер типа вагона (1-4): ");
//         int carTypeChoice = int.Parse(Console.ReadLine()); // Читаем выбор пользователя
//         
//         CarType selectedCarType = (CarType)(carTypeChoice - 1);  // Вычитаем 1, так как нумерация с 1, а в enum с 0
//         
//         Console.Write("Цена билета: ");
//         double price = double.Parse(Console.ReadLine());
//         
//         // Создаем билет
//         TrainTicket ticket = new TrainTicket();
//         ticket.PassengerName = passengerName;    // Присваиваем ФИО
//         ticket.TrainNumber = trainNumber;        // Присваиваем номер поезда
//         ticket.DepartureDate = departureDate;    // Присваиваем дату
//         ticket.DepartureTime = departureTime;    // Присваиваем время
//         ticket.CarType = selectedCarType;        // Присваиваем тип вагона
//         ticket.Price = price;                    // Присваиваем цену
//         
//         // Выводим билет
//         ticket.PrintTicket();
//     }
// }


//                           ЗАДАНИЕ 3 
// using System;
//
// namespace CarRentalApp  
// {
//     // Это ограниченный набор значений
//     enum CarClass
//     {
//         Econom,     
//         Comfort,    
//         Business,   
//         Premium     
//     }
//     class CarRental
//     {
//         // Свойство для имени клиента (можно читать и записывать)
//         public string ClientName { get; set; }
//         public string CarBrand { get; set; }
//         public CarClass Class { get; set; }
//         public DateTime StartDate { get; set; }
//         public DateTime EndDate { get; set; }
//         public double PricePerDay { get; set; }
//         public double CalculateTotalCost()
//         {
//             // Вычисляем количество дней аренды
//             int days = EndDate.Subtract(StartDate).Days; // .Days берёт количество дней из этой разницы: EndDate.Subtract(StartDate) возвращает разницу между датами
//             
//             // Умножаем количество дней на стоимость за сутки
//             return days * PricePerDay;
//         }
//
//         // Метод для вывода договора аренды
//         public void PrintContract()
//         {
//             Console.WriteLine("     ДОГОВОР АРЕНДЫ АВТОМОБИЛЯ ");
//             Console.WriteLine("Клиент: " + ClientName);
//             Console.WriteLine("Автомобиль: " + CarBrand);
//             Console.WriteLine("Класс: " + Class);
//             // ToString("dd.MM.yyyy") преобразует дату в формат день.месяц.год
//             Console.WriteLine("Дата начала: " + StartDate.ToString("dd.MM.yyyy"));
//             Console.WriteLine("Дата окончания: " + EndDate.ToString("dd.MM.yyyy"));
//             Console.WriteLine("Стоимость за сутки: " + PricePerDay.ToString("F2") + " руб.");
//             Console.WriteLine("Общая стоимость: " + CalculateTotalCost().ToString("F2") + " руб.");
//             int days = EndDate.Subtract(StartDate).Days;
//             Console.WriteLine("Срок аренды: " + days + " дн.");
//         }
//     }
//     
//     class Program
//     {
//        
//         static void Main()
//         {
//             Console.WriteLine("     Система аренды автомобилей ");
//             CarRental rental = new CarRental();
//             Console.Write("Имя клиента: ");
//             rental.ClientName = Console.ReadLine();
//             Console.Write("Введите марку автомобиля: ");
//             rental.CarBrand = Console.ReadLine();
//             
//             Console.WriteLine("Выберите класс автомобиля:");
//             Console.WriteLine("1 - Эконом");
//             Console.WriteLine("2 - Комфорт");
//             Console.WriteLine("3 - Бизнес");
//             Console.WriteLine("4 - Премиум");
//             Console.WriteLine("Введите номер класса (1-4): ");
//             
//             // Считывается выбор пользователя
//             string classChoice = Console.ReadLine();
//             
//             // Преобразуем выбор в enum CarClass с помощью switch
//             switch (classChoice)
//             {
//                 case "1":
//                     rental.Class = CarClass.Econom;  // Присваиваем эконом класс
//                     break;  // Выход из switch
//                 case "2":
//                     rental.Class = CarClass.Comfort;  // Присваиваем комфорт класс
//                     break;
//                 case "3":
//                     rental.Class = CarClass.Business;  // Присваиваем бизнес класс
//                     break;
//                 case "4":
//                     rental.Class = CarClass.Premium;  // Присваиваем премиум класс
//                     break;
//             }
//
//             
//             Console.WriteLine("Дата начала аренды (ДД.ММ.ГГГГ): ");
//             string startDateStr = Console.ReadLine();
//             
//             // Преобразуем строку в дату с помощью DateTime.ParseExact
//             rental.StartDate = DateTime.ParseExact(startDateStr, "dd.MM.yyyy", null);
//
//             
//             Console.WriteLine("Дата окончания аренды (ДД.ММ.ГГГГ): ");
//             string endDateStr = Console.ReadLine();
//             
//             // Преобразуем строку в дату окончания
//             rental.EndDate = DateTime.ParseExact(endDateStr, "dd.MM.yyyy", null);
//             Console.Write("Стоимость аренды за сутки (руб.): ");
//             string priceStr = Console.ReadLine();
//             rental.PricePerDay = double.Parse(priceStr);
//
//             // Выводим договор аренды, вызывая метод PrintContract()
//             rental.PrintContract();
//             Console.ReadKey();
//         }
//     }
// }


//                    ЗАДАНИЕ 4 
using System;  
namespace StudentCardApp 
{
    enum Faculty
    {
        IT,             
        Economics,      
        Law,            
        Design         
    }
    
    class Student
    {
        // Свойство для ФИО студента (можно читать и записывать)
        public string FullName { get; set; }
        public string RecordBookNumber { get; set; }
        public Faculty Faculty { get; set; }
        public int Course { get; set; }
        public double AverageGrade { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Метод для вывода карточки студента
        public void PrintCard()
        {
            Console.WriteLine("        КАРТОЧКА СТУДЕНТА ");
            Console.WriteLine("ФИО: " + FullName);
            Console.WriteLine("Номер зачетной книжки: " + RecordBookNumber);
            Console.WriteLine("Факультет: " + Faculty);
            Console.WriteLine("Курс: " + Course);
            Console.WriteLine("Средний балл: " + AverageGrade.ToString("F2"));
            // ToString("dd.MM.yyyy") преобразует дату в формат день.месяц.год
            Console.WriteLine("Дата зачисления: " + EnrollmentDate.ToString("dd.MM.yyyy"));
        }
    }

  
    class VYZ
    {
        static void Main()
        {
            Console.WriteLine("        Система учёта студентов ");
            Student student = new Student();
            Console.WriteLine("ФИО студента: ");
            student.FullName = Console.ReadLine();
            Console.WriteLine("Введите номер зачетной книжки: ");
            student.RecordBookNumber = Console.ReadLine();

            // Запрашиваем факультет
            Console.WriteLine("Выберите факультет:");
            Console.WriteLine("1 - ИТ (Информационные технологии)");
            Console.WriteLine("2 - Экономика");
            Console.WriteLine("3 - Юриспруденция");
            Console.WriteLine("4 - Дизайн");
            Console.Write("Введите номер факультета (1-4): ");
            
            // Считываем выбор пользователя
            string facultyChoice = Console.ReadLine();
            
            // Преобразуем выбор в enum Faculty с помощью switch
            switch (facultyChoice)
            {
                case "1":
                    student.Faculty = Faculty.IT;  // Присваиваем факультет ИТ
                    break;  // Выход из switch
                case "2":
                    student.Faculty = Faculty.Economics;  // Присваиваем факультет экономики
                    break;
                case "3":
                    student.Faculty = Faculty.Law;  // Присваиваем факультет юриспруденции
                    break;
                case "4":
                    student.Faculty = Faculty.Design;  // Присваиваем факультет дизайна
                    break;
            }
            Console.WriteLine("Введите курс обучения (1-6): ");
            string courseStr = Console.ReadLine();
            student.Course = int.Parse(courseStr);
            Console.Write("Введите средний балл: ");
            string gradeStr = Console.ReadLine();
            student.AverageGrade = double.Parse(gradeStr);
            Console.Write("Дата зачисления (ДД.ММ.ГГГГ): ");
            string dateStr = Console.ReadLine();
            
            // Преобразуем строку в дату с помощью DateTime.ParseExact
            student.EnrollmentDate = DateTime.ParseExact(dateStr, "dd.MM.yyyy", null);
            student.PrintCard();
            Console.ReadKey();
        }
    }
}