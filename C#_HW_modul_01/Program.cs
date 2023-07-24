// See https://aka.ms/new-console-template for more information
Console.WriteLine("Done Number 1");

Console.WriteLine("Введите число от 1 до 100:");

int number = Convert.ToInt32(Console.ReadLine());

    if (number < 1 || number > 100)
    {
       Console.WriteLine("Ошибка: число должно быть в диапазоне от 1 до 100.");
    }
    else if (number % 3 == 0 && number % 5 == 0)
    {
       Console.WriteLine("Fizz Buzz");
    }
    else if (number % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (number % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(number);
    }
// Ожидание нажатия клавиши для завершения программы
Console.ReadKey();

Console.WriteLine("Done Number 2");
Console.Write("Введите первое число: ");
double value = double.Parse(Console.ReadLine());
Console.Write("Введите процент: ");
double percent = double.Parse(Console.ReadLine());

// Вычисление процента от числа
double result = value * percent / 100;

// Вывод результата
Console.WriteLine("Результат: " + result);

// Ожидание нажатия клавиши для завершения программы
Console.ReadKey();

Console.WriteLine("Введите четыре цифры:");

// Вводим четыре цифры с клавиатуры
string input = Console.ReadLine();

if (input.Length == 4)
{
    // Преобразуем строку в массив символов
    char[] digits = input.ToCharArray();

    // Создаем пустую строку, в которой будет храниться число
    string strNumber = "";

    // Перебираем каждую цифру и добавляем ее к числу
    foreach (char digit in digits)
    {
        strNumber += digit;
    }
    // Проверяем, что строка не пустая перед преобразованием
    if (!string.IsNullOrEmpty(strNumber))
    {
        // Вывод числа на консоль
        Console.WriteLine("Сформированное число: " + strNumber);
    }
}
else
{
    Console.WriteLine("Неверный ввод. Пожалуйста, введите ровно четыре цифры.");
}
// Ожидание нажатия клавиши для завершения программы
Console.ReadKey();

Console.WriteLine("Done Number 4");

Console.Write("Введите шестизначное число: ");
string numberString = Console.ReadLine();

if (numberString.Length != 6)
{
    Console.WriteLine("Ошибка: введено не шестизначное число");
    return;
}

int number4 = Convert.ToInt32(numberString);

Console.Write("Введите номера разрядов для обмена цифр: ");
string positionsString = Console.ReadLine();
string[] positionsArray = positionsString.Split(' ');

if (positionsArray.Length != 2)
{
    Console.WriteLine("Ошибка: введено неверное количество номеров разрядов");
    return;
}

int position1 = Convert.ToInt32(positionsArray[0]);
int position2 = Convert.ToInt32(positionsArray[1]);

if (position1 < 1 || position1 > 6 || position2 < 1 || position2 > 6)
{
    Console.WriteLine("Ошибка: номер разряда должен быть от 1 до 6");
    return;
}

int digit1 = (number / (int)Math.Pow(10, 6 - position1)) % 10;
int digit2 = (number / (int)Math.Pow(10, 6 - position2)) % 10;

number = number - (digit1 * (int)Math.Pow(10, 6 - position1)) - (digit2 * (int)Math.Pow(10, 6 - position2))
        + (digit1 * (int)Math.Pow(10, 6 - position2)) + (digit2 * (int)Math.Pow(10, 6 - position1));

Console.WriteLine("Результат: " + number);
// Ожидание нажатия клавиши для завершения программы
Console.ReadKey();

Console.WriteLine("Done Number 5");
partial class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите дату (ДД.ММ.ГГГГ): ");
        string dateString = Console.ReadLine();

        // Конвертируем введенную строку даты в объект DateTime
        DateTime date;
        if (!DateTime.TryParseExact(dateString, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out date))
        {
            Console.WriteLine("Некорректный формат даты. Попробуйте еще раз.");
            return;
        }

        // Получаем название сезона
        string season = GetSeason(date);

        // Получаем название дня недели
        string dayOfWeek = date.DayOfWeek.ToString();

        // Выводим название сезона и дня недели
        Console.WriteLine($"{season} {dayOfWeek}");
    }

   static string GetSeason(DateTime date)
   {
        int month = date.Month;

        if (month >= 3 && month <= 5)
            return "Spring";
        else if (month >= 6 && month <= 8)
            return "Summer";
        else if (month >= 9 && month <= 11)
            return "Autumn";
        else
            return "Winter";
    }
}