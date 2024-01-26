using System.Threading.Channels;

Console.WriteLine("Введите номер месяца:");
string? numberMonth = Console.ReadLine();

#region Месяца

if (int.TryParse(numberMonth, out int number))
{
    switch (number)
    {
        case 1:
            Console.WriteLine("Январь");
            break;
        case 2:
            Console.WriteLine("Февраль");
            break;
        case 3:
            Console.WriteLine("Март");
            break;
        case 4:
            Console.WriteLine("Апрель");
            break;
        case 5:
            Console.WriteLine("Май");
            break;
        case 6:
            Console.WriteLine("Июнь");
            break;
        case 7:
            Console.WriteLine("Июль");
            break;
        case 8:
            Console.WriteLine("Август");
            break;
        case 9:
            Console.WriteLine("Сентябрь");
            break;
        case 10:
            Console.WriteLine("Октябрь");
            break;
        case 11:
            Console.WriteLine("Ноябрь");
            break;
        case 12:
            Console.WriteLine("Декабрь");
            break;
        default:
            Console.WriteLine("Такого месяца нет");
            break;
    }

}


#endregion
#region Название времени года

if (number > 0 && number < 3 || number == 12)
    Console.WriteLine("Зима");
else if (number >= 3 && number < 6)
    Console.WriteLine("Весна");
else if (number >= 6 && number < 9)
    Console.WriteLine("Лето");
else if (number > 9 && number < 12)
    Console.WriteLine("Осень");

else Console.WriteLine("Такого месяца нет");

#endregion
#region Четность числа
Console.WriteLine("Введите число : ");
string? text = Console.ReadLine();
if (int.TryParse(text, out int value))
{
    Console.WriteLine("Вы ввели число : " + value);
    if (value % 2 == 0)
        Console.WriteLine("Число четное");
    else
        Console.WriteLine("Число не четное");
}
else
    Console.WriteLine("Не удалось распознать число!");
#endregion
#region Температура
Console.WriteLine("Введите температуру :");
string? temp = Console.ReadLine();
if (int.TryParse(temp, out int t))
{
    if (t >= -5)
        Console.WriteLine("Тепло");
    else if (t >= -5 && t > -20)
        Console.WriteLine("Нормально");
    else if (t <= -20)
        Console.WriteLine("В такой холод программа отказывается работать!!");
}
else
    Console.WriteLine("Температура на распознана!");

#endregion
#region Радуга
Console.WriteLine("Введите номер цвета радуги :");
string? color = Console.ReadLine();
if (int.TryParse(color, out int colorValue))
{
    if (colorValue >= 1)
        switch (colorValue)
        {
            case 1:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Красный");
                Console.ResetColor();
                break;
            case 2:
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Оранжевый");
                Console.ResetColor();
                break;
            case 3:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Желтый");
                Console.ResetColor();
                break;
            case 4:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Зеленый");
                Console.ResetColor();
                break;
            case 5:
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Голубой");
                Console.ResetColor();
                break;
            case 6:
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Синий");
                Console.ResetColor();
                break;
            case 7:
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Фиолетовый");
                Console.ResetColor();
                break;

            default:
                Console.WriteLine("В рaдуге 7 цветов");
                break;
        }
    else
        Console.WriteLine("Число должно быть положительным");
}
else
    Console.WriteLine("Данные не распознаны");
#endregion

