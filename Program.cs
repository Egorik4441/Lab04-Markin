// // // // // // // // int age = 23;
// // // // // // // // if (age >= 21)
// // // // // // // // {
// // // // // // // //     Console.WriteLine("Доступ разрешён");
// // // // // // // // }
// // // // // // // // Console.WriteLine("Программа продолжает работу");

// // // // // // // int age = 15;
// // // // // // // if (age >= 18) {
// // // // // // //     Console.WriteLine("Доступ разрешён");
// // // // // // // } else {
// // // // // // //     Console.WriteLine($"Лет до совершеннолетия:{18 - age} ");
// // // // // // //     Console.WriteLine("Доступ запрещён");
// // // // // // // }

// // // // // // int age = 90;
// // // // // // if (age < 13) {
// // // // // //     Console.WriteLine("Ребёнок");
// // // // // // } else if (age < 18) {
// // // // // //     Console.WriteLine("Подросток");
// // // // // // } else if (age >= 60) {
// // // // // //     Console.WriteLine("Пенсионер");
// // // // // // } else {
// // // // // //     Console.WriteLine("Взрослый");
// // // // // // }

// // // // // int age = 16;
// // // // // double height = 1.55;
// // // // // bool hasAdultSupervision = true;
// // // // // if (age >= 14 && height >= 1.5)
// // // // // {
// // // // //     Console.WriteLine("Можно кататься");
// // // // // }    else if (height < 1.5 && hasAdultSupervision) {
// // // // // } else {
// // // // //     Console.WriteLine("Пока нельзя");
// // // // // }

// // // // int count = 3;
// // // // if (count % 2 == 0) {
// // // //     Console.WriteLine("Чётное");  
// // // // } else {
// // // //     Console.WriteLine("Нечётное");    
// // // // } 

// // // int count = 4;
// // // if (count == 5) {
// // //     Console.WriteLine("Отлично");
// // // } else if (count == 4) {
// // //     Console.WriteLine("Хорошо");
// // // } else if (count == 3) {
// // //     Console.WriteLine("Удовлетворительно");
// // // } else if (count == 2) {
// // //     Console.WriteLine("Неудовлетворительно");
// // // } else {
// // //     Console.WriteLine("Неверная оценка");
// // // }
// // Console.Write("Введите свою фамилию: ");
// // string surname = Console.ReadLine()!.Trim();
// // if (string.IsNullOrEmpty(surname)) {
// // Console.WriteLine("Фамилия не введена. Завершение работы.");
// // return;
// // }
// // Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// // var assigned = Enumerable.Range(1, 10)
// // .OrderBy(_ => rnd.Next())
// // .Take(2)
// // .OrderBy(x => x)
// // .ToList();
// // Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// int month = 4;

// if (month == 12 || month == 1 || month == 2) {
//     Console.WriteLine("Зима");
// } else if (month >= 3 && month <= 5) {
//     Console.WriteLine("Весна");
// } else if (month >= 6 && month <= 8) {
//     Console.WriteLine("Лето");
// } else if (month >= 9 && month <= 11) {
//     Console.WriteLine("Осень");
// } else {
//     Console.WriteLine("Неверный месяц");
// }

