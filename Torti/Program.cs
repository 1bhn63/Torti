using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        decimal totalOrderPrice = 0;
        string order = "";

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Выбрать торт");
            Console.WriteLine("2. Вывести заказ");
            Console.WriteLine("3. Вывести суммарную цену");
            Console.WriteLine("4. Оформить заказ");
            Console.WriteLine("5. Выход");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("Выберите форму торта:");
                    Console.WriteLine("1. Круглая");
                    Console.WriteLine("2. Прямоугольная");
                    Console.WriteLine("3. Квадратная");
                    string shape = Console.ReadKey().Key == ConsoleKey.D1 ? "Круглая" :
                                  Console.ReadKey().Key == ConsoleKey.D2 ? "Прямоугольная" :
                                  Console.ReadKey().Key == ConsoleKey.D3 ? "Квадратная" :
                                  "";
                    Console.Clear();

                    Console.WriteLine("Выберите размер торта:");
                    Console.WriteLine("1. Маленький");
                    Console.WriteLine("2. Средний");
                    Console.WriteLine("3. Большой");
                    string size = Console.ReadKey().Key == ConsoleKey.D1 ? "Маленький" :
                                  Console.ReadKey().Key == ConsoleKey.D2 ? "Средний" :
                                  Console.ReadKey().Key == ConsoleKey.D3 ? "Большой" :
                                  "";
                    Console.Clear();

                    Console.WriteLine("Выберите вкус торта:");
                    Console.WriteLine("1. Шоколадный");
                    Console.WriteLine("2. Ванильный");
                    Console.WriteLine("3. Фруктовый");
                    string flavor = Console.ReadKey().Key == ConsoleKey.D1 ? "Шоколадный" :
                                    Console.ReadKey().Key == ConsoleKey.D2 ? "Ванильный" :
                                    Console.ReadKey().Key == ConsoleKey.D3 ? "Фруктовый" :
                                    "";
                    Console.Clear();

                    Console.WriteLine("Введите количество тортов:");
                    int quantity = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("Выберите глазурь:");
                    Console.WriteLine("1. Шоколадная");
                    Console.WriteLine("2. Сливочная");
                    Console.WriteLine("3. Фруктовая");
                    string glaze = Console.ReadKey().Key == ConsoleKey.D1 ? "Шоколадная" :
                                   Console.ReadKey().Key == ConsoleKey.D2 ? "Сливочная" :
                                   Console.ReadKey().Key == ConsoleKey.D3 ? "Фруктовая" :
                                   "";
                    Console.Clear();

                    Console.WriteLine("Выберите декор:");
                    Console.WriteLine("1. Шоколадные стружки");
                    Console.WriteLine("2. Фруктовые ягоды");
                    Console.WriteLine("3. Карамельные конфеты");
                    string decor = Console.ReadKey().Key == ConsoleKey.D1 ? "Шоколадные стружки" :
                                   Console.ReadKey().Key == ConsoleKey.D2 ? "Фруктовые ягоды" :
                                   Console.ReadKey().Key == ConsoleKey.D3 ? "Карамельные конфеты" :
                                   "";
                    Console.Clear();

                    decimal price = CalculatePrice(size, quantity);
                    totalOrderPrice += price;
                    order += $"{shape} {size} торт, {flavor}, {quantity} шт., {glaze}, {decor}. Цена: {price} руб.\n";

                    Console.WriteLine("Торт успешно добавлен в заказ!");
                    Console.WriteLine("Нажмите любую клавишу для продолжения.");
                    Console.ReadKey();
                    break;

                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("Заказ:");
                    Console.WriteLine(order);
                    Console.WriteLine("Нажмите любую клавишу для продолжения.");
                    Console.ReadKey();
                    break;

                case ConsoleKey.D3:
                    Console.Clear();
                    Console.WriteLine($"Суммарная цена заказа: {totalOrderPrice} руб.");
                    Console.WriteLine("Нажмите любую клавишу для продолжения.");
                    Console.ReadKey();
                    break;

                case ConsoleKey.D4:
                    Console.Clear();
                    Console.WriteLine("Заказ успешно оформлен!");
                    Console.WriteLine("Нажмите любую клавишу для продолжения.");
                    Console.ReadKey();

                    totalOrderPrice = 0;
                    order = "";
                    break;

                case ConsoleKey.D5:
                    exit = true;
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Неверный ввод. Попробуйте снова.");
                    Console.WriteLine("Нажмите любую клавишу для продолжения.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static decimal CalculatePrice(string size, int quantity)
    {
        decimal price = 0;

        switch (size)
        {
            case "Маленький":
                price = 100;
                break;
            case "Средний":
                price = 200;
                break;
            case "Большой":
                price = 300;
                break;
        }

        return price * quantity;
    }
}