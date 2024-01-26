string again = "Y";
while (again == "Y")
{
    double value1;
    double value2;
    string symbol;
    double result;
    Console.WriteLine("Введите первое число :");
    var number = Console.ReadLine();
    if (!double.TryParse(number, out value1))
    {
        Console.WriteLine("Некорректное чиcло!");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Какую арифметическую оперцаю желаете выполнить? :" +
           "\n '+' - сложение " +
           "\n'-' - вычитание" +
           "\n'*'- умнижение " +
           "\n '/' - деление" +
           "\n'№' - Вычисление квадратного корня" +
           "\n '^' - возведение в степень" +
           "\n '%' - Процент от числа");
    }
    symbol = Console.ReadLine();
    if (symbol == "№")
    {
        double value3 = Math.Sqrt(value1);
        Console.WriteLine("Квадратный корень" + value1 + " = " + value3);
        Console.WriteLine("Продолжить работу с калькулятором? Y - да, N - нет :");
        again = Console.ReadLine();
        if (again == "N")
            Console.Clear();
        else
            value1 = value3;
        Console.WriteLine("Какую арифметическую оперцаю желаете выполнить? :");
        symbol = Console.ReadLine();
    }

    Console.WriteLine("Введите второе число :");
    var number1 = Console.ReadLine();
    if (!double.TryParse(number1, out value2))
    {
    }

    result = DoOper(value1, value2);

    while (symbol != "=")
    {
        Console.WriteLine("Какую арифметическую оперцаю желаете выполнить? :");
        symbol = Console.ReadLine();
        if (symbol == "=")
        {
            Console.WriteLine("Ваш ответ :" + result);
            Console.WriteLine("Продолжить работу с калькулятором? Y - да, N - нет :");
            again = Console.ReadLine();
           if(again == "N")
                Environment.Exit(0);

            Console.Clear();
        }
        value1 = result;
        Console.WriteLine("Введие число :");
         var number2 = Console.ReadLine();
        if (!double.TryParse(number2, out value2))
        {
            Console.WriteLine("Некорректное чиcло!");
            Environment.Exit(0);
        }
        result = DoOper(value1, value2);
    }

    double DoOper(double value1, double value2)
    {
        double value = 0;
        switch (symbol)
        {
            case "+":
                value = value1 + value2;
                break;
            case "-":
                value = value1 - value2;
                break;
            case "*":
                value = value1 * value2;
                break;
            case "^":
                value = Math.Pow(value1, value2);
                break;
            case "%":
                value = value1 * value2 / 100;
                break;
            case "/":
                if (value2 == 0)
                {
                    Console.WriteLine("На ноль делить нельзя");
                    break;
                }
                else
                {
                    value = value1 / value2;
                    break;
                }
            case "=":
                Console.WriteLine(value);
                break;


        }
        return value;
    }
}


















