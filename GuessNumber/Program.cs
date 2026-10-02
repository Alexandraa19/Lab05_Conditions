
// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);

// if (number > 0)
// {
//     Console.WriteLine("Число положительное.");
// }
// else if (number < 0)
// {
//     Console.WriteLine("Число отрицательное.");
// }
// else
// {
//     Console.WriteLine("Число равно нулю.");
// }

// Console.WriteLine("Введите балл (0-100): ");
// int score = int.Parse(Console.ReadLine()!);

// if (score >= 91)
// {
//     Console.WriteLine("Оценка: Отлично (5)");
// }
// else if (score >= 71)
// {
//     Console.WriteLine("Оценка: Хорошо (4)");
// }
// else if (score >= 51)
// {
//     Console.WriteLine("Оценка: Удовлетворительно (3)");
// }
// else
// {
//     Console.WriteLine("Оценка: Неудовлетворительно (2)");
// }

// Console.WriteLine("Введите количество посещений (из 19): ");
// int attendance = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите средний балл по практике: ");
// double practiceGpa = double.Parse(Console.ReadLine()!);

// bool goodAttendance = attendance >= 14;  
// bool goodGrades = practiceGpa >= 3.0;     

// if (goodAttendance && goodGrades)
// {
//     Console.WriteLine("+ Допуск к экзамену разрешён.");
// }
// else if (!goodAttendance && goodGrades)
// {
//     Console.WriteLine("- Недостаточно посещений. Нужно отработать пропуски.");
// }
// else if (goodAttendance && !goodGrades)
// {
//     Console.WriteLine("- Низкий балл по практике. Нужно пересдать работы.");
// }
// else
// {
//     Console.WriteLine("- Проблемы и с посещаемостью, и с оценками. Срочно к преподавателю.");
// }

// Console.Write("Введите балл (0-100): ");
// int score = int.Parse(Console.ReadLine()!);

// string result1;
// if (score >= 60)
//     result1 = "Зачёт";
// else
//     result1 = "Незачёт";

// string result2 = score >= 60 ? "Зачёт" : "Незачёт";

// Console.WriteLine($"if/else:            {result1}");
// Console.WriteLine($"тернарный оператор: {result2}");

// Console.Write("\nВведите ваш возраст: ");
// int age = int.Parse(Console.ReadLine()!);

// string ageGroup = age >= 18 ? "совершеннолетний" : "несовершеннолетний";
// Console.WriteLine($"Вы {ageGroup}.");


// Console.Write("\nВведите температуру за окном (°C): ");
// double temp = double.Parse(Console.ReadLine()!, System.Globalization.CultureInfo.InvariantCulture);

// string weather = temp >= 20 ? "тепло" : (temp >= 0 ? "прохладно" : "мороз");
// Console.WriteLine($"За окном {weather}.");

// Console.WriteLine("Меню");
// Console.WriteLine("1. Посмотреть расписание");
// Console.WriteLine("2. Посмотреть оценки");
// Console.WriteLine("3. Связаться с преподавателем");
// Console.WriteLine("4. Выйти");
// Console.Write("Выберите пункт (1-4): ");

// string choice = Console.ReadLine()!;

// switch (choice)
// {
//     case "1":
//         Console.WriteLine("Расписание: ИСП-244, каб. 102, 08:30");
//         break;
//     case "2":
//         Console.WriteLine("Ваши оценки: ИРСПО — 20, РМП — 35,");
//         break;
//     case "3":
//         Console.WriteLine("Email: denis.leontev92@yandex.ru");
//         break;
//     case "4":
//         Console.WriteLine("До свидания!");
//         break;
//     default:
//         Console.WriteLine($"Ошибка: пункт «{choice}» не существует. Введите число от 1 до 4.");
//         break;
// }

// Console.Write("\nВведите номер дня недели (1-7): ");
// int dayNumber = int.Parse(Console.ReadLine()!);

// switch (dayNumber)
// {
//     case 1:
//     case 2:
//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("Рабочий день – пора учиться!");
//         break;
//     case 6:
//     case 7:
//         Console.WriteLine("Выходной – заслуженный отдых.");
//         break;
//     default:
//         Console.WriteLine("Такого дня не существует.");
//         break;
// }


// Console.Write("\nВведите номер месяца (1-12): ");
// int month = int.Parse(Console.ReadLine()!);

// switch (month)
// {
//     case 12:
//     case 1:
//     case 2:
//         Console.WriteLine("Зима");
//         break;
//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("Весна");
//         break;
//     case 6:
//     case 7:
//     case 8:
//         Console.WriteLine("Лето");
//         break;
//     case 9:
//     case 10:
//     case 11:
//         Console.WriteLine("Осень");
//         break;
//     default:
//         Console.WriteLine("Некорректный номер месяца.");
//         break;
// }

// Random random = new Random();
// int secret = random.Next(1, 101);

// int attempts = 0;
// bool guessed = false;

// Console.WriteLine("Угадай число (1-100)");
// Console.WriteLine("Я загадал число. Попробуй угадать!");

// while (!guessed)
// {
//     Console.Write("Введите число: ");
//     string input = Console.ReadLine()!;

//     if (!int.TryParse(input, out int guess))
//     {
//         Console.WriteLine("!!! Введите целое число!");
//         continue;
//     }

//     if (guess < 1 || guess > 100)
//     {
//         Console.WriteLine("!!! Число должно быть от 1 до 100!");
//         continue;
//     }

//     attempts++;

//     if (guess < secret)
//     {
//         int diff = secret - guess;
//         string hint = GetHint(diff);
//         Console.WriteLine($"↑ Больше! {hint}\n");
//     }
//     else if (guess > secret)
//     {
//         int diff = guess - secret;
//         string hint = GetHint(diff);
//         Console.WriteLine($"↓ Меньше! {hint}\n");
//     }
//     else
//     {
//         guessed = true;
//     }
// }
// string result = attempts <= 7
//     ? $"Отличный результат! Всего {attempts} попыток."
//     : $"Число найдено за {attempts} попыток. Можно лучше!";

// Console.WriteLine($"Правильно! Загаданное число: {secret}");
// Console.WriteLine($"{result}");


// static string GetHint(int diff)
// {
//     switch (diff)
//     {
//         case <= 3:
//             return "Горячо!";
//         case <= 10:
//             return "Тепло.";
//         case <= 25:
//             return "Прохладно.";
//         default:
//             return "Холодно.";
//     }
// }
using System;
using System.Globalization;

Console.WriteLine("Лабораторная работа №5. Самостоятельные задания ");
Console.WriteLine("Выберите задание:");
Console.WriteLine("1 — Задание 1. Проверка пароля");
Console.WriteLine("2 — Задание 2. Роскомнадзор");
Console.WriteLine("3 — Задание 3. Простой Калькулятор");
Console.WriteLine("4 — Задание 4. Только положительные");
Console.WriteLine("5 — Задание 5. Путешествие в Тёмный Лабиринт");
Console.Write("ваш выбор: ");

string menu = Console.ReadLine()!;

switch (menu)
{
    case "1":
        RunPasswordCheck();
        break;
    case "2":
        RunRknCheck();
        break;
    case "3":
        RunCalculator();
        break;
    case "4":
        RunPositivesSum();
        break;
    case "5":
        RunDarkLabyrinth();
        break;
    default:
        Console.WriteLine("нету такого.");
        break;
}


static void RunPasswordCheck()
{
    Console.WriteLine("\nЗадание 1. Проверка пароля ");
    Console.Write("Введите пароль: ");
    string password = Console.ReadLine()!;
    Console.Write("Подтвердите пароль: ");
    string confirm = Console.ReadLine()!;

    if (password == confirm)
        Console.WriteLine("Пароль принят");
    else
        Console.WriteLine("Пароль не принят");
}


static void RunRknCheck()
{
    Console.WriteLine("\n Задание 2. Роскомнадзор ");
    Console.Write("Введите возраст: ");
    int age = int.Parse(Console.ReadLine()!);

    if (age >= 18)
        Console.WriteLine("Доступ разрешён");
    else
        Console.WriteLine("Доступ запрещён");
}

static void RunCalculator()
{
    Console.WriteLine("\nЗадание 3. Простой Калькулятор");

    Console.Write("Введите первое число: ");
    double a = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    Console.Write("Введите второе число: ");
    double b = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

    Console.Write("Введите операцию (+, -, *, /): ");
    string op = Console.ReadLine()!;
    switch (op)
    {
        case "+":
            Console.WriteLine($"{a} + {b} = {a + b}");
            break;
        case "-":
            Console.WriteLine($"{a} - {b} = {a - b}");
            break;
        case "*":
            Console.WriteLine($"{a} * {b} = {a * b}");
            break;
        case "/":
            if (b != 0)
                Console.WriteLine($"{a} / {b} = {a / b}");
            else
                Console.WriteLine("Деление на ноль невозможно!");
            break;
        default:
            Console.WriteLine("Неизвестная операция");
            break;
    }
}

static void RunPositivesSum()
{
    Console.WriteLine("\n Задание 4. Только положительные ");
    int sum = 0;

    for (int i = 1; i <= 3; i++)
    {
        Console.Write($"Введите число {i}: ");
        int num = int.Parse(Console.ReadLine()!);
        if (num > 0)
            sum += num;
    }

    Console.WriteLine($"Сумма положительных: {sum}");
}

static void RunDarkLabyrinth()
{
    Console.WriteLine("\n Задание 5. Путешествие в Тёмный Лабиринт ");
    Console.WriteLine("Вы стоите перед первой дверью.");
    Console.WriteLine("A — Войти в комнату с драконом");
    Console.WriteLine("B — Пойти по тёмному коридору");
    Console.Write("Ваш выбор (A/B): ");
    string path = Console.ReadLine()!.ToUpper();

    if (path == "A")
    {
        Console.WriteLine("\nДракон загадывает загадку:");
        Console.WriteLine("\"Кто не дышит, но живёт; хоть не нужно — много пьёт;");
        Console.WriteLine(" и в жизни, и в смерти тело как лёд.\"");
        Console.Write("Ваш ответ: ");
        string answer = Console.ReadLine()!.ToLower();

        if (answer == "рыба")
            Console.WriteLine("+ Дракон открывает дверь. Вы прошли дальше!");
        else
            Console.WriteLine("- Дракон съедает вас. Игра окончена.");
    }
    else if (path == "B")
    {
        Console.WriteLine("\nТёмная комната с двумя дверями:");
        Console.WriteLine("1 — Дверь с сокровищами");
        Console.WriteLine("2 — Дверь с ловушкой");
        Console.Write("Ваш выбор (1/2): ");
        string door = Console.ReadLine()!;

        switch (door)
        {
            case "1":
                Console.WriteLine("+ Вы нашли сокровища Dungeon Master’а!");
                break;
            case "2":
                Console.WriteLine("- Ловушка с ядовитыми шипами. Игра окончена.");
                break;
            default:
                Console.WriteLine("Неизвестная дверь.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Неизвестный путь.");
    }
}