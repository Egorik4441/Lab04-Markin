// int age = 23;
// if (age >= 21)
// {
//     Console.WriteLine("Доступ разрешён");
// }
// Console.WriteLine("Программа продолжает работу");

int age = 15;
if (age >= 18) {
    Console.WriteLine("Доступ разрешён");
} else {
    Console.WriteLine($"Лет до совершеннолетия:{18 - age} ");
    Console.WriteLine("Доступ запрещён");
}