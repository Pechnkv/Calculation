while (true)

{

    Console.Clear();


    double a, b;
    string action;

    try
    {
        Console.WriteLine("Введите первое число");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        b = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Вы ввели не число");
        Console.ReadLine();
        continue;
    }

    Console.WriteLine("Выберите операцию");

    action = Console.ReadLine();

    switch (action)
    {
        case "+":
            Console.WriteLine(a + b);
            break;
        case "-":
            Console.WriteLine(a - b);
            break;
        case "/":
            Console.WriteLine(a / b);
            break;
        case "*":
            Console.WriteLine(a * b);
            break;

        default:
            Console.WriteLine("Неизвестное действие");
            break;
    }
    Console.ReadLine();

}

